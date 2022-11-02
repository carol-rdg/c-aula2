using System;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, n5, soma;
        double media;

        Console.Write("Digite um número inteiro ");
        n1 = int.Parse(Console.ReadLine());

         Console.Write("Digite o segundo número ");
         n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número ");
         n3 = int.Parse(Console.ReadLine());

         Console.Write("Digite o quarto número ");
         n4 = int.Parse(Console.ReadLine());

         Console.Write("Digite o quinto número ");
         n5 = int.Parse(Console.ReadLine());


        soma = n1 + n2 + n3 + n4 + n5;
        media = soma / 5.0;

        Console.Write("Soma: " + soma);
         Console.Write("Média: " + media);
      
        Console.ReadKey();

        // raizes e potencia
        //Math.Pow(9,2); // 9 elevado a 2
        //Math.Sqrt(9); // raiz quadrada de 9
        //Math.Sqrt(81,  / 1/3.0)); // raiz cubica




   // public static void Main(string[] args)
    {
        double Hipotenusa, Cateto1, Cateto2;

        Console.Write("Digite um cateto 1: ");
        Cateto1 = double.Parse(Console.ReadLine());

        Console.Write("Digite outro cateto 2: ");
        Cateto2 = double.Parse(Console.ReadLine());

        Hipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
        Console.Write("Resultado da hipotenusa: " + Hipotenusa);
    }
    

}


