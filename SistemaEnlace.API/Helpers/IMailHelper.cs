

using SistemaEnlace.Shared.Responses;

namespace SistemaEnlace.API.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }
}