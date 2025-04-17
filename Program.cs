
using System;
using System.IO;
using System.Media;

namespace PROG6221pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Display ASCII Art Logo
            Image.DisplayAsciiArt();

            // 2. Play Voice Greeting
            Audio.PlayVoiceGreeting();

            // 3. Greet User and Ask for Name
            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Cyber User";
            }

            Console.WriteLine($"\nWelcome, {userName}! Ask me a cybersecurity question on Passwords, Phishing, and/or Safe Browsing. If not (Type 'Exit/Quit' to leave)\n");

            // 4. Chat Loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase? (Or type 'Exit/Quit' to leave)");
                    continue;
                }

                if (input == "exit" || input == "quit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                ResponseToUser.RespondToUser(input);
            }

            Console.ResetColor();
        }
    }
}