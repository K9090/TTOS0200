using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tekijä: Timo Hakamäki / K9090
 * Alkaen: 12.1.2017
*/

namespace harjoituksia
{
    public class harjoitukset
    {
        public static void harj1()
        {
            int input;

            Console.Write("Insert a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                default:
                    Console.WriteLine("Joku muu luku");
                    break;
            }
        }
        public static void harj2()
        {
            int points;

            Console.Write("Anna pistemäärä: ");
            points = Convert.ToInt32(Console.ReadLine());

            if (points == 0 || points == 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            if (points == 2 || points == 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            if (points == 4 || points == 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            if (points == 6 || points == 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            if (points == 8 || points == 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            if (points == 10 || points == 11 || points == 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            if (points < 0 || points > 12)
            {
                Console.WriteLine("Minimipisteet 0 ja maksimipisteet 12!");
            }
        }
        public static void harj3()
        {
            int luku1, luku2, luku3, summa, keskiarvo;

            Console.WriteLine("Ohjelma laskee syötetyt kolme numeroa yhteen ja laskee niiden keskiarvon.\n");
            Console.WriteLine("Syötä kolme lukua:");
            luku1 = Convert.ToInt32(Console.ReadLine());
            luku2 = Convert.ToInt32(Console.ReadLine());
            luku3 = Convert.ToInt32(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3;

            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
        }
        public static void harj4()
        {
            int ika;

            Console.Write("Syötä ikäsi: ");
            ika = Convert.ToInt32(Console.ReadLine());

            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            if (ika >= 18 && ika < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            if (ika > 65)
            {
                Console.WriteLine("Seniori");
            }
        }
        public static void harj5()
        {
            int SyoteSek, tun, min, sek;

            Console.Write("Syötä haluamasi aika sekunteina: ");
            SyoteSek = Convert.ToInt32(Console.ReadLine());

            tun = SyoteSek / 3600;
            min = (SyoteSek - (3600 * tun)) / 60;
            sek = SyoteSek - (3600 * tun) - (60 * min);
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmaista muodossa: " + tun + " tuntia " + min + " minuuttia " + sek + " sekuntia ");
        }
        public static void harj6()
        {
            double kulutus, hinta, matka;

            Console.Write("Anna matka: ");
            matka = Convert.ToInt32(Console.ReadLine());

            kulutus = (matka / 100) * 7.02;
            hinta = kulutus * 1.595;

            Console.Write("Bensaa kuluu {0:F2}", kulutus);
            Console.Write(" litraa, kustannus {0:F2} euroa", hinta);
            Console.WriteLine();
        }
        public static void harj7()
        {
            int vuosiluku;

            Console.Write("Anna vuosiluku: ");
            vuosiluku = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosiluku))
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
        public static void harj8()
        {
            int[] luku = new int[3];
            Console.WriteLine("Ohjelma näyttää käyttäjän syöttämistä kolmesta numerosta suurimman.\n");
            Console.Write("Anna luku: ");
            luku[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna vielä yksi luku: ");
            luku[2] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(luku);

            Console.WriteLine("\nSuurin luku: " + luku[2] + "\n");
        }
        public static void harj9()
        {
            int luku, summa = 0;

            Console.WriteLine("Ohjelma laskee käyttäjän syöttämät luvut yhteen. \nLukuja voi syöttää, kunnes 0 syötetään. Nollan syöttö näyttää tuloksen.\n");

            do
            {
                Console.Write("Syötä luku: ");
                luku = Convert.ToInt32(Console.ReadLine());
                summa += luku;
            } while (luku != 0);
            Console.WriteLine("Lukujen summa on " + summa + "\n");
        }
        public static void harj10()
        {
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int PariTutka;

            Console.WriteLine("Ohjelma tulostaa taulukosta lukuja, joista se merkkaa parilliset sanalla 'HEP!'\n");
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i]);
                PariTutka = luvut[i] % 2;
                if (PariTutka == 0)
                {
                    Console.Write(" <---- HEP!");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void harj11()
        {
            int RiviMaara, TahtiMaara = 1;

            Console.WriteLine("Ohjelma tulostaa tähtiä, lisäten jokaiselle riville yhden lisää.");
            Console.Write("Anna tähtirivien määrä: ");
            RiviMaara = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < RiviMaara; i++)
            {
                for (int j = 0; j < TahtiMaara; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                TahtiMaara++;
            }
        }
        public static void harj12()
        {
            int[] luku = new int[5];
            Console.WriteLine("Ohjelma kysyy viisi lukua. Nämä luvut ohjelma tulostaa käänteisessä järjestyksessä.\n");

            for (int i = 0; i < luku.Length; i++)
            {
                Console.Write("Anna luku: ");
                luku[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(luku);

            Console.WriteLine();
            Console.Write("Luvut ovat: ");
            for (int i = 0; i < luku.Length; i++)
            {
                Console.Write(luku[i]);
                if (i < luku.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        public static void harj13()
        {
            int[] luku = new int[5];
            int summa;

            Console.WriteLine("Ohjelma kysyy viidet arvostelupisteet mäkihypystä. \nOhjelma laskee pisteet yhteen, mutta jättää suurimman ja pienimmän pisteluvun huomiotta\n");

            for (int i = 0; i < luku.Length; i++)
            {
                Console.Write("Anna pisteet: ");
                luku[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(luku);

            summa = luku[1] + luku[2] + luku[3];
            Console.WriteLine("Kokonaispisteet ovat: " + summa + "\n");

        }
        public static void harj14()
        {
            int Arv0 = 0, Arv1 = 0, Arv2 = 0, Arv3 = 0, Arv4 = 0, Arv5 = 0, syote;

            Console.WriteLine("Ohjelma tulostaa arvosanajakauman tähtinä. \nKäyttäjä syöttää arvosanoja väliltä 0-5. \nLopeta painamalla nro 6 tai isompi.");

            do
            {
                Console.Write("Syötä arvosana: ");
                syote = Convert.ToInt32(Console.ReadLine());
                if (syote == 0)
                {
                    Arv0++;
                }
                if (syote == 1)
                {
                    Arv1++;
                }
                if (syote == 2)
                {
                    Arv2++;
                }
                if (syote == 3)
                {
                    Arv3++;
                }
                if (syote == 4)
                {
                    Arv4++;
                }
                if (syote == 5)
                {
                    Arv5++;
                }

            } while (syote < 6);

            Console.WriteLine("Arvosanat:");
            Console.Write("0: ");
            while (Arv0 > 0)
            {
                Console.Write("*");
                Arv0--;
            }
            Console.WriteLine();
            Console.Write("1: ");
            while (Arv1 > 0)
            {
                Console.Write("*");
                Arv1--;
            }
            Console.WriteLine();
            Console.Write("2: ");
            while (Arv2 > 0)
            {
                Console.Write("*");
                Arv2--;
            }
            Console.WriteLine();
            Console.Write("3: ");
            while (Arv3 > 0)
            {
                Console.Write("*");
                Arv3--;
            }
            Console.WriteLine();
            Console.Write("4: ");
            while (Arv4 > 0)
            {
                Console.Write("*");
                Arv4--;
            }
            Console.WriteLine();
            Console.Write("5: ");
            while (Arv5 > 0)
            {
                Console.Write("*");
                Arv5--;
            }
            Console.WriteLine();
        }
        public static void harj15()
        {
            int RiviMaara, Tyhjaa, Juuri = 2, TahtiMaara = 1;

            Console.WriteLine("Ohjelma tulostaa kuusen. Kuusen korkeuden määrittää käyttäjä ja juureksi uhrataan korkeudesta kaksi kerrosta.");
            Console.Write("Anna kuusen korkeus: ");
            RiviMaara = Convert.ToInt32(Console.ReadLine());
            Tyhjaa = RiviMaara;

            for (int i = 2; i < RiviMaara; i++)
            {
                for (int k = 0; k < Tyhjaa; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < TahtiMaara; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                TahtiMaara = TahtiMaara + 2;
                Tyhjaa--;
            }

            for (int l = 0; l < Juuri; l++)
            {
                for (int i = 0; i < RiviMaara; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                Console.WriteLine();
            }
        }
        public static void harj16()
        {
            int Rand, Input, ArvMaara = 0;
            Random rnd = new Random();

            Console.WriteLine("Ohjelma arpoo luvun väliltä 0-100. \nKäyttäjä arvailee lukua ja ohjelma antaa vinkkejä: \nLuku on suurempi tai Luku on pienempi");
            Rand = rnd.Next(0, 100);

            do
            {
                Console.Write("Arvaa luku: ");
                Input = Convert.ToInt32(Console.ReadLine());

                ArvMaara++;
                if (Input < Rand)
                {
                    Console.WriteLine("Luku on suurempi");
                }
                if (Input > Rand)
                {
                    Console.WriteLine("Luku on pienempi");
                }
            } while (Input != Rand);

            Console.WriteLine("Arvasit oikein!");
            Console.WriteLine("Arvauksiesi määrä: {0}", ArvMaara);
        }
        public static void harj17()
        {
            //Ohjelma yhdistää Array1 ja Array2 sisällöt Array3:een.
            int[] Array1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] Array2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] Array3 = new int[10];
            int j = Array1.Length;

            for (int i = 0; i < Array1.Length; i++)
            {
                Array3[i] = Array1[i];
            }
            for (int i = 0; i < Array2.Length; i++)
            {
                Array3[j] = Array2[i];
                j++;
            }
            //Array3 järjestellään
            Array.Sort(Array3);

            //Array3 tulostetaan järjesteltynä
            for (int i = 0; i < Array3.Length; i++)
            {
                Console.Write(Array3[i]);
                if (i < Array3.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        public static void harj18()
        {
            int OnPalindromi = 1;
            string Input, InputOrg;

            Console.WriteLine("Ohjelma kertoo onko syötetty sana tai lause palindromi.");

            Console.Write("Kirjoita tekstiä: ");

            Input = Console.ReadLine();
            
            InputOrg = Input;

            Console.WriteLine();

            char[] arr = Input.ToCharArray();
            Array.Reverse(arr);
            Input = new string(arr);

            Console.Write("Teksti käännettynä: ");
            
                Console.Write(Input);
            
            Console.WriteLine();

            if (Input != InputOrg)
                {
                    OnPalindromi = 0;
                }
            
            Console.WriteLine();

            if (OnPalindromi != 0)
            {
                Console.WriteLine("Teksti oli palindromi!");
            }
            else
            {
                Console.WriteLine("Teksti ei ollut palindromi!");
            }
            Console.WriteLine();
        }
        public static void harj19()
        {
            //Kesken ja metsässä
            int Tries = 0;
            string Target = "epäilyttävä";
            char Input;

            char[] array = Target.ToCharArray();

            Console.WriteLine("Hirsipuupeli. Arvaa sana kirjain kerrallaan. \nSana on 11 merkkiä pitkä ja kymmenestä väärästä arvauksesta joutuu kiikkuun.");

            for (int i = 0; i < Target.Length; i++)
            {
                Console.Write("Arvaa kirjain: ");
                Input = Convert.ToChar(Console.Read());
                if (Input == array[i])
                {
                    Console.Write("Arvasit kirjaimen {0} oikein!", Input);
                }
                if (Input != array[i])
                {
                    Console.Write("Arvasit kirjaimen {0} väärin!", Input);
                    Tries++;
                }
            }

            if (Tries == 10)
            {
                Console.WriteLine("Hävisit!");
            }
       
            Target = new string(array);
        }
        public static void harj20()
        {
            //Kesken
        }
    }
}

