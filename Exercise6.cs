using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ValidDate
    {
        public static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            bool a = IsValidDate(year, month, date);
            Console.WriteLine(a);
        }
        public static bool IsValidDate(int year, int month, int date)
        {
            int odate;
            bool q=true;
            if (year > 0)

            {

                switch (month)
                {
                    case 1:
                        q = checkdate(date, odate = 31);
                        break;
                    case 2:
                        int lep = feb(year);
                        if (date > 0 && date <= lep)
                        {
                            q = true;
                        }
                        else
                        {
                            q = false;
                        }
                        break;
                    case 3: q = checkdate(date, odate = 31); break;
                    case 4: q = checkdate(date, odate = 30); break;
                    case 5: q = checkdate(date, odate = 31); break;
                    case 6: q = checkdate(date, odate = 30); break;
                    case 7: q = checkdate(date, odate = 31); break;
                    case 8: q = checkdate(date, odate = 31); break;
                    case 9: q = checkdate(date, odate = 30); break;
                    case 10: q = checkdate(date, odate = 31); break;
                    case 11: q = checkdate(date, odate = 30); break;
                    case 12: q = checkdate(date, odate = 31); break;
                    default: q = false; break;
                }

            }
            return q;
        }



            public static bool checkdate(int date1, int odate1)
            {
                if (date1 > 0 && date1 <= odate1)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }
            public static int feb(int yer)
            {
                if ((yer % 400) == 0)
                    return (29);
                else if ((yer % 100) == 0)
                    return (28);

                else if ((yer % 4) == 0)
                    return (29);
                else
                    return (28);

            }

    }

}

 
