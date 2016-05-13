using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class InputUtils
    {
        public const string k_GetBoundedIntFromConsoleTemplate = "Invalid input, please enter a number between {0} and {1} :";
        public const string k_GetIntFromConsoleInvalidMessage = "Invalid input, please enter a number";
        public const string k_GetSepcificCharsFromConsoleInvalidTemplate = "Please enter a charecter from these valid characters: '{0}' ";
        public const string k_GetSepcificCharsFromConsoleExceptionMessage = "Missing valid character params";
        public const string k_GetSingleCharFromConsoleInvalidInputMessage = "Invalid input, Please enter a single character:";
        public const string k_GetBoundedIntOrQuitFromConsoleInvalidTemplate = "Invalid input, please enter a number between {0} to {1} ,or {2} to quit";

        public static int GetBoundedIntFromConsole(int i_min, int i_max)
        {
            int result = GetIntFromConsole();

            while (!IntInBounds(result, i_min, i_max))
            {
                Console.WriteLine(
                    string.Format(k_GetBoundedIntFromConsoleTemplate, i_min, i_max));
                result = GetIntFromConsole();
            }

            return result;
        }

        public static int GetIntFromConsole()
        {
            string userInput = Console.ReadLine();
            int result;

            while (!int.TryParse(userInput, out result))
            {
                Console.WriteLine(k_GetIntFromConsoleInvalidMessage);
                userInput = Console.ReadLine();
            }

            return result;
        }

        /// <summary>
        /// Gets a single  char from console, 
        /// if validChars are given, then only those characters will count as valid input
        /// </summary>
        /// <param name="validChars"></param>
        /// <returns></returns>
        public static char GetSepcificCharsFromConsole(params char[] validChars)
        {
            char result;
            if (validChars.Length > 0)
            {
                string validcharsString = new string(validChars);
                result = GetSingleCharFromConsole();

                while (validcharsString.IndexOf(result) == -1)
                {
                    // TODO: imporve user feedback on invalid input
                    Console.WriteLine(k_GetSepcificCharsFromConsoleInvalidTemplate, validcharsString);
                    result = GetSingleCharFromConsole();
                }
            }
            else
            {
                throw new Exception(k_GetSepcificCharsFromConsoleExceptionMessage);   
            }

            return result;
        }

        /// <summary>
        /// Get a single char from the user (from write line);
        /// </summary>
        /// <returns></returns>
        public static char GetSingleCharFromConsole()
        {
            string userInput = Console.ReadLine();
            while (userInput.Length != 1)
            {
                Console.WriteLine();
                userInput = Console.ReadLine();
            }

            return userInput[0];
        }

        public static int GetBoundedIntOrQuitFromConsole(int i_min, int i_max, char i_QuitGameChar, ref bool io_isQuitSelected)
        {
            string userInput = Console.ReadLine();
            int result = -1;
            
            // string equals the quit char
            // or an int in the wanted bounds
            while (!(StringEqualsChar(userInput, i_QuitGameChar) || (int.TryParse(userInput, out result)
                                                                     && IntInBounds(result, i_min, i_max)))) 
            {
                Console.WriteLine(
                    string.Format(
                        k_GetBoundedIntOrQuitFromConsoleInvalidTemplate,
                        i_min,
                        i_max,
                        i_QuitGameChar));
                userInput = Console.ReadLine();
            }

            if (StringEqualsChar(userInput, i_QuitGameChar))
            {
                io_isQuitSelected = true;
            }

            return result;
        }

        /// <summary>
        /// Check if number is between min and max
        /// </summary>
        /// <param name="i_number"></param>
        /// <param name="i_min"></param>
        /// <param name="i_max"></param>
        /// <returns></returns>
        private static bool IntInBounds(int i_number, int i_min, int i_max)
        {
            return i_min <= i_number && i_number <= i_max;
        }

        /// <summary>
        /// Check if a string is a specific single char
        /// </summary>
        /// <param name="i_string"></param>
        /// <param name="i_char"></param>
        /// <returns></returns>
        private static bool StringEqualsChar(string i_string, char i_char)
        {
            return i_string.Length == 1 && i_char == i_string[0];
        }

        /// <summary>
        /// Returns the selcted enum index value from enum values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int GetEnumSelectionFromType<T>()
        {
            bool isEnum = default(T) is Enum;
            if (!isEnum)
            {
                throw new ArgumentException("The given template type is not an enum");
            }

            Type i_EnumType = typeof(T);
            string[] valueNames = Enum.GetNames(i_EnumType);
            foreach (string valueName in valueNames)
            {
                Console.WriteLine(string.Format("{1:D} - {0} ", valueName, Enum.Parse(i_EnumType, valueName)));
            }
            int selection = InputUtils.GetBoundedIntFromConsole(0, valueNames.Length - 1);
            
            return selection;
        }

        /// <summary>
        /// Get boolean value from user
        /// </summary>
        /// <param name="i_TrueChar"></param>
        /// <param name="i_FalseChar"></param>
        /// <returns></returns>
        public static bool GetBooleanFromConsole(char i_TrueChar, char i_FalseChar)
        {
            char[] validChars = { i_TrueChar, i_FalseChar };
            char selectedChar = GetSepcificCharsFromConsole(validChars);
            return selectedChar == i_TrueChar;
        }

        /// <summary>
        /// Get float from console
        /// </summary>
        /// <returns></returns>
        public static float GetFloatFromConsole()
        {

            string userInput = Console.ReadLine();
            float result;

            while (!float.TryParse(userInput, out result))
            {
                Console.WriteLine(k_GetIntFromConsoleInvalidMessage);
                userInput = Console.ReadLine();
            }

            return result;
        }
    }
}
