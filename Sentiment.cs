using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221pt1
{
    internal static class Sentiment
    {
        public static string DetectSentiment(string input)
        {
            if (input.Contains("worried"))
                return "It’s okay to feel worried — cybersecurity threats can be scary, but you're not alone!";
            if (input.Contains("curious"))
                return "Curiosity is great! Let’s explore how to protect yourself online.";
            if (input.Contains("frustrated"))
                return "I understand the frustration. Let me simplify things for you.";
            return "";
        }
    }
}
