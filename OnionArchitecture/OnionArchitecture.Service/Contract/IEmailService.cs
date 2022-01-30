using OnionArchitecture.Domain.Settings;
using System.Threading.Tasks;

namespace OnionArchitecture.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
