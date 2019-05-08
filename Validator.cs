using System;

namespace CloudyDay
{
    public class Validator
    {
        public static bool ValidInt64Value(string inputValue)
        {
            Int64 Int64Value;

            if (!Int64.TryParse(inputValue, out Int64Value))
            {
                return false;
            }

            if (Int64Value < 1 || Int64Value > 100000)
            {
                return false;
            }

            return true;
        }

        public static bool ValidLongValues(string inputValues)
        {
            long[] values = new long[] { };
            bool done = false;
            Int64 Int64Value;
            while (!done)
            {
                if (!string.IsNullOrWhiteSpace(inputValues) && inputValues.Split(' ').Length > 0)
                {
                    try
                    {
                        foreach (var value in inputValues.Split(' '))
                        {
                            if (Int64.TryParse(value, out Int64Value))
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

        public static bool ValidTownPopulations(string value, Int64 towns)
        {
            Int64 Int64Value;
            if (Int64.TryParse(value, out Int64Value))
            {
                return false;
            }

            if (Int64Value < 1 || Int64Value > 10000000)
            {
                return false;
            }

            return true;
        }

        public static bool Match(Int64 amount, Int64 lenght)
        {
            return amount == lenght;
        }
    }
}