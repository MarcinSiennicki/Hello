using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.AvgRating();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();
            
            for (; ; )
            {
                Console.WriteLine("Podaj ocene 1 : 10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);            

                if (rating == 11)
                {
                    break;
                }
                if (result == true)
                {
                    if (rating > 0 && rating < 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                        Console.WriteLine("Niepoprawna liczba");
                }
            }

            Console.WriteLine("srednia twoich ocen " + diary.AvgRating());
            Console.WriteLine("maxymalna ocena " + diary.GiveMaxRating());
            Console.WriteLine("minimalna ocena" + diary.GiveMinRating());

            Console.ReadKey();
        }
    }
}
