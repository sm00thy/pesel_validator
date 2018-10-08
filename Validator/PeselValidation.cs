using System;
namespace Validator
{
    public static class PeselValidation
    {
        private static readonly int[] multipliers = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        public static string ValidatePesel(string pesel)
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

            return toRet ? "Tak" : "Nie";
        }

        private static string CountSum(string pesel)
        {
            int sum = 0;
            for (int i = 0; i < multipliers.Length; i++)
            {
                sum += multipliers[i] * int.Parse(pesel[i].ToString());
            }

            int rest = sum % 10;
            return rest == 0 ? rest.ToString() : (10 - rest).ToString();
        }
    }
}
