using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Validator
{
    class Program
    {
        public static class PeselValidator
        { 
            static void Main(string[] args)
            {
                Console.Write("Podaj numer PESEL: ");
                string pesel = Console.ReadLine();

                Console.WriteLine("Poprawność pesel: " + PeselValidation.ValidatePesel(pesel));

                Console.WriteLine("Data urodzenia: " + DateParse.Date(pesel).ToString("yyyy-MM-dd"));

                Console.WriteLine("Płeć: " + SexCheck.Sex(pesel));
                Console.ReadKey();
            }
        }
    }
}