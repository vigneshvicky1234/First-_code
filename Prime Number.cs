// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Enter your Number");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= a; i++)
{
    if (a % i == 0)
    {
        sum++;
    }
}
if(sum ==2)
{
    Console.WriteLine(a + " is prime number ");
}
else
{
    Console.WriteLine(a + " it is not prime ");
}
