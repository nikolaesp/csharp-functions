// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


int[] arrayinteri = { 2, 6, 7, 5, 3, 9 };

StampaArrayInteri(arrayinteri);
StampaArrayInteri(ElevaArrayAlQuadrato(arrayinteri));
StampaArrayInteri(arrayinteri);
int somma = sommaElementiArray(arrayinteri);
int sommaquadra = sommaElementiArray(ElevaArrayAlQuadrato(arrayinteri));
Console.WriteLine("La somma di array e: " + somma);
Console.WriteLine("La somma di array elevati al quadrato e: " + sommaquadra);




void StampaArrayInteri(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write(array[i] + " , ");
        if (i > 0 && i < array.Length - 1)
        { Console.Write(array[i] + " , "); }
        if (i == array.Length - 1) { Console.Write(array[i]); }
    }
    Console.WriteLine("]");
}

int Quadrato(int numero)
{
    return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }


    return copiaArray;
}

int sommaElementiArray(int[] array)
{

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }


    return sum;
}