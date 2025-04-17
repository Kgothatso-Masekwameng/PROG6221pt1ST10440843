using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221pt1
{
    internal class ResponseToUser
    {
        public static void RespondToUser(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I’m doing great, thanks for asking!");
            }
            else if (input.Contains("your purpose"))
            {
                Console.WriteLine("Bot: I’m here to teach you about staying safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use long, unique passwords and enable two-factor authentication.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Don’t click on suspicious links or attachments. Verify email sources.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Always check the URL, use HTTPS sites, and avoid public Wi-Fi for sensitive tasks.");
            }
            else
            {
                Console.WriteLine("Bot: Hmm, I’m not sure how to answer that. Try asking about passwords, phishing, or safe browsing.");
            }
        }
    }
}
