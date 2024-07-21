//Crea un array e inserta los números pares del 1 al 100 en ese array.
int[] numerosPares = new int[50];
int k = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        numerosPares[k] = i;
        k++;
    }
}