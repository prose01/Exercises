using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises
{
    public class ContainsCommonItem
    {
        // Given 2 arrays, create a function that let's a user know (true/false) whether these two arrays contain any common items
        //For Example:
        //const array1 = ['a', 'b', 'c', 'x'];//const array2 = ['z', 'y', 'i'];
        //should return false.
        //-----------
        //const array1 = ['a', 'b', 'c', 'x'];//const array2 = ['z', 'y', 'x'];
        //should return true.

        // 2 parameters - arrays - no size limit
        // return true or false

        public bool containsCommonItem(char[] arr1, char[] arr2)
        {
            for (var i = 0; i < arr1.Length; i++)
            {
                for (var j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool containsCommonItem2(char[] arr1, char[] arr2)
        {
            // loop through first array and create object where properties === items in the array
            // can we assume always 2 params?

            Dictionary<char, bool> map =  new Dictionary<char, bool>();
            for (var i = 0; i < arr1.Length; i++)
            {
                if (!map.ContainsKey(arr1[i]))
                {
                    var item = arr1[i];
                    map.Add(item, true);
                }
            }
            // loop through second array and check if item in second array exists on created object. 
            for (var j = 0; j < arr2.Length; j++)
            {
                if (map.ContainsKey(arr2[j]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool containsCommonItem3(char[] arr1, char[] arr2)
        {
            return arr1.Any(item => arr2.Contains(item));
        }
    }
}
