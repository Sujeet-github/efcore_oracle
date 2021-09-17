
//Ref:: https://dotnetthoughts.net/creating-stored-procs-in-efcore-migrations/
//Call these extension method at the end of the Migration.Up() method 
//for new migrations                :: CustomMigrationBuilder.MigrateScripts(migrationBuilder);
//for reverting the latest change   :: 

using System.Linq;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace projectMigration
{
    public static class CustomMigrationBuilder
    {
        public static void MigrateScripts(this MigrationBuilder migrationBuilder)
        {
            //For each table registered in the builder, let's create a sequence and a trigger
            // foreach (CreateTableOperation createTableOperation in migrationBuilder.Operations.ToArray().OfType<CreateTableOperation>())
            // {
            //     string tableName = createTableOperation.Name;
            //     string primaryKey = createTableOperation.PrimaryKey.Columns[0];
            //     migrationBuilder.CreateSequence<int>(name: $"SQ_{tableName}", schema: createTableOperation.Schema);
            //     migrationBuilder.Sql(@"sql string")
            // }

            var assembly = Assembly.GetExecutingAssembly();
            var sqlFiles = assembly.GetManifestResourceNames().
                        Where(file => file.EndsWith(".sql"));
            foreach (var sqlFile in sqlFiles)
            {
                using (Stream stream = assembly.GetManifestResourceStream(sqlFile))
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sqlScript = reader.ReadToEnd();
                    migrationBuilder.Sql(sqlScript);
                }
            }
        }

        public static void RollbackScripts(this MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var sqlFiles = assembly.GetManifestResourceNames().
                        Where(file => file.EndsWith(".bkp"));
            foreach (var sqlFile in sqlFiles)
            {
                using (Stream stream = assembly.GetManifestResourceStream(sqlFile))
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sqlScript = reader.ReadToEnd();
                    migrationBuilder.Sql(sqlScript);
                }
            }
        }
    }
}