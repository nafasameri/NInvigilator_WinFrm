using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInvigilator_WinFrm
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 24)
                    hour = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 60)
                    minute = value;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value < 60)
                    hour = value;
            }
        }
        public Time(int hour, int minute, int second)
        {
            if (hour < 24)
                this.hour = hour;
            if (minute < 60)
                this.minute = minute;
            if (second < 60)
                this.second = second;
        }
        public void Print()
        {
            Console.WriteLine(hour + ":" + minute + ":" + second);
        }
        public static bool operator >(Time f, Time s)
        {
            if (f.hour > s.hour)
                return true;
            else if (f.hour == s.hour)
                if (f.minute > s.minute)
                    return true;
                else if (f.minute == s.minute)
                    if (f.second > s.second)
                        return true;
                    else if (f.second == s.second)
                        return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        public static bool operator <(Time f, Time s)
        {
            if (f.hour < s.hour)
                return true;
            else if (f.hour == s.hour)
                if (f.minute < s.minute)
                    return true;
                else if (f.minute == s.minute)
                    if (f.second < s.second)
                        return true;
                    else if (f.second == s.second)
                        return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        public static bool operator >=(Time f, Time s)
        {
            if (f.hour > s.hour)
                return true;
            else if (f.hour == s.hour)
                if (f.minute > s.minute)
                    return true;
                else if (f.minute == s.minute)
                    if (f.second >= s.second)
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        public static bool operator <=(Time f, Time s)
        {
            if (f.hour < s.hour)
                return true;
            else if (f.hour == s.hour)
                if (f.minute < s.minute)
                    return true;
                else if (f.minute == s.minute)
                    if (f.second <= s.second)
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        private static void Swap(ref Time f, ref Time s)
        {
            Time temp;
            temp = f;
            f = s;
            s = temp;
        }
        public static void sort(Time[] S, Time[] F, string[] Names)
        {
            for (int i = 0; i < F.Length; i++)
                for (int j = i + 1; j < F.Length; j++)
                    if (F[i] > F[j])
                    {
                        Swap(ref F[i], ref F[j]);
                        Swap(ref S[i], ref S[j]);
                        string temp = Names[i];
                        Names[i] = Names[j];
                        Names[j] = temp;
                    }
        }
    }
}
