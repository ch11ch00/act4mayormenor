Console.WriteLine("escriba el primer número"); 
var primernum = Console.ReadLine();
int num1 = int.Parse(primernum);
Console.WriteLine("escriba el segundo número"); 
var segundonum = Console.ReadLine();
int num2 = int.Parse(segundonum);
if (num1 > num2)
{
    Console.WriteLine("el " + num1 + " es mayor que " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("el " + num1 + " es menor que " + num2);
}
else
{
    Console.WriteLine("el " + num1 + " es igual " + num2);
}
if (num2 % 2 == 1)
{
    Console.WriteLine("el " + num2 + " es impar");
}
else
{
    Console.WriteLine("El " + num2 + " es par");
}