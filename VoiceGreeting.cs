using System;
using System.Media;

namespace CybersecurityChatbot
{
    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppContext.BaseDirectory, "Audio", "greeting.wav");

                if (System.IO.File.Exists(audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                }
                else
                {
                    Console.WriteLine("[Voice greeting file not found.]");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("[The voice greeting could not be played.]");
            }
        }
    }
}