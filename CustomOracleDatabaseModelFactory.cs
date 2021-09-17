//ref :: https://www.florinciubotariu.com/exclude-tables-when-using-entity-framework-core-reverse-engineering/
//desc:: Custom class to remove tables from database first approach  

using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace projectMigration
{
    public class CustomOraclServerDatabaseModelFactory : IDatabaseModelFactory
{
    private IDatabaseModelFactory databaseModelFactory;

    private static readonly List<string> ExcludedTables = new List<string>
    {
      "BANK",
      "SCH_PUB_SIMPLE_TRIGGERS",
      "SCH_PUB_TRIGGERS",
      "SCH_PUB_CRON_TRIGGERS",
      "SCH_PUB_TRIGGER_LISTENERS",
      "SCH_PUB_BLOB_TRIGGERS"
    };

    public CustomOraclServerDatabaseModelFactory(IDatabaseModelFactory databaseModelFactory)
    {
      this.databaseModelFactory = databaseModelFactory;
    }

    public DatabaseModel Create(string connectionString, DatabaseModelFactoryOptions options)
    {
      var databaseModel = databaseModelFactory.Create(connectionString, options);

      RemoveTables(databaseModel);

      return databaseModel;
    }

    public DatabaseModel Create(DbConnection connection, DatabaseModelFactoryOptions options)
    {
      var databaseModel = databaseModelFactory.Create(connection, options);

      RemoveTables(databaseModel);

      return databaseModel;
    }

    private static void RemoveTables(DatabaseModel databaseModel)
    {
      var tablesToBeRemoved = databaseModel.Tables.Where(x => ExcludedTables.Contains(x.Name)).ToList();

      foreach (var tableToRemove in tablesToBeRemoved)
      {
        databaseModel.Tables.Remove(tableToRemove);
      }
    }
}
}