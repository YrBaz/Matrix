namespace Matrix
{
    public class Matrix
    {
        public int[,] Mtrx { get; }

        public Matrix(int rank, int raw)
        {
            Mtrx = new int[rank, raw];
        }

        public void FillMatrix()
        {
            Random rnd = new Random();

            for (int i = 0; i < Mtrx.GetLength(1); i++)
            {
                for (int j = 0; j < Mtrx.GetLength(0); j++)
                {
                    Mtrx[i, j] = rnd.Next(0, 9);
                }
            }
        }

        public int GetSumOfMatrixMainDiagonal()
        {
            int sum = 0;

            for (int i = 0; i < Mtrx.GetLength(1); i++)
            {
                for (int j = 0; j < Mtrx.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        sum += Mtrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
