using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    internal class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LinearSeachArray<T>(T[] myArray, T target) where T : IComparable<T>
        {

            int i = 0; 
            bool found = false;
            while (!found && i <myArray.Length) // while not found and not end of array 
            {
                if (target.CompareTo(myArray[i])==0)
                    found = true;

                else
                    i++; // if no match move to next element in array 
            }

            if (i<myArray.Length)
                return i; //return index of array element found 

            else 

            return -1; //return -1 if not found. 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearchArray<T>(T[] myArray, T target) where T : IComparable<T>
        {
                int min = 0;
                int max = myArray.Length - 1;
                int mid;
                do
                {
                    mid = (min + max) / 2;
                    if (myArray[mid].CompareTo(target)==0)  //if the item is found return the index mid
                        return mid;
                    if ( myArray[mid].CompareTo(target)==1)  //check if the item wanted is in the top half of the search 
                        min = mid + 1; //the item must be in the upper half, set the min for the search to start at mid +1
                    else
                        max = mid - 1; //otherwise the item must be in the lower half, set max to the mid-1
                } while (min <= max);
                return -1;  // -1 is returned when not found
            }

        //Object of Type <T> in ascending order 
        private static void BubbleSortOfInt(int[] numbers) {
            int temp;
            for (int j = 0; j < numbers.Length - 1; j++) {
                {
                    for (int i = 0; i < numbers.Length - 1; i++) {
                    }
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
        
            