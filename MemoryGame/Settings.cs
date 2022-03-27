using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MemoryGame
{
    public class Settings
    {
        private String _nick;
        private int time = 5;
        private int size1 = 6;
        private int size2 = 8;
        private string _path;
        private StreamReader _file;
        private StreamWriter _file_;
        private String _json;
        private Dictionary<String, int> _scores;

        public StreamReader File
        {
            get => _file;
            set => _file = value;
        }
        public StreamWriter File_
        {
            get => _file_;
            set => _file_ = value;
        }
        public Dictionary<string, int> Scores
        {
            get => _scores;
            set => _scores = value;
        }

        public void scoresToJson()
        {
            _file.Close();
            _file_= new StreamWriter
                (@"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores1.json");
            String _newScore = JsonConvert.SerializeObject(_scores);
            _file_.Write(_newScore);
            
            _file_.Close();
        }

        public Settings(String nick)
        {
            _nick = nick;
            _path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";
            _file = new StreamReader
                (@"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores1.json");
            _json = _file.ReadToEnd();
            _scores = JsonConvert.DeserializeObject<Dictionary<String, int>>(_json);
            
            _file.Close();
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
        public void Disney()
        {
            Path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Disney\";
        }

        public void Stitch()
        {
            Path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";
        }
    }
}