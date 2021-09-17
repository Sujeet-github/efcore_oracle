create or replace package body pkg_fins_3In1App as

procedure proc_InsertRequest
(
  i_AuthRRNNumber     varchar2 := null
  , i_AuthSeqID       varchar2 := null
  , i_RequestPacket   varchar2 := null
  , i_Source          varchar2 := null
  , o_Output          out sys_refcursor
)
as
  v_ReqSeq            number := 0;
  v_TokenExpiryFlag   varchar2(1);
  v_Token             varchar2(100);

  v_TimeOut           varchar2(10);
  v_Authorization     varchar2(100);

  v_AuthDataURL       varchar2(100);
  v_AuthEDKey         varchar2(20);
  v_ConnectionFrom    varchar2(20);
  v_Source            varchar2(20);

  v_TokenURL          varchar2(100);
  v_TokenEDKey        varchar2(20);
  v_TSource           varchar2(20);
  v_TConnectionFrom   varchar2(20);
  v_TAccept           varchar2(20);
  v_JsonRequest       varchar(4000);

begin

  select seq_3In1App_req.nextval into v_ReqSeq from dual;

  insert into fins_3In1AppRequest
  (
    ReqSeq
    , Auth_RRNNumber
    , Auth_SeqID
    , RequestPacket
    , Source
    , "respcode"
  )
  values
  (
    v_reqseq
    , i_AuthRRNNumber
    , i_AuthSeqID
    , i_RequestPacket
    , i_Source
    , '200'
  );
  commit;

  -- Check Token Expiry  API Details
  proc_GetAPIDetails
  (
    'AUTH'
    , v_TokenExpiryFlag, v_Token
    , v_TimeOut, v_Authorization
    , v_AuthDataURL, v_AuthEDKey, v_ConnectionFrom, v_Source
    , v_TokenURL, v_TokenEDKey, v_TSource, v_TConnectionFrom, v_TAccept, v_JsonRequest
  );

  open o_Output for
  select v_ReqSeq as ReqSeq, v_TokenExpiryFlag as TokenExpiryFlag, v_Token as Token, v_TimeOut as TimeOut
        -- 3IN1App API Details
        , v_AuthDataURL as AuthDataAPI, 'Basic ' || v_Authorization as Authorization
        , v_AuthEDKey as EDKey, v_ConnectionFrom as Connectionfrom, v_Source as source
        -- OAuth Token API Details
        , v_TokenURL as TokenUrl, v_TokenEDKey as TokenEDKey, v_Authorization as TAuthorization, v_TSource as TSource
        , v_TConnectionFrom as TokenConnectionfrom, v_TAccept as tokenAccept, v_JsonRequest as TokenRequest
  from dual;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_InsertRequest','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'i_AuthSeqID',i_AuthSeqID);
    commit;
    open o_Output for select '0' as ReqSeq from dual;
end proc_InsertRequest;

procedure proc_InsertResponse
(
  i_ReqSeq            varchar2 := null
  , i_ResponsePacket  varchar2 := null
  , i_ResponseCode    varchar2 := null
  , i_ResponseDesc    varchar2 := null
  , i_HttpStatusCode  varchar2 := null
  , o_Output          out sys_refcursor
)
as
  v_ResSeq            number := 0;
begin
  select seq_3In1App_res.nextval into v_ResSeq from dual;
  insert into fins_3In1AppResponse
  (
    ResSeq
    , ReqSeq
    , ResponsePacket
    , ResponseCode
    , ResponseDesc
    , AlertSMSFlag
  )
  values
  (
    v_ResSeq
    , i_ReqSeq
    , case when i_ResponseCode = '900' then i_ResponseDesc else i_ResponsePacket end
    , case when i_ResponseCode in ('7001','200') then '00' else case when json_value(i_ResponsePacket, '$.statusCode') is not null then json_value(i_ResponsePacket, '$.statusCode') else i_ResponseCode end end
    , i_ResponseDesc
    , case when i_HttpStatusCode = '900' or i_ResponseCode in ('500','480','7002','7004','900') then 'Y' else 'N' end
  );
  commit;

  open o_Output for select v_ResSeq as ResSeq from dual;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_InsertResponse','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'i_ReqSeq',i_ReqSeq);
    commit;
    open o_Output for select '0' as ResSeq from dual;
end proc_InsertResponse;

