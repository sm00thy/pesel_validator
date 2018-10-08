using System;
namespace Validator
{
    public static class SexCheck
    {
        public static string Sex(string pesel)
        {
            int sex = int.Parse(pesel.Substring(9, 1));

            if (sex % 2 == 0)
            {
                return "Kobieta";
            }
            return "Mężczyzna";
        }
    }
}
