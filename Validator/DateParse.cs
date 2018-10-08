using System;
namespace Validator
{
    public static class DateParse
    {
        public static DateTime Date(string pesel)
        {
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));


            if (month > 80)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 20)
            {
                year += 2000;
                month -= 20;
            }
            else if (month > 40)
            {
                year += 2100;
                month -= 40;
            }
            else
            {
                year += 1900;
            }

            DateTime birth = new DateTime(year, month, day);

            return birth.Date;

        }
    }
}
