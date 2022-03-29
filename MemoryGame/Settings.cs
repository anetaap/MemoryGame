using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MemoryGame
{
    public class Settings
    {
        private int _time = 5;
        private int _showtime = 10;
        private int _size1 = 6;
        private int _size2 = 8;
        private int _scaler = 3;
        private string _path;
        
        private String _nick;
        private String _jsonpath = 
            @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\ScoreFiles\scores1.json";
        
        private StreamReader _fileReader;
        private StreamWriter _fileWriter;
        
        private Dictionary<String, int> _scores;

        public StreamReader File
        {
            get => _fileReader;
            set => _fileReader = value;
        }
        public StreamWriter File_
        {
            get => _fileWriter;
            set => _fileWriter = value;
        }
        public string Jsonpath
        {
            get => _jsonpath;
            set => _jsonpath = value;
        }
        public Dictionary<string, int> Scores
        {
            get => _scores;
            set => _scores = value;
        }
        public int Scaler
        {
            get => _scaler;
            set => _scaler = value;
        }

        public int Showtime
        {
            get => _showtime;
            set => _showtime = value;
        }
        
        public void ScoresToJson()
        {
            _fileReader.Close();
            _fileWriter= new StreamWriter(_jsonpath);
            String newScore = JsonConvert.SerializeObject(_scores);
            _fileWriter.Write(newScore);
            
            _fileWriter.Close();
        }

        public Settings(String nick)
        {
            _nick = nick;
            _path = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";
            _fileReader = new StreamReader(_jsonpath);
            String json = _fileReader.ReadToEnd();
            _scores = JsonConvert.DeserializeObject<Dictionary<String, int>>(json);
            
            _fileReader.Close();
        }

        public int Time
        {
            get => _time;
            set => _time = value;
        }

        public int Size1
        {
            get => _size1;
            set => _size1 = value;
        }        
        public int Size2
        {
            get => _size2;
            set => _size2 = value;
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