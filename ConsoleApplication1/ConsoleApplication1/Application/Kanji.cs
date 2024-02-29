using System;

namespace JpPractice.Application
{

    public class Kanji
    {

        public string romanji;
        public string audioPath;
        System.Media.SoundPlayer player;

        public Kanji(string romanji,string audioPath)
        {
            this.romanji = romanji;
            this.audioPath = audioPath;
            player = new System.Media.SoundPlayer(audioPath);
        }

        public void playSound()
        {
            player.Play();
        }
    }
}
