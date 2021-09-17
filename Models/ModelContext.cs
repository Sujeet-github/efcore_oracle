using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace projectMigration.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fins3in1apprequest> Fins3in1apprequests { get; set; }
        public virtual DbSet<Fins3in1appresponse> Fins3in1appresponses { get; set; }
        public virtual DbSet<Fins3in1apptoken> Fins3in1apptokens { get; set; }
        public virtual DbSet<Fins3in1cusrequest> Fins3in1cusrequests { get; set; }
        public virtual DbSet<Fins3in1cusresponse> Fins3in1cusresponses { get; set; }
        public virtual DbSet<FinsAccountmaster> FinsAccountmasters { get; set; }
        public virtual DbSet<FinsAccprodmapping> FinsAccprodmappings { get; set; }
        public virtual DbSet<FinsAcqproductparammaster> FinsAcqproductparammasters { get; set; }
        public virtual DbSet<FinsApiwiselog> FinsApiwiselogs { get; set; }
        public virtual DbSet<FinsAssetcategorymaster> FinsAssetcategorymasters { get; set; }
        public virtual DbSet<FinsAssetmodelmapping> FinsAssetmodelmappings { get; set; }
        public virtual DbSet<FinsAuthorizationmaster> FinsAuthorizationmasters { get; set; }
        public virtual DbSet<FinsAuthorizationmasterBkp> FinsAuthorizationmasterBkps { get; set; }
        public virtual DbSet<FinsAuthorizationmasterHi> FinsAuthorizationmasterHis { get; set; }
        public virtual DbSet<FinsBulkdealerdetail> FinsBulkdealerdetails { get; set; }
        public virtual DbSet<FinsCardmaster> FinsCardmasters { get; set; }
        public virtual DbSet<FinsClientmaster> FinsClientmasters { get; set; }
        public virtual DbSet<FinsCreditprogrammapping> FinsCreditprogrammappings { get; set; }
        public virtual DbSet<FinsDealermanfmapping> FinsDealermanfmappings { get; set; }
        public virtual DbSet<FinsDealermappingmaster> FinsDealermappingmasters { get; set; }
        public virtual DbSet<FinsDealermaster> FinsDealermasters { get; set; }
        public virtual DbSet<FinsDealershortname> FinsDealershortnames { get; set; }
        public virtual DbSet<FinsEcommOtp> FinsEcommOtps { get; set; }
        public virtual DbSet<FinsEcsconfigday> FinsEcsconfigdays { get; set; }
        public virtual DbSet<FinsEmiFeeLogicStip> FinsEmiFeeLogicStips { get; set; }
        public virtual DbSet<FinsGetdealerkey> FinsGetdealerkeys { get; set; }
        public virtual DbSet<FinsInactaccountmaster> FinsInactaccountmasters { get; set; }
        public virtual DbSet<FinsInactcardmaster> FinsInactcardmasters { get; set; }
        public virtual DbSet<FinsInactclientmaster> FinsInactclientmasters { get; set; }
        public virtual DbSet<FinsLrpdebug> FinsLrpdebugs { get; set; }
        public virtual DbSet<FinsManufacturermaster> FinsManufacturermasters { get; set; }
        public virtual DbSet<FinsModelmaster> FinsModelmasters { get; set; }
        public virtual DbSet<FinsModelproductmapping> FinsModelproductmappings { get; set; }
        public virtual DbSet<FinsProductlevelparammaster> FinsProductlevelparammasters { get; set; }
        public virtual DbSet<FinsProfilekeyconfig> FinsProfilekeyconfigs { get; set; }
        public virtual DbSet<FinsProfilemaster> FinsProfilemasters { get; set; }
        public virtual DbSet<FinsRuralschememaster> FinsRuralschememasters { get; set; }
        public virtual DbSet<FinsSchemedealermapping> FinsSchemedealermappings { get; set; }
        public virtual DbSet<FinsSchememappingremi> FinsSchememappingremis { get; set; }
        public virtual DbSet<FinsSchememaster> FinsSchememasters { get; set; }
        public virtual DbSet<FinsSchememodelmapping> FinsSchememodelmappings { get; set; }
        public virtual DbSet<FinsSmsalertmaster> FinsSmsalertmasters { get; set; }
        public virtual DbSet<FinsSysLevelParamMaster> FinsSysLevelParamMasters { get; set; }
        public virtual DbSet<FinsTid> FinsTids { get; set; }
        public virtual DbSet<FinsValidateorderid> FinsValidateorderids { get; set; }
        public virtual DbSet<FinsValidateorderidPo> FinsValidateorderidPos { get; set; }
        public virtual DbSet<FinsValidaterequestid> FinsValidaterequestids { get; set; }
        public virtual DbSet<RequestAudit> RequestAudits { get; set; }
        public virtual DbSet<RequestAuditCustsearch> RequestAuditCustsearches { get; set; }
        public virtual DbSet<ResponseAudit> ResponseAudits { get; set; }
        public virtual DbSet<ResponseAuditCustsearch> ResponseAuditCustsearches { get; set; }
        public virtual DbSet<VwFinsAuthorizationmaster> VwFinsAuthorizationmasters { get; set; }
        public virtual DbSet<WsKeyconfigmultiservice> WsKeyconfigmultiservices { get; set; }
        public virtual DbSet<XpBflDealerBusinessProd> XpBflDealerBusinessProds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=10.10.11.225:1521/BFLDBUAT;User Id=EFCOREPOC;Password=EFCOREPOC");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EFCOREPOC")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Fins3in1apprequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_3IN1APPREQUEST");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate\n   ");

                entity.Property(e => e.AuthRrnnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RRNNUMBER");

                entity.Property(e => e.AuthSeqid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_SEQID");

                entity.Property(e => e.Reqseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQ");

                entity.Property(e => e.Requestpacket)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTPACKET");

                entity.Property(e => e.Source)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");
            });

            modelBuilder.Entity<Fins3in1appresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_3IN1APPRESPONSE");

                entity.HasIndex(e => e.Addedon, "IDX_3IN1APPRESPONSE_DT");

                entity.HasIndex(e => e.Alertsmsflag, "IDX_3IN1APPRESPONSE_SMS");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Alertsmsflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALERTSMSFLAG");

                entity.Property(e => e.Reqseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQ");

                entity.Property(e => e.Responsecode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSECODE");

                entity.Property(e => e.Responsedesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSEDESC");

                entity.Property(e => e.Responsepacket)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSEPACKET");

                entity.Property(e => e.Resseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESSEQ");
            });

            modelBuilder.Entity<Fins3in1apptoken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_3IN1APPTOKEN");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate\n   ");

                entity.Property(e => e.Expiresin)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXPIRESIN");

                entity.Property(e => e.Response)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSE");

                entity.Property(e => e.Seqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQNO")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"SEQ_3IN1APPTOKEN\".\"NEXTVAL\"");

                entity.Property(e => e.Source)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TOKEN");
            });

            modelBuilder.Entity<Fins3in1cusrequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_3IN1CUSREQUEST");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate\n   ");

                entity.Property(e => e.Keydata)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KEYDATA");

                entity.Property(e => e.Reqseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQ");

                entity.Property(e => e.Requestpacket)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTPACKET");

                entity.Property(e => e.Source)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");
            });

            modelBuilder.Entity<Fins3in1cusresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_3IN1CUSRESPONSE");

                entity.HasIndex(e => e.Addedon, "IDX_3IN1CUSRESPONSE_DT");

                entity.HasIndex(e => e.Alertsmsflag, "IDX_3IN1CUSRESPONSE_SMS");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Alertsmsflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALERTSMSFLAG");

                entity.Property(e => e.Reqseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQ");

                entity.Property(e => e.Responsecode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSECODE");

                entity.Property(e => e.Responsedesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSEDESC");

                entity.Property(e => e.Responsepacket)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSEPACKET");

                entity.Property(e => e.Resseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESSEQ");

                entity.Property(e => e.Retrycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RETRYCOUNT");
            });

            modelBuilder.Entity<FinsAccountmaster>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK_ACC_ID");

                entity.ToTable("FINS_ACCOUNTMASTER");

                entity.HasIndex(e => e.AccCustId, "IDX_ACCOUNTCUSTID");

                entity.Property(e => e.AccId)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("ACC_ID");

                entity.Property(e => e.AccAdjLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_ADJ_LIMIT");

                entity.Property(e => e.AccAdjLimitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_ADJ_LIMIT_DATE");

                entity.Property(e => e.AccBankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANKCODE");

                entity.Property(e => e.AccBestLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_BEST_LIMIT");

                entity.Property(e => e.AccBlockClassModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.AccBlockClassification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BLOCK_CLASSIFICATION");

                entity.Property(e => e.AccCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_CREATION_DATE");

                entity.Property(e => e.AccCreditLimUpdSrc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACC_CREDIT_LIM_UPD_SRC");

                entity.Property(e => e.AccCreditLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_CREDIT_LIMIT");

                entity.Property(e => e.AccCreditLimtChgDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_CREDIT_LIMT_CHG_DT");

                entity.Property(e => e.AccCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("ACC_CUST_ID");

                entity.Property(e => e.AccEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_END_DATE");

                entity.Property(e => e.AccFirstTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_FIRST_TXN_DATE");

                entity.Property(e => e.AccFirstTxnLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_FIRST_TXN_LIMIT");

                entity.Property(e => e.AccFirstTxnRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ACC_FIRST_TXN_RRN");

                entity.Property(e => e.AccIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_IVR_UPD");

                entity.Property(e => e.AccLastAuthDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_AUTH_DATE");

                entity.Property(e => e.AccLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.AccLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_MODIFY_DT_WL");

                entity.Property(e => e.AccManualBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACC_MANUAL_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.AccManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_MANUAL_BLOCK_DATE");

                entity.Property(e => e.AccManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.AccManualUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACC_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.AccNameChmpChllg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACC_NAME_CHMP_CHLLG");

                entity.Property(e => e.AccNoOfAddonCards)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AccOldestActPriCard)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ACC_OLDEST_ACT_PRI_CARD");

                entity.Property(e => e.AccProcDevEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_PROC_DEV_END_DATE");

                entity.Property(e => e.AccProcDevFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACC_PROC_DEV_FLAG");

                entity.Property(e => e.AccStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_START_DATE");

                entity.Property(e => e.AccSystemBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACC_SYSTEM_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.AccSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.AccSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.AccSystemUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACC_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.AccTempLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TEMP_LIMIT");

                entity.Property(e => e.AccTempLimitEndDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_TEMP_LIMIT_END_DT");

                entity.Property(e => e.AccTempLimitStartDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_TEMP_LIMIT_START_DT");

                entity.Property(e => e.AccTotalAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.AccTotalLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.AccTotalNoOfCards)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TOTAL_NO_OF_CARDS");

                entity.Property(e => e.AccType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TYPE");

                entity.Property(e => e.AccVipNonvipFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACC_VIP_NONVIP_FLAG");
            });

            modelBuilder.Entity<FinsAccprodmapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_ACCPRODMAPPING");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTTYPE");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"SQEACCPRODMAPPING\".\"NEXTVAL\"");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifyby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifyon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFYON");

                entity.Property(e => e.Priority)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FinsAcqproductparammaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_ACQPRODUCTPARAMMASTER");

                entity.Property(e => e.Acqchannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACQCHANNEL");

                entity.Property(e => e.Addedby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Cancelotpbypass)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELOTPBYPASS");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Otpbypass)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OTPBYPASS");

                entity.Property(e => e.Productid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ");

                entity.Property(e => e.Settlement)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SETTLEMENT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FinsApiwiselog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_APIWISELOG");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Application)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION");

                entity.Property(e => e.Auditseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUDITSEQ")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"FINS_AUDITLOGSEQ\".\"NEXTVAL\"");

                entity.Property(e => e.Errortext)
                    .HasColumnType("CLOB")
                    .HasColumnName("ERRORTEXT");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FIELDNAME");

                entity.Property(e => e.Fieldvalue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FIELDVALUE");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Procedurename)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PROCEDURENAME");
            });

            modelBuilder.Entity<FinsAssetcategorymaster>(entity =>
            {
                entity.HasKey(e => e.Catgid)
                    .HasName("FINS_ASSETCATEGORYMASTER_PK");

                entity.ToTable("FINS_ASSETCATEGORYMASTER");

                entity.Property(e => e.Catgid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATGID");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Assetcatseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSETCATSEQ");

                entity.Property(e => e.Catgdesc)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CATGDESC");

                entity.Property(e => e.CibilCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIBIL_CHECK");

                entity.Property(e => e.DigitalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DIGITAL_FLAG");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modefiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODEFIEDBY");

                entity.Property(e => e.Modefiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODEFIEDON");

                entity.Property(e => e.RiskClassification)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RISK_CLASSIFICATION");

                entity.Property(e => e.Uploadid)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsAssetmodelmapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_ASSETMODELMAPPING");

                entity.Property(e => e.Addedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Assetid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ASSETID");

                entity.Property(e => e.Bflprofileid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BFLPROFILEID");

                entity.Property(e => e.Modelid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODELID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FinsAuthorizationmaster>(entity =>
            {
                entity.HasKey(e => e.AuthSeqNo)
                    .HasName("FINS_AUTHMASTER_PK1");

                entity.ToTable("FINS_AUTHORIZATIONMASTER");

                entity.HasIndex(e => new { e.AuthCustomerId, e.AuthRrnumber, e.AuthResponseCode }, "IDX$$_AE240001");

                entity.Property(e => e.AuthSeqNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_SEQ_NO")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"FINS_AUTHORIZATIONMASTER_SEQ\".\"NEXTVAL\"");

                entity.Property(e => e.AuthAccCardLimit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACC_CARD_LIMIT");

                entity.Property(e => e.AuthAccountId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_ID");

                entity.Property(e => e.AuthAccountLimitUtil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_LIMIT_UTIL");

                entity.Property(e => e.AuthAcqChannelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACQ_CHANNEL_ID");

                entity.Property(e => e.AuthAddOnFirstTran)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADD_ON_FIRST_TRAN");

                entity.Property(e => e.AuthAddrChngFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDR_CHNG_FLG");

                entity.Property(e => e.AuthAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE1");

                entity.Property(e => e.AuthAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE2");

                entity.Property(e => e.AuthAddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE3");

                entity.Property(e => e.AuthAdvanceEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADVANCE_EMI_AMT");

                entity.Property(e => e.AuthAssetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ASSET_CODE");

                entity.Property(e => e.AuthAuthAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_AMT");

                entity.Property(e => e.AuthAuthCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_CODE");

                entity.Property(e => e.AuthAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthAvlAmtAfterTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_AFTER_TXN");

                entity.Property(e => e.AuthAvlAmtBeforeTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_BEFORE_TXN");

                entity.Property(e => e.AuthBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BANK_CODE");

                entity.Property(e => e.AuthBatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BATCH_ID");

                entity.Property(e => e.AuthBreStip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BRE_STIP");

                entity.Property(e => e.AuthCancelAmtAdjstFrom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CANCEL_AMT_ADJST_FROM");

                entity.Property(e => e.AuthCardCharges)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_CHARGES");

                entity.Property(e => e.AuthCardDesign)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_DESIGN");

                entity.Property(e => e.AuthCardExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_EXP");

                entity.Property(e => e.AuthCardNum)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_NUM");

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_TYPE");

                entity.Property(e => e.AuthCardtypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARDTYPE_IDENTIFIER");

                entity.Property(e => e.AuthCdParentRrn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CD_PARENT_RRN");

                entity.Property(e => e.AuthChallengerEligibleFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_ELIGIBLE_FLAG");

                entity.Property(e => e.AuthChallengerRuleId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_RULE_ID1");

                entity.Property(e => e.AuthChargeId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1");

                entity.Property(e => e.AuthChargeId1Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1_AMT");

                entity.Property(e => e.AuthChargeId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2");

                entity.Property(e => e.AuthChargeId2Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2_AMT");

                entity.Property(e => e.AuthChargeId3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3");

                entity.Property(e => e.AuthChargeId3Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3_AMT");

                entity.Property(e => e.AuthChargeId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4");

                entity.Property(e => e.AuthChargeId4Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4_AMT");

                entity.Property(e => e.AuthChargeId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5");

                entity.Property(e => e.AuthChargeId5Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5_AMT");

                entity.Property(e => e.AuthCibilDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DATE");

                entity.Property(e => e.AuthCibilDone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DONE");

                entity.Property(e => e.AuthCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_SCORE");

                entity.Property(e => e.AuthCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_TIME");

                entity.Property(e => e.AuthCoBrandCardCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_CARD_CODE");

                entity.Property(e => e.AuthCoBrandLimitFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_LIMIT_FLAG");

                entity.Property(e => e.AuthCreditProgramCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CREDIT_PROGRAM_CODE");

                entity.Property(e => e.AuthCtrFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CTR_FLAG");

                entity.Property(e => e.AuthCustomerDueCycle)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_DUE_CYCLE");

                entity.Property(e => e.AuthCustomerId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_ID");

                entity.Property(e => e.AuthCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_NAME");

                entity.Property(e => e.AuthDateLtxnMatch)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_DATE_LTXN_MATCH");

                entity.Property(e => e.AuthDbdSubvenPerc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DBD_SUBVEN_PERC");

                entity.Property(e => e.AuthDeliveryPinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DELIVERY_PIN_CODE");

                entity.Property(e => e.AuthDfsAcquringChannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_ACQURING_CHANNEL");

                entity.Property(e => e.AuthDfsEFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_E_FLAG");

                entity.Property(e => e.AuthDfsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_FLAG");

                entity.Property(e => e.AuthDfsPremiumAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_PREMIUM_AMOUNT");

                entity.Property(e => e.AuthDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthDocumentRequiredFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOCUMENT_REQUIRED_FLG");

                entity.Property(e => e.AuthDowNumberPayment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOW_NUMBER_PAYMENT");

                entity.Property(e => e.AuthEcsAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_ACCOUNT_NUMBER");

                entity.Property(e => e.AuthEcsAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthEcsBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_BANK_NAME");

                entity.Property(e => e.AuthEcsMandateRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_MANDATE_REQUIRED");

                entity.Property(e => e.AuthEcslmtamt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECSLMTAMT");

                entity.Property(e => e.AuthEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EMI_AMT");

                entity.Property(e => e.AuthExceptionMsg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXCEPTION_MSG");

                entity.Property(e => e.AuthExtraPricingLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXTRA_PRICING_LIMIT");

                entity.Property(e => e.AuthFailedRuleId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FAILED_RULE_ID");

                entity.Property(e => e.AuthField63Tag96)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIELD_63_TAG_96");

                entity.Property(e => e.AuthFinancingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FINANCING_TYPE_CODE");

                entity.Property(e => e.AuthFirstDueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FIRST_DUE_DATE");

                entity.Property(e => e.AuthFirstSwipeFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_SWIPE_FLAG");

                entity.Property(e => e.AuthFirstTranscatioNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_TRANSCATIO_NO");

                entity.Property(e => e.AuthFosMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FOS_MOBILE");

                entity.Property(e => e.AuthFraudFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_FLAG");

                entity.Property(e => e.AuthFraudTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FRAUD_TXN_DATE");

                entity.Property(e => e.AuthFraudTxnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_TXN_FLAG");

                entity.Property(e => e.AuthIdentifier)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IDENTIFIER");

                entity.Property(e => e.AuthImei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IMEI");

                entity.Property(e => e.AuthInterestRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_INTEREST_RATE");

                entity.Property(e => e.AuthIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IP_ADDRESS");

                entity.Property(e => e.AuthLastUpdDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LAST_UPD_DATE");

                entity.Property(e => e.AuthLoanToValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LOAN_TO_VALUE");

                entity.Property(e => e.AuthManufacturerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MANUFACTURER_ID");

                entity.Property(e => e.AuthMatchFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MATCH_FLAG");

                entity.Property(e => e.AuthMbd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MBD");

                entity.Property(e => e.AuthMeDealerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ME_DEALER_ID");

                entity.Property(e => e.AuthMerchantBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_BRANCH_ID");

                entity.Property(e => e.AuthMerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_NAME");

                entity.Property(e => e.AuthMicrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MICR_CODE");

                entity.Property(e => e.AuthMid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MID");

                entity.Property(e => e.AuthMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE");

                entity.Property(e => e.AuthMobileChangedFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_CHANGED_FLAG");

                entity.Property(e => e.AuthMobileTransaction)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_TRANSACTION");

                entity.Property(e => e.AuthModelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_ID");

                entity.Property(e => e.AuthModelMake)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_MAKE");

                entity.Property(e => e.AuthNoOfAddonCards)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AuthNoOfAdvEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NO_OF_ADV_EMI");

                entity.Property(e => e.AuthNonDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NON_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthOldCibilDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_DATE");

                entity.Property(e => e.AuthOldCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_SCORE");

                entity.Property(e => e.AuthOldCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_TIME");

                entity.Property(e => e.AuthOrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORDER_NO");

                entity.Property(e => e.AuthOrgTxnAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORG_TXN_AMT");

                entity.Property(e => e.AuthOriginalRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORIGINAL_RRNUMBER");

                entity.Property(e => e.AuthOtpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_ID");

                entity.Property(e => e.AuthOtpRequestId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_REQUEST_ID");

                entity.Property(e => e.AuthOtpVerificReslt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_VERIFIC_RESLT");

                entity.Property(e => e.AuthOtpgentime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_OTPGENTIME");

                entity.Property(e => e.AuthParentRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARENT_RRNUMBER");

                entity.Property(e => e.AuthPartialCnclChrgs)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_CHRGS");

                entity.Property(e => e.AuthPartialCnclFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_FLAG");

                entity.Property(e => e.AuthPartialCnclId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_ID");

                entity.Property(e => e.AuthPartialDbdRefund)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_DBD_REFUND");

                entity.Property(e => e.AuthPartnerEdcChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTNER_EDC_CHANNEL");

                entity.Property(e => e.AuthPartnerapiRequestdate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_PARTNERAPI_REQUESTDATE");

                entity.Property(e => e.AuthPinumberEntered)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PINUMBER_ENTERED");

                entity.Property(e => e.AuthPosEntryMode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_ENTRY_MODE");

                entity.Property(e => e.AuthPosReinventAuthcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_AUTHCODE");

                entity.Property(e => e.AuthPosReinventInvoiceAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_INVOICE_AMT");

                entity.Property(e => e.AuthPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.AuthProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESS_CODE");

                entity.Property(e => e.AuthProcessingFee)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESSING_FEE");

                entity.Property(e => e.AuthProdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROD_DESC");

                entity.Property(e => e.AuthProductCodeType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_CODE_TYPE");

                entity.Property(e => e.AuthProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_ID");

                entity.Property(e => e.AuthPromoCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROMO_CODE");

                entity.Property(e => e.AuthRelationshipType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RELATIONSHIP_TYPE");

                entity.Property(e => e.AuthReqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQ_DATE");

                entity.Property(e => e.AuthReqdatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQDATETIME");

                entity.Property(e => e.AuthRequestid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_REQUESTID");

                entity.Property(e => e.AuthResidenceCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESIDENCE_CITY");

                entity.Property(e => e.AuthResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_CODE");

                entity.Property(e => e.AuthResponseDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_DESC");

                entity.Property(e => e.AuthRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RRNUMBER");

                entity.Property(e => e.AuthSchemeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SCHEME_CODE");

                entity.Property(e => e.AuthSdkSegment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SDK_SEGMENT");

                entity.Property(e => e.AuthSdkSegmentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SDK_SEGMENT_DATE");

                entity.Property(e => e.AuthSettledFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SETTLED_FLAG");

                entity.Property(e => e.AuthSettledFlagDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SETTLED_FLAG_DATE");

                entity.Property(e => e.AuthSfdcorg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SFDCORG")
                    .IsFixedLength(true);

                entity.Property(e => e.AuthSourceReverse)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SOURCE_REVERSE");

                entity.Property(e => e.AuthStoreId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_STORE_ID");

                entity.Property(e => e.AuthTenor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TENOR");

                entity.Property(e => e.AuthTid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TID");

                entity.Property(e => e.AuthTliUtilizedFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TLI_UTILIZED_FLG");

                entity.Property(e => e.AuthTraceAuditNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRACE_AUDIT_NUMBER");

                entity.Property(e => e.AuthTransactionBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRANSACTION_BRANCH_ID");

                entity.Property(e => e.AuthTxnMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_MOBILE_NO");

                entity.Property(e => e.AuthTxnSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_SOURCE");

                entity.Property(e => e.AuthUniqueCancellationId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_UNIQUE_CANCELLATION_ID");

                entity.Property(e => e.AuthUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_USER_NAME");

                entity.Property(e => e.AuthVasAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_VAS_AMT");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_ADDRESS");

                entity.Property(e => e.SeqId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<FinsAuthorizationmasterBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_AUTHORIZATIONMASTER_BKP");

                entity.HasIndex(e => e.AuthCardNum, "IDX_BKPAUTHCARD");

                entity.HasIndex(e => e.AuthSourceReverse, "IDX_BKPAUTHREVERSE");

                entity.HasIndex(e => e.AuthRrnumber, "IDX_BKPAUTHRRN");

                entity.Property(e => e.AuthAccCardLimit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACC_CARD_LIMIT");

                entity.Property(e => e.AuthAccountId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_ID");

                entity.Property(e => e.AuthAccountLimitUtil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_LIMIT_UTIL");

                entity.Property(e => e.AuthAcqChannelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACQ_CHANNEL_ID");

                entity.Property(e => e.AuthAddOnFirstTran)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADD_ON_FIRST_TRAN");

                entity.Property(e => e.AuthAddrChngFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDR_CHNG_FLG");

                entity.Property(e => e.AuthAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE1");

                entity.Property(e => e.AuthAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE2");

                entity.Property(e => e.AuthAddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE3");

                entity.Property(e => e.AuthAdvanceEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADVANCE_EMI_AMT");

                entity.Property(e => e.AuthAssetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ASSET_CODE");

                entity.Property(e => e.AuthAuthAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_AMT");

                entity.Property(e => e.AuthAuthCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_CODE");

                entity.Property(e => e.AuthAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthAvlAmtAfterTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_AFTER_TXN");

                entity.Property(e => e.AuthAvlAmtBeforeTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_BEFORE_TXN");

                entity.Property(e => e.AuthBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BANK_CODE");

                entity.Property(e => e.AuthBatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BATCH_ID");

                entity.Property(e => e.AuthBreStip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BRE_STIP");

                entity.Property(e => e.AuthCancelAmtAdjstFrom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CANCEL_AMT_ADJST_FROM");

                entity.Property(e => e.AuthCardCharges)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_CHARGES");

                entity.Property(e => e.AuthCardDesign)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_DESIGN");

                entity.Property(e => e.AuthCardExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_EXP");

                entity.Property(e => e.AuthCardNum)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_NUM");

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_TYPE");

                entity.Property(e => e.AuthCardtypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARDTYPE_IDENTIFIER");

                entity.Property(e => e.AuthCdParentRrn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CD_PARENT_RRN");

                entity.Property(e => e.AuthChallengerEligibleFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_ELIGIBLE_FLAG");

                entity.Property(e => e.AuthChallengerRuleId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_RULE_ID1");

                entity.Property(e => e.AuthChargeId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1");

                entity.Property(e => e.AuthChargeId1Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1_AMT");

                entity.Property(e => e.AuthChargeId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2");

                entity.Property(e => e.AuthChargeId2Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2_AMT");

                entity.Property(e => e.AuthChargeId3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3");

                entity.Property(e => e.AuthChargeId3Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3_AMT");

                entity.Property(e => e.AuthChargeId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4");

                entity.Property(e => e.AuthChargeId4Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4_AMT");

                entity.Property(e => e.AuthChargeId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5");

                entity.Property(e => e.AuthChargeId5Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5_AMT");

                entity.Property(e => e.AuthCibilDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DATE");

                entity.Property(e => e.AuthCibilDone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DONE");

                entity.Property(e => e.AuthCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_SCORE");

                entity.Property(e => e.AuthCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_TIME");

                entity.Property(e => e.AuthCoBrandCardCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_CARD_CODE");

                entity.Property(e => e.AuthCoBrandLimitFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_LIMIT_FLAG");

                entity.Property(e => e.AuthCreditProgramCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CREDIT_PROGRAM_CODE");

                entity.Property(e => e.AuthCtrFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CTR_FLAG");

                entity.Property(e => e.AuthCustomerDueCycle)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_DUE_CYCLE");

                entity.Property(e => e.AuthCustomerId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_ID");

                entity.Property(e => e.AuthCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_NAME");

                entity.Property(e => e.AuthDateLtxnMatch)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_DATE_LTXN_MATCH");

                entity.Property(e => e.AuthDbdSubvenPerc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DBD_SUBVEN_PERC");

                entity.Property(e => e.AuthDeliveryPinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DELIVERY_PIN_CODE");

                entity.Property(e => e.AuthDfsAcquringChannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_ACQURING_CHANNEL");

                entity.Property(e => e.AuthDfsEFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_E_FLAG");

                entity.Property(e => e.AuthDfsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_FLAG");

                entity.Property(e => e.AuthDfsPremiumAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_PREMIUM_AMOUNT");

                entity.Property(e => e.AuthDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthDocumentRequiredFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOCUMENT_REQUIRED_FLG");

                entity.Property(e => e.AuthDowNumberPayment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOW_NUMBER_PAYMENT");

                entity.Property(e => e.AuthEcsAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_ACCOUNT_NUMBER");

                entity.Property(e => e.AuthEcsAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthEcsBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_BANK_NAME");

                entity.Property(e => e.AuthEcsMandateRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_MANDATE_REQUIRED");

                entity.Property(e => e.AuthEcslmtamt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECSLMTAMT");

                entity.Property(e => e.AuthEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EMI_AMT");

                entity.Property(e => e.AuthExceptionMsg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXCEPTION_MSG");

                entity.Property(e => e.AuthExtraPricingLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXTRA_PRICING_LIMIT");

                entity.Property(e => e.AuthFailedRuleId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FAILED_RULE_ID");

                entity.Property(e => e.AuthField63Tag96)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIELD_63_TAG_96");

                entity.Property(e => e.AuthFinancingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FINANCING_TYPE_CODE");

                entity.Property(e => e.AuthFirstDueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FIRST_DUE_DATE");

                entity.Property(e => e.AuthFirstSwipeFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_SWIPE_FLAG");

                entity.Property(e => e.AuthFirstTranscatioNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_TRANSCATIO_NO");

                entity.Property(e => e.AuthFosMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FOS_MOBILE");

                entity.Property(e => e.AuthFraudFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_FLAG");

                entity.Property(e => e.AuthFraudTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FRAUD_TXN_DATE");

                entity.Property(e => e.AuthFraudTxnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_TXN_FLAG");

                entity.Property(e => e.AuthIdentifier)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IDENTIFIER");

                entity.Property(e => e.AuthImei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IMEI");

                entity.Property(e => e.AuthInterestRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_INTEREST_RATE");

                entity.Property(e => e.AuthIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IP_ADDRESS");

                entity.Property(e => e.AuthLastUpdDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LAST_UPD_DATE");

                entity.Property(e => e.AuthLoanToValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LOAN_TO_VALUE");

                entity.Property(e => e.AuthManufacturerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MANUFACTURER_ID");

                entity.Property(e => e.AuthMatchFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MATCH_FLAG");

                entity.Property(e => e.AuthMbd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MBD");

                entity.Property(e => e.AuthMeDealerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ME_DEALER_ID");

                entity.Property(e => e.AuthMerchantBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_BRANCH_ID");

                entity.Property(e => e.AuthMerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_NAME");

                entity.Property(e => e.AuthMicrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MICR_CODE");

                entity.Property(e => e.AuthMid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MID");

                entity.Property(e => e.AuthMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE");

                entity.Property(e => e.AuthMobileChangedFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_CHANGED_FLAG");

                entity.Property(e => e.AuthMobileTransaction)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_TRANSACTION");

                entity.Property(e => e.AuthModelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_ID");

                entity.Property(e => e.AuthModelMake)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_MAKE");

                entity.Property(e => e.AuthNoOfAddonCards)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AuthNoOfAdvEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NO_OF_ADV_EMI");

                entity.Property(e => e.AuthNonDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NON_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthOldCibilDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_DATE");

                entity.Property(e => e.AuthOldCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_SCORE");

                entity.Property(e => e.AuthOldCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_TIME");

                entity.Property(e => e.AuthOrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORDER_NO");

                entity.Property(e => e.AuthOrgTxnAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORG_TXN_AMT");

                entity.Property(e => e.AuthOriginalRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORIGINAL_RRNUMBER");

                entity.Property(e => e.AuthOtpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_ID");

                entity.Property(e => e.AuthOtpRequestId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_REQUEST_ID");

                entity.Property(e => e.AuthOtpVerificReslt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_VERIFIC_RESLT");

                entity.Property(e => e.AuthOtpgentime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_OTPGENTIME");

                entity.Property(e => e.AuthParentRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARENT_RRNUMBER");

                entity.Property(e => e.AuthPartialCnclChrgs)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_CHRGS");

                entity.Property(e => e.AuthPartialCnclFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_FLAG");

                entity.Property(e => e.AuthPartialCnclId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_ID");

                entity.Property(e => e.AuthPartialDbdRefund)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_DBD_REFUND");

                entity.Property(e => e.AuthPartnerEdcChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTNER_EDC_CHANNEL");

                entity.Property(e => e.AuthPartnerapiRequestdate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_PARTNERAPI_REQUESTDATE");

                entity.Property(e => e.AuthPinumberEntered)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PINUMBER_ENTERED");

                entity.Property(e => e.AuthPosEntryMode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_ENTRY_MODE");

                entity.Property(e => e.AuthPosReinventAuthcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_AUTHCODE");

                entity.Property(e => e.AuthPosReinventInvoiceAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_INVOICE_AMT");

                entity.Property(e => e.AuthPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.AuthProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESS_CODE");

                entity.Property(e => e.AuthProcessingFee)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESSING_FEE");

                entity.Property(e => e.AuthProdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROD_DESC");

                entity.Property(e => e.AuthProductCodeType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_CODE_TYPE");

                entity.Property(e => e.AuthProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_ID");

                entity.Property(e => e.AuthPromoCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROMO_CODE");

                entity.Property(e => e.AuthRelationshipType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RELATIONSHIP_TYPE");

                entity.Property(e => e.AuthReqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQ_DATE");

                entity.Property(e => e.AuthReqdatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQDATETIME");

                entity.Property(e => e.AuthRequestid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_REQUESTID");

                entity.Property(e => e.AuthResidenceCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESIDENCE_CITY");

                entity.Property(e => e.AuthResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_CODE");

                entity.Property(e => e.AuthResponseDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_DESC");

                entity.Property(e => e.AuthRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RRNUMBER");

                entity.Property(e => e.AuthSchemeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SCHEME_CODE");

                entity.Property(e => e.AuthSdkSegment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SDK_SEGMENT");

                entity.Property(e => e.AuthSdkSegmentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SDK_SEGMENT_DATE");

                entity.Property(e => e.AuthSeqNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_SEQ_NO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AuthSettledFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SETTLED_FLAG");

                entity.Property(e => e.AuthSettledFlagDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SETTLED_FLAG_DATE");

                entity.Property(e => e.AuthSfdcorg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SFDCORG")
                    .IsFixedLength(true);

                entity.Property(e => e.AuthSourceReverse)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SOURCE_REVERSE");

                entity.Property(e => e.AuthStoreId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_STORE_ID");

                entity.Property(e => e.AuthTenor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TENOR");

                entity.Property(e => e.AuthTid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TID");

                entity.Property(e => e.AuthTliUtilizedFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TLI_UTILIZED_FLG");

                entity.Property(e => e.AuthTraceAuditNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRACE_AUDIT_NUMBER");

                entity.Property(e => e.AuthTransactionBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRANSACTION_BRANCH_ID");

                entity.Property(e => e.AuthTxnMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_MOBILE_NO");

                entity.Property(e => e.AuthTxnSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_SOURCE");

                entity.Property(e => e.AuthUniqueCancellationId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_UNIQUE_CANCELLATION_ID");

                entity.Property(e => e.AuthUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_USER_NAME");

                entity.Property(e => e.AuthVasAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_VAS_AMT");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_ADDRESS");

                entity.Property(e => e.SeqId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_ID");
            });

            modelBuilder.Entity<FinsAuthorizationmasterHi>(entity =>
            {
                entity.HasKey(e => e.AuthSeqNo)
                    .HasName("FINS_AUTHMASTER_HIS_PK1");

                entity.ToTable("FINS_AUTHORIZATIONMASTER_HIS");

                entity.HasIndex(e => e.AuthCardNum, "IDX_HISAUTHCARD");

                entity.HasIndex(e => e.AuthSourceReverse, "IDX_HISAUTHREVERSE");

                entity.HasIndex(e => e.AuthRrnumber, "IDX_HISAUTHRRN");

                entity.Property(e => e.AuthSeqNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_SEQ_NO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AuthAccCardLimit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACC_CARD_LIMIT");

                entity.Property(e => e.AuthAccountId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_ID");

                entity.Property(e => e.AuthAccountLimitUtil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_LIMIT_UTIL");

                entity.Property(e => e.AuthAcqChannelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACQ_CHANNEL_ID");

                entity.Property(e => e.AuthAddOnFirstTran)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADD_ON_FIRST_TRAN");

                entity.Property(e => e.AuthAddrChngFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDR_CHNG_FLG");

                entity.Property(e => e.AuthAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE1");

                entity.Property(e => e.AuthAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE2");

                entity.Property(e => e.AuthAddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE3");

                entity.Property(e => e.AuthAdvanceEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADVANCE_EMI_AMT");

                entity.Property(e => e.AuthAssetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ASSET_CODE");

                entity.Property(e => e.AuthAuthAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_AMT");

                entity.Property(e => e.AuthAuthCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_CODE");

                entity.Property(e => e.AuthAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthAvlAmtAfterTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_AFTER_TXN");

                entity.Property(e => e.AuthAvlAmtBeforeTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_BEFORE_TXN");

                entity.Property(e => e.AuthBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BANK_CODE");

                entity.Property(e => e.AuthBatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BATCH_ID");

                entity.Property(e => e.AuthBreStip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BRE_STIP");

                entity.Property(e => e.AuthCancelAmtAdjstFrom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CANCEL_AMT_ADJST_FROM");

                entity.Property(e => e.AuthCardCharges)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_CHARGES");

                entity.Property(e => e.AuthCardDesign)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_DESIGN");

                entity.Property(e => e.AuthCardExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_EXP");

                entity.Property(e => e.AuthCardNum)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_NUM");

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_TYPE");

                entity.Property(e => e.AuthCardtypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARDTYPE_IDENTIFIER");

                entity.Property(e => e.AuthCdParentRrn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CD_PARENT_RRN");

                entity.Property(e => e.AuthChallengerEligibleFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_ELIGIBLE_FLAG");

                entity.Property(e => e.AuthChallengerRuleId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_RULE_ID1");

                entity.Property(e => e.AuthChargeId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1");

                entity.Property(e => e.AuthChargeId1Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1_AMT");

                entity.Property(e => e.AuthChargeId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2");

                entity.Property(e => e.AuthChargeId2Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2_AMT");

                entity.Property(e => e.AuthChargeId3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3");

                entity.Property(e => e.AuthChargeId3Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3_AMT");

                entity.Property(e => e.AuthChargeId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4");

                entity.Property(e => e.AuthChargeId4Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4_AMT");

                entity.Property(e => e.AuthChargeId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5");

                entity.Property(e => e.AuthChargeId5Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5_AMT");

                entity.Property(e => e.AuthCibilDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DATE");

                entity.Property(e => e.AuthCibilDone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DONE");

                entity.Property(e => e.AuthCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_SCORE");

                entity.Property(e => e.AuthCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_TIME");

                entity.Property(e => e.AuthCoBrandCardCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_CARD_CODE");

                entity.Property(e => e.AuthCoBrandLimitFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_LIMIT_FLAG");

                entity.Property(e => e.AuthCreditProgramCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CREDIT_PROGRAM_CODE");

                entity.Property(e => e.AuthCtrFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CTR_FLAG");

                entity.Property(e => e.AuthCustomerDueCycle)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_DUE_CYCLE");

                entity.Property(e => e.AuthCustomerId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_ID");

                entity.Property(e => e.AuthCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_NAME");

                entity.Property(e => e.AuthDateLtxnMatch)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_DATE_LTXN_MATCH");

                entity.Property(e => e.AuthDbdSubvenPerc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DBD_SUBVEN_PERC");

                entity.Property(e => e.AuthDeliveryPinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DELIVERY_PIN_CODE");

                entity.Property(e => e.AuthDfsAcquringChannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_ACQURING_CHANNEL");

                entity.Property(e => e.AuthDfsEFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_E_FLAG");

                entity.Property(e => e.AuthDfsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_FLAG");

                entity.Property(e => e.AuthDfsPremiumAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_PREMIUM_AMOUNT");

                entity.Property(e => e.AuthDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthDocumentRequiredFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOCUMENT_REQUIRED_FLG");

                entity.Property(e => e.AuthDowNumberPayment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOW_NUMBER_PAYMENT");

                entity.Property(e => e.AuthEcsAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_ACCOUNT_NUMBER");

                entity.Property(e => e.AuthEcsAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthEcsBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_BANK_NAME");

                entity.Property(e => e.AuthEcsMandateRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_MANDATE_REQUIRED");

                entity.Property(e => e.AuthEcslmtamt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECSLMTAMT");

                entity.Property(e => e.AuthEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EMI_AMT");

                entity.Property(e => e.AuthExceptionMsg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXCEPTION_MSG");

                entity.Property(e => e.AuthExtraPricingLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXTRA_PRICING_LIMIT");

                entity.Property(e => e.AuthFailedRuleId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FAILED_RULE_ID");

                entity.Property(e => e.AuthField63Tag96)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIELD_63_TAG_96");

                entity.Property(e => e.AuthFinancingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FINANCING_TYPE_CODE");

                entity.Property(e => e.AuthFirstDueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FIRST_DUE_DATE");

                entity.Property(e => e.AuthFirstSwipeFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_SWIPE_FLAG");

                entity.Property(e => e.AuthFirstTranscatioNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_TRANSCATIO_NO");

                entity.Property(e => e.AuthFosMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FOS_MOBILE");

                entity.Property(e => e.AuthFraudFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_FLAG");

                entity.Property(e => e.AuthFraudTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FRAUD_TXN_DATE");

                entity.Property(e => e.AuthFraudTxnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_TXN_FLAG");

                entity.Property(e => e.AuthIdentifier)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IDENTIFIER");

                entity.Property(e => e.AuthImei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IMEI");

                entity.Property(e => e.AuthInterestRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_INTEREST_RATE");

                entity.Property(e => e.AuthIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IP_ADDRESS");

                entity.Property(e => e.AuthLastUpdDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LAST_UPD_DATE");

                entity.Property(e => e.AuthLoanToValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LOAN_TO_VALUE");

                entity.Property(e => e.AuthManufacturerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MANUFACTURER_ID");

                entity.Property(e => e.AuthMatchFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MATCH_FLAG");

                entity.Property(e => e.AuthMbd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MBD");

                entity.Property(e => e.AuthMeDealerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ME_DEALER_ID");

                entity.Property(e => e.AuthMerchantBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_BRANCH_ID");

                entity.Property(e => e.AuthMerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_NAME");

                entity.Property(e => e.AuthMicrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MICR_CODE");

                entity.Property(e => e.AuthMid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MID");

                entity.Property(e => e.AuthMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE");

                entity.Property(e => e.AuthMobileChangedFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_CHANGED_FLAG");

                entity.Property(e => e.AuthMobileTransaction)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_TRANSACTION");

                entity.Property(e => e.AuthModelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_ID");

                entity.Property(e => e.AuthModelMake)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_MAKE");

                entity.Property(e => e.AuthNoOfAddonCards)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AuthNoOfAdvEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NO_OF_ADV_EMI");

                entity.Property(e => e.AuthNonDigitalTxnEligibility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NON_DIGITAL_TXN_ELIGIBILITY");

                entity.Property(e => e.AuthOldCibilDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_DATE");

                entity.Property(e => e.AuthOldCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_SCORE");

                entity.Property(e => e.AuthOldCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_TIME");

                entity.Property(e => e.AuthOrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORDER_NO");

                entity.Property(e => e.AuthOrgTxnAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORG_TXN_AMT");

                entity.Property(e => e.AuthOriginalRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORIGINAL_RRNUMBER");

                entity.Property(e => e.AuthOtpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_ID");

                entity.Property(e => e.AuthOtpRequestId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_REQUEST_ID");

                entity.Property(e => e.AuthOtpVerificReslt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_VERIFIC_RESLT");

                entity.Property(e => e.AuthOtpgentime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_OTPGENTIME");

                entity.Property(e => e.AuthParentRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARENT_RRNUMBER");

                entity.Property(e => e.AuthPartialCnclChrgs)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_CHRGS");

                entity.Property(e => e.AuthPartialCnclFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_FLAG");

                entity.Property(e => e.AuthPartialCnclId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_ID");

                entity.Property(e => e.AuthPartialDbdRefund)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_DBD_REFUND");

                entity.Property(e => e.AuthPartnerEdcChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTNER_EDC_CHANNEL");

                entity.Property(e => e.AuthPartnerapiRequestdate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_PARTNERAPI_REQUESTDATE");

                entity.Property(e => e.AuthPinumberEntered)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PINUMBER_ENTERED");

                entity.Property(e => e.AuthPosEntryMode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_ENTRY_MODE");

                entity.Property(e => e.AuthPosReinventAuthcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_AUTHCODE");

                entity.Property(e => e.AuthPosReinventInvoiceAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_INVOICE_AMT");

                entity.Property(e => e.AuthPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.AuthProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESS_CODE");

                entity.Property(e => e.AuthProcessingFee)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESSING_FEE");

                entity.Property(e => e.AuthProdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROD_DESC");

                entity.Property(e => e.AuthProductCodeType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_CODE_TYPE");

                entity.Property(e => e.AuthProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_ID");

                entity.Property(e => e.AuthPromoCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROMO_CODE");

                entity.Property(e => e.AuthRelationshipType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RELATIONSHIP_TYPE");

                entity.Property(e => e.AuthReqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQ_DATE");

                entity.Property(e => e.AuthReqdatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQDATETIME");

                entity.Property(e => e.AuthRequestid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_REQUESTID");

                entity.Property(e => e.AuthResidenceCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESIDENCE_CITY");

                entity.Property(e => e.AuthResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_CODE");

                entity.Property(e => e.AuthResponseDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_DESC");

                entity.Property(e => e.AuthRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RRNUMBER");

                entity.Property(e => e.AuthSchemeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SCHEME_CODE");

                entity.Property(e => e.AuthSdkSegment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SDK_SEGMENT");

                entity.Property(e => e.AuthSdkSegmentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SDK_SEGMENT_DATE");

                entity.Property(e => e.AuthSettledFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SETTLED_FLAG");

                entity.Property(e => e.AuthSettledFlagDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_SETTLED_FLAG_DATE");

                entity.Property(e => e.AuthSfdcorg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SFDCORG")
                    .IsFixedLength(true);

                entity.Property(e => e.AuthSourceReverse)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SOURCE_REVERSE");

                entity.Property(e => e.AuthStoreId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_STORE_ID");

                entity.Property(e => e.AuthTenor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TENOR");

                entity.Property(e => e.AuthTid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TID");

                entity.Property(e => e.AuthTliUtilizedFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TLI_UTILIZED_FLG");

                entity.Property(e => e.AuthTraceAuditNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRACE_AUDIT_NUMBER");

                entity.Property(e => e.AuthTransactionBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRANSACTION_BRANCH_ID");

                entity.Property(e => e.AuthTxnMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_MOBILE_NO");

                entity.Property(e => e.AuthTxnSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_SOURCE");

                entity.Property(e => e.AuthUniqueCancellationId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_UNIQUE_CANCELLATION_ID");

                entity.Property(e => e.AuthUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_USER_NAME");

                entity.Property(e => e.AuthVasAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_VAS_AMT");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_ADDRESS");

                entity.Property(e => e.SeqId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_ID");
            });

            modelBuilder.Entity<FinsBulkdealerdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_BULKDEALERDETAILS");

                entity.HasIndex(e => e.DealerId, "FINS_BULKDEALERDETS_DEALERID");

                entity.Property(e => e.Actionflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONFLAG")
                    .IsFixedLength(true);

                entity.Property(e => e.Addedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.BulkId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BULK_ID")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"FINS_BULKDEALERDETAILS_SEQ\".\"NEXTVAL\" ");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.DealerDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_DESCRIPTION");

                entity.Property(e => e.DealerId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_ID");

                entity.Property(e => e.DealershortName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DEALERSHORT_NAME");

                entity.Property(e => e.Description)
                    .HasColumnType("CLOB")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Flag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FLAG");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.ProcessingFee)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROCESSING_FEE");

                entity.Property(e => e.Ranking)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RANKING");

                entity.Property(e => e.StatusFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_FLAG");

                entity.Property(e => e.Uploadid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UPLOADID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<FinsCardmaster>(entity =>
            {
                entity.HasKey(e => e.CrdNo)
                    .HasName("PK_CRD_NO");

                entity.ToTable("FINS_CARDMASTER");

                entity.HasIndex(e => e.CrdAccountId, "IDX_CARDACCOUNTNO");

                entity.HasIndex(e => e.CrdCustId, "IDX_CARDCUSTID");

                entity.HasIndex(e => e.CrdAddonmobile, "IDX_CRD_ADDONMOBILE");

                entity.HasIndex(e => e.CrdPrimaryAddOnInd, "IDX_CRD_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.CrdNo)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_NO");

                entity.Property(e => e.CrdAccountId)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ACCOUNT_ID");

                entity.Property(e => e.CrdActivationDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ACTIVATION_DT");

                entity.Property(e => e.CrdActivationMob)
                    .HasPrecision(3)
                    .HasColumnName("CRD_ACTIVATION_MOB");

                entity.Property(e => e.CrdAddonParentConsentFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDON_PARENT_CONSENT_FLAG");

                entity.Property(e => e.CrdAddondob)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONDOB");

                entity.Property(e => e.CrdAddondocsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONDOCS_FLAG");

                entity.Property(e => e.CrdAddonlastModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONLAST_MODIFY_DT");

                entity.Property(e => e.CrdAddonmobChangeDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONMOB_CHANGE_DT");

                entity.Property(e => e.CrdAddonmobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONMOBILE");

                entity.Property(e => e.CrdAddonoldMobilNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONOLD_MOBIL_NO");

                entity.Property(e => e.CrdAddonrelationshipPrim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONRELATIONSHIP_PRIM");

                entity.Property(e => e.CrdAddonresidenceEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONRESIDENCE_EMAIL");

                entity.Property(e => e.CrdBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CRD_BANK_CODE");

                entity.Property(e => e.CrdChargedRrn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_CHARGED_RRN");

                entity.Property(e => e.CrdCreaDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_CREA_DT");

                entity.Property(e => e.CrdCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_CUST_ID");

                entity.Property(e => e.CrdDealerCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_DEALER_CD");

                entity.Property(e => e.CrdDesign)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CRD_DESIGN");

                entity.Property(e => e.CrdEmiCharges)
                    .HasPrecision(12)
                    .HasColumnName("CRD_EMI_CHARGES");

                entity.Property(e => e.CrdExpDt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CRD_EXP_DT");

                entity.Property(e => e.CrdFundedNonfunded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_FUNDED_NONFUNDED");

                entity.Property(e => e.CrdGrpDealerCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_GRP_DEALER_CD");

                entity.Property(e => e.CrdGrpDealerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CRD_GRP_DEALER_NAME");

                entity.Property(e => e.CrdIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_IVR_UPD");

                entity.Property(e => e.CrdLastAuthDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_AUTH_DT");

                entity.Property(e => e.CrdLastModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT");

                entity.Property(e => e.CrdLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CrdLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CrdLatestStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_LATEST_STATUS");

                entity.Property(e => e.CrdManualBlockCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_BLOCK_CODE");

                entity.Property(e => e.CrdManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CrdNameOnCard)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("CRD_NAME_ON_CARD");

                entity.Property(e => e.CrdPin)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CRD_PIN");

                entity.Property(e => e.CrdPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.CrdReissueDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_REISSUE_DT");

                entity.Property(e => e.CrdReplNewCard)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_REPL_NEW_CARD");

                entity.Property(e => e.CrdReplOldCard)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_REPL_OLD_CARD");

                entity.Property(e => e.CrdSourceInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SOURCE_IND");

                entity.Property(e => e.CrdSrcType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SRC_TYPE");

                entity.Property(e => e.CrdSystemBlockCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CrdSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CrdSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CrdSystemUnblockReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_TYPE");

                entity.Property(e => e.CrdTypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_TYPE_IDENTIFIER");

                entity.Property(e => e.CrdUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CRD_USER_NAME");

                entity.Property(e => e.CrdWecareRefNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_WECARE_REF_NO");

                entity.Property(e => e.CrdWrngOtpAttmpt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_WRNG_OTP_ATTMPT");

                entity.Property(e => e.CrdWrngPinAttmpt)
                    .HasPrecision(3)
                    .HasColumnName("CRD_WRNG_PIN_ATTMPT");
            });

            modelBuilder.Entity<FinsClientmaster>(entity =>
            {
                entity.HasKey(e => e.CliCustId)
                    .HasName("PK_CLI_CUST_ID");

                entity.ToTable("FINS_CLIENTMASTER");

                entity.HasIndex(e => e.CliResMobile, "IDX_CUSTRESIMOBILE");

                entity.Property(e => e.CliCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CUST_ID");

                entity.Property(e => e.CliAnnualFeeDueDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ANNUAL_FEE_DUE_DT");

                entity.Property(e => e.CliBankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BANKCODE");

                entity.Property(e => e.CliBaseLoanFdd)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_BASE_LOAN_FDD");

                entity.Property(e => e.CliBaseLoanNumber)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BASE_LOAN_NUMBER");

                entity.Property(e => e.CliBlockClassModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.CliBlockClassification)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BLOCK_CLASSIFICATION");

                entity.Property(e => e.CliBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BRANCH_ID");

                entity.Property(e => e.CliBscore)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BSCORE");

                entity.Property(e => e.CliCcNccFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CC_NCC_FLAG");

                entity.Property(e => e.CliCibilScore)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CIBIL_SCORE");

                entity.Property(e => e.CliCibilScoreDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CIBIL_SCORE_DATE");

                entity.Property(e => e.CliCibilScoreSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CIBIL_SCORE_SOURCE");

                entity.Property(e => e.CliCibilv3Score)
                    .HasPrecision(6)
                    .HasColumnName("CLI_CIBILV3_SCORE");

                entity.Property(e => e.CliCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CREATION_DATE");

                entity.Property(e => e.CliCredcrdKycFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_KYC_FLAG");

                entity.Property(e => e.CliCredcrdOfrBflccid)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_OFR_BFLCCID");

                entity.Property(e => e.CliCredcrdOfrLim)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDCRD_OFR_LIM");

                entity.Property(e => e.CliCredcrdOfrType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_OFR_TYPE");

                entity.Property(e => e.CliCredcrdOtbl)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDCRD_OTBL");

                entity.Property(e => e.CliCredcrdPancopyExist)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_PANCOPY_EXIST");

                entity.Property(e => e.CliCredcrdSplOffer)
                    .HasPrecision(5)
                    .HasColumnName("CLI_CREDCRD_SPL_OFFER");

                entity.Property(e => e.CliCreditLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDIT_LIMIT");

                entity.Property(e => e.CliCreditRewardsPts)
                    .HasPrecision(10)
                    .HasColumnName("CLI_CREDIT_REWARDS_PTS");

                entity.Property(e => e.CliCtrChargedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CTR_CHARGED_DATE");

                entity.Property(e => e.CliDedupeDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DEDUPE_DATE");

                entity.Property(e => e.CliDedupeFromId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DEDUPE_FROM_ID");

                entity.Property(e => e.CliDedupeToId)
                    .HasColumnType("NUMBER(30)")
                    .HasColumnName("CLI_DEDUPE_TO_ID");

                entity.Property(e => e.CliDndEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DND_EMAIL");

                entity.Property(e => e.CliDndSms)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DND_SMS");

                entity.Property(e => e.CliDob)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DOB");

                entity.Property(e => e.CliDocsDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DOCS_DATE");

                entity.Property(e => e.CliDocsFlagRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DOCS_FLAG_RRN");

                entity.Property(e => e.CliDocsPendingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DOCS_PENDING_FLAG");

                entity.Property(e => e.CliEcsAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_ACCOUNT_NO");

                entity.Property(e => e.CliEcsAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_AUTH_BLOCKED");

                entity.Property(e => e.CliEcsAvailableLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.CliEcsBankBranchName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_BANK_BRANCH_NAME");

                entity.Property(e => e.CliEcsBankName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_BANK_NAME");

                entity.Property(e => e.CliEcsExpiryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ECS_EXPIRY_DATE");

                entity.Property(e => e.CliEcsIfscCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_IFSC_CODE");

                entity.Property(e => e.CliEcsLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_LIMIT");

                entity.Property(e => e.CliEcsLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_LOAN_BLOCKED");

                entity.Property(e => e.CliEcsMicrCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_MICR_CODE");

                entity.Property(e => e.CliEcsRegNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_REG_NO");

                entity.Property(e => e.CliEcsUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ECS_UPDATE_DATE");

                entity.Property(e => e.CliEcsUpdateMode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_UPDATE_MODE");

                entity.Property(e => e.CliEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_END_DATE");

                entity.Property(e => e.CliFirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_FIRST_NAME");

                entity.Property(e => e.CliFraudProneFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_FRAUD_PRONE_FLAG");

                entity.Property(e => e.CliGender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CLI_GENDER");

                entity.Property(e => e.CliImpsFirstHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_IMPS_FIRST_HOLDER_NAME");

                entity.Property(e => e.CliImpsSecondHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_IMPS_SECOND_HOLDER_NAME");

                entity.Property(e => e.CliInstaRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CLI_INSTA_RRN");

                entity.Property(e => e.CliIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_IVR_UPD");

                entity.Property(e => e.CliLastAuthDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_AUTH_DATE");

                entity.Property(e => e.CliLastLoanDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_LOAN_DATE");

                entity.Property(e => e.CliLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CliLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CliLastName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_LAST_NAME");

                entity.Property(e => e.CliMailingAddr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MAILING_ADDR");

                entity.Property(e => e.CliManualBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MANUAL_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.CliManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CliManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CliManualUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CliMiddleName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MIDDLE_NAME");

                entity.Property(e => e.CliMoratPaymentFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MORAT_PAYMENT_FLAG");

                entity.Property(e => e.CliNoOfActiveLoans)
                    .HasPrecision(5)
                    .HasColumnName("CLI_NO_OF_ACTIVE_LOANS");

                entity.Property(e => e.CliNoOfLinkedCust)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLI_NO_OF_LINKED_CUST");

                entity.Property(e => e.CliOfcAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR1");

                entity.Property(e => e.CliOfcAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR2");

                entity.Property(e => e.CliOfcAddr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR3");

                entity.Property(e => e.CliOfcAddrDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_ADDR_DATE");

                entity.Property(e => e.CliOfcArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_AREA");

                entity.Property(e => e.CliOfcCityId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_CITY_ID");

                entity.Property(e => e.CliOfcEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_EMAIL");

                entity.Property(e => e.CliOfcEmailDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_EMAIL_DATE");

                entity.Property(e => e.CliOfcLandmark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_LANDMARK");

                entity.Property(e => e.CliOfcMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_MOBILE");

                entity.Property(e => e.CliOfcMobileChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_MOBILE_CHG_DATE");

                entity.Property(e => e.CliOfcPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_PHONE");

                entity.Property(e => e.CliOfcPincode)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_PINCODE");

                entity.Property(e => e.CliOfcStateId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_STATE_ID");

                entity.Property(e => e.CliOfcStd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_STD");

                entity.Property(e => e.CliOldOfcMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OLD_OFC_MOBILE");

                entity.Property(e => e.CliOldResMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OLD_RES_MOBILE");

                entity.Property(e => e.CliPanNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_PAN_NO");

                entity.Property(e => e.CliPanStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_PAN_STATUS");

                entity.Property(e => e.CliReKycFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RE_KYC_FLAG");

                entity.Property(e => e.CliResAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR1");

                entity.Property(e => e.CliResAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR2");

                entity.Property(e => e.CliResAddr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR3");

                entity.Property(e => e.CliResAddrChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_ADDR_CHG_DATE");

                entity.Property(e => e.CliResArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_AREA");

                entity.Property(e => e.CliResCityId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_CITY_ID");

                entity.Property(e => e.CliResEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_EMAIL");

                entity.Property(e => e.CliResEmailDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_EMAIL_DATE");

                entity.Property(e => e.CliResLandmark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_LANDMARK");

                entity.Property(e => e.CliResMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_MOBILE");

                entity.Property(e => e.CliResMobileChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_MOBILE_CHG_DATE");

                entity.Property(e => e.CliResPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_PHONE");

                entity.Property(e => e.CliResPincode)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_PINCODE");

                entity.Property(e => e.CliResStateId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_STATE_ID");

                entity.Property(e => e.CliResStd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_STD");

                entity.Property(e => e.CliSdkSegment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SDK_SEGMENT");

                entity.Property(e => e.CliSdkSegmentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SDK_SEGMENT_DATE");

                entity.Property(e => e.CliSmtFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SMT_FLAG");

                entity.Property(e => e.CliStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_START_DATE");

                entity.Property(e => e.CliStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_STATUS");

                entity.Property(e => e.CliSystemBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CliSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CliSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CliSystemUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.CliTitle)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TITLE");

                entity.Property(e => e.CliTotalAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.CliTotalLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.CliTxnScore)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TXN_SCORE");

                entity.Property(e => e.CliType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TYPE");

                entity.Property(e => e.CliUid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_UID");

                entity.Property(e => e.CliVehicleRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_VEHICLE_REGISTRATION");

                entity.Property(e => e.CliVehicleType)
                    .HasPrecision(1)
                    .HasColumnName("CLI_VEHICLE_TYPE");
            });

            modelBuilder.Entity<FinsCreditprogrammapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_CREDITPROGRAMMAPPING");

                entity.Property(e => e.Addedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Carddesign)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CARDDESIGN");

                entity.Property(e => e.Creditprogram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREDITPROGRAM");

                entity.Property(e => e.Customertype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERTYPE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Processtype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPE");

                entity.Property(e => e.SrNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SR_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FinsDealermanfmapping>(entity =>
            {
                entity.HasKey(e => new { e.Supplierid, e.ManufacturerId })
                    .HasName("CMPPKFINSDEALERMANFMAPPING");

                entity.ToTable("FINS_DEALERMANFMAPPING");

                entity.Property(e => e.Supplierid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUPPLIERID");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MANUFACTURER_ID");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bankpk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANKPK");

                entity.Property(e => e.DlrMnfmapid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DLR_MNFMAPID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Processeddate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESSEDDATE");

                entity.Property(e => e.RecordStatusFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_STATUS_FLAG");

                entity.Property(e => e.Uploadid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsDealermappingmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_DEALERMAPPINGMASTER");

                entity.HasIndex(e => e.Supplierid, "IDX_SUPPLIERIDDMAPPING");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Code)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Delmapseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELMAPSEQ");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modefiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODEFIEDBY");

                entity.Property(e => e.Modefiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODEFIEDON");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_TYPE");

                entity.Property(e => e.Supplierid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUPPLIERID");

                entity.Property(e => e.Uploadid)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsDealermaster>(entity =>
            {
                entity.HasKey(e => e.Bflprofileid)
                    .HasName("FINS_DEALERMASTER_PK");

                entity.ToTable("FINS_DEALERMASTER");

                entity.HasIndex(e => e.Tid, "IDXDEALERPROFTID");

                entity.HasIndex(e => e.Zipcode, "IDX_DEALERZIP");

                entity.HasIndex(e => e.Mid, "INDEXDEALERPROFMID");

                entity.HasIndex(e => e.Supplierid, "SYS_C0048755")
                    .IsUnique();

                entity.Property(e => e.Bflprofileid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BFLPROFILEID");

                entity.Property(e => e.AcquringChannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACQURING_CHANNEL");

                entity.Property(e => e.AddedIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDED_IP");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Address1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS3");

                entity.Property(e => e.Address4)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS4");

                entity.Property(e => e.AssetCatgId)
                    .HasPrecision(8)
                    .HasColumnName("ASSET_CATG_ID");

                entity.Property(e => e.AssetModel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_MODEL");

                entity.Property(e => e.AssetSrNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSET_SR_NO");

                entity.Property(e => e.CashFunding)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CASH_FUNDING");

                entity.Property(e => e.ChkmakStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHKMAK_STATUS");

                entity.Property(e => e.City)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Classification)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION");

                entity.Property(e => e.CoBrandCardCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CO_BRAND_CARD_CODE");

                entity.Property(e => e.CoBrandLimitFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CO_BRAND_LIMIT_FLAG");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_PERSON");

                entity.Property(e => e.ConvFeeIdentifier)
                    .HasPrecision(3)
                    .HasColumnName("CONV_FEE_IDENTIFIER");

                entity.Property(e => e.DealerEmail)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_EMAIL");

                entity.Property(e => e.DealerGrpDesc)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_GRP_DESC");

                entity.Property(e => e.DealerGrpId)
                    .HasPrecision(8)
                    .HasColumnName("DEALER_GRP_ID");

                entity.Property(e => e.DealerSupergroup)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_SUPERGROUP");

                entity.Property(e => e.DealerUploadFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_UPLOAD_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DealerUploadRejections)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_UPLOAD_REJECTIONS");

                entity.Property(e => e.DiyAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DIY_AMOUNT");

                entity.Property(e => e.DiyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DIY_FLAG");

                entity.Property(e => e.DiyFlagDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DIY_FLAG_DATE");

                entity.Property(e => e.DummyLanno)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DUMMY_LANNO");

                entity.Property(e => e.ExistingBank)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EXISTING_BANK");

                entity.Property(e => e.ExistingMid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EXISTING_MID");

                entity.Property(e => e.ExistingTid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EXISTING_TID");

                entity.Property(e => e.FinancingType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FINANCING_TYPE");

                entity.Property(e => e.Financingtypecode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FINANCINGTYPECODE");

                entity.Property(e => e.Location)
                    .HasPrecision(10)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.LoyalityProgApplicable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOYALITY_PROG_APPLICABLE");

                entity.Property(e => e.MerchantCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_CATEGORY");

                entity.Property(e => e.Mid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.ModifedIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFED_IP");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.NoOfTerminal)
                    .HasPrecision(2)
                    .HasColumnName("NO_OF_TERMINAL");

                entity.Property(e => e.Pan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PAN");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("PHONE1");

                entity.Property(e => e.PreferredLimitFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREFERRED_LIMIT_FLAG");

                entity.Property(e => e.ProcessType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_TYPE");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_STATUS");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_TYPE");

                entity.Property(e => e.RejectionReason)
                    .IsUnicode(false)
                    .HasColumnName("REJECTION_REASON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemiFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMI_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RemiRejections)
                    .IsUnicode(false)
                    .HasColumnName("REMI_REJECTIONS");

                entity.Property(e => e.RewardRedemptionApplicable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REWARD_REDEMPTION_APPLICABLE");

                entity.Property(e => e.RewardRedemptionFee)
                    .HasColumnType("NUMBER(5,2)")
                    .HasColumnName("REWARD_REDEMPTION_FEE");

                entity.Property(e => e.RiskIndicator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RISK_INDICATOR");

                entity.Property(e => e.ServingCities)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVING_CITIES");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Stdisd)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STDISD");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STORE_ID");

                entity.Property(e => e.SupplierBranch)
                    .HasPrecision(10)
                    .HasColumnName("SUPPLIER_BRANCH");

                entity.Property(e => e.SupplierDealerFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUPPLIER_DEALER_FLAG");

                entity.Property(e => e.Supplierdesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUPPLIERDESC");

                entity.Property(e => e.Supplierid)
                    .HasPrecision(10)
                    .HasColumnName("SUPPLIERID");

                entity.Property(e => e.Suppliertype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SUPPLIERTYPE");

                entity.Property(e => e.Tid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TID");

                entity.Property(e => e.Typeofrequest)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPEOFREQUEST");

                entity.Property(e => e.Zipcode)
                    .HasPrecision(6)
                    .HasColumnName("ZIPCODE");
            });

            modelBuilder.Entity<FinsDealershortname>(entity =>
            {
                entity.HasKey(e => e.Dealercode)
                    .HasName("CONST_DEALERCODESHORT");

                entity.ToTable("FINS_DEALERSHORTNAME");

                entity.Property(e => e.Dealercode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEALERCODE");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Dealershortname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEALERSHORTNAME");

                entity.Property(e => e.Dshortseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DSHORTSEQ")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"SEQ_DSHORTSEQ\".\"NEXTVAL\"");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");
            });

            modelBuilder.Entity<FinsEcommOtp>(entity =>
            {
                entity.HasKey(e => e.Otpid)
                    .HasName("PRI_ECOMOTPID");

                entity.ToTable("FINS_ECOMM_OTP");

                entity.HasIndex(e => e.Cardnumber, "IDX_ECOMOTPCARD");

                entity.HasIndex(e => e.Dealerid, "IDX_ECOMOTPDEALERID");

                entity.HasIndex(e => e.Servicetype, "IDX_ECOMOTPSERVICETP");

                entity.HasIndex(e => e.OtpStatus, "IDX_ECOMOTPSTATUS");

                entity.HasIndex(e => e.Trantype, "IDX_ECOMOTPTRANTYPE");

                entity.Property(e => e.Otpid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OTPID");

                entity.Property(e => e.Adddatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDDATETIME");

                entity.Property(e => e.AttemptCounter)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTEMPT_COUNTER");

                entity.Property(e => e.Authcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTHCODE");

                entity.Property(e => e.CardStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CARD_STATUS");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Cardtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CARDTYPE");

                entity.Property(e => e.Dealerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEALERID");

                entity.Property(e => e.Finaldatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("FINALDATETIME");

                entity.Property(e => e.GenerateCounter)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GENERATE_COUNTER");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENO");

                entity.Property(e => e.Nooftransaction)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NOOFTRANSACTION");

                entity.Property(e => e.OtpReqdatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("OTP_REQDATETIME");

                entity.Property(e => e.OtpStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OTP_STATUS");

                entity.Property(e => e.Otprrn)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OTPRRN");

                entity.Property(e => e.Otpvalue)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("OTPVALUE");

                entity.Property(e => e.Responseid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSEID");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Trantype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANTYPE");

                entity.Property(e => e.Utilizecount)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UTILIZECOUNT");

                entity.Property(e => e.Utilizedatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("UTILIZEDATETIME");
            });

            modelBuilder.Entity<FinsEcsconfigday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_ECSCONFIGDAYS");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDDATE");

                entity.Property(e => e.Ecsconfigdays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ECSCONFIGDAYS");
            });

            modelBuilder.Entity<FinsEmiFeeLogicStip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_EMI_FEE_LOGIC_STIP");

                entity.Property(e => e.AuthChargeAmt2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_AMT2");

                entity.Property(e => e.AuthChargeAmt4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_AMT4");

                entity.Property(e => e.AuthChargeAmt5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_AMT5");

                entity.Property(e => e.AuthChargeId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2");

                entity.Property(e => e.AuthChargeId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4");

                entity.Property(e => e.AuthChargeId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5");

                entity.Property(e => e.ConvApplicable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONV_APPLICABLE");

                entity.Property(e => e.ConvFeeIdentifier)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONV_FEE_IDENTIFIER");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_TYPE");

                entity.Property(e => e.CtrApplicable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTR_APPLICABLE");

                entity.Property(e => e.MaximumAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MAXIMUM_AMOUNT");

                entity.Property(e => e.MinimumAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MINIMUM_AMOUNT");

                entity.Property(e => e.Seqid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQID");

                entity.Property(e => e.SmsText)
                    .IsUnicode(false)
                    .HasColumnName("SMS_TEXT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TxnType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TXN_TYPE");
            });

            modelBuilder.Entity<FinsGetdealerkey>(entity =>
            {
                entity.HasKey(e => e.Dealerid)
                    .HasName("FINS_GETDEALERKEY_PK");

                entity.ToTable("FINS_GETDEALERKEY");

                entity.HasIndex(e => e.Securitykey, "IDX_SECURITYKEY");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.Addedon)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Addedondate)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDONDATE");

                entity.Property(e => e.Addedontime)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDONTIME");

                entity.Property(e => e.Keyseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYSEQ");

                entity.Property(e => e.Keytype)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("KEYTYPE");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULENAME");

                entity.Property(e => e.Securitykey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SECURITYKEY");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FinsInactaccountmaster>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK_INACTACC_ID");

                entity.ToTable("FINS_INACTACCOUNTMASTER");

                entity.HasIndex(e => e.AccCustId, "IDX_INACTACCOUNTCUSTID");

                entity.Property(e => e.AccId)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("ACC_ID");

                entity.Property(e => e.AccAdjLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_ADJ_LIMIT");

                entity.Property(e => e.AccAdjLimitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_ADJ_LIMIT_DATE");

                entity.Property(e => e.AccBankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANKCODE");

                entity.Property(e => e.AccBestLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_BEST_LIMIT");

                entity.Property(e => e.AccBlockClassModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.AccBlockClassification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BLOCK_CLASSIFICATION");

                entity.Property(e => e.AccCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_CREATION_DATE");

                entity.Property(e => e.AccCreditLimUpdSrc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACC_CREDIT_LIM_UPD_SRC");

                entity.Property(e => e.AccCreditLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_CREDIT_LIMIT");

                entity.Property(e => e.AccCreditLimtChgDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_CREDIT_LIMT_CHG_DT");

                entity.Property(e => e.AccCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("ACC_CUST_ID");

                entity.Property(e => e.AccEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_END_DATE");

                entity.Property(e => e.AccFirstTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_FIRST_TXN_DATE");

                entity.Property(e => e.AccFirstTxnLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_FIRST_TXN_LIMIT");

                entity.Property(e => e.AccFirstTxnRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ACC_FIRST_TXN_RRN");

                entity.Property(e => e.AccIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_IVR_UPD");

                entity.Property(e => e.AccLastAuthDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_AUTH_DATE");

                entity.Property(e => e.AccLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.AccLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_LAST_MODIFY_DT_WL");

                entity.Property(e => e.AccManualBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACC_MANUAL_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.AccManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_MANUAL_BLOCK_DATE");

                entity.Property(e => e.AccManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.AccManualUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACC_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.AccNameChmpChllg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACC_NAME_CHMP_CHLLG");

                entity.Property(e => e.AccNoOfAddonCards)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AccOldestActPriCard)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ACC_OLDEST_ACT_PRI_CARD");

                entity.Property(e => e.AccProcDevEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_PROC_DEV_END_DATE");

                entity.Property(e => e.AccProcDevFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACC_PROC_DEV_FLAG");

                entity.Property(e => e.AccStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_START_DATE");

                entity.Property(e => e.AccSystemBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACC_SYSTEM_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.AccSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.AccSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.AccSystemUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACC_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.AccTempLimit)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TEMP_LIMIT");

                entity.Property(e => e.AccTempLimitEndDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_TEMP_LIMIT_END_DT");

                entity.Property(e => e.AccTempLimitStartDt)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_TEMP_LIMIT_START_DT");

                entity.Property(e => e.AccTotalAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.AccTotalLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("ACC_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.AccTotalNoOfCards)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TOTAL_NO_OF_CARDS");

                entity.Property(e => e.AccType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TYPE");

                entity.Property(e => e.AccVipNonvipFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACC_VIP_NONVIP_FLAG");
            });

            modelBuilder.Entity<FinsInactcardmaster>(entity =>
            {
                entity.HasKey(e => e.CrdNo)
                    .HasName("PK_INACTCRD_NO");

                entity.ToTable("FINS_INACTCARDMASTER");

                entity.HasIndex(e => e.CrdAccountId, "IDX_INACTCARDACCOUNTNO");

                entity.HasIndex(e => e.CrdCustId, "IDX_INACTCARDCUSTID");

                entity.Property(e => e.CrdNo)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_NO");

                entity.Property(e => e.CrdAccountId)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ACCOUNT_ID");

                entity.Property(e => e.CrdActivationDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ACTIVATION_DT");

                entity.Property(e => e.CrdActivationMob)
                    .HasPrecision(3)
                    .HasColumnName("CRD_ACTIVATION_MOB");

                entity.Property(e => e.CrdAddonParentConsentFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDON_PARENT_CONSENT_FLAG");

                entity.Property(e => e.CrdAddondob)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONDOB");

                entity.Property(e => e.CrdAddondocsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONDOCS_FLAG");

                entity.Property(e => e.CrdAddonlastModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONLAST_MODIFY_DT");

                entity.Property(e => e.CrdAddonmobChangeDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_ADDONMOB_CHANGE_DT");

                entity.Property(e => e.CrdAddonmobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONMOBILE");

                entity.Property(e => e.CrdAddonoldMobilNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONOLD_MOBIL_NO");

                entity.Property(e => e.CrdAddonrelationshipPrim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONRELATIONSHIP_PRIM");

                entity.Property(e => e.CrdAddonresidenceEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_ADDONRESIDENCE_EMAIL");

                entity.Property(e => e.CrdBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CRD_BANK_CODE");

                entity.Property(e => e.CrdChargedRrn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_CHARGED_RRN");

                entity.Property(e => e.CrdCreaDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_CREA_DT");

                entity.Property(e => e.CrdCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_CUST_ID");

                entity.Property(e => e.CrdDealerCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_DEALER_CD");

                entity.Property(e => e.CrdDesign)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CRD_DESIGN");

                entity.Property(e => e.CrdEmiCharges)
                    .HasPrecision(12)
                    .HasColumnName("CRD_EMI_CHARGES");

                entity.Property(e => e.CrdExpDt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CRD_EXP_DT");

                entity.Property(e => e.CrdFundedNonfunded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRD_FUNDED_NONFUNDED");

                entity.Property(e => e.CrdGrpDealerCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_GRP_DEALER_CD");

                entity.Property(e => e.CrdGrpDealerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CRD_GRP_DEALER_NAME");

                entity.Property(e => e.CrdIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_IVR_UPD");

                entity.Property(e => e.CrdLastAuthDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_AUTH_DT");

                entity.Property(e => e.CrdLastModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT");

                entity.Property(e => e.CrdLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CrdLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CrdLatestStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_LATEST_STATUS");

                entity.Property(e => e.CrdManualBlockCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_BLOCK_CODE");

                entity.Property(e => e.CrdManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CrdNameOnCard)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("CRD_NAME_ON_CARD");

                entity.Property(e => e.CrdPin)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CRD_PIN");

                entity.Property(e => e.CrdPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.CrdReissueDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_REISSUE_DT");

                entity.Property(e => e.CrdReplNewCard)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_REPL_NEW_CARD");

                entity.Property(e => e.CrdReplOldCard)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CRD_REPL_OLD_CARD");

                entity.Property(e => e.CrdSourceInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SOURCE_IND");

                entity.Property(e => e.CrdSrcType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SRC_TYPE");

                entity.Property(e => e.CrdSystemBlockCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CrdSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CrdSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CRD_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CrdSystemUnblockReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_TYPE");

                entity.Property(e => e.CrdTypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD_TYPE_IDENTIFIER");

                entity.Property(e => e.CrdUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CRD_USER_NAME");

                entity.Property(e => e.CrdWecareRefNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CRD_WECARE_REF_NO");

                entity.Property(e => e.CrdWrngOtpAttmpt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRD_WRNG_OTP_ATTMPT");

                entity.Property(e => e.CrdWrngPinAttmpt)
                    .HasPrecision(3)
                    .HasColumnName("CRD_WRNG_PIN_ATTMPT");
            });

            modelBuilder.Entity<FinsInactclientmaster>(entity =>
            {
                entity.HasKey(e => e.CliCustId)
                    .HasName("PK_INACTCLI_CUST_ID");

                entity.ToTable("FINS_INACTCLIENTMASTER");

                entity.HasIndex(e => e.CliResMobile, "IDX_INACTCUSTRESIMOBILE");

                entity.Property(e => e.CliCustId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CUST_ID");

                entity.Property(e => e.CcliCredcrdSplOffer)
                    .HasPrecision(5)
                    .HasColumnName("CCLI_CREDCRD_SPL_OFFER");

                entity.Property(e => e.CliAnnualFeeDueDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ANNUAL_FEE_DUE_DT");

                entity.Property(e => e.CliBankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BANKCODE");

                entity.Property(e => e.CliBaseLoanFdd)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_BASE_LOAN_FDD");

                entity.Property(e => e.CliBaseLoanNumber)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BASE_LOAN_NUMBER");

                entity.Property(e => e.CliBlockClassModifyDt)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.CliBlockClassification)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BLOCK_CLASSIFICATION");

                entity.Property(e => e.CliBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BRANCH_ID");

                entity.Property(e => e.CliBscore)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_BSCORE");

                entity.Property(e => e.CliCcNccFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CC_NCC_FLAG");

                entity.Property(e => e.CliCibilScore)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CIBIL_SCORE");

                entity.Property(e => e.CliCibilScoreDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CIBIL_SCORE_DATE");

                entity.Property(e => e.CliCibilScoreSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CIBIL_SCORE_SOURCE");

                entity.Property(e => e.CliCibilv3Score)
                    .HasPrecision(6)
                    .HasColumnName("CLI_CIBILV3_SCORE");

                entity.Property(e => e.CliCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CREATION_DATE");

                entity.Property(e => e.CliCredcrdKycFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_KYC_FLAG");

                entity.Property(e => e.CliCredcrdOfrBflccid)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_OFR_BFLCCID");

                entity.Property(e => e.CliCredcrdOfrLim)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDCRD_OFR_LIM");

                entity.Property(e => e.CliCredcrdOfrType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_OFR_TYPE");

                entity.Property(e => e.CliCredcrdOtbl)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDCRD_OTBL");

                entity.Property(e => e.CliCredcrdPancopyExist)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_CREDCRD_PANCOPY_EXIST");

                entity.Property(e => e.CliCreditLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_CREDIT_LIMIT");

                entity.Property(e => e.CliCreditRewardsPts)
                    .HasPrecision(10)
                    .HasColumnName("CLI_CREDIT_REWARDS_PTS");

                entity.Property(e => e.CliCtrChargedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_CTR_CHARGED_DATE");

                entity.Property(e => e.CliDedupeDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DEDUPE_DATE");

                entity.Property(e => e.CliDedupeFromId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DEDUPE_FROM_ID");

                entity.Property(e => e.CliDedupeToId)
                    .HasColumnType("NUMBER(30)")
                    .HasColumnName("CLI_DEDUPE_TO_ID");

                entity.Property(e => e.CliDndEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DND_EMAIL");

                entity.Property(e => e.CliDndSms)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DND_SMS");

                entity.Property(e => e.CliDob)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DOB");

                entity.Property(e => e.CliDocsDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_DOCS_DATE");

                entity.Property(e => e.CliDocsFlagRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DOCS_FLAG_RRN");

                entity.Property(e => e.CliDocsPendingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DOCS_PENDING_FLAG");

                entity.Property(e => e.CliEcsAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_ACCOUNT_NO");

                entity.Property(e => e.CliEcsAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_AUTH_BLOCKED");

                entity.Property(e => e.CliEcsAvailableLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.CliEcsBankBranchName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_BANK_BRANCH_NAME");

                entity.Property(e => e.CliEcsBankName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_BANK_NAME");

                entity.Property(e => e.CliEcsExpiryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ECS_EXPIRY_DATE");

                entity.Property(e => e.CliEcsIfscCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_IFSC_CODE");

                entity.Property(e => e.CliEcsLimit)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_LIMIT");

                entity.Property(e => e.CliEcsLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_ECS_LOAN_BLOCKED");

                entity.Property(e => e.CliEcsMicrCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_MICR_CODE");

                entity.Property(e => e.CliEcsRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_REG_NO");

                entity.Property(e => e.CliEcsUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_ECS_UPDATE_DATE");

                entity.Property(e => e.CliEcsUpdateMode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_UPDATE_MODE");

                entity.Property(e => e.CliEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_END_DATE");

                entity.Property(e => e.CliFirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_FIRST_NAME");

                entity.Property(e => e.CliFraudProneFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_FRAUD_PRONE_FLAG");

                entity.Property(e => e.CliGender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CLI_GENDER");

                entity.Property(e => e.CliImpsFirstHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_IMPS_FIRST_HOLDER_NAME");

                entity.Property(e => e.CliImpsSecondHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_IMPS_SECOND_HOLDER_NAME");

                entity.Property(e => e.CliInstaRrn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CLI_INSTA_RRN");

                entity.Property(e => e.CliIvrUpd)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_IVR_UPD");

                entity.Property(e => e.CliLastAuthDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_AUTH_DATE");

                entity.Property(e => e.CliLastLoanDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_LOAN_DATE");

                entity.Property(e => e.CliLastModifyDtBfl)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CliLastModifyDtWl)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CliLastName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_LAST_NAME");

                entity.Property(e => e.CliMailingAddr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MAILING_ADDR");

                entity.Property(e => e.CliManualBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MANUAL_BLOCK_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.CliManualBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CliManualUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CliManualUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CliMiddleName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MIDDLE_NAME");

                entity.Property(e => e.CliMoratPaymentFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MORAT_PAYMENT_FLAG");

                entity.Property(e => e.CliNoOfActiveLoans)
                    .HasPrecision(5)
                    .HasColumnName("CLI_NO_OF_ACTIVE_LOANS");

                entity.Property(e => e.CliNoOfLinkedCust)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLI_NO_OF_LINKED_CUST");

                entity.Property(e => e.CliOfcAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR1");

                entity.Property(e => e.CliOfcAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR2");

                entity.Property(e => e.CliOfcAddr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_ADDR3");

                entity.Property(e => e.CliOfcAddrDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_ADDR_DATE");

                entity.Property(e => e.CliOfcArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_AREA");

                entity.Property(e => e.CliOfcCityId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_CITY_ID");

                entity.Property(e => e.CliOfcEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_EMAIL");

                entity.Property(e => e.CliOfcEmailDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_EMAIL_DATE");

                entity.Property(e => e.CliOfcLandmark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_LANDMARK");

                entity.Property(e => e.CliOfcMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_MOBILE");

                entity.Property(e => e.CliOfcMobileChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_OFC_MOBILE_CHG_DATE");

                entity.Property(e => e.CliOfcPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_PHONE");

                entity.Property(e => e.CliOfcPincode)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_PINCODE");

                entity.Property(e => e.CliOfcStateId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_OFC_STATE_ID");

                entity.Property(e => e.CliOfcStd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OFC_STD");

                entity.Property(e => e.CliOldOfcMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OLD_OFC_MOBILE");

                entity.Property(e => e.CliOldResMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_OLD_RES_MOBILE");

                entity.Property(e => e.CliPanNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_PAN_NO");

                entity.Property(e => e.CliPanStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_PAN_STATUS");

                entity.Property(e => e.CliReKycFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RE_KYC_FLAG");

                entity.Property(e => e.CliResAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR1");

                entity.Property(e => e.CliResAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR2");

                entity.Property(e => e.CliResAddr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_ADDR3");

                entity.Property(e => e.CliResAddrChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_ADDR_CHG_DATE");

                entity.Property(e => e.CliResArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_AREA");

                entity.Property(e => e.CliResCityId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_CITY_ID");

                entity.Property(e => e.CliResEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_EMAIL");

                entity.Property(e => e.CliResEmailDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_EMAIL_DATE");

                entity.Property(e => e.CliResLandmark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_LANDMARK");

                entity.Property(e => e.CliResMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_MOBILE");

                entity.Property(e => e.CliResMobileChgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_RES_MOBILE_CHG_DATE");

                entity.Property(e => e.CliResPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_PHONE");

                entity.Property(e => e.CliResPincode)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_PINCODE");

                entity.Property(e => e.CliResStateId)
                    .HasPrecision(8)
                    .HasColumnName("CLI_RES_STATE_ID");

                entity.Property(e => e.CliResStd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_RES_STD");

                entity.Property(e => e.CliSdkSegment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SDK_SEGMENT");

                entity.Property(e => e.CliSdkSegmentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SDK_SEGMENT_DATE");

                entity.Property(e => e.CliSmtFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SMT_FLAG");

                entity.Property(e => e.CliStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_START_DATE");

                entity.Property(e => e.CliStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CLI_STATUS");

                entity.Property(e => e.CliSystemBlockCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CliSystemBlockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CliSystemUnblockDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLI_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CliSystemUnblockReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.CliTitle)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TITLE");

                entity.Property(e => e.CliTotalAuthBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.CliTotalLoanBlocked)
                    .HasPrecision(12)
                    .HasColumnName("CLI_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.CliTxnScore)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TXN_SCORE");

                entity.Property(e => e.CliType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_TYPE");

                entity.Property(e => e.CliUid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_UID");

                entity.Property(e => e.CliVehicleRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLI_VEHICLE_REGISTRATION");

                entity.Property(e => e.CliVehicleType)
                    .HasPrecision(1)
                    .HasColumnName("CLI_VEHICLE_TYPE");
            });

            modelBuilder.Entity<FinsLrpdebug>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_LRPDEBUG");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Line)
                    .HasColumnType("CLOB")
                    .HasColumnName("LINE");
            });

            modelBuilder.Entity<FinsManufacturermaster>(entity =>
            {
                entity.HasKey(e => new { e.ManufactureId, e.ManufactureDesc })
                    .HasName("SYS_C0011349");

                entity.ToTable("FINS_MANUFACTURERMASTER");

                entity.Property(e => e.ManufactureId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MANUFACTURE_ID");

                entity.Property(e => e.ManufactureDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURE_DESC");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Mmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MMID");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.UploadId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOAD_ID");
            });

            modelBuilder.Entity<FinsModelmaster>(entity =>
            {
                entity.HasKey(e => e.Modelid)
                    .HasName("FINS_MDLMMASTER_PK");

                entity.ToTable("FINS_MODELMASTER");

                entity.HasIndex(e => e.Manufacturerid, "IDX_MANUFACTURERIDMM");

                entity.Property(e => e.Modelid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODELID");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDED_DATE");

                entity.Property(e => e.Categoryid)
                    .HasPrecision(8)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Make)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("MAKE");

                entity.Property(e => e.Manufacturerid)
                    .HasPrecision(8)
                    .HasColumnName("MANUFACTURERID");

                entity.Property(e => e.ModelExpiryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MODEL_EXPIRY_DATE");

                entity.Property(e => e.ModelMinPrice)
                    .HasColumnType("NUMBER(18,4)")
                    .HasColumnName("MODEL_MIN_PRICE");

                entity.Property(e => e.ModelSeq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODEL_SEQ");

                entity.Property(e => e.Modelno)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MODELNO");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_CODE");

                entity.Property(e => e.SellingPrice)
                    .HasColumnType("NUMBER(18,4)")
                    .HasColumnName("SELLING_PRICE");

                entity.Property(e => e.SerialNoValidFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NO_VALID_FLAG");

                entity.Property(e => e.SfdcModelCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SFDC_MODEL_CODE");

                entity.Property(e => e.SfdcModelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFDC_MODEL_ID");

                entity.Property(e => e.SizeId)
                    .HasPrecision(8)
                    .HasColumnName("SIZE_ID");

                entity.Property(e => e.Uploadid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsModelproductmapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_MODELPRODUCTMAPPING");

                entity.HasIndex(e => new { e.Modelid, e.Product }, "IDX1_FINS_MODELPRODUCTMAPPING");

                entity.HasIndex(e => e.Product, "IDX_PRODUCTMAST");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modefiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODEFIEDBY");

                entity.Property(e => e.Modefiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODEFIEDON");

                entity.Property(e => e.Modelid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODELID");

                entity.Property(e => e.Modelprodseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODELPRODSEQ");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Uploadid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsProductlevelparammaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_PRODUCTLEVELPARAMMASTER");

                entity.Property(e => e.Accounttypeid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTTYPEID");

                entity.Property(e => e.Addedby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDON");

                entity.Property(e => e.BaseDueDateCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BASE_DUE_DATE_CHECK");

                entity.Property(e => e.Ctrallowed)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CTRALLOWED");

                entity.Property(e => e.Dueday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUEDAY");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifyon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFYON");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.ProductLevelId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_LEVEL_ID")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"PRODUCTPARAMATERID\".\"NEXTVAL\"");

                entity.Property(e => e.Refundday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REFUNDDAY");

                entity.Property(e => e.Ruralproduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RURALPRODUCT");

                entity.Property(e => e.Settelment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SETTELMENT");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FinsProfilekeyconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_PROFILEKEYCONFIG");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Keyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYID");

                entity.Property(e => e.Keylength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYLENGTH");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Modulecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODULECODE");

                entity.Property(e => e.ProfileId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_ID");

                entity.Property(e => e.Profilekey)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PROFILEKEY");

                entity.Property(e => e.Thirdparty)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("THIRDPARTY");
            });

            modelBuilder.Entity<FinsProfilemaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_PROFILEMASTER");

                entity.Property(e => e.AccBestLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BEST_LIMIT");

                entity.Property(e => e.AccBlockClassModifyDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.AccBlockClassification)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BLOCK_CLASSIFICATION");

                entity.Property(e => e.AccEndDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_END_DATE");

                entity.Property(e => e.AccLastModifyDtBfl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.AccLastModifyDtWl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_LAST_MODIFY_DT_WL");

                entity.Property(e => e.AccNoOfAddonCards)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AccStartDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_START_DATE");

                entity.Property(e => e.AccTotalNoOfCards)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TOTAL_NO_OF_CARDS");

                entity.Property(e => e.AccountAdjLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ADJ_LIMIT");

                entity.Property(e => e.AccountAdjLimitAdjDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ADJ_LIMIT_ADJ_DATE");

                entity.Property(e => e.AccountCreationDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_CREATION_DATE");

                entity.Property(e => e.AccountCreditLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_CREDIT_LIMIT");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AccountLastAuthDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_LAST_AUTH_DATE");

                entity.Property(e => e.AccountManualBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_MANUAL_BLOCK_CODE");

                entity.Property(e => e.AccountManualBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_MANUAL_BLOCK_DATE");

                entity.Property(e => e.AccountManualUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.AccountManualUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.AccountSystemBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.AccountSystemBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.AccountSystemUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.AccountSystemUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.AccountTempLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TEMP_LIMIT");

                entity.Property(e => e.AccountTempLimitEndDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TEMP_LIMIT_END_DT");

                entity.Property(e => e.AccountTempLimitStartDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TEMP_LIMIT_START_DT");

                entity.Property(e => e.AccountTotalAuthBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.AccountTotalLoanBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_TYPE");

                entity.Property(e => e.AccountVipNonvipFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_VIP_NONVIP_FLAG");

                entity.Property(e => e.ActivityMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_MODE");

                entity.Property(e => e.AnnualFeeDueDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ANNUAL_FEE_DUE_DT");

                entity.Property(e => e.Authcode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTHCODE");

                entity.Property(e => e.BaseLoanFdd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BASE_LOAN_FDD");

                entity.Property(e => e.BaseLoanNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BASE_LOAN_NUMBER");

                entity.Property(e => e.BlockClassModifyDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BLOCK_CLASS_MODIFY_DT");

                entity.Property(e => e.BlockClassification)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BLOCK_CLASSIFICATION");

                entity.Property(e => e.Bscore)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BSCORE");

                entity.Property(e => e.CardAccountId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ACCOUNT_ID");

                entity.Property(e => e.CardActivationDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ACTIVATION_DT");

                entity.Property(e => e.CardCardCreaDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CARD_CREA_DT");

                entity.Property(e => e.CardCardNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CARD_NO");

                entity.Property(e => e.CardCardType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CARD_TYPE");

                entity.Property(e => e.CardCustId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CUST_ID");

                entity.Property(e => e.CardDealerCd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_DEALER_CD");

                entity.Property(e => e.CardDesign)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_DESIGN");

                entity.Property(e => e.CardEmiCardCharges)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_EMI_CARD_CHARGES");

                entity.Property(e => e.CardExpDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_EXP_DT");

                entity.Property(e => e.CardGrpDealerCd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_GRP_DEALER_CD");

                entity.Property(e => e.CardGrpDealerName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_GRP_DEALER_NAME");

                entity.Property(e => e.CardLastAuthDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_LAST_AUTH_DT");

                entity.Property(e => e.CardLastModifyDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_LAST_MODIFY_DT");

                entity.Property(e => e.CardLatestCardStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_LATEST_CARD_STATUS");

                entity.Property(e => e.CardNameOnCard)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_NAME_ON_CARD");

                entity.Property(e => e.CardPin)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_PIN");

                entity.Property(e => e.CardPrimaryAddOnInd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.CardReissueDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_REISSUE_DT");

                entity.Property(e => e.CardReplNewCard)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_REPL_NEW_CARD");

                entity.Property(e => e.CardReplOldCard)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_REPL_OLD_CARD");

                entity.Property(e => e.CardSourceInd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_SOURCE_IND");

                entity.Property(e => e.CardSrcType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_SRC_TYPE");

                entity.Property(e => e.CardSystemBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CardSystemBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CardSystemUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.CardTypeIdentifier)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE_IDENTIFIER");

                entity.Property(e => e.CardUserName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_USER_NAME");

                entity.Property(e => e.CardWecareRefNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_WECARE_REF_NO");

                entity.Property(e => e.CardWrngPinAttmpt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARD_WRNG_PIN_ATTMPT");

                entity.Property(e => e.CibilScoreSource)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CIBIL_SCORE_SOURCE");

                entity.Property(e => e.CliDocsFlagRrn)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_DOCS_FLAG_RRN");

                entity.Property(e => e.CliEcsUpdateMode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_ECS_UPDATE_MODE");

                entity.Property(e => e.CliEndDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_END_DATE");

                entity.Property(e => e.CliFraudProneFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_FRAUD_PRONE_FLAG");

                entity.Property(e => e.CliInstaRrn)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_INSTA_RRN");

                entity.Property(e => e.CliLastModifyDtBfl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CliLastModifyDtWl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CliMoratPaymentFlag)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("CLI_MORAT_PAYMENT_FLAG");

                entity.Property(e => e.CliSdkSegment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SDK_SEGMENT");

                entity.Property(e => e.CliSmtFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_SMT_FLAG");

                entity.Property(e => e.CliStartDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_START_DATE");

                entity.Property(e => e.CrdChargedRrn)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_CHARGED_RRN");

                entity.Property(e => e.CrdFundedNonfunded)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_FUNDED_NONFUNDED");

                entity.Property(e => e.CrdLastModifyDtBfl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_LAST_MODIFY_DT_BFL");

                entity.Property(e => e.CrdLastModifyDtWl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_LAST_MODIFY_DT_WL");

                entity.Property(e => e.CrdManualBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_BLOCK_CODE");

                entity.Property(e => e.CrdManualBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CrdManualUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CrdSystemUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CrdWrngOtpAttmpt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CRD_WRNG_OTP_ATTMPT");

                entity.Property(e => e.CredcrdOfrBflccid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDCRD_OFR_BFLCCID");

                entity.Property(e => e.CredcrdOfrLim)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDCRD_OFR_LIM");

                entity.Property(e => e.CredcrdOfrType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDCRD_OFR_TYPE");

                entity.Property(e => e.CredcrdOtbl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDCRD_OTBL");

                entity.Property(e => e.CredcrdPancopyExist)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDCRD_PANCOPY_EXIST");

                entity.Property(e => e.CreditRewardsPts)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_REWARDS_PTS");

                entity.Property(e => e.CustomerBranchId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_BRANCH_ID");

                entity.Property(e => e.CustomerCibilScore)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CIBIL_SCORE");

                entity.Property(e => e.CustomerCibilScoreDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CIBIL_SCORE_DATE");

                entity.Property(e => e.CustomerCreationDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CREATION_DATE");

                entity.Property(e => e.CustomerCreditLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CREDIT_LIMIT");

                entity.Property(e => e.CustomerCtrChargedDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CTR_CHARGED_DATE");

                entity.Property(e => e.CustomerDndEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_DND_EMAIL");

                entity.Property(e => e.CustomerDndSms)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_DND_SMS");

                entity.Property(e => e.CustomerDocsDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_DOCS_DATE");

                entity.Property(e => e.CustomerDocsPendingFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_DOCS_PENDING_FLAG");

                entity.Property(e => e.CustomerEcsAccountNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_ACCOUNT_NO");

                entity.Property(e => e.CustomerEcsAuthBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_AUTH_BLOCKED");

                entity.Property(e => e.CustomerEcsAvailableLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.CustomerEcsBankBranchName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_BANK_BRANCH_NAME");

                entity.Property(e => e.CustomerEcsBankName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_BANK_NAME");

                entity.Property(e => e.CustomerEcsExpiryDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_EXPIRY_DATE");

                entity.Property(e => e.CustomerEcsIfscCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_IFSC_CODE");

                entity.Property(e => e.CustomerEcsLimit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_LIMIT");

                entity.Property(e => e.CustomerEcsLoanBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_LOAN_BLOCKED");

                entity.Property(e => e.CustomerEcsMicrCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ECS_MICR_CODE");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerManualBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_MANUAL_BLOCK_CODE");

                entity.Property(e => e.CustomerManualBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_MANUAL_BLOCK_DATE");

                entity.Property(e => e.CustomerManualUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_MANUAL_UNBLOCK_DATE");

                entity.Property(e => e.CustomerManualUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_MANUAL_UNBLOCK_REASON");

                entity.Property(e => e.CustomerStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_STATUS");

                entity.Property(e => e.CustomerSystemBlockCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_SYSTEM_BLOCK_CODE");

                entity.Property(e => e.CustomerSystemBlockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_SYSTEM_BLOCK_DATE");

                entity.Property(e => e.CustomerSystemBlockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_SYSTEM_BLOCK_REASON");

                entity.Property(e => e.CustomerSystemUnblockDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_SYSTEM_UNBLOCK_DATE");

                entity.Property(e => e.CustomerTotalAuthBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_TOTAL_AUTH_BLOCKED");

                entity.Property(e => e.CustomerTotalLoanBlocked)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_TOTAL_LOAN_BLOCKED");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_TYPE");

                entity.Property(e => e.CustomerVehicleRegistration)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_VEHICLE_REGISTRATION");

                entity.Property(e => e.CustomerVehicleType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_VEHICLE_TYPE");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.DedupeDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DEDUPE_DATE");

                entity.Property(e => e.DedupeFromCustomerId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DEDUPE_FROM_CUSTOMER_ID");

                entity.Property(e => e.DedupeToCustomerId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DEDUPE_TO_CUSTOMER_ID");

                entity.Property(e => e.DigitalColour)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DIGITAL_COLOUR");

                entity.Property(e => e.Dob)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.EcsRegNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ECS_REG_NO");

                entity.Property(e => e.EcsUpdateDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ECS_UPDATE_DATE");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.LaddonDob)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_DOB");

                entity.Property(e => e.LaddonDocsFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_DOCS_FLAG");

                entity.Property(e => e.LaddonLastModifyDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_LAST_MODIFY_DT");

                entity.Property(e => e.LaddonMobChangeDt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_MOB_CHANGE_DT");

                entity.Property(e => e.LaddonMobile)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_MOBILE");

                entity.Property(e => e.LaddonOldMobilNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_OLD_MOBIL_NO");

                entity.Property(e => e.LaddonRelationshipPrim)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_RELATIONSHIP_PRIM");

                entity.Property(e => e.LaddonResidenceEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LADDON_RESIDENCE_EMAIL");

                entity.Property(e => e.LastAuthDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LAST_AUTH_DATE");

                entity.Property(e => e.LastLoanDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LAST_LOAN_DATE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LbcliOldResidenceMobile)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LBCLI_OLD_RESIDENCE_MOBILE");

                entity.Property(e => e.LbcliOldestActPriCard)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LBCLI_OLDEST_ACT_PRI_CARD");

                entity.Property(e => e.LbcliResidenceEmailDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LBCLI_RESIDENCE_EMAIL_DATE");

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MAILING_ADDRESS");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NameOfChmpChllg)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NAME_OF_CHMP_CHLLG");

                entity.Property(e => e.NoOfLinkedCust)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NO_OF_LINKED_CUST");

                entity.Property(e => e.NonDigitalColour)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NON_DIGITAL_COLOUR");

                entity.Property(e => e.OldOfcMobile)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("OLD_OFC_MOBILE");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PAN_NO");

                entity.Property(e => e.ProcessDeviationEndDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_DEVIATION_END_DATE");

                entity.Property(e => e.ProcessDeviationFlag)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_DEVIATION_FLAG");

                entity.Property(e => e.ProfileId)
                    .HasPrecision(10)
                    .HasColumnName("PROFILE_ID");

                entity.Property(e => e.ProfileIdIdentifier)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_ID_IDENTIFIER");

                entity.Property(e => e.ProfileOwner)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_OWNER");

                entity.Property(e => e.Profilestatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILESTATUS");

                entity.Property(e => e.ResidenceAddress1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_ADDRESS1");

                entity.Property(e => e.ResidenceAddress2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_ADDRESS2");

                entity.Property(e => e.ResidenceAddress3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_ADDRESS3");

                entity.Property(e => e.ResidenceAddressChangeDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_ADDRESS_CHANGE_DATE");

                entity.Property(e => e.ResidenceArea)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_AREA");

                entity.Property(e => e.ResidenceCityId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_CITY_ID");

                entity.Property(e => e.ResidenceEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_EMAIL");

                entity.Property(e => e.ResidenceLandmark)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_LANDMARK");

                entity.Property(e => e.ResidenceMobile)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_MOBILE");

                entity.Property(e => e.ResidenceMobileChangeDate)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_MOBILE_CHANGE_DATE");

                entity.Property(e => e.ResidencePhone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_PHONE");

                entity.Property(e => e.ResidencePincode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_PINCODE");

                entity.Property(e => e.ResidenceStateId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_STATE_ID");

                entity.Property(e => e.ResidenceStd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCE_STD");

                entity.Property(e => e.SystemUnblockReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_UNBLOCK_REASON");

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.TxnScore)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TXN_SCORE");

                entity.Property(e => e.Txntype)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TXNTYPE");

                entity.Property(e => e.UidNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("UID_NO");

                entity.Property(e => e.UnblockBlockCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UNBLOCK_BLOCK_CODE");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USEREMAIL");

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<FinsRuralschememaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_RURALSCHEMEMASTER");

                entity.HasIndex(e => e.Schemeid, "IDX_RURALSCHEMEMASTER");

                entity.HasIndex(e => e.Ruralschemeid, "IDX_RURALSCHEMEMASTERRSID");

                entity.Property(e => e.Activestatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVESTATUS");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Createdid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Modifiedid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDID");

                entity.Property(e => e.Nschemeproduct)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NSCHEMEPRODUCT");

                entity.Property(e => e.Rschemeproduct)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RSCHEMEPRODUCT");

                entity.Property(e => e.Ruralschemeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RURALSCHEMEID");

                entity.Property(e => e.Schemeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMEID");

                entity.Property(e => e.Seqid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQID");
            });

            modelBuilder.Entity<FinsSchemedealermapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_SCHEMEDEALERMAPPING");

                entity.HasIndex(e => e.Supplierid, "IDX1_FINS_SCHEMEDEALERMAPPING");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bankpk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANKPK");

                entity.Property(e => e.DlrSchid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DLR_SCHID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Processeddate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESSEDDATE");

                entity.Property(e => e.SchemeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCHEME_ID");

                entity.Property(e => e.Supplierid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUPPLIERID");

                entity.Property(e => e.Uploadid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsSchememappingremi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_SCHEMEMAPPINGREMI");

                entity.Property(e => e.Mappedproduct)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MAPPEDPRODUCT");

                entity.Property(e => e.Mappedschemeid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAPPEDSCHEMEID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Parentschemeid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENTSCHEMEID");

                entity.Property(e => e.Schid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCHID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FinsSchememaster>(entity =>
            {
                entity.HasKey(e => e.Schemeid)
                    .HasName("SYS_C0011357");

                entity.ToTable("FINS_SCHEMEMASTER");

                entity.HasIndex(e => e.SchemeExpiryDate, "IDX_SCHEMMASTEXPDATE");

                entity.HasIndex(e => e.Product, "IDX_SCHEMMASTPRODUCT");

                entity.Property(e => e.Schemeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCHEMEID");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.AdvanceEmi)
                    .HasColumnType("NUMBER(17,2)")
                    .HasColumnName("ADVANCE_EMI");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Dbd)
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("DBD");

                entity.Property(e => e.DealerMapping)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_MAPPING");

                entity.Property(e => e.GenSch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GEN_SCH");

                entity.Property(e => e.Intrate)
                    .HasColumnType("NUMBER(5,2)")
                    .HasColumnName("INTRATE");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.MaxEmiAmountPer)
                    .HasColumnType("NUMBER(7,2)")
                    .HasColumnName("MAX_EMI_AMOUNT_PER");

                entity.Property(e => e.Maxamount)
                    .HasPrecision(18)
                    .HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Mbd)
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("MBD");

                entity.Property(e => e.Minamount)
                    .HasPrecision(18)
                    .HasColumnName("MINAMOUNT");

                entity.Property(e => e.ModelMapping)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_MAPPING");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.PortalDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PORTAL_DESCRIPTION");

                entity.Property(e => e.ProcessingFees)
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSING_FEES");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.SchemeExpiryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHEME_EXPIRY_DATE");

                entity.Property(e => e.SchemeStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHEME_START_DATE");

                entity.Property(e => e.Schemedesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMEDESC");

                entity.Property(e => e.Smid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SMID");

                entity.Property(e => e.SplSch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPL_SCH");

                entity.Property(e => e.Tenure)
                    .HasPrecision(5)
                    .HasColumnName("TENURE");

                entity.Property(e => e.UploadId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOAD_ID");
            });

            modelBuilder.Entity<FinsSchememodelmapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_SCHEMEMODELMAPPING");

                entity.HasIndex(e => e.SchemeId, "IDX1_FINS_SCHEMEMODELMAPPING");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bankpk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANKPK");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.ManufacturerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_ID");

                entity.Property(e => e.ModelId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Processeddate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESSEDDATE");

                entity.Property(e => e.SchemeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCHEME_ID");

                entity.Property(e => e.SchidMdl)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCHID_MDL");

                entity.Property(e => e.Uploadid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADID");
            });

            modelBuilder.Entity<FinsSmsalertmaster>(entity =>
            {
                entity.HasKey(e => e.Servicename)
                    .HasName("FINS_SMSALERTMASTER_PK");

                entity.ToTable("FINS_SMSALERTMASTER");

                entity.Property(e => e.Servicename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICENAME");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.AuthRestime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESTIME");

                entity.Property(e => e.Ccemailid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CCEMAILID");

                entity.Property(e => e.ExtCcemail)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EXT_CCEMAIL");

                entity.Property(e => e.ExtToemail)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EXT_TOEMAIL");

                entity.Property(e => e.Fromemailid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FROMEMAILID");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.OtpRestime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OTP_RESTIME");

                entity.Property(e => e.SendsmsTo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SENDSMS_TO");

                entity.Property(e => e.SmsFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SMS_FLAG");

                entity.Property(e => e.SmsText)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SMS_TEXT");

                entity.Property(e => e.Toemailid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TOEMAILID");
            });

            modelBuilder.Entity<FinsSysLevelParamMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_SYS_LEVEL_PARAM_MASTER");

                entity.HasIndex(e => e.Status, "IDX_PARAMSTATUS");

                entity.HasIndex(e => e.SysLevelParameter, "IDX_SYSLAVELPARAM");

                entity.Property(e => e.Addedby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDON");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifyon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFYON");

                entity.Property(e => e.Paramatervalues)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMATERVALUES");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.SysLevelId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SYS_LEVEL_ID")
                    .HasDefaultValueSql("\"EFCOREPOC\".\"SYSTEMPARAMATERID\".\"NEXTVAL\"");

                entity.Property(e => e.SysLevelParameter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYS_LEVEL_PARAMETER");
            });

            modelBuilder.Entity<FinsTid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_TID");

                entity.HasIndex(e => e.Acqchncode, "IDX_TIDACQCHNCODE");

                entity.HasIndex(e => e.Tid, "IDX_XPBFLTID");

                entity.HasIndex(e => e.Bflprofileid, "IDX_XP_BFL_TIDBFLPROFILEID");

                entity.Property(e => e.AcqChnl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACQ_CHNL");

                entity.Property(e => e.AcqchangeDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACQCHANGE_DATE");

                entity.Property(e => e.Acqchncode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACQCHNCODE");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bflprofileid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BFLPROFILEID");

                entity.Property(e => e.PosType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POS_TYPE");

                entity.Property(e => e.Tid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TID");

                entity.Property(e => e.Tidcreationdate)
                    .HasColumnType("DATE")
                    .HasColumnName("TIDCREATIONDATE");

                entity.Property(e => e.Tidstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIDSTATUS");
            });

            modelBuilder.Entity<FinsValidateorderid>(entity =>
            {
                entity.HasKey(e => new { e.Dealerid, e.Orderid, e.Awlchanneltype })
                    .HasName("SYS_C0048780");

                entity.ToTable("FINS_VALIDATEORDERID");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Awlchanneltype)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AWLCHANNELTYPE");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate");
            });

            modelBuilder.Entity<FinsValidateorderidPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINS_VALIDATEORDERID_POS");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Awlchanneltype)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AWLCHANNELTYPE");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.RequestAuditSeqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQUEST_AUDIT_SEQNO");

                entity.Property(e => e.Resdescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RESDESCRIPTION");

                entity.Property(e => e.Respcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RESPCODE");
            });

            modelBuilder.Entity<FinsValidaterequestid>(entity =>
            {
                entity.HasKey(e => new { e.Dealerid, e.Requestid, e.Awlchanneltype })
                    .HasName("SYS_C0048779");

                entity.ToTable("FINS_VALIDATEREQUESTID");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.Requestid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTID");

                entity.Property(e => e.Awlchanneltype)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AWLCHANNELTYPE");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON")
                    .HasDefaultValueSql("sysdate");
            });

            modelBuilder.Entity<RequestAudit>(entity =>
            {
                entity.HasKey(e => e.Reqseqno)
                    .HasName("PRI_REQAUDITSEQ1");

                entity.ToTable("REQUEST_AUDIT");

                entity.HasIndex(e => e.Bflreqid, "IDX_BFLREQID1");

                entity.HasIndex(e => e.AwlChanneltype, "IDX_REQAUDITCHNLTYPE1");

                entity.HasIndex(e => e.Dealercode, "IDX_REQAUDITDEALERCODE1");

                entity.HasIndex(e => e.Orderno, "IDX_REQAUDITORDERNO1");

                entity.HasIndex(e => e.AwlTxntype, "IDX_REQAUDITTXNTYPE1");

                entity.Property(e => e.Reqseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQNO");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.AwlChanneltype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AWL_CHANNELTYPE");

                entity.Property(e => e.AwlTxntype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AWL_TXNTYPE");

                entity.Property(e => e.Bflreqid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BFLREQID");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Dealercode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEALERCODE");

                entity.Property(e => e.Dealid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DEALID");

                entity.Property(e => e.FieldvalidationStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FIELDVALIDATION_STATUS");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Orderno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDERNO");

                entity.Property(e => e.ReqPktValidFlg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PKT_VALID_FLG");

                entity.Property(e => e.Reqpacket)
                    .IsUnicode(false)
                    .HasColumnName("REQPACKET");

                entity.Property(e => e.Reqpacketclear)
                    .IsUnicode(false)
                    .HasColumnName("REQPACKETCLEAR");

                entity.Property(e => e.Sealvalue)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("SEALVALUE");

                entity.Property(e => e.Sourcetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCETYPE");

                entity.Property(e => e.Storeid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STOREID");

                entity.Property(e => e.Txntype)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TXNTYPE");
            });

            modelBuilder.Entity<RequestAuditCustsearch>(entity =>
            {
                entity.HasKey(e => e.Reqseqno)
                    .HasName("CONST_REQSEQNO_CUST");

                entity.ToTable("REQUEST_AUDIT_CUSTSEARCH");

                entity.HasIndex(e => new { e.Bflreqid, e.AwlChanneltype }, "IDX$$_AD610001");

                entity.HasIndex(e => e.Addedon, "IDX_REQUEST_AUDIT_CUSTSEARCH_ADDEDON");

                entity.Property(e => e.Reqseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQNO");

                entity.Property(e => e.Addedon)
                    .HasPrecision(6)
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.AwlChanneltype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AWL_CHANNELTYPE");

                entity.Property(e => e.AwlReqid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AWL_REQID");

                entity.Property(e => e.AwlTxntype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AWL_TXNTYPE");

                entity.Property(e => e.Bflreqid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BFLREQID");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Dealercode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEALERCODE");

                entity.Property(e => e.Dealid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DEALID");

                entity.Property(e => e.FieldvalidationStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FIELDVALIDATION_STATUS");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Orderno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDERNO");

                entity.Property(e => e.ReqPktValidFlg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PKT_VALID_FLG");

                entity.Property(e => e.Reqpacket)
                    .HasColumnType("CLOB")
                    .HasColumnName("REQPACKET");

                entity.Property(e => e.Reqpacketclear)
                    .HasColumnType("CLOB")
                    .HasColumnName("REQPACKETCLEAR");

                entity.Property(e => e.Sealvalue)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("SEALVALUE");

                entity.Property(e => e.Sourcetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCETYPE");

                entity.Property(e => e.Storeid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STOREID");

                entity.Property(e => e.Txntype)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TXNTYPE");
            });

            modelBuilder.Entity<ResponseAudit>(entity =>
            {
                entity.HasKey(e => e.Resseqno)
                    .HasName("PRI_RESSEQNO1");

                entity.ToTable("RESPONSE_AUDIT");

                entity.HasIndex(e => e.Respcode, "IDX_RESAUDITRESPCODE1");

                entity.HasIndex(e => e.Reqseqno, "IDX_RESAUDITTXNTYPE1");

                entity.Property(e => e.Resseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESSEQNO");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Dealid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEALID");

                entity.Property(e => e.Reqseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQNO");

                entity.Property(e => e.Resdescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("RESDESCRIPTION");

                entity.Property(e => e.Respacket)
                    .IsUnicode(false)
                    .HasColumnName("RESPACKET");

                entity.Property(e => e.Respacketclear)
                    .IsUnicode(false)
                    .HasColumnName("RESPACKETCLEAR");

                entity.Property(e => e.Respcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RESPCODE");
            });

            modelBuilder.Entity<ResponseAuditCustsearch>(entity =>
            {
                entity.HasKey(e => e.Resseqno)
                    .HasName("CONST_RESPONSESEQNO_CUST");

                entity.ToTable("RESPONSE_AUDIT_CUSTSEARCH");

                entity.HasIndex(e => e.Reqseqno, "IDX_CUSTSEARCH_REQSEQNO");

                entity.Property(e => e.Resseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESSEQNO");

                entity.Property(e => e.Addedon)
                    .HasPrecision(6)
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Dealid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEALID");

                entity.Property(e => e.Reqseqno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQSEQNO");

                entity.Property(e => e.Resdescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("RESDESCRIPTION");

                entity.Property(e => e.Respacket)
                    .HasColumnType("CLOB")
                    .HasColumnName("RESPACKET");

                entity.Property(e => e.Respacketclear)
                    .HasColumnType("CLOB")
                    .HasColumnName("RESPACKETCLEAR");

                entity.Property(e => e.Respcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RESPCODE");
            });

            modelBuilder.Entity<VwFinsAuthorizationmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_FINS_AUTHORIZATIONMASTER");

                entity.Property(e => e.AuthAccCardLimit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACC_CARD_LIMIT");

                entity.Property(e => e.AuthAccountId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_ID");

                entity.Property(e => e.AuthAccountLimitUtil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACCOUNT_LIMIT_UTIL");

                entity.Property(e => e.AuthAcqChannelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ACQ_CHANNEL_ID");

                entity.Property(e => e.AuthAddOnFirstTran)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADD_ON_FIRST_TRAN");

                entity.Property(e => e.AuthAddrChngFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDR_CHNG_FLG");

                entity.Property(e => e.AuthAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE1");

                entity.Property(e => e.AuthAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE2");

                entity.Property(e => e.AuthAddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADDRESS_LINE3");

                entity.Property(e => e.AuthAdvanceEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ADVANCE_EMI_AMT");

                entity.Property(e => e.AuthAssetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ASSET_CODE");

                entity.Property(e => e.AuthAuthAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_AMT");

                entity.Property(e => e.AuthAuthCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AUTH_CODE");

                entity.Property(e => e.AuthAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthAvlAmtAfterTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_AFTER_TXN");

                entity.Property(e => e.AuthAvlAmtBeforeTxn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_AVL_AMT_BEFORE_TXN");

                entity.Property(e => e.AuthBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BANK_CODE");

                entity.Property(e => e.AuthBatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BATCH_ID");

                entity.Property(e => e.AuthBreStip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_BRE_STIP");

                entity.Property(e => e.AuthCardCharges)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_CHARGES");

                entity.Property(e => e.AuthCardDesign)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_DESIGN");

                entity.Property(e => e.AuthCardExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_EXP");

                entity.Property(e => e.AuthCardNum)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_NUM");

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARD_TYPE");

                entity.Property(e => e.AuthCardtypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CARDTYPE_IDENTIFIER");

                entity.Property(e => e.AuthCdParentRrn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CD_PARENT_RRN");

                entity.Property(e => e.AuthChallengerEligibleFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_ELIGIBLE_FLAG");

                entity.Property(e => e.AuthChallengerRuleId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHALLENGER_RULE_ID1");

                entity.Property(e => e.AuthChargeId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1");

                entity.Property(e => e.AuthChargeId1Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID1_AMT");

                entity.Property(e => e.AuthChargeId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2");

                entity.Property(e => e.AuthChargeId2Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID2_AMT");

                entity.Property(e => e.AuthChargeId3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3");

                entity.Property(e => e.AuthChargeId3Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID3_AMT");

                entity.Property(e => e.AuthChargeId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4");

                entity.Property(e => e.AuthChargeId4Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID4_AMT");

                entity.Property(e => e.AuthChargeId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5");

                entity.Property(e => e.AuthChargeId5Amt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CHARGE_ID5_AMT");

                entity.Property(e => e.AuthCibilDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DATE");

                entity.Property(e => e.AuthCibilDone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_DONE");

                entity.Property(e => e.AuthCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_SCORE");

                entity.Property(e => e.AuthCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CIBIL_TIME");

                entity.Property(e => e.AuthCoBrandCardCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_CARD_CODE");

                entity.Property(e => e.AuthCoBrandLimitFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CO_BRAND_LIMIT_FLAG");

                entity.Property(e => e.AuthCreditProgramCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CREDIT_PROGRAM_CODE");

                entity.Property(e => e.AuthCtrFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CTR_FLAG");

                entity.Property(e => e.AuthCustomerDueCycle)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_DUE_CYCLE");

                entity.Property(e => e.AuthCustomerId)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_ID");

                entity.Property(e => e.AuthCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_CUSTOMER_NAME");

                entity.Property(e => e.AuthDbdSubvenPerc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DBD_SUBVEN_PERC");

                entity.Property(e => e.AuthDeliveryPinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DELIVERY_PIN_CODE");

                entity.Property(e => e.AuthDfsAcquringChannel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_ACQURING_CHANNEL");

                entity.Property(e => e.AuthDfsEFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_E_FLAG");

                entity.Property(e => e.AuthDfsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_FLAG");

                entity.Property(e => e.AuthDfsPremiumAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DFS_PREMIUM_AMOUNT");

                entity.Property(e => e.AuthDocumentRequiredFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOCUMENT_REQUIRED_FLG");

                entity.Property(e => e.AuthDowNumberPayment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_DOW_NUMBER_PAYMENT");

                entity.Property(e => e.AuthEcsAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_ACCOUNT_NUMBER");

                entity.Property(e => e.AuthEcsAvailableLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_AVAILABLE_LIMIT");

                entity.Property(e => e.AuthEcsBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_BANK_NAME");

                entity.Property(e => e.AuthEcsMandateRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECS_MANDATE_REQUIRED");

                entity.Property(e => e.AuthEcslmtamt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ECSLMTAMT");

                entity.Property(e => e.AuthEmiAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EMI_AMT");

                entity.Property(e => e.AuthExceptionMsg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXCEPTION_MSG");

                entity.Property(e => e.AuthExtraPricingLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_EXTRA_PRICING_LIMIT");

                entity.Property(e => e.AuthFailedRuleId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FAILED_RULE_ID");

                entity.Property(e => e.AuthField63Tag96)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIELD_63_TAG_96");

                entity.Property(e => e.AuthFinancingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FINANCING_TYPE_CODE");

                entity.Property(e => e.AuthFirstDueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FIRST_DUE_DATE");

                entity.Property(e => e.AuthFirstSwipeFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_SWIPE_FLAG");

                entity.Property(e => e.AuthFirstTranscatioNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FIRST_TRANSCATIO_NO");

                entity.Property(e => e.AuthFosMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FOS_MOBILE");

                entity.Property(e => e.AuthFraudFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_FLAG");

                entity.Property(e => e.AuthFraudTxnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_FRAUD_TXN_DATE");

                entity.Property(e => e.AuthFraudTxnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_FRAUD_TXN_FLAG");

                entity.Property(e => e.AuthIdentifier)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IDENTIFIER");

                entity.Property(e => e.AuthImei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IMEI");

                entity.Property(e => e.AuthInterestRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_INTEREST_RATE");

                entity.Property(e => e.AuthIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_IP_ADDRESS");

                entity.Property(e => e.AuthLastUpdDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LAST_UPD_DATE");

                entity.Property(e => e.AuthLoanToValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_LOAN_TO_VALUE");

                entity.Property(e => e.AuthManufacturerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MANUFACTURER_ID");

                entity.Property(e => e.AuthMatchFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MATCH_FLAG");

                entity.Property(e => e.AuthMbd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MBD");

                entity.Property(e => e.AuthMeDealerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ME_DEALER_ID");

                entity.Property(e => e.AuthMerchantBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_BRANCH_ID");

                entity.Property(e => e.AuthMerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MERCHANT_NAME");

                entity.Property(e => e.AuthMicrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MICR_CODE");

                entity.Property(e => e.AuthMid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MID");

                entity.Property(e => e.AuthMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE");

                entity.Property(e => e.AuthMobileChangedFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_CHANGED_FLAG");

                entity.Property(e => e.AuthMobileTransaction)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MOBILE_TRANSACTION");

                entity.Property(e => e.AuthModelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_ID");

                entity.Property(e => e.AuthModelMake)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_MODEL_MAKE");

                entity.Property(e => e.AuthNoOfAddonCards)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTH_NO_OF_ADDON_CARDS");

                entity.Property(e => e.AuthNoOfAdvEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_NO_OF_ADV_EMI");

                entity.Property(e => e.AuthOldCibilDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_DATE");

                entity.Property(e => e.AuthOldCibilScore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_SCORE");

                entity.Property(e => e.AuthOldCibilTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OLD_CIBIL_TIME");

                entity.Property(e => e.AuthOrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORDER_NO");

                entity.Property(e => e.AuthOrgTxnAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORG_TXN_AMT");

                entity.Property(e => e.AuthOriginalRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_ORIGINAL_RRNUMBER");

                entity.Property(e => e.AuthOtpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_ID");

                entity.Property(e => e.AuthOtpRequestId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_REQUEST_ID");

                entity.Property(e => e.AuthOtpVerificReslt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_OTP_VERIFIC_RESLT");

                entity.Property(e => e.AuthOtpgentime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_OTPGENTIME");

                entity.Property(e => e.AuthParentRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARENT_RRNUMBER");

                entity.Property(e => e.AuthPartialCnclChrgs)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_CHRGS");

                entity.Property(e => e.AuthPartialCnclFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_FLAG");

                entity.Property(e => e.AuthPartialCnclId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_CNCL_ID");

                entity.Property(e => e.AuthPartialDbdRefund)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTIAL_DBD_REFUND");

                entity.Property(e => e.AuthPartnerEdcChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PARTNER_EDC_CHANNEL");

                entity.Property(e => e.AuthPinumberEntered)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PINUMBER_ENTERED");

                entity.Property(e => e.AuthPosEntryMode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_ENTRY_MODE");

                entity.Property(e => e.AuthPosReinventAuthcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_AUTHCODE");

                entity.Property(e => e.AuthPosReinventInvoiceAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_POS_REINVENT_INVOICE_AMT");

                entity.Property(e => e.AuthPrimaryAddOnInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRIMARY_ADD_ON_IND");

                entity.Property(e => e.AuthProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESS_CODE");

                entity.Property(e => e.AuthProcessingFee)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROCESSING_FEE");

                entity.Property(e => e.AuthProdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROD_DESC");

                entity.Property(e => e.AuthProductCodeType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_CODE_TYPE");

                entity.Property(e => e.AuthProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PRODUCT_ID");

                entity.Property(e => e.AuthPromoCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_PROMO_CODE");

                entity.Property(e => e.AuthRelationshipType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RELATIONSHIP_TYPE");

                entity.Property(e => e.AuthReqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQ_DATE");

                entity.Property(e => e.AuthReqdatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("AUTH_REQDATETIME");

                entity.Property(e => e.AuthRequestid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_REQUESTID");

                entity.Property(e => e.AuthResidenceCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESIDENCE_CITY");

                entity.Property(e => e.AuthResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_CODE");

                entity.Property(e => e.AuthResponseDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RESPONSE_DESC");

                entity.Property(e => e.AuthRrnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_RRNUMBER");

                entity.Property(e => e.AuthSchemeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SCHEME_CODE");

                entity.Property(e => e.AuthSettledFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SETTLED_FLAG");

                entity.Property(e => e.AuthSfdcorg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SFDCORG")
                    .IsFixedLength(true);

                entity.Property(e => e.AuthSourceReverse)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_SOURCE_REVERSE");

                entity.Property(e => e.AuthStoreId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_STORE_ID");

                entity.Property(e => e.AuthTenor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TENOR");

                entity.Property(e => e.AuthTid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TID");

                entity.Property(e => e.AuthTliUtilizedFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TLI_UTILIZED_FLG");

                entity.Property(e => e.AuthTraceAuditNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRACE_AUDIT_NUMBER");

                entity.Property(e => e.AuthTransactionBranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TRANSACTION_BRANCH_ID");

                entity.Property(e => e.AuthTxnMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_MOBILE_NO");

                entity.Property(e => e.AuthTxnSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_TXN_SOURCE");

                entity.Property(e => e.AuthUserName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_USER_NAME");

                entity.Property(e => e.AuthVasAmt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTH_VAS_AMT");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_ADDRESS");

                entity.Property(e => e.SeqId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_ID");
            });

            modelBuilder.Entity<WsKeyconfigmultiservice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WS_KEYCONFIGMULTISERVICE");

                entity.HasIndex(e => new { e.Bankcode, e.Modulecode }, "IDX_KEYCONFIG");

                entity.Property(e => e.Addedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDEDBY");

                entity.Property(e => e.Addedon)
                    .HasColumnType("DATE")
                    .HasColumnName("ADDEDON");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Dealercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DEALERCODE");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Encryptionkey)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ENCRYPTIONKEY");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Keyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYID");

                entity.Property(e => e.Keylength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYLENGTH");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Modulecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODULECODE");

                entity.Property(e => e.Thirdparty)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("THIRDPARTY");
            });

            modelBuilder.Entity<XpBflDealerBusinessProd>(entity =>
            {
                entity.HasKey(e => e.Dealerbusiprodid)
                    .HasName("XP_BFL_DEALER_BUSINESS_PROD");

                entity.ToTable("XP_BFL_DEALER_BUSINESS_PROD");

                entity.HasIndex(e => e.Dealerid, "BFLDELBUSPROD_DEALRID");

                entity.Property(e => e.Dealerbusiprodid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERBUSIPRODID");

                entity.Property(e => e.BusiProdCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BUSI_PROD_CODE");

                entity.Property(e => e.Businessproddesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESSPRODDESC");

                entity.Property(e => e.Dealerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEALERID");

                entity.Property(e => e.ModifedIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFED_IP");

                entity.Property(e => e.Modifiedby)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("DATE")
                    .HasColumnName("MODIFIEDON");
            });

            modelBuilder.HasSequence("FINS_AUDITLOGSEQ");

            modelBuilder.HasSequence("FINS_AUTHORIZATIONMASTER_SEQ");

            modelBuilder.HasSequence("FINS_BULKDEALERDETAILS_SEQ");

            modelBuilder.HasSequence("PRODUCTPARAMATERID");

            modelBuilder.HasSequence("SEQ_3IN1APP_REQ");

            modelBuilder.HasSequence("SEQ_3IN1APP_RES");

            modelBuilder.HasSequence("SEQ_3IN1APPTOKEN");

            modelBuilder.HasSequence("SEQ_3IN1CUS_REQ");

            modelBuilder.HasSequence("SEQ_3IN1CUS_RES");

            modelBuilder.HasSequence("SEQ_AUTHMASTER");

            modelBuilder.HasSequence("SEQ_CANCELLATION_ID");

            modelBuilder.HasSequence("SEQ_DSHORTSEQ");

            modelBuilder.HasSequence("SEQ_GENERATERRN");

            modelBuilder.HasSequence("SEQ_REQUESTAUDIT");

            modelBuilder.HasSequence("SEQ_RESPONSEAUDIT");

            modelBuilder.HasSequence("SEQ_STAN");

            modelBuilder.HasSequence("SQEACCPRODMAPPING");

            modelBuilder.HasSequence("SYSTEMPARAMATERID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
