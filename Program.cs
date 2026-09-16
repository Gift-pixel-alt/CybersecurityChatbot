using System;
using System.Threading;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            Console.ForegroundColor = ConsoleColor.Cyan;

            DisplayLogo();

            Console.ResetColor();

            VoiceGreeting.PlayGreeting();

            Console.Clear();

            DisplayLogo();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot!");
            Console.ResetColor();

            Console.WriteLine();
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine() ?? "";

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty.");
                Console.ResetColor();

                Console.Write("Please enter your name: ");
                name = Console.ReadLine() ?? "";
            }

            Chatbot chatbot = new Chatbot(name);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            TypeText($"Hello {name}! I'm here to help you stay safe online.");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("• Phishing");
            Console.WriteLine("• Password safety");
            Console.WriteLine("• Safe browsing");
            Console.WriteLine("• Online scams");
            Console.WriteLine("• Malware");
            Console.WriteLine("• Social engineering");
            Console.WriteLine();
            Console.WriteLine("Type 'exit' to close the chatbot.");
            Console.ResetColor();

            Console.WriteLine();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{name}: ");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";

                if (input.Trim().ToLower() == "exit")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    TypeText($"Goodbye {name}! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                string response = chatbot.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Chatbot: ");
                Console.ResetColor();

                TypeText(response);

                Console.WriteLine();
            }
        }

        static void DisplayLogo()
{
    string logoPath = Path.Combine(
        AppContext.BaseDirectory,
        "ASCII_Logo.txt"
    );

    if (File.Exists(logoPath))
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(File.ReadAllText(logoPath));
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("STAY SAFE ONLINE");
    }
}

        static void TypeText(string text)
        {
            foreach (char character in text)
            {
                Console.Write(character);
                Thread.Sleep(15);
            }

            Console.WriteLine();
        }
    }
}