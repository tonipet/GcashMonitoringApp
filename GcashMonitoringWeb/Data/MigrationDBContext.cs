using Microsoft.EntityFrameworkCore;
using GcashMonitoringWeb.Models;


namespace GcashMonitoringWeb.Data
{
    public class MigrationDBContext : DbContext
    {

        public MigrationDBContext(DbContextOptions<MigrationDBContext> options) : base(options)
        {
        }

        public DbSet<tbl_login> tbl_login {get;set;}

        public DbSet<GcashMonitoringWeb.Models.LoginModel>? LoginModel { get; set; }

        

    }
}
