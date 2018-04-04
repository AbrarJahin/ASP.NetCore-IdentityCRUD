using System.Threading.Tasks;

namespace IdentityCrud.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
