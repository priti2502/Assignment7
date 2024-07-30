namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = [-1, -3];

            //int[] A = [1, 2, 3];

            int[] A = [5, 3, -6, -4, 10, 2];

            Solution solution = new Solution();

            int min=solution.solution(A);

            Console.WriteLine("Square of Minimum Integer is: "+ (min*min));

        }
    }
}