procedure proc_GetAuthAPIData
(
  i_AuthRRNNumber     varchar2 := null
  ,o_Output           out sys_refcursor
)
as
v_JsonPacket VARCHAR2(4000);
v_RRN VARCHAR2(20);
v_SEQ_ID NUMBER;
BEGIN
  open o_Output for
    select JSON_OBJECT
    (
      'ruFormNo' value AUTH_RRNUMBER, 'ruBranchId' value AUTH_TRANSACTION_BRANCH_ID, 'ruProductId' value AUTH_PRODUCT_ID, 'ruSchemeId' value AUTH_SCHEME_CODE
      , 'ruSourceProg' value AUTH_CREDIT_PROGRAM_CODE, 'ruApproveStatus' value AUTH_SOURCE_REVERSE, 'ruLoanAmt' value AUTH_AUTH_AMT, 'ruLoanTenor' value AUTH_TENOR
      , 'ruAssetModel' value AUTH_MODEL_ID, 'ruDealer' value AUTH_ME_DEALER_ID, 'ruEMICardCustomerId' value AUTH_CUSTOMER_ID, 'ruDueDay' value AUTH_CUSTOMER_DUE_CYCLE
      , 'ruChargeId' value AUTH_CHARGE_ID1, 'ruChargeAmt' value AUTH_CHARGE_ID1_AMT, 'ruChargeId2' value AUTH_CHARGE_ID2, 'ruChargeAmt2' value AUTH_CHARGE_ID2_AMT
      , 'ruChargeId3' value AUTH_CHARGE_ID3, 'ruChargeAmt3' value AUTH_CHARGE_ID3_AMT, 'ruChargeId4' value AUTH_CHARGE_ID4, 'ruChargeAmt4' value AUTH_CHARGE_ID4_AMT
      , 'ruChargeId5' value AUTH_CHARGE_ID5, 'ruChargeAmt5' value AUTH_CHARGE_ID5_AMT, 'ruInvoiceAmt' value AUTH_ORG_TXN_AMT, 'ruBatchId' value systemdate
      , 'ruTId' value AUTH_TID, 'parentRRN' value AUTH_PARENT_RRNUMBER, 'dueDate' value AUTH_FIRST_DUE_DATE, 'imeiNos' value AUTH_IMEI, 'rrnUniqueId' value AUTH_UNIQUE_CANCELLATION_ID
      , 'cardNumber' value AUTH_CARD_NUM, 'grossLoanAmt' value AUTH_ORG_TXN_AMT, 'advanceEMIAmt' value AUTH_ADVANCE_EMI_AMT, 'noOfAdvanceEMIs' value AUTH_NO_OF_ADV_EMI
      , 'grossTenor' value AUTH_TENOR, 'respCode' value AUTH_RESPONSE_CODE, 'responseDesc' value AUTH_RESPONSE_DESC, 'assetCategory' value AUTH_ASSET_CODE
      , 'merchantName' value AUTH_MERCHANT_NAME, 'orderId' value AUTH_ORDER_NO, 'productDetails' value AUTH_PROD_DESC, 'requestId' value AUTH_REQUESTID
      , 'acquiringChannelCode' value AUTH_ACQ_CHANNEL_ID, 'authDateTime' value AUTH_REQ_DATE, 'accountId' value AUTH_ACCOUNT_ID, 'mobileNumber' value AUTH_MOBILE
      , 'nowAvailableLimit' value AUTH_AVL_AMT_AFTER_TXN, 'dbd' value AUTH_DBD_SUBVEN_PERC, 'processingFee' value AUTH_PROCESSING_FEE, 'interestRate' value AUTH_INTEREST_RATE
      , 'failedRuleId' value AUTH_FAILED_RULE_ID, 'dfsFlag' value AUTH_DFS_FLAG, 'residenceCity' value AUTH_RESIDENCE_CITY, 'deliveryPinCode' value AUTH_DELIVERY_PIN_CODE
      , 'mbd' value AUTH_MBD, 'mobileBasedTransaction' value AUTH_MOBILE_TRANSACTION, 'primaryAddOnCardIndicator' value AUTH_PRIMARY_ADD_ON_IND
      , 'cardType' value AUTH_CARD_TYPE, 'cardDesign' value AUTH_CARD_DESIGN, 'storeId' value AUTH_STORE_ID
      , 'Parter_API_Request_Date_time' value AUTH_PARTNERAPI_REQUESTDATE  -- Added by [PS] US694734 - KPI Dashboards
    ) as requestpacket , AUTH_RRNUMBER as RRN, SEQ_ID
    from
    (
      select AUTH_RRNUMBER, AUTH_TRANSACTION_BRANCH_ID, AUTH_PRODUCT_ID, AUTH_SCHEME_CODE, AUTH_CREDIT_PROGRAM_CODE, AUTH_SOURCE_REVERSE, AUTH_AUTH_AMT
      , AUTH_TENOR, AUTH_MODEL_ID, AUTH_ME_DEALER_ID, AUTH_CUSTOMER_ID, AUTH_CUSTOMER_DUE_CYCLE, AUTH_CHARGE_ID1, AUTH_CHARGE_ID1_AMT, AUTH_CHARGE_ID2
      , AUTH_CHARGE_ID2_AMT, AUTH_CHARGE_ID3, AUTH_CHARGE_ID3_AMT, AUTH_CHARGE_ID4, AUTH_CHARGE_ID4_AMT, AUTH_CHARGE_ID5, AUTH_CHARGE_ID5_AMT
      , AUTH_ORG_TXN_AMT, to_char(sysdate-1,'DDMMYYYYHH24MISS') as systemdate, AUTH_TID, AUTH_PARENT_RRNUMBER, AUTH_FIRST_DUE_DATE, AUTH_IMEI, AUTH_UNIQUE_CANCELLATION_ID
      , AUTH_CARD_NUM, AUTH_ADVANCE_EMI_AMT, AUTH_NO_OF_ADV_EMI, AUTH_RESPONSE_CODE, AUTH_RESPONSE_DESC, AUTH_ASSET_CODE
      , AUTH_MERCHANT_NAME, AUTH_ORDER_NO, AUTH_PROD_DESC, AUTH_REQUESTID, AUTH_ACQ_CHANNEL_ID, AUTH_REQ_DATE, AUTH_ACCOUNT_ID, AUTH_MOBILE
      , AUTH_AVL_AMT_AFTER_TXN, AUTH_DBD_SUBVEN_PERC, AUTH_PROCESSING_FEE, AUTH_INTEREST_RATE, AUTH_FAILED_RULE_ID, AUTH_DFS_FLAG, AUTH_RESIDENCE_CITY
      , AUTH_DELIVERY_PIN_CODE, AUTH_MBD, AUTH_MOBILE_TRANSACTION, AUTH_PRIMARY_ADD_ON_IND, AUTH_CARD_TYPE, AUTH_CARD_DESIGN, AUTH_STORE_ID, SEQ_ID
      , AUTH_PARTNERAPI_REQUESTDATE AS AUTH_PARTNERAPI_REQUESTDATE -- Added by [PS] US694734 - KPI Dashboards
      from FINS_AUTHORIZATIONMASTER
      where AUTH_RRNUMBER=i_AuthRRNNumber--'110663410414'
      and ( case when AUTH_CARDTYPE_IDENTIFIER = 'D' and  to_number(AUTH_ORG_TXN_AMT) < 10000 then 0 else 1 end ) = 1

      union

      select AUTH_RRNUMBER, AUTH_TRANSACTION_BRANCH_ID, AUTH_PRODUCT_ID, AUTH_SCHEME_CODE, AUTH_CREDIT_PROGRAM_CODE, AUTH_SOURCE_REVERSE, AUTH_AUTH_AMT
      , AUTH_TENOR, AUTH_MODEL_ID, AUTH_ME_DEALER_ID, AUTH_CUSTOMER_ID, AUTH_CUSTOMER_DUE_CYCLE, AUTH_CHARGE_ID1, AUTH_CHARGE_ID1_AMT, AUTH_CHARGE_ID2
      , AUTH_CHARGE_ID2_AMT, AUTH_CHARGE_ID3, AUTH_CHARGE_ID3_AMT, AUTH_CHARGE_ID4, AUTH_CHARGE_ID4_AMT, AUTH_CHARGE_ID5, AUTH_CHARGE_ID5_AMT
      , AUTH_ORG_TXN_AMT, to_char(sysdate-1,'DDMMYYYYHH24MISS') as systemdate, AUTH_TID, AUTH_PARENT_RRNUMBER, AUTH_FIRST_DUE_DATE, AUTH_IMEI, AUTH_UNIQUE_CANCELLATION_ID
      , AUTH_CARD_NUM, AUTH_ADVANCE_EMI_AMT, AUTH_NO_OF_ADV_EMI, AUTH_RESPONSE_CODE, AUTH_RESPONSE_DESC, AUTH_ASSET_CODE
      , AUTH_MERCHANT_NAME, AUTH_ORDER_NO, AUTH_PROD_DESC, AUTH_REQUESTID, AUTH_ACQ_CHANNEL_ID, AUTH_REQ_DATE, AUTH_ACCOUNT_ID, AUTH_MOBILE
      , AUTH_AVL_AMT_AFTER_TXN, AUTH_DBD_SUBVEN_PERC, AUTH_PROCESSING_FEE, AUTH_INTEREST_RATE, AUTH_FAILED_RULE_ID, AUTH_DFS_FLAG, AUTH_RESIDENCE_CITY
      , AUTH_DELIVERY_PIN_CODE, AUTH_MBD, AUTH_MOBILE_TRANSACTION, AUTH_PRIMARY_ADD_ON_IND, AUTH_CARD_TYPE, AUTH_CARD_DESIGN, AUTH_STORE_ID, SEQ_ID
      , AUTH_PARTNERAPI_REQUESTDATE AS AUTH_PARTNERAPI_REQUESTDATE -- Added by [PS] US694734 - KPI Dashboards
      from FINS_AUTHORIZATIONMASTER_HIS
      where AUTH_RRNUMBER=i_AuthRRNNumber
      and ( case when AUTH_CARDTYPE_IDENTIFIER = 'D' and  to_number(AUTH_ORG_TXN_AMT) < 10000 then 0 else 1 end ) = 1
    );

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_GetAuthAPIData','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'RRN',i_AuthRRNNumber);
    commit;
    open o_Output for select '0' as ResSeq from dual;
