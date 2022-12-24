void FillShowArrey(double[,] arr, int rows, int cols)
{
    double[,] arrey = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arrey[i, j] = new Random().NextDouble() * 10;
            Console.Write("    " + Math.Round((arrey[i, j]), 3));
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
Console.WriteLine("input rows :  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input cols :  ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[rows, cols];
FillShowArrey(arr, rows, cols);