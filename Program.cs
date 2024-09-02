using static System.Console; 
int [] numeros = new int[5];
WriteLine("Digite 5 numeros. ");
WriteLine("Pressione ENTER para cada número digitado.....");
for(int n = 0; n < numeros.Length; n++)
{
    numeros[n] = Convert.ToInt32(ReadLine());
}
Clear();
WriteLine("---------------------------------------");
WriteLine("          Estes são os numeros         ");
WriteLine("---------------------------------------");
for (int i = 0; i < numeros.Length; i++)
{
    WriteLine(numeros[i]);
}
ReadKey();
