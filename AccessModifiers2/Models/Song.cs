using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2.Models
{
    public class Song
    {
        private string _name;
        private string _genre;
        public float rating;
        public float[] ratings;

        public int n = 12;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _name = value;
                }
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
                {
                    _genre = value;
                }
            }
        }
        public Singer Singer
        {
            get;
            set;

        }
    

        public float AddRating(float[] ratings)
        {
            this.ratings =ratings;
            float Avg=0;
            
            for (int  i = 0; i < ratings.Length; i++)
            {
                Avg = ratings[0];
                Avg = Avg / 2 + ratings[i] / 2;
            }
            return Avg;       
        }
        public void GetAverageRating()
        {
            Console.WriteLine(AddRating(ratings));
        }
    }
    }



