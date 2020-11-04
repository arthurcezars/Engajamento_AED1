using System;

class MainClass {
  public static void Main (string[] args) {
    int   numero1, numero2;
    double  soma = 0, nota;

    Console.Write ("Informe um numero: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.Write ("Informe um numero: ");
    numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine ("A soma do numeros é igual a "+ (numero1 + numero2));

    Console.Clear();

    for(int i = 1; i < 5; i++)
    {
      Console.Write ("Informe a nota do bimestre {0}: ", i);
      nota = int.Parse(Console.ReadLine());
      soma = soma + nota;
      if(i == 4)
      {
        Console.WriteLine("A media das notas é igual a: "+ (soma/i));
      }
    }
  }
}