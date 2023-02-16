int a = 34;
int b = 5;
int resalt = a % b;

if(resalt == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.Write("Не кратно, остаток ");
    Console.WriteLine(resalt);
}
