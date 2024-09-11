using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CalcChallenge
    {
        // Constructor
        public CalcChallenge() { }

        // 1. Add two numbers only
        public int Add_two_numbers(string input)
        {
            int totalResult = 0;
            int variableWithNullValue = 0;
            string[] separators = { "," };
            string[] returnResult = input.Split(separators, StringSplitOptions.None);

            if (returnResult.Length > 2)
            {
                throw new Exception("Numbers cannot be more than 2");
            }
            else
            {
                foreach (string result in returnResult)
                {
                    bool newValue = int.TryParse(result, out variableWithNullValue);
                    if (!newValue)
                    {
                        throw new FormatException($"Invalid number: {result}");
                    }
                    totalResult += variableWithNullValue;
                }
            }
            return totalResult;
        }

        //// 2. Remove maximum constraints for numbers
        public int Add_multiple_numbers(string input)
        {
            int totalResult = 0;
            int variableWithNullValue = 0;
            string[] separators = { "," };
            string[] returnResult = input.Split(separators, StringSplitOptions.None);

            foreach (string result in returnResult)
            {
                bool newValue = int.TryParse(result, out variableWithNullValue);
                if (!newValue)
                {
                    throw new FormatException($"Invalid number: {result}");
                }
                totalResult += variableWithNullValue;
            }

            return totalResult;
        }

        //// 3. Support a new line character delimiter
        public int Add_multiple_numbers_with_new_Delimiter(string input)
        {
            int totalResult = 0;
            int variableWithNullValue = 0;
            string[] separators = { ",", "\n" };
            string[] returnResult = input.Split(separators, StringSplitOptions.None);

            foreach (string result in returnResult)
            {
                bool newValue = int.TryParse(result, out variableWithNullValue);
                if (!newValue)
                {
                    throw new FormatException($"Invalid number: {result}");
                }
                totalResult += variableWithNullValue;
            }

            return totalResult;
        }

        //// 4. Deny negative numbers
        public int Deny_Negative_Numbers(string input)
        {
            int totalResult = 0;
            int variableWithNullValue = 0;
            string[] separators = { ",", "\n" };
            string[] returnResult = input.Split(separators, StringSplitOptions.None);

            foreach (string result in returnResult)
            {
                bool newValue = int.TryParse(result, out variableWithNullValue);
                if (!newValue)
                {
                    throw new FormatException($"Invalid number: {result}");
                }

                if (variableWithNullValue < 0)
                {
                    throw new Exception($"Negative number found: {variableWithNullValue}");
                }

                totalResult += variableWithNullValue;
            }

            return totalResult;
        }

        //// 5. Invalidate values greater than 1000
        //public int Invalidate_Values_Above_1000(string input)
        //{
        //    int totalResult = 0;
        //    int variableWithNullValue = 0;
        //    string[] separators = { "," };
        //    string[] returnResult = input.Split(separators, StringSplitOptions.None);

        //    foreach (string result in returnResult)
        //    {
        //        bool newValue = int.TryParse(result, out variableWithNullValue);
        //        if (!newValue)
        //        {
        //            throw new FormatException($"Invalid number: {result}");
        //        }

        //        if (variableWithNullValue <= 1000)
        //        {
        //            totalResult += variableWithNullValue;
        //        }
        //    }

        //    return totalResult;
        //}

        //// 6. Support one delimiter (e.g., # or ,)
        //public int Add_multiple_numbers_with_One_Delimiter(string input)
        //{
        //    int totalResult = 0;
        //    int variableWithNullValue = 0;
        //    string[] separators = { ",", "\n", "#" };
        //    string[] returnResult = input.Split(separators, StringSplitOptions.None);

        //    foreach (string result in returnResult)
        //    {
        //        bool newValue = int.TryParse(result, out variableWithNullValue);
        //        if (!newValue)
        //        {
        //            throw new FormatException($"Invalid number: {result}");
        //        }
        //        totalResult += variableWithNullValue;
        //    }

        //    return totalResult;
        //}

        //// 7. Support one delimiter of any length (***)
        //public int Add_multiple_numbers_with_Star_Delimiter(string input)
        //{
        //    int totalResult = 0;
        //    int variableWithNullValue = 0;
        //    string[] separators = { ",", "\n", "#", "***", "[***]" };
        //    string[] returnResult = input.Split(separators, StringSplitOptions.None);

        //    foreach (string result in returnResult)
        //    {
        //        bool newValue = int.TryParse(result, out variableWithNullValue);
        //        if (!newValue)
        //        {
        //            throw new FormatException($"Invalid number: {result}");
        //        }
        //        totalResult += variableWithNullValue;
        //    }

        //    return totalResult;
        //}

        //// 8. Support multiple delimiters of any length ([*][!!][r9r])
        //public int Add_multiple_numbers_with_Multiple_Delimiter(string input)
        //{
        //    int totalResult = 0;
        //    int variableWithNullValue = 0;
        //    string[] separators = { ",", "\n", "#", "***", "[***]", "*", "!!", "r9r" };
        //    string[] returnResult = input.Split(separators, StringSplitOptions.None);

        //    foreach (string result in returnResult)
        //    {
        //        bool newValue = int.TryParse(result, out variableWithNullValue);
        //        if (!newValue)
        //        {
        //            throw new FormatException($"Invalid number: {result}");
        //        }
        //        totalResult += variableWithNullValue;
        //    }

        //    return totalResult;
        //}
    }
}
