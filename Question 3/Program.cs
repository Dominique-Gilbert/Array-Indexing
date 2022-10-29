using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question_3
{
    internal class Program
    {
        public string exit = " ";
        static void Main(string[] args)
        {


                //giving the variable string a value before it is used within the loop.          
                string exit = "nothing";


                //looping the application until the user decides to exit the application using the text exit.
                while (exit != "exit")
                {


                //array values made for the user to pick from.
                    int[] number = { 24, 25, 26, 27, 28 };
                Console.Write("The Range of the array is : ");


                //displaying the range of the array.
                    for (int i = 0; i < number.Length; i++)
                    {
                        Console.Write(number[i] + " ");
                    }
                    Console.WriteLine();


                //making a try catch statement to catch any errors that may occur from user input.
                try
                {


                //asking for user input for a index of the array to be displayed.
                    Console.WriteLine("As seen in the display above that is the list of the array choose which specific Index you'd");
                    Console.WriteLine("like to see by typing in the numbers 1, 2, 3, 4, 5");
                    int num1 = Convert.ToInt32(Console.ReadLine());


                //Displaying the index the user wants to see.
                    Console.WriteLine("The numeric value at this particular index is " + number[num1 - 1]);


                //prompting the user to see if they's like to either exit or continue with the application.
                    Console.WriteLine("If you'd like to restart the app press Enter but if you'd like it to close type in exit");
                    string answer = Console.ReadLine();
                    string newanswer = answer.ToLower();
                    if (newanswer == " ")
                    {

                    }
                    else if (newanswer == "exit")
                    {
                        exit = "exit";

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("What you have entered is not 1, 2, 3, 4, 5");
                    Console.WriteLine("Please enter the fields correctly");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("What you have entered is not 1, 2, 3, 4, 5");
                    Console.WriteLine("Please enter the fields correctly");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("What you have entered is not 1, 2, 3, 4, 5");
                    Console.WriteLine("Please enter the fields correctly");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");

                }
                catch 
                {
                    Console.WriteLine("What you have entered is not 1, 2, 3, 4, 5");
                    Console.WriteLine("Please enter the fields correctly");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********************************************");


                }
            }
            
            
            

        }
    }
}
