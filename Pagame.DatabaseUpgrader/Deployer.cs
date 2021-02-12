using System;
using System.Reflection;
using DbUp;
using DbUp.Engine;
namespace Pagame.DatabaseUpgrader
{
    public static class Deployer
    {
        public static DatabaseUpgradeResult DeployDatabaseScripts(string connectionString)
        {
            EnsureDatabase.For.SqlDatabase(connectionString);

            UpgradeEngine upgradeEngine =
                DeployChanges.To
                .SqlDatabase(connectionString)
                .WithTransactionPerScript()
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly(), (s) => { return s.Contains("sprocs"); })
                .LogToConsole()
                .Build();

            DatabaseUpgradeResult databaseUpgradeResult = upgradeEngine.PerformUpgrade();
            return databaseUpgradeResult;

        }

        public static DatabaseUpgradeResult DeployDatabaseTables(string connectionString)
        {
            EnsureDatabase.For.SqlDatabase(connectionString);

            UpgradeEngine upgradeEngine =
                DeployChanges.To
                .SqlDatabase(connectionString)
                .WithTransactionPerScript()
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly(), (s) => { return s.Contains("table"); })
                .LogToConsole()
                .Build();

            DatabaseUpgradeResult databaseUpgradeResult = upgradeEngine.PerformUpgrade();
            return databaseUpgradeResult;
        }
    }
}
