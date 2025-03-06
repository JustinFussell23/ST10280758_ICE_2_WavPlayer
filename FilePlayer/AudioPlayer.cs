/*
 *Justin Fussell ST10280758 Group 3
 */
using System.Media;//Using the system media namespace

namespace FilePlayer//Namespace for the project
{
    public class AudioPlayer//Class for the project
    {
        private readonly SoundPlayer player;//SoundPlayer instance
        public string FilePath { get; private set; }//Property for the file path
        public bool HasBeenPlayed { get; private set; }//Property for if the song has been played

        public AudioPlayer(string filePath)//Constructor for the class
        {
            FilePath = filePath;//Set the file path
            player = new SoundPlayer(filePath);//Create the SoundPlayer instance
            HasBeenPlayed = false;//Set the song to not played
        }

        public void Play()//Method to play the song
        {
            player.Play();//Play the song
            HasBeenPlayed = true;//Set the song to played
        }
    }
}
//*******************************************************END OF FILE*****************************************************************