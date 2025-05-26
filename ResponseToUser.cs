using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221
{
    internal class ResponseToUser
    {
        // Keyword-response map (for keyword recognition and random responses)
        private static readonly Dictionary<string, string> keywordResponses = new Dictionary<string, string>
        {
            { "password", "Bot: Use long, unique passwords and enable two-factor authentication." },
            { "phishing", "Bot: Don’t click on suspicious links or attachments. Verify email sources." },
            { "safe browsing", "Bot: Always check the URL, use HTTPS sites, and avoid public Wi-Fi for sensitive tasks." },
            { "how are you", "Bot: I’m doing great, thanks for asking!" },
            { "your purpose", "Bot: I’m here to teach you about staying safe online." }
        };

        // List of common emotional keywords
        private static readonly List<string> negativeFeelings = new List<string>
        {
            "worried", "scared", "frustrated", "anxious", "confused", "nervous"
        };

        // List of random fallback responses
        private static readonly List<string> fallbackResponses = new List<string>
        {
            "Bot: Hmm, I'm not sure how to answer that. Try asking about passwords, phishing, or safe browsing.",
            "Bot: That's an interesting question. Could you try rephrasing it?",
            "Bot: Let's focus on online safety. What do you want to know about passwords or phishing?",
            "Bot: I'm still learning. Ask me about staying safe online!"
        };

        // Main response logic
        public static void RespondToUser(string input, Dictionary<string, string> memory)
        {
            bool responded = false;

            // 1. Sentiment detection
            if (DetectSentiment(input))
            {
                responded = true;
            }

            // 2. Keyword-based recognition
            foreach (var pair in keywordResponses)
            {
                if (input.Contains(pair.Key))
                {
                    Console.WriteLine(pair.Value);
                    responded = true;
                }
            }

            // 3. Fallback response
            if (!responded)
            {
                Random rand = new Random();
                int index = rand.Next(fallbackResponses.Count);
                Console.WriteLine(fallbackResponses[index]);
            }
        }

        // Detects emotional sentiment in the input
        private static bool DetectSentiment(string input)
        {
            foreach (string feeling in negativeFeelings)
            {
                if (input.Contains(feeling))
                {
                    Console.WriteLine("Bot: I understand you're feeling that way. Cybersecurity can be overwhelming, but you're not alone. Let’s take it one step at a time.");
                    return true;
                }
            }
            return false;
        }
    }
}
