using Countries.Data;
using Countries.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETDataSourceControls.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CountriesDbContext, Configuration>());
            CountriesDbContext.Create().Database.Initialize(true);
        }
    }
}