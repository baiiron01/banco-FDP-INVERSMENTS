using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            int b1 = 18, b2 = 19, b3 = 23, b4 = 50, da1000 = 0, da500 = 0, da200 = 0, da100 = 0;
            string nombac = "";

           
            Console.WriteLine("1 BANCO FDP INVERSMENTS");
            Console.WriteLine("2 OTRO  ");
         
            Console.Write("seleccione el banco: ");
            int banco = int.Parse(Console.ReadLine());


            Console.Write("- Digite el monto a retirar: ");
            int monto = int.Parse(Console.ReadLine());

            if (monto % 2 == 0)
            {
                if (banco == 1 && monto <= 20000)
                {
                    nombac = "BANCO FDP INVERSMENTS";
                    if (monto >= 1000)
                    {
                        do
                        {
                            monto -= 1000;
                            da1000 += 1;
                            b1 -= 1;
                        } while (monto >= 1000);
                    }
                    if (monto >= 500)
                    {
                        do
                        {
                            monto -= 500;
                            da500 += 1;
                            b2 -= 1;
                        } while (monto >= 500);
                    }
                    if (monto >= 200)
                    {
                        do
                        {
                            monto -= 200;
                            da200 += 1;
                            b3 -= 1;
                        } while (monto >= 200);
                    }
                    if (monto >= 100)
                    {
                        do
                        {
                            monto -= 100;
                            da100 += 1;
                            b4 -= 100;
                        } while (monto >= 100);

                    }
                }
                else if (banco == 2 && monto <= 10000)
                {
                    nombac = "Otro";
                    if (monto >= 1000)
                    {

                        do
                        {
                            monto -= 1000;
                            da1000 += 1;
                            b1 -= 1;
                        } while (monto >= 1000);
                    }
                    if (monto >= 500)
                    {
                        do
                        {
                            monto -= 500;
                            da500 += 1;
                            b2 -= 100;
                        } while (monto >= 500);
                    }
                    if (monto >= 200)
                    {
                        do
                        {
                            monto -= 200;
                            da200 += 1;
                            b3 -= 1;
                        } while (monto >= 200);
                    }
                    if (monto >= 100)
                    {
                        do
                        {
                            monto -= 100;
                            da100 += 1;
                            b4 -= 100;
                        } while (monto >= 100);

                    }
                }
                else
                {
                    Console.WriteLine("SUPERA LIMITE DE RETIRO");
                }
                Console.Clear();

                if (monto > 1)
                {
                    Console.WriteLine($"GRACIAS POR SU RETIRO EN EL : {nombac} BILLETES RECIBIDO SON: \n" +
                   $"BILLETE DE 1000: {da1000}  \n" +
                   $"BILLETE DE 500: {da500}  \n" +
                   $"BILLETE 200: {da200}  \n" +
                   $"BILLETE 100: {da100}   \n" +
                   $"NO PUDO RETIRAR: {monto} pesos"

                    );
                }
                else
                {

                    Console.WriteLine($"GRACIAS POR SU RETIRO EN EL: {nombac} BILLETES RECIBIDO SON: \n" +
                        $"BILLETE DE 1000: {da1000}  \n" +
                        $"BILLETE DE 500: {da500}  \n" +
                        $"BILLETE 200: {da200}  \n" +
                        $"BILLETE 100: {da100}   \n"

                         );
                }

            }

            Console.ReadKey();

        }
    }
}