end proc_GetAuthAPIData;

procedure proc_SendAuthData
(
  i_AuthSeqNo         varchar2 := null
)
as
  v_JsonPacket        varchar2(4000);
  v_RRN               varchar2(1000);
begin
  select JSON_OBJECT
  (
    'ruFormNo' value AUTH_RRNUMBER, 'ruBranchId' value AUTH_TRANSACTION_BRANCH_ID, 'ruProductId' value AUTH_PRODUCT_ID, 'ruSchemeId' value AUTH_SCHEME_CODE
    , 'ruSourceProg' value AUTH_CREDIT_PROGRAM_CODE, 'ruApproveStatus' value AUTH_SOURCE_REVERSE, 'ruLoanAmt' value AUTH_AUTH_AMT, 'ruLoanTenor' value AUTH_TENOR
    , 'ruAssetModel' value AUTH_MODEL_ID, 'ruDealer' value AUTH_ME_DEALER_ID, 'ruEMICardCustomerId' value AUTH_CUSTOMER_ID, 'ruDueDay' value AUTH_CUSTOMER_DUE_CYCLE
    , 'ruChargeId' value AUTH_CHARGE_ID1, 'ruChargeAmt' value AUTH_CHARGE_ID1_AMT, 'ruChargeId2' value AUTH_CHARGE_ID2, 'ruChargeAmt2' value AUTH_CHARGE_ID2_AMT
    , 'ruChargeId3' value AUTH_CHARGE_ID3, 'ruChargeAmt3' value AUTH_CHARGE_ID3_AMT, 'ruChargeId4' value AUTH_CHARGE_ID4, 'ruChargeAmt4' value AUTH_CHARGE_ID4_AMT
    , 'ruChargeId5' value AUTH_CHARGE_ID5, 'ruChargeAmt5' value AUTH_CHARGE_ID5_AMT, 'ruInvoiceAmt' value AUTH_ORG_TXN_AMT, 'ruBatchId' value systemdate
    , 'ruTId' value AUTH_TID, 'parentRRN' value AUTH_PARENT_RRNUMBER, 'dueDate' value AUTH_FIRST_DUE_DATE, 'imeiNos' value AUTH_IMEI, 'rrnUniqueId' value AUTH_UNIQUE_CANCELLATION_ID
    , 'cardNumber' value AUTH_CARD_NUM, 'grossLoanAmt' value AUTH_ORG_TXN_AMT, 'advanceEMIAmt' value AUTH_ADVANCE_EMI_AMT, 'noOfAdvanceEMIs' value AUTH_NO_OF_ADV_EMI
    , 'grossTenor' value AUTH_TENOR, 'respCode' value AUTH_RESPONSE_CODE, 'responseDesc' value AUTH_RESPONSE_DESC, 'assetCategory' value AUTH_ASSET_CODE
    , 'merchantName' value AUTH_MERCHANT_NAME, 'orderId' value AUTH_ORDER_NO, 'productDetails' value AUTH_PROD_DESC, 'requestId' value AUTH_REQUESTID
    , 'acquiringChannelCode' value AUTH_ACQ_CHANNEL_ID, 'authDateTime' value AUTH_REQ_DATE, 'accountId' value AUTH_ACCOUNT_ID, 'mobileNumber' value AUTH_MOBILE
    , 'nowAvailableLimit' value AUTH_AVL_AMT_AFTER_TXN, 'dbd' value AUTH_DBD_SUBVEN_PERC, 'processingFee' value AUTH_PROCESSING_FEE, 'interestRate' value AUTH_INTEREST_RATE
    , 'failedRuleId' value AUTH_FAILED_RULE_ID, 'dfsFlag' value AUTH_DFS_FLAG, 'residenceCity' value AUTH_RESIDENCE_CITY, 'deliveryPinCode' value AUTH_DELIVERY_PIN_CODE
    , 'mbd' value AUTH_MBD, 'mobileBasedTransaction' value AUTH_MOBILE_TRANSACTION, 'primaryAddOnCardIndicator' value AUTH_PRIMARY_ADD_ON_IND
    , 'cardType' value AUTH_CARD_TYPE, 'cardDesign' value AUTH_CARD_DESIGN, 'storeId' value AUTH_STORE_ID
    , 'Parter_API_Request_Date_time' value AUTH_PARTNERAPI_REQUESTDATE  -- Added by [PS] US694734 - KPI Dashboards
  ) as jsonPacket, AUTH_RRNUMBER || SEQ_ID as RRN
  into v_JsonPacket, v_RRN
  from
  (
    select AUTH_RRNUMBER, AUTH_TRANSACTION_BRANCH_ID, AUTH_PRODUCT_ID, AUTH_SCHEME_CODE, AUTH_CREDIT_PROGRAM_CODE, AUTH_SOURCE_REVERSE, AUTH_AUTH_AMT
        , AUTH_TENOR, AUTH_MODEL_ID, AUTH_ME_DEALER_ID, AUTH_CUSTOMER_ID, AUTH_CUSTOMER_DUE_CYCLE, AUTH_CHARGE_ID1, AUTH_CHARGE_ID1_AMT, AUTH_CHARGE_ID2
        , AUTH_CHARGE_ID2_AMT, AUTH_CHARGE_ID3, AUTH_CHARGE_ID3_AMT, AUTH_CHARGE_ID4, AUTH_CHARGE_ID4_AMT, AUTH_CHARGE_ID5, AUTH_CHARGE_ID5_AMT
        , AUTH_ORG_TXN_AMT, to_char(sysdate-1,'DDMMYYYYHH24MISS') as systemdate, AUTH_TID, AUTH_PARENT_RRNUMBER, AUTH_FIRST_DUE_DATE, AUTH_IMEI, AUTH_UNIQUE_CANCELLATION_ID
        , AUTH_CARD_NUM, AUTH_ADVANCE_EMI_AMT, AUTH_NO_OF_ADV_EMI, AUTH_RESPONSE_CODE, AUTH_RESPONSE_DESC, AUTH_ASSET_CODE
        , AUTH_MERCHANT_NAME, AUTH_ORDER_NO, AUTH_PROD_DESC, AUTH_REQUESTID, AUTH_ACQ_CHANNEL_ID, AUTH_REQ_DATE, AUTH_ACCOUNT_ID, AUTH_MOBILE
        , AUTH_AVL_AMT_AFTER_TXN, AUTH_DBD_SUBVEN_PERC, AUTH_PROCESSING_FEE, AUTH_INTEREST_RATE, AUTH_FAILED_RULE_ID, AUTH_DFS_FLAG, AUTH_RESIDENCE_CITY
        , AUTH_DELIVERY_PIN_CODE, AUTH_MBD, AUTH_MOBILE_TRANSACTION, AUTH_PRIMARY_ADD_ON_IND, AUTH_CARD_TYPE, AUTH_CARD_DESIGN, AUTH_STORE_ID, SEQ_ID
        , AUTH_PARTNERAPI_REQUESTDATE AS AUTH_PARTNERAPI_REQUESTDATE -- Added by [PS] US694734 - KPI Dashboards
    from FINS_AUTHORIZATIONMASTER
    where SEQ_ID = i_AuthSeqNo
    and ( case when AUTH_CARDTYPE_IDENTIFIER = 'D' and  to_number(AUTH_ORG_TXN_AMT) < 10000 then 0 else 1 end ) = 1
  );

  --SP_ENQUEUESMSDATA(v_RRN, '3IN1APP' || i_AuthSeqNo, v_JsonPacket);

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_SendAuthData','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'i_AuthSeqNo',i_AuthSeqNo);
    commit;
