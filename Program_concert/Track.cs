using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program_concert
{
    public class Track
    {
        //Название 1genre2 жанр -> time время
        public string name;
        public List<string> genre;
        public int time_seconds;
        public string time;
        public Track(string new_track)
        {
            Regex regex = new Regex(@"^(.*) 1genre2 (.*) -> time (.*)$");
            var match = regex.Match(new_track);
            name = match.Groups[1].Value;
            genre = match.Groups[2].Value.Split('&').ToList();
            time = match.Groups[3].Value;
            time_seconds = toSeconds(time);
        }
        public Track()
        {
            name = "";
            genre = new List<string>();
            time = "";
            time_seconds = 0;
        }
        public string toMinutes() => $"{time_seconds/60}:{time_seconds%60}";
        public int toSeconds(string time)
        {
            try
            {
                Tuple<int, int> t = new Tuple<int, int>(int.Parse(time.Split(':')[0]), int.Parse(time.Split(':')[1]));
                return t.Item1 * 60 + t.Item2;
            }
            catch (Exception) {
                Console.WriteLine("Error from parse time to seconds");
                return 0;
            }
        }
        public override string ToString() => $"{name} 1genre2 {String.Join("&", genre.ToArray())} -> time {time}";
        public override bool Equals(object obj) => name.Equals(((Track)obj).name); 
        public override int GetHashCode() => name.GetHashCode();
    }
}