using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221
{
    internal static class Memory
    {
        public static string UserName { get; set; } = "Cyber User";
        public static string Interest { get; set; } = "";

        public static void StoreInterest(string input)
        {
            if (input.Contains("privacy"))
            {
                Interest = "privacy";
            }
            else if (input.Contains("password"))
            {
                Interest = "passwords";
            }
            else if (input.Contains("phishing") || input.Contains("scam"))
            {
                Interest = "phishing";
            }
        }

        public static string RecallInterest()
        {
            if (!string.IsNullOrEmpty(Interest))
            {
                return $"As someone interested in {Interest}, remember to stay updated and review your settings regularly.";
            }
            return "";
        }
    }
}