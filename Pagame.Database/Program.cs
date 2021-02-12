using System;
using System.Linq;
using DbUp.Engine;
namespace Pagame.Database
{
    public class Program
    {
        public Program()
        {
            static void Main(string[] args)
            {
                string connectionString =
                    args.FirstOrDefault() ??
                    "Server=localhost,1433\\Catalog=PagameDevDatabase;Database=PagameDevDatabase;User=sa;Password=2shMr.p2muW6g48qonqxara";
                DatabaseUpgradeResult result = Deployer.DeployDatabaseTables(connectionString);
                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
                    Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successful upgrade");
                Console.ResetColor();

            }
        }
    }
}
