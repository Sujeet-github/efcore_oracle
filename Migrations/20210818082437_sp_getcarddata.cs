using Microsoft.EntityFrameworkCore.Migrations;

namespace projectMigration.Migrations
{
    public partial class sp_getcarddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var _proc1 = @"create procedure sp_testefmigration
                    (
                    pcrd_no            varchar2,
                    p_output          out sys_refcursor
                    )
                    as
                    begin
                    open p_output for select * from fins_cardmaster where crd_no = pcrd_no;
                    end;";
                    migrationBuilder.Sql(_proc1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var proc1 = @"drop procedure sp_testefmigration;";
            migrationBuilder.Sql(proc1);
        }
    }
}
