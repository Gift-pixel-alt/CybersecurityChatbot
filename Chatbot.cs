using System;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        public string UserName { get; set; }

        public Chatbot(string userName)
        {
            UserName = userName;
        }

        public string GetResponse(string input)
        {
            // Check if the user entered nothing
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please enter a question so I can help you.";
            }

            string message = input.ToLower().Trim();

            // General conversation
            if (message.Contains("how are you"))
            {
                return $"I'm doing well, {UserName}! I'm ready to help you stay safe online.";
            }
            else if (message.Contains("hello") || message.Contains("hi"))
            {
                return $"Hello {UserName}! How can I help you with cybersecurity today?";
            }
            else if (message.Contains("thank"))
            {
                return "You're welcome! Remember to stay alert and protect your personal information.";
            }

            // Chatbot purpose
            else if (message.Contains("purpose") ||
                     message.Contains("what do you do"))
            {
                return "My purpose is to help South African citizens understand cybersecurity risks and stay safer online.";
            }

            // Topics the chatbot can answer
            else if (message.Contains("what can i ask") ||
                     message.Contains("what can i learn"))
            {
                return "You can ask me about phishing, passwords, safe browsing, online scams, malware, social engineering, and online privacy.";
            }

            // Phishing
            else if (message.Contains("phishing"))
            {
                return "Phishing is a scam where criminals pretend to be a trusted person or organisation to steal information. Check links carefully and never share passwords or OTPs.";
            }

            // Password safety
            else if (message.Contains("password"))
            {
                return "Use a long and unique password for each account. Avoid using your name, birthday, or other personal information. A password manager can also help.";
            }

            // OTP safety
            else if (message.Contains("otp") ||
                     message.Contains("one time password"))
            {
                return "Never share an OTP with someone who contacts you unexpectedly. Legitimate organisations should not ask you to reveal your OTP to them.";
            }

            // Online scams
            else if (message.Contains("scam"))
            {
                return "Be careful of messages that create urgency or ask for money, passwords, PINs, or OTPs. Verify requests using official contact details.";
            }

            // Safe browsing
            else if (message.Contains("safe browsing") ||
                     message.Contains("browser") ||
                     message.Contains("browsing"))
            {
                return "For safer browsing, use trusted websites, check the website address carefully, keep your browser updated, and avoid suspicious downloads.";
            }

            // Malware
            else if (message.Contains("malware") ||
                     message.Contains("virus"))
            {
                return "Malware is malicious software that can damage devices or steal information. Keep your software updated and avoid downloading files from unknown sources.";
            }

            // Social engineering
            else if (message.Contains("social engineering"))
            {
                return "Social engineering tricks people into revealing information or performing unsafe actions. Be cautious of pressure, urgency, and suspicious requests.";
            }

            // Privacy
            else if (message.Contains("privacy") ||
                     message.Contains("personal information"))
            {
                return "Protect your personal information by limiting what you share online, using strong privacy settings, and avoiding unknown websites and messages.";
            }

            // Public Wi-Fi
            else if (message.Contains("wi-fi") ||
                     message.Contains("wifi") ||
                     message.Contains("public wifi"))
            {
                return "Be careful when using public Wi-Fi. Avoid accessing sensitive accounts when possible, use trusted networks, and make sure websites use HTTPS.";
            }

            // Default response
            else
            {
                return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }
}