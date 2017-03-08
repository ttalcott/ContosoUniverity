
using Microsoft.Extensions.Options;

namespace ContosoUniversity.Services
{
    //public class AuthMessageSender : IEmailSender, ISmsSender
    //{
    //    public AuthMessageSenderOptions Options { get; }

    //    public AuthMessageSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
    //    {
    //        Options = optionsAccessor.Value;
    //    }
    //}

    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}