end;

procedure proc_GetAutoReflowData
(
   i_Date             varchar2 := null
   ,i_type             varchar2 := null
  ,o_Output           out sys_refcursor
)as
begin


  if(i_type='Auto') then
    open o_Output for
    /*
    select distinct request.REQUESTPACKET as "requestpacket" ,request.AUTH_SEQID as "SEQ_ID",request.AUTH_RRNNUMBER as "RRN"
    from fins_3In1AppRequest request inner join FINS_3IN1APPRESPONSE response on request.REQSEQ=response.REQSEQ
    where to_date(request.ADDEDON,'dd-mm-yy')>=to_date(i_Date,'dd-mm-yy') and response.RESPONSECODE<>'00'
    and response.RESPONSECODE not in ('200','7001','7003','400', '5005')
    and response.RESPONSEDESC<>'Token not generated'
    and not exists
      (select req.AUTH_SEQID
      from fins_3In1AppRequest req inner join FINS_3IN1APPRESPONSE res on req.REQSEQ=res.REQSEQ
      where
      to_date(req.ADDEDON,'dd-mm-yy')>=to_date(i_Date,'dd-mm-yy') and req.AUTH_SEQID=request.AUTH_SEQID
      --and res.RESPONSECODE='00'
      --and res.RESPONSECODE not in ('200','7001','7003','400', '5005')
      and res.RESPONSECODE in ('200','7001')
      --and res.RESPONSEDESC<>'Token not generated'
      );
    --order by request.ADDEDON;
    */

    select distinct request.REQUESTPACKET as "requestpacket" ,request.AUTH_SEQID as "SEQ_ID",request.AUTH_RRNNUMBER as "RRN"
    from fins_3In1AppRequest request inner join FINS_3IN1APPRESPONSE response on request.REQSEQ=response.REQSEQ
    where to_date(request.ADDEDON,'dd-mm-yy')=to_date(i_Date,'dd-mm-yy')
    and response.RESPONSECODE not in ('200','7001','7003','400', '5005','00')
   --and request.AUTH_RRNNUMBER='113266413196'
    and request.AUTH_SEQID not in
      (
      select req.AUTH_SEQID
      from fins_3In1AppRequest req inner join FINS_3IN1APPRESPONSE res on req.REQSEQ=res.REQSEQ
      where
      req.AUTH_SEQID=request.AUTH_SEQID
      and to_date(req.ADDEDON,'dd-mm-yy')=to_date(i_Date,'dd-mm-yy')
      and res.RESPONSECODE in ('200','7001','00')
     -- and req.AUTH_RRNNUMBER='113266413196'
      )
    order by request.AUTH_SEQID  desc;

