using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PROG6221
{
    internal class Audio
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                string filePath = @"C:\Users\lab_services_student\Desktop\PROG6221\PROG6221\files\Greetings.wav";
                SoundPlayer player = new SoundPlayer(filePath);
               player.PlaySync(); // or Play() if you don't want it to block
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("[Voice greeting skipped: 'Greeting.wav' not found]");
            }
        }
    }
}
