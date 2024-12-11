// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tables");
int i = 1;
while (i <= 5)
{
    int j = 1;
    while (j <= 10)
    {
        Console.WriteLine(i + "*" + j + "=" + (i * j));
        j++;
    }
    i++;
}
    