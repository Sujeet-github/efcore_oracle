using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projectMigration.Migrations
{
    public partial class us234567 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // var assembly = Assembly.GetExecutingAssembly();
            // var sqlFiles = assembly.GetManifestResourceNames().
            //             Where(file => file.EndsWith(".sql"));
            // foreach (var sqlFile in sqlFiles)
            // {
            //     using (Stream stream = assembly.GetManifestResourceStream(sqlFile))
            //     using (StreamReader reader = new StreamReader(stream))
            //     {
            //         var sqlScript = reader.ReadToEnd();
            //         migrationBuilder.Sql(sqlScript);
            //     }

            // }

            CustomMigrationBuilder.MigrateScripts(migrationBuilder);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // var assembly = Assembly.GetExecutingAssembly();
            // var sqlFiles = assembly.GetManifestResourceNames().
            //             Where(file => file.EndsWith(".bkp"));
            // foreach (var sqlFile in sqlFiles)
            // {
            //     using (Stream stream = assembly.GetManifestResourceStream(sqlFile))
            //     using (StreamReader reader = new StreamReader(stream))
            //     {
            //         var sqlScript = reader.ReadToEnd();
            //         migrationBuilder.Sql(sqlScript);
            //     }

            // }

            CustomMigrationBuilder.RollbackScripts(migrationBuilder);
        }
    }
}
