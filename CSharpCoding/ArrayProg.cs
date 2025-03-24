using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpCoding
{
    public class ArrayProg
    {
        // Create an array of 5 integers and display its elements.
        public void IntArrayProg()
        {
            int[] IntArrayProg = {1,2,3,4,5 };

            foreach (int number in IntArrayProg)
            { 
                Console.WriteLine(number);
            }
        }
        public void IntArrayReverse()
        {
            int[] IntArrayProg = { 1, 2, 3, 4, 5 };
            int left = 0; int rigth = IntArrayProg.Length - 1;
            while (left < rigth)
            { 
                int temp = IntArrayProg[left];
                IntArrayProg[left] = IntArrayProg[rigth];
                IntArrayProg[rigth] = temp;

                left++;

                rigth--;
            }

            foreach(int numbers in IntArrayProg)
            {
                Console.Write(numbers + " ");
            }
        }

        public void IntArrayReverseRecursion(int[] IntArray, int left, int rigth )
        {
            
            // left = 0;  rigth = IntArray.Length - 1;
            if (left > rigth)
            
                return ;
            int temp = IntArray[left];
            IntArray[left] = IntArray[rigth];
            IntArray[rigth] = temp;
            //left++;

            //rigth--;
            IntArrayReverseRecursion(IntArray, left + 1, rigth - 1); 

        }

    }
}
