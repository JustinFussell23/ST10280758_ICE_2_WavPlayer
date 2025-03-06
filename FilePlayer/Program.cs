/*
 *Justin Fussell ST10280758 Group 3
 */
using System;//Using the system namespace

namespace FilePlayer//Namespace for the project
{
    class Program//Class for the project
    {
        static void Main(string[] args)//Main method for the project
        {
            // Array of WAV file paths - replace with your actual paths
            string[] filePaths = new string[]//Array of file paths
            {
                @"C:\Users\Justin Fussell\source\repos\FilePlayer\FilePlayer\bin\Debug\Music\Electronic_Beat.wav",//File path for the first song
                @"C:\Users\Justin Fussell\source\repos\FilePlayer\FilePlayer\bin\Debug\Music\Guitar_Beat.wav",//File path for the second song
                @"C:\Users\Justin Fussell\source\repos\FilePlayer\FilePlayer\bin\Debug\Music\Tranquil_Beat.wav"//File path for the third song
            };

            // Create AudioPlayer instances
            AudioPlayer[] players = new AudioPlayer[3];//Array of AudioPlayer instances
            for (int i = 0; i < 3; i++)//For loop to create the AudioPlayer instances
            {
                players[i] = new AudioPlayer(filePaths[i]);//Create the AudioPlayer instances
            }

            bool running = true;//Boolean to keep the program running
            while (running)//While loop to keep the program running
            {
                Console.Clear();//Clear the console

                // Display menu with color based on play status
                for (int i = 0; i < players.Length; i++)//For loop to display the menu
                {
                    if (players[i].HasBeenPlayed)//If the song has been played
                    {
                        Console.ForegroundColor = ConsoleColor.Green;//Change the color to green
                    }
                    Console.WriteLine($"{i + 1}. Wav {i + 1}");//Display the menu
                    Console.ResetColor();//Reset the color
                }

                Console.WriteLine("\nEnter a number of choice from (1-3) to play a song. Alternativly click 0 to exit:");//Display the menu
                string input = Console.ReadLine();//Read the user input

                // Handle user input
                if (int.TryParse(input, out int choice))//If the user input is a number
                {
                    if (choice == 0)//If the user input is 0
                    {
                        running = false; // Exit program
                    }
                    else if (choice >= 1 && choice <= 3)//If the user input is between 1 and 3
                    {
                        players[choice - 1].Play(); // Play selected WAV
                        Console.WriteLine("Playing... Press any key to continue");//Display the message
                        Console.ReadKey(); // Wait for user to continue
                    }
                    else//If the user input is not between 0 and 3
                    {
                        Console.WriteLine("Invalid choice! Press any key to try again");//Display the message
                        Console.ReadKey();//Wait for the user to press a key
                    }
                }
                else//If the user input is not a number
                {
                    Console.WriteLine("Please enter a number! Press any key to try again");//Display the message
                    Console.ReadKey();//Wait for the user to press a key
                }
            }
        }
    }
}
//*******************************************************END OF FILE*****************************************************************