using System;

namespace e_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = Convert.ToInt32(Console.ReadLine()), count_year = 0, date_1, date_2, count_13 = 0;
            string str = "";
            for (int i = 0; i < K; i++)
            {
                if ((str += Console.ReadLine()) != "")
                    if (i != K - 1)
                        str += ".";
            }

            string[] years = str.Split('.'), year;
            for (int i = 0; i < K; i++)
            {
                year = years[i].Split(' ');
                date_2 = Convert.ToInt32(year[1]);
                date_1 = Convert.ToInt32(year[0]);
                if ((count_year = (date_2 > date_1) ? (date_2 - date_1) : (date_1 - date_2)) >= 0)
                    for (int j = 0; j < count_year + 1; j++)
                    {
                        for (int k = 1; k < 13; k++)
                        {
                            if (new DateTime(date_1, k, 13).DayOfWeek.ToString() == "Friday")
                                count_13++;
                        }
                        date_1++;
                    }
            }
            Console.WriteLine(count_13);
        }
    }
}
