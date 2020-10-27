using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDayOfWeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetDayOfWeeks(DateTime.Now);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// Tra ve thu trong tuan dua vao ngay truyen vao
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GetDayOfWeeks(DateTime? date)
        {
            var strDayOfWeek = string.Empty;
            if (date != null)
            {
                switch (date.Value.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        strDayOfWeek = "Sunday"; break;
                    case DayOfWeek.Monday:
                        strDayOfWeek = "Monday"; break;
                    case DayOfWeek.Tuesday:
                        strDayOfWeek = "Tuesday"; break;
                    case DayOfWeek.Wednesday:
                        strDayOfWeek = "Wednesday"; break;
                    case DayOfWeek.Thursday:
                        strDayOfWeek = "Thursday"; break;
                    case DayOfWeek.Friday:
                        strDayOfWeek = "Friday"; break;
                    case DayOfWeek.Saturday:
                        strDayOfWeek = "Saturday"; break;
                }
            }
            return strDayOfWeek;
        }

    }

    
}
