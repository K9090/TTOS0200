using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Timon lottokone v.1.1
//11.1.2017
//Toinen lisäkommentti, tuosta!
namespace lottokone
{
    class Program
    {
        static void Main()
        {
            int[] lottorivi = new int[7]; /*Alkiot 0-6*/
            int i, x, j, apu, maara, RiviNro = 0;
            bool OnArvottu = false;

            //srand(time(NULL));
            Random rnd = new Random();

            Console.Write("Syötä arvottavien lottorivien määrä: ");
            maara = Convert.ToInt32(Console.ReadLine());

            for (apu = 0; maara > 0; maara--)
            {
                // Ensin arvotaan
                for (i = 0; i < 7; i++)
                {
                    x = rnd.Next(1, 40);

                    // Pitää tarkistaa, että kelpaako arvottu numero
                    // Käydään aiemmin arvotut numerot läpi:
                    for (j = 0; j < i; j++)
                    {
                        if (lottorivi[j] == x)
                        {
                            OnArvottu = true;
                        }
                    }
                    if (OnArvottu)
                    {
                        // Pitää arpoa uudestaan:
                        i--;
                        OnArvottu = false;
                    }
                    else
                    {
                        // KELPAA:
                        lottorivi[i] = x;
                    }

                }

                //Järjestellään pieneimmästä suurimpaan
                for (i = 6; i >= 1; i--)
                {
                    for (j = 0; j <= i - 1; j++)
                    {
                        if (lottorivi[j] > lottorivi[j + 1])
                        {
                            apu = lottorivi[j];
                            lottorivi[j] = lottorivi[j + 1];
                            lottorivi[j + 1] = apu;
                        }
                    }
                }
                RiviNro++;
                // Sitten tulostetaan
                Console.WriteLine("\n" + RiviNro + ". Rivi: ");
                for (i = 0; i < 7; i++)
                {
                    if (i <= 5)
                        Console.Write(lottorivi[i] + ", ");

                    else
                        Console.Write(lottorivi[i] + "\n\n");
                }

                if (OnArvottu)
                {
                    Console.WriteLine("RIVISSA OLI KAKSI SAMAA NUMEROA!!! ARVO UUDET!!!" + " \n\n");
                }
            }
        }
    }
}