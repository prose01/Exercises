using System.Collections;

namespace Exercises
{
    public class FirstRecurringCharacter
    {
        //Google Question
        //Given an array = [2,5,1,2,3,5,1,2,4]:
        //It should return 2

        //Given an array = [2,1,1,2,3,5,1,2,4]:
        //It should return 1

        //Given an array = [2,3,4,5]:
        //It should return undefined

        public int FindFirstRecurringChar(int[] arr)
        {
            Hashtable itemList = new Hashtable();

            foreach (var item in arr)
            {
                if (itemList.ContainsKey(item))
                {
                    return item;
                }
                itemList.Add(item, true);
            }

            return 0;
        }
    }
    //Bonus... What if we had this:
    // [2,5,5,2,3,5,1,2,4]
    // return 5 because the pairs are before 2,2

}
