using System;

namespace CloudyDay
{
    public class Validator
    {
        public static bool ValidIntValue(string inputValue)
        {
            int intValue;

            if (!int.TryParse(inputValue, out intValue))
            {
                return false;
            }

            if (intValue < 1 || intValue > 100000)
            {
                return false;
            }

            return true;
        }

        public static bool ValidLongValues(string inputValues)
        {
            long[] values = new long[] { };
            bool done = false;
            Int64 intValue;
            while (!done)
            {
                if (!string.IsNullOrWhiteSpace(inputValues) && inputValues.Split(' ').Length > 0)
                {
                    try
                    {
                        foreach (var value in inputValues.Split(' '))
                        {
                            if (Int64.TryParse(value, out intValue))
                            {
                                done = true;
                            }
                        }
                        return done;
                    }
                    catch (System.Exception) { }
                }
            }
            return done;
        }

        public static bool ValidTownPopulations(string value, int towns)
        {
            int intValue;
            if (int.TryParse(value, out intValue))
            {
                return false;
            }

            if (intValue < 1 || intValue > 10000000)
            {
                return false;
            }

            return true;
        }

        internal static bool Match(int amount, int lenght)
        {
            return amount == lenght;
        }
    }
}