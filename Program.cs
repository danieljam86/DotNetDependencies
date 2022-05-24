int valor = 0;
int[] array = {1, 2, 3, 4, 5};
int resto = 0;

foreach(int i in array)
{
    resto = i % 2;
    if(resto == 0)
    {
        valor += i;
        Console.WriteLine(valor);
    }
    
}

Console.WriteLine("O valor total de números pares é: " +valor);