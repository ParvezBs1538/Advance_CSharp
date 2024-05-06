namespace Advance_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[2][];
            jarr[0] = new int[3] { 1, 2, 3 };
            jarr[1] = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < jarr.Length; i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
