using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<float> ratings = new List<float>();

        /// <summary>
        /// dodawanie oceny
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// oblicznie sredniej
        /// </summary>
        /// <returns></returns>
        public float AvgRating()
        {
            float sum = 0, avg = 0;
            foreach (var item in ratings)
            {
                sum = +item;
            }
            avg = sum / ratings.Count();
            return avg;
        }
        /// <summary>
        /// wyswietla max
        /// </summary>
        /// <returns>max</returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        /// <summary>
        /// wyswietla min
        /// </summary>
        /// <returns>Min</returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
