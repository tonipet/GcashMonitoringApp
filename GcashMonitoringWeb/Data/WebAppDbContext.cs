using System.ComponentModel.DataAnnotations;

namespace GcashMonitoringWeb.Data
{
    public class WebAppDbContext
    {
       
    }
    public class tbl_login
    {

        [Key]
        public int Id { get; set; } 
        [MaxLength(250)]
        public string? FirstName { get; set; }
        [MaxLength(250)]
        public string? LastName { get; set; }
        [MaxLength(250)]
        public string? MiddleName { get; set; }
        [MaxLength(250)]
        public string? Username { get; set; }
        public string? Pasword { get; set; }
        public string? Emailaddress { get; set; }

        public DateTime? DateRegister { get; set; }

    }
}
