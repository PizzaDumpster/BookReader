using System;
using System.Speech.Synthesis;

namespace BookReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            synth.SetOutputToDefaultAudioDevice();

            synth.Volume = 50;

            // Speak a string.
            foreach (var myString in File.ReadAllLines(@"C:\Users\djd18\OneDrive\Desktop\pg46.txt"))
            {
                Console.WriteLine(myString);
                synth.Speak(myString);
                
            }
                

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}