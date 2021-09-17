//ref :: https://www.florinciubotariu.com/exclude-tables-when-using-entity-framework-core-reverse-engineering/
//ref :: https://en.wikipedia.org/wiki/Decorator_pattern
//desc:: Custom class to remove tables from database first approach

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace projectMigration
{
public class CustomEFDesignTimeServices : IDesignTimeServices
{
    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
    {
      serviceCollection.Decorate<IDatabaseModelFactory, CustomOraclServerDatabaseModelFactory>();
    }
}
}