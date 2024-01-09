using System;

namespace Lab4_CSS_1
{
    public class IntArray
    {
        private int[] intArray;
        private int n;

        public IntArray(int n)
        {
            try
            {
                if (n == 0)
                {
                    Console.WriteLine("array size must be > 0");
                    return;
                }
                this.n = n;
                intArray = new int[n];
            }
            catch
            {
                Console.WriteLine("array size must be > 0");
            }
        }

        public void Enter()
        {
            Console.WriteLine("Enter the array elements with one space:");
            while (true)
            {
                try
                {
                    string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (numbers.Length == n)
                    {
                        for (int i = 0; i < n; i++)
                            intArray[i] = Convert.ToInt32(numbers[i]);
                        break;
                    }
                    else
                        Console.WriteLine("You entered more numbers or less than the array can store!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Print()
        {
            foreach (int i in intArray)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }

        public int Size
        {
            get { return intArray.Length; }
        }

        private int scalar;
        public int Scalar
        {
            set
            {
                scalar = value;
                for (int i = 0; i < n; i++)
                    intArray[i] *= scalar;
            }
            get { return scalar; }
        }
    }
}
