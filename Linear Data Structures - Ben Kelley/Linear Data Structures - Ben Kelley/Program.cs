using System;
using System.Collections.Generic;
using System.Linq;

namespace Linear_Data_Structures___Ben_Kelley
{
    class Program
    {
        /// <summary>
        /// Confirms a user entered variable to make sure it is a number
        /// </summary>
        /// <returns>Returns the number after entered correctly</returns>
        public static int Confirm()
        {
            int number;
            string line = Console.ReadLine();
            bool validate = Int32.TryParse(line, out number);
            while (validate != true)
            {
                Console.WriteLine("Please try again");
                line = Console.ReadLine();
                validate = Int32.TryParse(line, out number);
            }
            number = Convert.ToInt32(line);
            return number;
        }

        /// <summary>
        /// Runs the stack exercise. Prints numbers in reverse after entered by the user.
        /// </summary>
        public static void StackExercise()
        {
            Console.WriteLine("How many integers will you enter?");
            int length = Confirm();
            Stack<int> reverse = new Stack<int>();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter an int");
                reverse.Push(Confirm());
            }
            foreach (int number in reverse)
            {
                Console.WriteLine(number);
            }
        }


        /// <summary>
        /// Runs the array exercise. Takes an array and prints out how many times an integer occurs
        /// </summary>
        public static void ArrayExercise()
        {
            int[] array = { 9, 8, 7, 6, 9, 10, 11, 6, 4, 10, 6, 1, 2, 2, 3, 4, 99, 99, 6 };
            int[] array2 = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                if (array2.Contains(array[i]))
                {
                    
                }
                else
                {
                    array2[i] = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {

                        if (array[i] == array[j])
                            count = count + 1;
                    }
                    Console.WriteLine("\t\n " + array[i] + ": " + count + " times");
                }
            }
        }

        /// <summary>
        /// Runs the queue exercise. Gets the first 50 results from a user entered integer using a set of equations.
        /// </summary>
        public static void QueueExercise()
        {
            int i = 1;
            Console.WriteLine("Please enter an int");
            int N = Confirm();
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(N);
            Console.WriteLine("N = " + N);
            while (i <= 50)
            {
                int current = queue.Dequeue();
                Console.WriteLine("S" + i + " = " + current);
                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2);
                i++;
            }
        }

        /// <summary>
        /// Runs the whole program
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the corresponding number\n");
            while (true)
            {
                Console.WriteLine("Would you like to\n1. Run the Stack Exercise\n2. Run the Array Exercise\n3. Run the Queue Exercise\n4. Exit");
                int choice = Confirm();
                if (choice == 1)
                {
                    StackExercise();
                }
                else if (choice == 2)
                {
                    ArrayExercise();
                }
                else if (choice == 3)
                {
                    QueueExercise();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("See ya loser");
                    break;
                }
                else
                {
                    Console.WriteLine("C'mon now enter one of the numbers");
                }
            }
        }
    }
}
