// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of rows : ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns");
int j = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[i, j];

Console.WriteLine("Enter array elements: ");
for(int n = 0; n <i; n++)
{
    for (int k = 0; k <j; k++)
    {
        arr[n, k] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("The array elements are : ");
for (int n = 0; n < i; n++)
{
    for (int k = 0; k < j; k++)
    {
        Console.Write(arr[n, k] + " " );
    }
    Console.WriteLine("\n");
}

