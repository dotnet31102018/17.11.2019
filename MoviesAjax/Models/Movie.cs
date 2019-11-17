using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies1711.Models
{
    public class Movie 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rank { get; set; }
        public string Genre { get; set; }
        public Movie()
        {

        }

        public Movie(int id, string name, int year, int rank, string genre)
        {
            Id = id;
            Name = name;
            Year = year;
            Rank = rank;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Year} {Rank} {Genre}";
        }
    }
}