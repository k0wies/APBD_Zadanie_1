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
    }
}