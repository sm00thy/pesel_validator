using System;

namespace Validator
{
    class Program
    {
        public static class PeselValidator
        { 
            private static readonly int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            public static bool ValidatePesel(string pesel)
            {
                bool toRet = false;
                try
                {
                    if (pesel.Length == 11)
                    {
                        toRet = CountSum(pesel).Equals(pesel[10].ToString());
                    }
                }
                catch (Exception)
                {
                    toRet = false;
                }
                return toRet;
            }

            private static string CountSum(string pesel)
            {
                int sum = 0;
                for (int i = 0; i < mnozniki.Length; i++)
                {
                    sum += mnozniki[i] * int.Parse(pesel[i].ToString());
                }

                int reszta = sum % 10;
                return reszta == 0 ? reszta.ToString() : (10 - reszta).ToString();
            }

            static void Main(string[] args)
            {
                Console.Write("Podaj numer PESEL: ");
                string pesel = Console.ReadLine();

                Console.WriteLine(ValidatePesel(pesel));
            }
        }
    }
}