using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221
{
    internal static class CyberTips
    {
        private static readonly Dictionary<string, List<string>> tips = new Dictionary<string, List<string>>()
        {
            {
                "phishing", new List<string>()
                {
                    "Be cautious of emails asking for personal info.",
                    "Scammers often disguise themselves as trusted sources.",
                    "Always verify email addresses and links before clicking.",
                    "Don’t respond to suspicious pop-ups or messages."
                }
            }
        };

        public static string GetRandomTip(string keyword)
        {
            if (tips.ContainsKey(keyword))
            {
                var responses = tips[keyword];
                Random rand = new Random();
                return responses[rand.Next(responses.Count)];
            }
            return null;
        }
    }
}
