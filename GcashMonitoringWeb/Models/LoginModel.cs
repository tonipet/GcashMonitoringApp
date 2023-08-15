namespace GcashMonitoringWeb.Models
{
    public class LoginModel
    {

        public int Id { get; set; }
    
        public string? FirstName { get; set; }
       
        public string? LastName { get; set; }
      
        public string? MiddleName { get; set; }
     
        public string? Username { get; set; }
        public string? Pasword { get; set; }
        public string? Emailaddress { get; set; }

        public DateTime? DateRegister { get; set; }
    }
}
