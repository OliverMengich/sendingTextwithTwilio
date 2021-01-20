using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Threading.Tasks;

namespace TwilioSendMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountSid = Environment.GetEnvironmentVariable("AC43e0d4f52a377bc5c59463b4f5136d64");
            string token = Environment.GetEnvironmentVariable("ff9c18a44d40f91742bb12225fa473c4");

            TwilioClient.Init(accountSid, token);

            var message = MessageResource.Create(body: "Hello Welcome to Twilio",
                from: new Twilio.Types.PhoneNumber("+254710235787"),
                to: new Twilio.Types.PhoneNumber("+254742583425")
                );
            
        }
    }
}
