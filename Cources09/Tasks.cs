using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09
{
     class Tasks
    {

        public  static void Task1()
         {
             int[] nums = { 12, 43, 5, 4, 24, 5, 67, 5, 3, 55, 65 };
             List<int> res=Method(nums);
            for (int i=0;i<res.Count;i++)
            {
             Console.WriteLine(res[i]);
            }

            Console.WriteLine();
         }

        public static List<int> Method(int[] numbers)
        {
            List<int> result = new List<int>();
            foreach (int i in ListRet(numbers))
            {
                result.Add(i);
            }
            return result;
        }
        public static System.Collections.Generic.IEnumerable<int> ListRet(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i+=2)
            {
                yield return numbers[i];
            }
        }




        public static void Task2()
        {
            MyList<string> testinglist = new MyList<string>();

            testinglist.Add("первый");
            testinglist.Add("второй");
            testinglist.Add("третий");
            testinglist.Add("четвёртый");
            testinglist.Add("пятый");

            
            
            foreach (string val in testinglist)
            {
                Console.WriteLine(val);
            }

            testinglist[2] =  testinglist[0] +" - "+ testinglist[4] + " Всего элементов: "+testinglist.Length.ToString();
            Console.WriteLine(testinglist[2]);

            Console.WriteLine("--- 4. GetArray() ---");
            string[] arr = testinglist.GetArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Task3()
        {
            var dictionary = new MyDictionary.MyDictionary<int, string>();
            dictionary.Add(100, "user");
            dictionary.Add(200, "tester");
           dictionary.Add(300, "developer");
            dictionary.Add(9000, "Somebody");
            try
            {
                dictionary.Add(9000, "Another guy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (MyDictionary.DictionaryElement<int,string> val in dictionary)
            {
                Console.WriteLine(val.Key + " : "+val.Value);
            }

         }

         
    }


}
