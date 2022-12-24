int[,] FillShowArrey(int[,] arr, int rows, int cols, int min, int max)
{
    int[,] arrey = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arrey[i, j] = new Random().Next(min, max + 1);
            Console.Write("    " + arrey[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return arrey;
}
void AveregeCols(int[,] farrey)
{
   

    for (int i = 0; i < farrey.GetLength(0); i++)

    {
        double dif = 0;
        for (int j = 0; j < farrey.GetLength(1); j++)
        {
            dif = farrey[i, j] + dif;
        }
        Console.WriteLine("       Averege of column  "+i+"  =   " + Math.Round(dif/farrey.GetLength(1), 2));
    }


}
Console.WriteLine("input rows :  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input cols :  ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min :  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max :  ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[rows, cols];

int[,] farrey = FillShowArrey(arr, rows, cols, min, max);
AveregeCols(farrey);

