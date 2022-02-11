using System;

namespace robozin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe as dimensões do mapa: ");
            string[] mapa = Console.ReadLine().ToLower().Split();
            int X = Convert.ToInt32(mapa[0]);
            int Y = Convert.ToInt32(mapa[1]);
            int numerorobo = 0;

            while (true)
            {

                numerorobo++;
                Console.WriteLine($"Informe as coordenadas iniciais e direção do robo {numerorobo}: ");
                string[] XYD = Console.ReadLine().Split();
                int robox = Convert.ToInt32(XYD[0]);
                int roboy = Convert.ToInt32(XYD[1]);
                string robodire = XYD[2].ToLower();
                Console.WriteLine("Informe o comando: ex(E= esquerda, D= direita M= mover)");
                string robocomando = Console.ReadLine().ToLower();

                foreach (char item in robocomando)
                {
                    if (item == 'd')
                    {
                        if (robodire == "s")
                        {
                            robodire = "o";
                        }

                        else if (robodire == "n")
                        {
                            robodire = "l";
                        }

                        else if (robodire == "o")
                        {
                            robodire = "n";
                        }

                        else if (robodire == "l")
                        {
                            robodire = "s";
                        }

                    }

                    else if (item == 'e')
                    {
                        if (robodire == "s")
                        {
                            robodire = "l";
                        }

                        else if (robodire == "n")
                        {
                            robodire = "o";
                        }

                        else if (robodire == "l")
                        {
                            robodire = "n";
                        }

                        else if (robodire == "o")
                        {
                            robodire = "s";
                        }


                    }

                    else if (item == 'm')
                    {
                        if (robodire == "s")
                        {
                            roboy--;
                        }

                        else if (robodire == "n")
                        {
                            roboy++;
                        }

                        else if (robodire == "l")
                        {
                            robox++;
                        }

                        else if (robodire == "o")
                        {
                            robox--;
                        }
                    }
                }

                if (X < robox || Y < roboy || roboy < 0 || robox < 0)
                    Console.WriteLine("robo do bolsonaro fora do mapa");


                else
                    Console.WriteLine($"O robo parou em: X: {robox}, Y: {roboy}, Direção: {robodire.ToUpper()}");

            }
        }
    }
}