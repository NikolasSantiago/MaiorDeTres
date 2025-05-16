Console.Clear();



Console.Write("Qual sera o Maior dos tres?\n");

Console.Write("Digite o primeiro numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro numero: ");
int n3 = Convert.ToInt32(Console.ReadLine());



int OMaiorNumero;
if (n1 > n2)

{if (n1 > n3)
{OMaiorNumero = n1;}

else
{OMaiorNumero = n3;}
}


else
{if (n2 > n3)
{OMaiorNumero = n2;}

else
{OMaiorNumero = n3;}
}

Console.WriteLine($"\n O Maior numero É: {OMaiorNumero}");

