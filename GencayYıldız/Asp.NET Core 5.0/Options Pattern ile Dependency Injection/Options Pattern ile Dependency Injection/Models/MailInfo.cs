namespace Options_Pattern_ile_Dependency_Injection.Models
{
    public class MailInfo
    {
        public string Port { get; set; }
        public string Host { get; set; }
        public EmailInfo EmailInfo { get; set; }
    }

    public class EmailInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
