//Знаю что надо делать как рекурсия, может не успею поэтому так отправил:(

int n = 21;
int[] massiv = new int[n];
int[] massiv1 = new int[n];
int[] massiv2 = new int[n];
int[] massiv3 = new int[n];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = i;
}
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write(massiv[i] + " ");
}

Console.WriteLine();
Console.WriteLine(massiv[1]);
massiv[1] = 0;
int s=0;
for (int j = 2; j < n ; j++)
{
    for (int i = j+1; i < n; i++)
    {
        if (massiv[i] != 0 && massiv[j]!= 0)
        {
            if (massiv[i] % massiv[j] == 0)
            {
                massiv1[s]=massiv[i];
                massiv[i] = 0;
                s++;

            }
        }
    }

}

   for (int i = 0; i < massiv.Length; i++)
   {
       if (massiv[i] != 0)
       {
           Console.Write(massiv[i] + " ");
       }
   }

for (int j = 0; j < n ; j++)
{
    for (int i = j+1; i < n; i++)
    {
        if (massiv1[i] != 0 && massiv1[j]!= 0)
        {
            if (massiv1[i] % massiv1[j] == 0)
            {
                massiv2[s]=massiv1[i];
                massiv1[i] = 0;
                s++;

            }
        }
    }

}
for (int j = 0; j < n ; j++)
{
    for (int i = j+1; i < n; i++)
    {
        if (massiv2[i] != 0 && massiv2[j]!= 0)
        {
            if (massiv2[i] % massiv2[j] == 0)
            {
                massiv3[s]=massiv2[i];
                massiv2[i] = 0;
                s++;

            }
        }
    }

}




   Console.WriteLine();
   for (int i = 0; i < massiv1.Length; i++)
   {
       if (massiv1[i] != 0)
       {
           Console.Write(massiv1[i] + " ");
       }
   }
     Console.WriteLine();
   for (int i = 0; i < massiv2.Length; i++)
   {
       if (massiv2[i] != 0)
       {
           Console.Write(massiv2[i] + " ");
       }
   }
   