using System;

namespace ManipulandoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numerosrecebidos = new int[10]; // criação da ARRAY contendo 10 posições


            Console.WriteLine("Digite 10 valores Inteiros: ");



            //Entrada e saida de valores digitados
            AdquirirValores(ref numerosrecebidos);
            Console.WriteLine("\nEsses são os numeros digitados: ");
            MostrarValores(ref numerosrecebidos);


            int MenorNumero;
            MenorNumeroMet(numerosrecebidos, out MenorNumero);
            Console.WriteLine("O menor numero é: " + MenorNumero);


            int maiornumero = 0;
            MaiorNumeroMet(ref numerosrecebidos, ref maiornumero);
            Console.WriteLine("O maior numero é: " + maiornumero);


            Console.WriteLine("A média é : " + MediaDeValores(ref numerosrecebidos));


            int[] x = TresValoresMaiores(ref numerosrecebidos);
            Console.Write("Esses são seus 3 maiores numeros: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }


            int[] arraydenegativos = ValoresNegativos(ref numerosrecebidos);
            Array.Sort(arraydenegativos);
            Console.WriteLine("\nEsses são os numeros negativos: ");
            for (int i = 0; i < arraydenegativos.Length; i++)
            {
                Console.WriteLine(arraydenegativos[i]);
            }
            Console.ResetColor();


            //Retirando numeros da sequência
            Console.WriteLine("Digite o numero que quer retirar: ");
            int numeroselecionado = Convert.ToInt32(Console.ReadLine());
            int[] novoarray = RemoverItemDaSequencia(ref numerosrecebidos, ref numeroselecionado);
            Array.Sort(novoarray);
            Console.WriteLine("Sua nova sequência: ");
            for (int i = 0; i < novoarray.Length; i++)
            {
                Console.WriteLine(novoarray[i]);
            }
            Console.ResetColor();


            static int[] AdquirirValores(ref int[] numerosrecebidos)
            {

                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    numerosrecebidos[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(numerosrecebidos);

                return numerosrecebidos;
            }
            static void MenorNumeroMet(int[] numerosrecebidos, out int MenorNumero)
            {

                MenorNumero = numerosrecebidos[0];

            }
            static void MaiorNumeroMet(ref int[] numerosrecebidos, ref int maiornumero)
            {
                maiornumero = numerosrecebidos[numerosrecebidos.Length - 1];


            }
            static decimal MediaDeValores(ref int[] numerosrecebidos)
            {
                decimal media = 0;

                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    media = numerosrecebidos[i] + media;

                }
                media = media / numerosrecebidos.Length;


                return media;
            }
            static int[] TresValoresMaiores(ref int[] numerosrecebidos)
            {
                int[] valores = new int[3];
                valores[0] = numerosrecebidos[numerosrecebidos.Length - 1]; // posição 9 do array "numerosrecebidos"  
                valores[1] = numerosrecebidos[numerosrecebidos.Length - 2];// posição 8 do array "numerosrecebidos"
                valores[2] = numerosrecebidos[numerosrecebidos.Length - 3];//posição 7 do array "numerosrecebidos"
                Array.Sort(valores);
                return valores;

            }
            static int[] ValoresNegativos(ref int[] numerosrecebidos)
            {
                int totalnumerosnegativos = 0;
                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    if (numerosrecebidos[i] < 0)
                    {
                        totalnumerosnegativos++;
                    }
                    else
                    {

                    }
                }

                int[] arraynegativos = new int[totalnumerosnegativos];
                int j = 0;
                for (int i = 0; i < arraynegativos.Length; i++)
                {
                    if (numerosrecebidos[i] < 0)
                    {
                        arraynegativos[j] = numerosrecebidos[i];
                        j++;
                    }
                    else
                    {

                    }
                }
                return arraynegativos;
            }
            static void MostrarValores(ref int[] numerosrecebidos)
            {
                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    Console.WriteLine(numerosrecebidos[i]);
                }
            }
            static int[] RemoverItemDaSequencia(ref int[] numerosrecebidos, ref int numeroselecionado)
            {

                int reduzir = 0;

                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    if (numerosrecebidos[i] == numeroselecionado)
                    {
                        reduzir++;
                    }
                   
                }
                int[] novoarray = new int[numerosrecebidos.Length - reduzir];
                int j = 0;
                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    if (numerosrecebidos[i] != numeroselecionado)
                    {
                        novoarray[j] = numerosrecebidos[i];
                        j++;
                    }
                    
                }
                return novoarray;
            }


            

        }
    }
}
