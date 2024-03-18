namespace Zadanie1
{
    public class Program
    {
        public static double average(int []tab)
        {
            int sum = 0;
            foreach (int i in tab)
            {
                sum += i;
            }
            return sum/tab.Length;
        }

        public static int MaxValue(int[] values)
        {
            if (values.Length>0)
            {
                int max = values[0];
                foreach (int j in values)
                {
                    if (j>max)
                    {
                        max = j;
                    }
                }
                
                return max;
            }

            return 0;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(average([1, 2, 3]));
            Console.WriteLine(MaxValue([4, 5, 6]));
            
        }
        
    }
}//tu miało byc dodanie funkcjonalnoście, ale zrobiłem to wcześniej przez pomyłkę