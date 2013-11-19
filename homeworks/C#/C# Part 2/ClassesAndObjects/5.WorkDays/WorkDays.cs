using System;
using System.Collections.Generic;



class WorkDays
{
    static int CalculateWorkingDays(DateTime startDate, DateTime endDate,string[]freeDays,string[]notFreeDays)
    {
        int countDays = 0;
        string daysRepInString;
        for (;startDate <= endDate;startDate = startDate.AddDays(1))
        {
            
            if (startDate.DayOfWeek.ToString().Equals("Saturday") || startDate.DayOfWeek.ToString().Equals("Sunday"))
            {
                
                countDays--;
            }
            /////////////////////////////////////////////////
            daysRepInString = startDate.ToShortDateString();
            ////////////////////////////////////////////////
            for (int i = 0; i < freeDays.Length; i++)
			{
                if (daysRepInString.Equals(freeDays[i]))
                {
                    
                    countDays--;
                }
			}

            for (int i = 0; i < notFreeDays.Length; i++)
            {
                if (daysRepInString.Equals(notFreeDays[i]))
                {
                    
                    countDays++;
                }
            }

            countDays++; 
        }
        return countDays;
    }

    /*________________________________________________________________________________*/

    static void Main(string[] args)
    {
        Console.WriteLine("This program shows working days for year of 2013(including today)");
        //string today;
        int workingDays;
        string[] officialUnWorkingDays = {
                                             "1.5.2013 г.",
                                             "2.5.2013 г.",
                                             "3.5.2013 г.",
                                             "6.5.2013 г.",
                                             "24.5.2013 г.",
                                             "6.9.2013 г.",
                                             "24.12.2013 г.",
                                             "25.12.2013 г.",
                                             "26.12.2013 г.",
                                             "31.12.2013 г."
                                         };

        ///////////////////////////////////////////////////////
        string[] officialWorkOutDays = {
                                           "11.5.2013 г.",
                                           "14.12.2013 г."
                                       };
        Console.Write("Starting date is today {0} to (format:dd.mm.yyyy):",DateTime.Now.Date);
        DateTime endDate = new DateTime();
        endDate = DateTime.Parse(Console.ReadLine());
        /////////////////////////////////////////////////////
        //DateTime nowaDays = new DateTime();
        DateTime today = new DateTime();
        today = DateTime.Now.Date;
        /////////////////////////////////////////////////////
        //Console.WriteLine(today);
        //Console.WriteLine(endDate);
        workingDays = CalculateWorkingDays(today, endDate,officialUnWorkingDays, officialWorkOutDays);
        Console.WriteLine(workingDays);
    }
}

