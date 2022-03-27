using System;

namespace MemoryGame
{
    public class Settings
    {
        private String _nick;
        private int time = 5;
        private int size1 = 2;
        private int size2 = 3;
        private string _path;


        public void Disney()
        {
            Path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Disney\";
        }

        public void Stitch()
        {
            Path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";
        }

        public Settings(String nick)
        {
            _nick = nick;
            _path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";
        }

        public int Time
        {
            get => time;
            set => time = value;
        }

        public int Size1
        {
            get => size1;
            set => size1 = value;
        }        
        public int Size2
        {
            get => size2;
            set => size2 = value;
        }

        public String Nick
        {
            set => _nick = value;
            get => _nick;
        }

        public String Path
        {
            get => _path;
            set => _path = value;
        }
    }
}