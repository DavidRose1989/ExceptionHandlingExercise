using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // done - First create an char[], it must contain 6 numbers and 3 letters - name it arr

            var arr = new char[] { 'D', 'A', 'R', '1', '9', '8', '9', '3', '3' };

            // done - Create a list called numbers that will hold integers

            List<int> numbers = new List<int>();                                      //Same as var numbers = new List<int>();

            // done - Create an string variable with an empty string initializer - name it str

            var str = "";

            // done - using a foreach loop, attempt to parse the elements in your char[] with int.Parse()

            foreach (var item in arr)
            {
                try
                { 
                    str = item.ToString();               //You need to convert a char to a string before you can parse to a int. The .ToString method will convert char to string.
                                                         //you need to attempt to Parse the items in the arr array. You can only parse integers and not letters. 
                    numbers.Add(int.Parse(str));         //The letter's char[] in item that were converted to a string cannot be parsed because they're not integers. 
                }                                        //They cannot be parsd and the catch(Exception) will catch that. 
                catch (Exception)
                {

                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // done - Make a foreach loop to iterate through your character array

            //done - Now create a try catch


            // Inside your try block
            // done - set your string variable to each array element in your char[] to .ToString()
            // done - Now, using int.Parse, parse your string variable and store in an int variable
            // done - Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //done - Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



        }
    }
}
