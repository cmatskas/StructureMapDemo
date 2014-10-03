namespace StructureMapDemo.Services
{
    public interface IEmailService
    {
        bool SendEmail(string recepient, string emailBody);
    }
}