using System;
using System.Collections.Generic;
using System.Text;

namespace lab_19_collections
{

    public class CollectionProject
    {
        // have to make static as is for labs 1 and 2
        static int[,,] myCubicArray = new int[11, 11, 11];

        // used for lab 3
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // used for lab 4
        static Queue<int> queue = new Queue<int>();

        // used for lab 5
        static Stack<int> stack = new Stack<int>();

        /*
         
        ### Lab 1 : Cubic Array 10x10x10

        Build a three dimensional array and populate it with numbers 
        which are products of the input numbers.  
        
        Make the size of the cube to be 11x11x11 
        and your numbers will run from 0 at (0,0,0) 
        through 1000 at (10,10,10).  
        
        Numbering starts at 1 here instead of 0.

        Tip : use a loop within a loop within a loop to accomplish this!

        Finally output the value at (2,3,7) and check it has value 2x3x7=42

     */

        public int CubicArray()
        {
            for (int x = 0; x < myCubicArray.GetLength(0); x++)
            {
                for (int y = 0; y < myCubicArray.GetLength(1); y++) 
                {
                    for (int z = 0; z < myCubicArray.GetLength(2); z++)
                    {
                        Console.WriteLine(myCubicArray[x, y, z] = x * y * z);
                    }

                }
         

            }
            return myCubicArray[2, 3, 7];
        }


        /*
         * 
         * 
         * 
                 ### Lab 2 : List

            Create a one-dimensional list of integers called List01.

            Iterate over the three dimensional array above, and for every number in the array, add it to the list.

            Finally add up the total sum of all numbers in the list and output the result.

         */


        public int List()
        {
            List<int> List01 = new List<int>();
            int Sum01 = 0;
            for (int x = 0; x < myCubicArray.GetLength(0); x++)
                {
                    for (int y = 0; y < myCubicArray.GetLength(1); y++)
                    {
                        for (int z = 0; z < myCubicArray.GetLength(2); z++)
                        {
                            List01.Add(x * y * z);
                        Sum01 = Sum01 + x * y * z;
                        }

                    }


                }
            return Sum01;
        }


        /*
         * 
         

            ### Lab 3 : Dictionary

            Create a dictionary of 10 countries as the index, with the capital city as the data.

            Iterate over the data and display it.

            return the completed dictionary to complete the test

         *
         * 
         * 
         */

        public Dictionary<string, string> DictionaryTest() {

            dictionary.Add("England", "London");
            dictionary.Add("Ireland", "Dublin");
            dictionary.Add("Nigeria", "Lagos");
            dictionary.Add("France", "Paris");
            dictionary.Add("Wales", "Cardiff");
            dictionary.Add("Bangladesh", "Dhaka");
            dictionary.Add("India", "New Dehli");
            dictionary.Add("Spain", "Madrid");
            dictionary.Add("Turkey", "Ankara");
            dictionary.Add("Albania", "Tirana");
            
            return dictionary;
        }
        
        

        /*
         * 
         * 
         
           ### Lab 4 : Queue

            Count from 1 to 100 and add the cubes of each number to a queue.  

            Run dequeue 10 times and sum the output

            Return this sum.




         *
         * 
         * 
         */

        public int QueueTest()
        {
            int Sum02 = 0;
            for (int i = 1; i < 101; i++)
            {   
                Console.WriteLine(i);
                queue.Enqueue(i * i * i);
            }

            for (int i = 1; i < 11; i++)
            {
                queue.Dequeue();
                Sum02 = Sum02 + (i * i * i);
            }
            return Sum02;
        }




        /*
        * 
        * 

            ### Lab 5 : Stack

            Repeat this for a stack ie count from 1 to 100, 
            add the cube of each number to the stack, 
            then `pop` 10 items off the top of the stack 
            and sum the output of those 10 numbers.

            Return this sum

        *
        * 
        * 
        */

        public int StackTest()
        {
            int Sum03 = 0;
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                stack.Push(i * i * i);
            }

            for (int i = 91 ; i < 101; i++)
            {
                stack.Pop();

                Sum03 = Sum03 + (i * i * i);
            }
            return Sum03;
        }



    }
}
