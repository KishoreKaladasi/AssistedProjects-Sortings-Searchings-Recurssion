using System;

namespace AssistedProjectsSortingsSearchingsRecurssion

{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            Console.WriteLine("Enter marks to search and press Enter:");
            string input = Console.ReadLine();
            int search;
            bool isValidInput = Int32.TryParse(input, out search);

            if (isValidInput)
            {
                bool found = false;

                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] == search)
                    {
                        Console.WriteLine(marks[i] + " was found at location " + i);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Invalid marks. Please enter valid marks of the student.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for marks.");
            }

            Console.ReadLine();
        }
    }
}
