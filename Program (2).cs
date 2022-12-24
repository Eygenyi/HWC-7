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
void InArrey(int[,] savearrey, int rows, int cols, int findpozx, int findpozy)
{
    if (findpozx <= rows && findpozy <= cols)
    {
        Console.WriteLine("Search number in massive at x = "+findpozx+"  y= "+ findpozy+"  is  "+savearrey[findpozx-1, findpozy-1]);
    }
    else
    {
        Console.WriteLine("This element not in massive");
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
Console.WriteLine("input to find the element poz x :  ");
int findpozx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input to the find element poz y :  ");
int findpozy = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[rows, cols];

int[,] savearrey = FillShowArrey(arr, rows, cols, min, max);
InArrey(savearrey, rows, cols, findpozx, findpozy);