else
    open o_Output for
    /*
    select distinct ''''||request.AUTH_RRNNUMBER as "RRN",request.ADDEDON,response.RESPONSEDESC
    --,response.RESPONSEDESC
    from fins_3In1AppRequest request inner join FINS_3IN1APPRESPONSE response on request.REQSEQ=response.REQSEQ
    where to_date(request.ADDEDON,'dd-mm-yy')=to_date(i_Date,'dd-mm-yy') and response.RESPONSECODE<>'00'
    and response.RESPONSECODE not in ('200','7001','7003','400', '5005')
    and response.RESPONSEDESC<>'Token not generated'
    and not exists
      (select req.AUTH_SEQID
      from fins_3In1AppRequest req inner join FINS_3IN1APPRESPONSE res on req.REQSEQ=res.REQSEQ
      where
      to_date(req.ADDEDON,'dd-mm-yy')>=to_date(i_Date,'dd-mm-yy') and req.AUTH_SEQID=request.AUTH_SEQID
      --and res.RESPONSECODE='00'
      --and res.RESPONSECODE not in ('200','7001','7003','400', '5005')
      and res.RESPONSECODE in ('200','7001')
      --and res.RESPONSEDESC<>'Token not generated'
      )
    order by request.ADDEDON;
    */

    select distinct ''''||request.AUTH_RRNNUMBER as "RRN",request.ADDEDON,response.RESPONSEDESC,request.AUTH_SEQID as "SEQ_ID"
    from fins_3In1AppRequest request inner join FINS_3IN1APPRESPONSE response on request.REQSEQ=response.REQSEQ
    where to_date(request.ADDEDON,'dd-mm-yy')=to_date(i_Date,'dd-mm-yy')
    and response.RESPONSECODE not in ('200','7001','7003','400', '5005','00')
    --and request.AUTH_RRNNUMBER='113266413196'
    and request.AUTH_SEQID not in
      (
      select req.AUTH_SEQID
      from fins_3In1AppRequest req inner join FINS_3IN1APPRESPONSE res on req.REQSEQ=res.REQSEQ
      where
      req.AUTH_SEQID=request.AUTH_SEQID
      and to_date(req.ADDEDON,'dd-mm-yy')=to_date(i_Date,'dd-mm-yy')
      and res.RESPONSECODE in ('200','7001','00')
      --and req.AUTH_RRNNUMBER='113266413196'
      )
    order by request.ADDEDON  desc;

end if;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_GetAutoReflowData','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'Date',i_Date);
    commit;
end proc_GetAutoReflowData;

procedure proc_GetAPIDetails
(
  i_APIName           varchar2 := null

  , o_TokenExpiryFlag out varchar2
  , o_Token           out varchar2

  , o_TimeOut         out varchar2
  , o_Authorization   out varchar2

  , o_APIDataURL      out varchar2
  , o_APIEDKey        out varchar2
  , o_ConnectionFrom  out varchar2
  , o_Source          out varchar2

  , o_TokenURL        out varchar2
  , o_TokenEDKey      out varchar2
  , o_TSource         out varchar2
  , o_TConnectionFrom out varchar2
  , o_TAccept         out varchar2
  , o_JsonRequest     out varchar2
)
as
  v_TokenExpiry       varchar2(2 byte) := 'Y';
  v_Token             varchar2(1000 byte);
  v_TokenBufferMin    number := 13;

begin

  begin
    select Token, case when round( (sysdate  - Addedon) * 24 * 60,0) > ((nvl(EXPIRESIN,0)/60) - v_TokenBufferMin) then 'Y' else 'N' end as TokenExpiry
    into v_Token, v_TokenExpiry
    from fins_3IN1AppToken
    order by seqno desc
    fetch first 1 rows only;

    o_TokenExpiryFlag := v_TokenExpiry;
    o_Token := v_Token;
  exception
    when no_data_found then
      o_TokenExpiryFlag := v_TokenExpiry;
      o_Token := v_Token;
    when others then
      o_TokenExpiryFlag := v_TokenExpiry;
      o_Token := v_Token;
  end;

  -- Common API details
  o_TimeOut := '25000';--'25000';
  select fn_to_base64('QAh1urIA6IfOmvU:xemhi1jlN1p4d8Tq4C-YdDWibgs') into o_Authorization from dual;

  if( i_APIName = 'AUTH' ) then
    -- Auth Data API details
    o_APIDataURL := 'https://superapp.bajajfinserv.in/apis/createemicardtransactionhistory';
    o_APIEDKey := 'Q8R2J3K4N6P7Q9S2';
    o_ConnectionFrom := 'Upgrade-ws';
    o_Source := 'atos';
  else
    -- Cust Data API details
    o_APIDataURL := 'https://sauat.bajajfinserv.in/apis/emicardupdate';
    o_APIEDKey := 'G2K4M5N7Q8R9T2J3';
    o_ConnectionFrom := 'Upgrade-ws';
    o_Source := 'local';
  end if;

  -- Token API details
  o_TokenURL := 'https://superapp.bajajfinserv.in/apis/oauth-token';
  o_TokenEDKey := 'G3K4M6P7Q8S2J3M5';
  o_TSource := 'atos';
  o_TConnectionFrom := 'rest';
  o_TAccept := 'json';
  select JSON_OBJECT
        (
          'grant_type' value 'password',
          'deviceId' value '12',
          'channelId' value '1',
          'username' value 'atosuser',
          'passwordType' value 'password',
          'password' value 'Kjwm5HUJNX4'
        ) as TokenRequest into o_JsonRequest from dual;

exception
  when others then
    o_TokenExpiryFlag := v_TokenExpiry;
    o_Token := v_Token;

    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_GetAPIDetails','BACKTRACE ERROR: '||substr(dbms_utility.format_error_backtrace,1,200) ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,null,null);
    commit;
end proc_GetAPIDetails;

procedure proc_InsertToken
(
  i_Token             varchar2
  , i_ExpiresIn       varchar2
  , i_Source          varchar2
  , i_Response        varchar2
)
as
begin

  insert into fins_3IN1AppToken
  (
    Token
    , ExpiresIn
    , Source
    , Response
  )
  values
  (
    i_Token
    , i_ExpiresIn
    , i_Source
    , i_Response
  );
  commit;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App Auth Data','pkg_fins_3In1App','proc_InsertToken','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,null,null);
    commit;
end proc_InsertToken;

procedure proc_SendAlertSMS
as
  v_Auth_Count        number := 0;
  v_Cust_Count        number := 0;
  v_Loop_Count        number := 0;
  v_SMSRRN            varchar2(50);
  v_SMS_SHORT_CODE    varchar2(10);
  v_SMSPacket         varchar2(1000);
  v_AlertInterval     number := 30; -- In Minutes
  v_AlertMobile       varchar2(1000);
  v_Mobile            varchar2(15);
  v_TimeRange         varchar2(50) := to_char(sysdate - v_AlertInterval/1440,'HH24:MI:SS') || ' to ' || to_char(sysdate,'HH24:MI:SS');
begin

  -- 3IN1 AUTH Alert
  select count(1) into v_Auth_Count
  from FINS_3IN1APPRESPONSE
  where ADDEDON >=  TO_DATE(TO_CHAR(SYSDATE - v_AlertInterval/1440, 'DD-MON-YY HH24MI'),'DD-MON-YY HH24MI')
  and ALERTSMSFLAG = 'Y'
  ;

  -- 3IN1 CUST Alert
  select count(1) into v_Cust_Count
  from FINS_3IN1CUSRESPONSE
  where ADDEDON >=  TO_DATE(TO_CHAR(SYSDATE - v_AlertInterval/1440, 'DD-MON-YY HH24MI'),'DD-MON-YY HH24MI')
  and ALERTSMSFLAG = 'Y'
  ;

  if( v_Auth_Count > 0 or v_Cust_Count > 0 ) then
    select SENDSMS_TO into v_AlertMobile from FINS_SMSALERTMASTER where SERVICENAME = '3IN1APP';
    
    select count(1) into v_Loop_Count
    from (
          SELECT regexp_substr(v_AlertMobile,'[^,]+', 1, LEVEL) AS acqchnl
          FROM dual
          CONNECT BY regexp_substr(v_AlertMobile, '[^,]+', 1, LEVEL) IS NOT NULL
        );

    while v_Loop_Count > 0
    loop
      select Mobile into v_Mobile
      from (
            select rownum as srno, Mobile
            from (
                  SELECT regexp_substr(v_AlertMobile,'[^,]+', 1, LEVEL) AS Mobile
                  FROM dual
                  CONNECT BY regexp_substr(v_AlertMobile, '[^,]+', 1, LEVEL) IS NOT NULL
                )
          )
      where srno = v_Loop_Count
      order by srno desc;

      if( v_Auth_Count > 0 ) then
        v_SMSRRN := '3IN1AUT' || to_char(sysdate,'DDMMYYYYHH24MI');
        v_SMS_SHORT_CODE := '3IN1AUT';
        v_SMSPacket := 'TXNTYPE=' || v_SMS_SHORT_CODE || '|BANK=00059|RRN=' || v_SMSRRN || '|SMSFLAG=Y|EMFLAG=N|REQMO=' || v_Mobile || '|ALERTTYPE=3IN1 AUTH API|TXNDATE=' || to_char(sysdate,'yyyymmdd') || '|TXNDTTM=' || to_char(sysdate,'HH24:MI:SS') || '|METHOD=' || v_Auth_Count || '|ERRCD=' || v_AlertInterval || '|TIMERANGE=' || v_TimeRange;
        --Dbms_output.put_line(v_SMSPacket);
        -- Enqueue SMS
        --SP_ENQUEUESMSDATA(v_SMSRRN, v_SMS_SHORT_CODE, v_SMSPacket);
      end if;

      if( v_Cust_Count > 0 ) then
        v_SMSRRN := '3IN1CUS' || to_char(sysdate,'DDMMYYYYHH24MI');
        v_SMS_SHORT_CODE := '3IN1CUS';
        v_SMSPacket := 'TXNTYPE=' || v_SMS_SHORT_CODE || '|BANK=00059|RRN=' || v_SMSRRN || '|SMSFLAG=Y|EMFLAG=N|REQMO=' || v_Mobile || '|ALERTTYPE=3IN1 CUS API|TXNDATE=' || to_char(sysdate,'yyyymmdd') || '|TXNDTTM=' || to_char(sysdate,'HH24:MI:SS') || '|METHOD=' || v_Cust_Count || '|ERRCD=' || v_AlertInterval || '|TIMERANGE=' || v_TimeRange;
        --Dbms_output.put_line(v_SMSPacket);
        -- Enqueue SMS
        --SP_ENQUEUESMSDATA(v_SMSRRN, v_SMS_SHORT_CODE, v_SMSPacket);
      end if;

      v_Loop_Count := v_Loop_Count - 1;
    end loop;

  end if;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_SendAlertSMS','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,null,null);
    commit;
end proc_SendAlertSMS;

procedure proc_InsertRequest_Cus
(
  i_KeyData           varchar2 := null
  , i_RequestPacket   varchar2 := null
  , i_Source          varchar2 := null
  , o_Output          out sys_refcursor
)
as
  v_ReqSeq            number := 0;
  v_TokenExpiryFlag   varchar2(1);
  v_Token             varchar2(100);

  v_TimeOut           varchar2(10);
  v_Authorization     varchar2(100);

  v_CustDataURL       varchar2(100);
  v_CustEDKey         varchar2(20);
  v_ConnectionFrom    varchar2(20);
  v_Source            varchar2(20);

  v_TokenURL          varchar2(100);
  v_TokenEDKey        varchar2(20);
  v_TSource           varchar2(20);
  v_TConnectionFrom   varchar2(20);
  v_TAccept           varchar2(20);
  v_JsonRequest       varchar(4000);

begin

  select seq_3In1Cus_req.nextval into v_ReqSeq from dual;

  insert into fins_3In1CusRequest
  (
    ReqSeq
    , KeyData
    , RequestPacket
    , Source
  )
  values
  (
    v_reqseq
    , i_KeyData
    , i_RequestPacket
    , i_Source
  );
  commit;

  -- Check Token Expiry  API Details
  proc_GetAPIDetails
  (
    'CUST'
    , v_TokenExpiryFlag, v_Token
    , v_TimeOut, v_Authorization
    , v_CustDataURL, v_CustEDKey, v_ConnectionFrom, v_Source
    , v_TokenURL, v_TokenEDKey, v_TSource, v_TConnectionFrom, v_TAccept, v_JsonRequest
  );

  open o_Output for
  select v_ReqSeq as ReqSeq, v_TokenExpiryFlag as TokenExpiryFlag, v_Token as Token, v_TimeOut as TimeOut
        -- 3IN1App API Details
        , v_CustDataURL as CustDataAPI, 'Basic ' || v_Authorization as Authorization
        , v_CustEDKey as EDKey, v_ConnectionFrom as Connectionfrom, v_Source as source
        -- OAuth Token API Details
        , v_TokenURL as TokenUrl, v_TokenEDKey as TokenEDKey, v_Authorization as TAuthorization, v_TSource as TSource
        , v_TConnectionFrom as TokenConnectionfrom, v_TAccept as tokenAccept, v_JsonRequest as TokenRequest
  from dual;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_InsertRequest_Cus','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'i_KeyData',i_KeyData);
    commit;
    open o_Output for select '0' as ReqSeq from dual;
end proc_InsertRequest_Cus;

procedure proc_InsertResponse_Cus
(
  i_ReqSeq            varchar2 := null
  , i_ResponsePacket  varchar2 := null
  , i_ResponseCode    varchar2 := null
  , i_ResponseDesc    varchar2 := null
  , i_HttpStatusCode  varchar2 := null
  , i_RetryCount      varchar2 := null
  , o_Output          out sys_refcursor
)
as
  v_ResSeq            number := 0;
begin

  select seq_3In1Cus_res.nextval into v_ResSeq from dual;

  insert into fins_3In1CusResponse
  (
    ResSeq
    , ReqSeq
    , ResponsePacket
    , ResponseCode
    , ResponseDesc
    , AlertSMSFlag
    , RetryCount
  )
  values
  (
    v_ResSeq
    , i_ReqSeq
    , i_ResponsePacket
    , case when i_ResponseCode in ('7001','200') then '00' else case when json_value(i_ResponsePacket, '$.statusCode') is not null then json_value(i_ResponsePacket, '$.statusCode') else i_ResponseCode end end
    , i_ResponseDesc
    , case when i_HttpStatusCode = '900' or i_ResponseCode in ('500','480','7002','7004','900') then 'Y' else 'N' end
    , i_RetryCount
  );
  commit;

  open o_Output for select v_ResSeq as ResSeq from dual;

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_InsertResponse_Cus','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'i_ReqSeq',i_ReqSeq);
    commit;
    open o_Output for select '0' as ResSeq from dual;
end proc_InsertResponse_Cus;

--Changes done by Rahul on 10-05-2021 for US-688210 Start
procedure proc_GetCUSTData
(
  CUST_ID                               	   varchar2 := null,
  ACCOUNT_ID                             	   varchar2 := null,
  CRD_NO                                     varchar2 := null,
  CLI_SYSTEM_BLOCK_CODE                      varchar2 := null,
  CLI_SYSTEM_UNBLOCK_REASON                  varchar2 := null,
  CLI_SYSTEM_BLOCK_DATE                      varchar2 := null,
  CLI_SYSTEM_UNBLOCK_DATE                    varchar2 := null,
  CLI_MANUAL_BLOCK_CODE                      varchar2 := null,
  CLI_MANUAL_UNBLOCK_REASON                  varchar2 := null,
  CLI_MANUAL_BLOCK_DATE                      varchar2 := null,
  CLI_MANUAL_UNBLOCK_DATE                    varchar2 := null,
  ACC_SYSTEM_BLOCK_CODE                      varchar2 := null,
  ACC_SYSTEM_BLOCK_DATE                      varchar2 := null,
  ACC_SYSTEM_UNBLOCK_DATE                    varchar2 := null,
  ACC_SYSTEM_UNBLOCK_REASON                  varchar2 := null,
  ACC_MANUAL_BLOCK_CODE                      varchar2 := null,
  ACC_MANUAL_BLOCK_DATE                      varchar2 := null,
  ACC_MANUAL_UNBLOCK_DATE                    varchar2 := null,
  ACC_MANUAL_UNBLOCK_REASON                  varchar2 := null,
  CRD_SYSTEM_BLOCK_CODE                      varchar2 := null,
  CRD_SYSTEM_BLOCK_DATE                      varchar2 := null,
  CRD_SYSTEM_UNBLOCK_DATE                    varchar2 := null,
  CRD_SYSTEM_UNBLOCK_REASON                  varchar2 := null,
  CRD_MANUAL_BLOCK_CODE                      varchar2 := null,
  CRD_MANUAL_BLOCK_DATE                      varchar2 := null,
  CRD_MANUAL_UNBLOCK_DATE                    varchar2 := null,
  CRD_MANUAL_UNBLOCK_REASON                  varchar2 := null,
  CLI_RES_MOBILE                             varchar2 := null,
  CLI_RES_EMAIL                              varchar2 := null,
  CRD_ADDONMOBILE                            varchar2 := null,
  ACC_CREDIT_LIMIT                           varchar2 := null,
  ACC_TOTAL_AUTH_BLOCKED                     varchar2 := null,
  ACC_TOTAL_LOAN_BLOCKED                     varchar2 := null,
  ACC_ADJ_LIMIT                              varchar2 := null,
  ACC_ADJ_LIMIT_DATE                         varchar2 := null,
  ACC_TEMP_LIMIT                             varchar2 := null,
  ACC_TEMP_LIMIT_START_DT                    varchar2 := null,
  ACC_TEMP_LIMIT_END_DT                      varchar2 := null,
  CRD_TYPE                                   varchar2 := null,
  CRD_DESIGN                                 varchar2 := null,
  Source                                     varchar2 := null
)
as
    v_JsonPacket  varchar2(4000):=null;
begin
  select JSON_OBJECT
  (
       'customerId'						              value		  CUST_ID
      ,'accountId'                          value    	ACCOUNT_ID
      ,'cardNumber'                         value    	CRD_NO
      ,'customerSystemBlockCode'            value    	CLI_SYSTEM_BLOCK_CODE
      ,'customerSystemUnblockReason'        value    	CLI_SYSTEM_UNBLOCK_REASON
      ,'customerSystemBlockDate'            value    	CLI_SYSTEM_BLOCK_DATE
      ,'customerSystemUnblockDate'          value    	CLI_SYSTEM_UNBLOCK_DATE
      ,'customerManualBlockCode'            value    	CLI_MANUAL_BLOCK_CODE
      ,'customerManualunblockReason'        value    	CLI_MANUAL_UNBLOCK_REASON
      ,'customerManualBlockDate'            value    	CLI_MANUAL_BLOCK_DATE
      ,'customerManualUnblockDate'          value    	CLI_MANUAL_UNBLOCK_DATE
      ,'accountSystemBlockCode'             value    	ACC_SYSTEM_BLOCK_CODE
      ,'accountSystemBlockDate'             value    	ACC_SYSTEM_BLOCK_DATE
      ,'accountSystemUnblockDate'           value    	ACC_SYSTEM_UNBLOCK_DATE
      ,'accountSystemUnblockReason'         value    	ACC_SYSTEM_UNBLOCK_REASON
      ,'accountManualBlockCode'             value    	ACC_MANUAL_BLOCK_CODE
      ,'accountManualBlockDate'             value    	ACC_MANUAL_BLOCK_DATE
      ,'accountManualUnblockDate'           value    	ACC_MANUAL_UNBLOCK_DATE
      ,'accountManualUnblockReason'         value    	ACC_MANUAL_UNBLOCK_REASON
      ,'cardSystemBlockCode'                value    	CRD_SYSTEM_BLOCK_CODE
      ,'cardSystemBlockDate'                value    	CRD_SYSTEM_BLOCK_DATE
      ,'cardSystemUnblockDate'              value    	CRD_SYSTEM_UNBLOCK_DATE
      ,'cardSystemUnblockReason'            value    	CRD_SYSTEM_UNBLOCK_REASON
      ,'cardManualBlockCode'                value    	CRD_MANUAL_BLOCK_CODE
      ,'cardManualBlockDate'                value    	CRD_MANUAL_BLOCK_DATE
      ,'cardManualUnblockDate'              value    	CRD_MANUAL_UNBLOCK_DATE
      ,'cardManualUnblockReason'            value    	CRD_MANUAL_UNBLOCK_REASON
      ,'residenceMobile'                    value    	CLI_RES_MOBILE
      ,'residenceEmail'                     value    	CLI_RES_EMAIL
      ,'addOnMobileNumber'                  value    	CRD_ADDONMOBILE
      ,'creditLimit'                        value    	ACC_CREDIT_LIMIT
      ,'accountTotalAuthBlocked'            value    	ACC_TOTAL_AUTH_BLOCKED
      ,'accountTotalLoanBlocked'            value    	ACC_TOTAL_LOAN_BLOCKED
      ,'accountAdjLimit'                    value    	ACC_ADJ_LIMIT
      ,'accountAdjLimitAdjDate'             value    	ACC_ADJ_LIMIT_DATE
      ,'accountTempLimit'                   value    	ACC_TEMP_LIMIT
      ,'accountTempLimitStartDt'            value    	ACC_TEMP_LIMIT_START_DT
      ,'accountTempLimitEndDt'              value    	ACC_TEMP_LIMIT_END_DT
      ,'crdType'                            value    	CRD_TYPE
      ,'cardDesign'                         value    	CRD_DESIGN
      ,'source'                             value    	Source
      ,'updateDate'                         value    	to_char(sysdate,'DDMMYYYYHH24MISS')

  ) as jsonPacket  into v_JsonPacket
  FROM dual;

  --SP_ENQUEUESMSDATA('', '3IN1CUS' || NVL(NVL(CUST_ID, ACCOUNT_ID), CRD_NO), v_JsonPacket);

exception
  when others then
    insert into fins_apiwiselog (application,packagename,procedurename,errortext,addedon,fieldname,fieldvalue)
    values ('3IN1App','pkg_fins_3In1App','proc_GetCUSTData','BACKTRACE ERROR: '||dbms_utility.format_error_backtrace ||' STACKTRACE ERROR: '||substr(dbms_utility.format_error_stack, 1, 200),SYSDATE,'','');
    commit;
end;

--Changes done by Rahul on 10-05-2021 for US-688210 End

end pkg_fins_3In1App;