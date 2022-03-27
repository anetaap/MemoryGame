using System;

namespace MemoryGame
{
    public class Settings
    {
        private String _nick;
        private int time = 10;
        private int size1 = 6;
        private int size2 = 8;

        public Settings(String nick)
        {
            _nick = nick;
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
    }
}