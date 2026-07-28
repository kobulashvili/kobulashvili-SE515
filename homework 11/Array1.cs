using homework_11.interfaces;

namespace homework_11
{
    internal class Array1 : IOutput2, ICalc2
    {
        public Array1(int[] collection)
        {
            Collection = collection;
        }

        public int[] Collection { get; set; }

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < Collection.Length; i++)
            {
            bool isDublicated = false;

                for(int j = 0;  j < i; j++)
                {

                   

                    if(Collection[i] == Collection[j])
                    {
                        isDublicated = true;
                        break;
                    }
                }

                if (!isDublicated)
                {
                    count++;
                }

            }
                return count;
        }






        public int EqualToValue(int valueToCompare)
        {
            int count = 0;

            foreach (int i in Collection) {
                if (i == valueToCompare) { count++; }
            }
            return count;
        }





        public void ShowEven()
        {
            
            foreach (var item in Collection)
            {
                if (item == 0)
                {
                    Console.WriteLine("number is 0");                    
                }
                else if(item % 2 == 0)
                {
                    Console.WriteLine($"{item} is even");
                }
            }
        }





        public void ShowOdd()
        {
            foreach (var item in Collection)
            {
                if (item == 0 )
                {
                    Console.WriteLine("number is 0");
                }

                else if(item % 2 == 1)
                {
                    Console.WriteLine($"{item} is odd");

                }
            }


























        }
    }
}
