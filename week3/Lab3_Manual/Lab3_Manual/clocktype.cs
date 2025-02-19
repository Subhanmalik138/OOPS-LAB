using Lab2_Manual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Manual
{
    using System;

    public class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementhours()
        {
            hours++;
        }
        public void incrementminutes()
        {
            minutes++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int elapsedTime(clockType time)
        {
            int elapsedTime = (time.hours * 3600) + (time.minutes * 60) + time.seconds;
            return elapsedTime;
        }
        public int remainingTime(clockType time)
        {
            int remainingTime = (24 * 3600) - elapsedTime(time);
            return remainingTime;
        }
        public int difference(clockType time, int h, int m,int s)
        {
            int time1 = (time.hours * 3600) + (time.minutes * 60) + time.seconds;
            int time2 = (h * 3600) + (m * 60) + s;
            int difference = Math.Abs(time1 - time2);
            return difference;
        }

    }
}


