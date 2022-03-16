namespace Matrix
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the rank in the matrix: ");
            var rank = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of raws in the matrix: ");
            var raw = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(rank, raw);

            matrix.FillMatrix();

            for (int i = 0; i < matrix.Mtrx.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.Mtrx.GetLength(0); j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    Console.Write(string.Format("{0} ", matrix.Mtrx[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ForegroundColor = ConsoleColor.White;

            var result = matrix.GetSumOfMatrixMainDiagonal();

            Console.WriteLine("Sum of main diagonal is " + result);
        }
    }
}