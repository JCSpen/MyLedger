using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class TimeManagement
    {
    //Variables
    public DateTime today = DateTime.Today;
    public DateTime otherDate = new DateTime();
    string day;
    string month;
    string year;
    public int selectedDay;

    public string convertDT() //Takes date as a string for file naming
                              // "\" causes errors when using as filename
    {
        selectedDay = today.Day;
        day = today.Day.ToString();
        month = today.Month.ToString();
        year = today.Year.ToString();
        return day + "_" + month + "_" + year;
    }

    public string nextDay() //Gets the next day and calls validation
    {
        selectedDay++;
        string output = valiDate(selectedDay, int.Parse(month), int.Parse(year));
        return output;
    }

    public string lastDay() //Gets the next day and calls validation
    {
        selectedDay--;
        string output = valiDate(selectedDay,int.Parse(month), int.Parse(year));
        return output;
    }

    public string valiDate(int day, int month, int year) // Ensures new date is valid
    {
        if (day <= 0)
        {
            switch (month)
            {
                // 30 Days
                case 10:
                    day = 30;
                    break;
                case 5:
                    day = 30;
                    break;
                case 7:
                    day = 30;
                    break;
                case 12:
                    day = 30;
                    break;
                case 3:
                    if (year % 4 == 0)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                case 1:
                    day = 31;
                    year --;
                    break;
            }
            month--;

        }
        else
        {
            if (day > 30)
            {
                switch (month)
                {
                    case 9:
                        day = 1;
                        month++;
                        break;
                    case 4:
                        day = 1;
                        month++;
                        break;
                    case 6:
                        day = 1;
                        month++;
                        break;
                    case 11:
                        day = 1;
                        month++;
                        break;
                }
   
            }
            if (day > 31)
            {
                switch (month)
                {
                    case 1:
                        day = 1;
                        break;
                    case 3:
                        day = 1;
                        break;
                    case 5:
                        day = 1;
                        break;
                    case 7:
                        day = 1;
                        break;
                    case 8:
                        day = 1;
                        break;
                    case 10:
                        day = 1;
                        break;
                    case 12:
                        day = 1;
                        year++;
                        break;
                        
                }
                month++;
            }
            if (day >= 28 && month == 2)
            {
                if(year % 4 == 0 && day == 28)
                {
                    day = 29;
                }
                else
                {
                    month++;
                    day = 1;
                }
            }
        }
        return day + "_" + month + "_" + year;
    }
    }

