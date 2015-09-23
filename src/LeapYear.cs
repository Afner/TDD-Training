namespace CSharp.Training
{
    public class LeapYear
    {
        public string LeapYearMethod(int year)
        { 
            if ( year%400 == 0)
            return "LeapYear";
            else if ( year%100 == 0)
            return "Not LeapYear";
            else if ( year%4 == 0 )
            return "LeapYear";
            else
            return "Not LeapYear";
        }
    }
}
