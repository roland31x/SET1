using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace SET1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SET1();
            Console.WriteLine("Aplicatia s-a inchis.");
        }

        private static void SET1()
        {
            Console.WriteLine("SET1 de exercitii in ConsoleApp - Fundamentele programarii 2022 - pali roland\n");
            Console.WriteLine("Apasa orice buton pentru a continua spre meniul de alegere al exercitiilor");
            Console.ReadKey();
            while (true)
            {
                MENU();
                string menubrowser = Console.ReadLine();
                switch (menubrowser.ToLower())
                {
                    case "exit":
                        return;
                    case "1":
                        Start();
                        P1();
                        Finish();
                        break;
                    case "2":
                        Start();
                        P2();
                        Finish();
                        break;
                    case "3":
                        Start();
                        P3();
                        Finish();
                        break;
                    case "4":
                        Start();
                        P4();
                        Finish();
                        break;
                    case "5":
                        Start();
                        P5();
                        Finish();
                        break;
                    case "6":
                        Start();
                        P6();
                        Finish();
                        break;
                    case "7":
                        Start();
                        P7();
                        Finish();
                        break;
                    case "8":
                        Start();
                        P8();
                        Finish();
                        break;
                    case "9":
                        Start();
                        P9();
                        Finish();
                        break;
                    case "10":
                        Start();
                        P10();
                        Finish();
                        break;
                    case "11":
                        Start();
                        P11();
                        Finish();
                        break;
                    case "12":
                        Start();
                        P12();
                        Finish();
                        break;
                    case "13":
                        Start();
                        P13();
                        Finish();
                        break;
                    case "14":
                        Start();
                        P14();
                        Finish();
                        break;
                    case "15":
                        Start();
                        P15();
                        Finish();
                        break;
                    case "16":
                        Start();
                        P16();
                        Finish();
                        break;
                    case "17":
                        Start();
                        P17();
                        Finish();
                        break;
                    case "18":
                        Start();
                        P18();
                        Finish();
                        break;
                    case "19":
                        Start();
                        P19();
                        Finish();
                        break;
                    case "20":
                        Start();
                        P20();
                        Finish();
                        break;
                    case "21":
                        Start();
                        P21();
                        Finish();
                        break;
                    case "22":
                        Start();
                        P22();
                        Finish();
                        break;
                    default:
                        Console.WriteLine("Valoarea introdusa nu apartine criteriului cerut, apasa orice buton pentru a reveni la meniul de selectie!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void MENU()
        {
            Console.Clear();
            Console.WriteLine("SET 1 de exercitii:");
            Console.WriteLine("1. Ecuatia de gradul I");
            Console.WriteLine("2. Ecuatia de gradul II");
            Console.WriteLine("3. Test de divizie");
            Console.WriteLine("4. Test de an bisect");
            Console.WriteLine("5. A 'k'-a cifra luata din sfarsitul numarului");
            Console.WriteLine("6. Test de triunghi");
            Console.WriteLine("7. Swap de variabile");
            Console.WriteLine("8. Swap de variabile ( restrictionat )");
            Console.WriteLine("9. Divizorii unui numar");
            Console.WriteLine("10. Test de primalitate");
            Console.WriteLine("11. Ordine inversa a cifrelor unui numar");
            Console.WriteLine("12. Cate numere intregi sunt divizibile cu 'n' dintr-un interval inchis [a,b]");
            Console.WriteLine("13. Cati ani sunt bisecti dintr-un interval inchis [y1,y2]");
            Console.WriteLine("14. Test palindrom");
            Console.WriteLine("15. 3 numere in ordine crescatoare");
            Console.WriteLine("16. 5 numere in ordine crescatoare ( fara tablouri )");
            Console.WriteLine("17. CMMDC & CMMMC");
            Console.WriteLine("18. Descompunerea in factori prim ai unui numar");
            Console.WriteLine("19. Test numar alcatuit din exact 2 cifre");
            Console.WriteLine("20. Fractia 'm/n' in format zecimal");
            Console.WriteLine("21. Ghiceste un numar intre 1 si 1024 cu intrebari de genul: Numarul este mai mare sau egal decat 'x'? ");
            Console.WriteLine("*22.Calculatorul ghiceste un numarul tau intre 1 si 1024 (ex21 interpretat gresit).");
            Console.WriteLine();

            Console.Write("Introduceti un numar de la 1 la 22 sau 'exit' pentru a iesi din aplicatie: ");
        }
        /// <summary>
        /// Ghiceste numarul tau intre 1 si 1024 prin intrebari
        /// </summary>
        private static void P22() // asta a fost initial raspunsul meu pentru problema 21 dar am interpretat gresit cerinta (cred).
        {
            Console.WriteLine("ex 21: Ghiciti un numar intre 1 si 1024 prin intrebari de forma 'numarul este mai mare sau egal decat x?'.\n ");
            Console.WriteLine("!! Alegetiva un numar intre 1 si 1024 si calculatorul il va ghici raspunzand la intrebarile lui cu: \n'da' sau 'mai mare', 'nu' sau 'mai mic', sau 'egal'.");
            Console.WriteLine();
            string raspuns;
            int n = 512;
            int aux = n; // va repr numarul care este intrebat
            int count = 0; // va repr precizia de intrebare
            int lastnr = 512; // va repr ultimul nr intrebat care se schimba in functie de raspuns
            int lastq = 0; // va repr ultimul nr intrebat ( pentru comparatia cu numarul ultimei intrebari )
            while (aux > 1 && aux <= 1024) // pentru a ghici 1 se raspunde cu nu la fiecare intrebare, pentru 1024 se face o intrebare finala dupa 9 da-uri
            {                
                if (count > 9)
                {
                    count = 9; // daca count > 9 se pierde precizia de cautare, pentru count = 9 fiecare intrebare creste sau decreste cu 1 minim
                }
                if (aux == 1023) // intrebarea finala care decide daca numarul este 1022, 1023 sau 1024, altfel se pierde posibilitatea de a ajunge la 1024
                {
                    Console.WriteLine($"Numarul tau este mai mare sau egal decat {aux} ?");
                    string raspuns1022 = Console.ReadLine();
                    switch (raspuns1022.ToLower())
                    {

                        case "da":
                            {
                                Console.WriteLine($"Numarul tau este {aux + 1} ?");
                                string raspuns1024 = Console.ReadLine();
                                switch (raspuns1024.ToLower()) 
                                {
                                    case "da":
                                        Console.WriteLine($"\nNumarul tau este 1024");
                                        return;
                                    case "nu":
                                        Console.WriteLine($"\nNumarul tau este 1023");
                                        return;
                                    default:
                                        Console.WriteLine("Trebuie sa raspunzi cu 'da' sau 'nu' !");
                                        break;
                                }
                                break;
                            }
                        case "mai mare":
                            {
                                Console.WriteLine($"Numarul tau este {aux + 1} ?");
                                string raspuns1024 = Console.ReadLine();
                                switch (raspuns1024.ToLower())
                                {
                                    case "da":
                                        Console.WriteLine($"\nNumarul tau este 1024");
                                        return;
                                    case "nu":
                                        Console.WriteLine($"\nNumarul tau este 1023");
                                        return;
                                    default:
                                        Console.WriteLine("trebuie sa raspunzi cu 'da' sau 'nu'.");
                                        break;
                                }
                                break;
                            }
                        case "nu":
                            {
                                Console.WriteLine($"\nNumarul tau este 1022");
                                return;
                            }
                        case "mai mic":
                            {
                                Console.WriteLine($"\nNumarul tau este 1022");
                                return;
                            }
                        case "egal":
                            {
                                Console.WriteLine($"\nNumarul tau este 1023");
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Trebuie sa raspunzi cu 'mai mare' sau cu 'da' , 'mai mic' sau cu 'nu', sau 'egal' !");
                                break;
                            }
                    }
                }                            
                else // algoritmul de intrebare care cauta numarul cu precizie crescatoare dupa fiecare raspuns
                {
                    Console.WriteLine($"Numarul tau este mai mare sau egal decat {aux} ?");
                    raspuns = Console.ReadLine();
                    switch (raspuns.ToLower())
                    {

                        case "da":
                            {
                                count++;
                                aux = lastnr + (n / (int)Math.Pow(2, count));
                                lastnr = aux;
                                if (lastq == lastnr)
                                {
                                    Console.WriteLine($"\nNumarul tau este {lastq}");
                                    return;
                                }
                                lastq = lastnr;
                                break;
                            }
                        case "mai mare":
                            {
                                count++;
                                aux = lastnr + (n / (int)Math.Pow(2, count));
                                lastnr = aux;
                                if (lastq == lastnr)
                                {
                                    Console.WriteLine($"\nNumarul tau este {lastq}");
                                    return;
                                }
                                lastq = lastnr;
                                break;
                            }
                        case "nu":
                            {
                                count++;
                                aux = lastnr - (n / (int)Math.Pow(2, count));
                                lastnr = aux;
                                if (lastq == lastnr)
                                {
                                    Console.WriteLine($"\nNumarul tau este {lastq - 1 }");
                                    return;
                                }
                                lastq = lastnr;
                                break;
                            }
                        case "mai mic":
                            {
                                count++;
                                aux = lastnr - (n / (int)Math.Pow(2, count));
                                lastnr = aux;
                                if (lastq == lastnr)
                                {
                                    Console.WriteLine($"\nNumarul tau este {lastq - 1 }");
                                    return;
                                }
                                lastq = lastnr;
                                break;
                            }
                        case "egal":
                            {
                                Console.WriteLine($"\nNumarul tau este {lastnr}");
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Trebuie sa raspunzi cu 'mai mare' sau 'da' , 'mai mic' sau cu 'nu', sau 'egal' !");
                                break;
                            }
                    }
                }
            }
            if (count == 9) 
            {
                Console.WriteLine($"Numarul tau este 1");
            }
        }
        private static void P21()
        {
            Console.WriteLine("21. Ghiceste un numar intre 1 si 1024 cu intrebari de genul: Numarul este mai mare sau egal decat 'x'? ");
            Console.WriteLine();
            Random nr = new Random();
            int ghicit = nr.Next(1, 1024);
            Console.WriteLine("M-am gandit la un numar, incearca sa il ghicesti! Scrie-mi un numar si eu iti raspund daca esti aproape sau nu");
            int nrc = 0;
            while (nrc != ghicit)
            {
                var nrcAsString = Console.ReadLine();
                while (!int.TryParse(nrcAsString, out nrc))
                {
                    Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                    Console.WriteLine();
                    nrcAsString = Console.ReadLine();
                }
                if (nrc < ghicit)
                {
                    if (ghicit - nrc > 100)
                    {
                        Console.WriteLine("Numarul meu este mult mai mare");
                        continue;
                    }
                    if (ghicit - nrc < 10)
                    {
                        Console.WriteLine("Numarul meu este un pic mai mare");
                        continue;
                    }
                    Console.WriteLine("Numarul meu este mai mare");
                }
                if (nrc > ghicit)
                {
                    if (nrc - ghicit > 100)
                    {
                        Console.WriteLine("Numarul meu este mult mai mic");
                        continue;
                    }
                    if (nrc - ghicit < 10)
                    {
                        Console.WriteLine("Numarul meu este un pic mai mic.");
                        continue;
                    }
                    Console.WriteLine("Numarul meu este mai mic");
                }
                if (nrc == ghicit)
                {
                    Console.WriteLine($"Mi-ai ghicit numarul! Este {ghicit}");
                }
            }
        }
        /// <summary>
        /// Afisare fractie de tip m/n in format zecimal cu perioade in paranteza. ( functioneaza pentru perioade pana la 15 cifre lungi )
        /// </summary>
        private static void P20()
        {
            int m, n;
            Console.WriteLine("ex 20: Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). \n");
            Console.Write("m = ");
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out m))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("m = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("n = ");
            var bAsString = Console.ReadLine();
            while (!int.TryParse(bAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                bAsString = Console.ReadLine();
            }
            if (n == 0)
            {
                Console.WriteLine("'n' trebuie sa fie diferit de 0, divizia cu 0 nu exista!");
                return;
            }
            if (m == 0)
            {
                Console.WriteLine($"{m}/{n} in format zecimal este: 0");
                return;
            }
            int semnm = m / Math.Abs(m) ;
            int semnn = n / Math.Abs(n) ;
            int norg = Math.Abs(n);
            int morg = Math.Abs(m);
            m = Math.Abs(m); // m si n iau valori absolute pentru a nu avea probleme cu semn
            n = Math.Abs(n);
            int auxa, auxb, cmmdc; // se simplifica fractia sa fie irreducibila
            if (m > n)
            {
                auxa = m;
                auxb = n;
            }
            else
            {
                auxa = m;
                auxb = n;
            }
            int r;
            while (auxb != 0) // calcul cmmdc pentru simplificarea fractiei.
            {
                r = auxa % auxb;
                auxa = auxb;
                auxb = r;
            }
            cmmdc = auxa;
            if (semnm * semnn < 0)
            {
                Console.WriteLine($"\nFractia introdusa de forma -{morg}/{norg} se poate scrie in forma zecimala astfel: ");
            }
            else
            {
                Console.WriteLine($"\nFractia introdusa de forma {morg}/{norg} se poate scrie in forma zecimala astfel: ");
            }
            m /= cmmdc;
            n /= cmmdc;

            int pintreaga; 
            pintreaga = (int)(m / n);
            // part1 : verificam cazul de fractie fara perioada
            int[] simplecheck = new int[] { 2, 5 };
            int aux = (int)Math.Abs(n);
            for (int i = 0; i < 2; i++) // verifica daca numaratorul se imparte doar cu 2 sau 5
            {
                while (aux % simplecheck[i] == 0)
                {
                    aux /= simplecheck[i];
                }
            //    Console.WriteLine(aux);
            }
            if (aux == 1) // daca aux are valoare 1 inseamna ca numitorul sa impartit de mai multe ori cu 2 sau cu 5, si nu se mai poate imparte cu un alt numar prim
            {
                if (semnm * semnn < 0)
                {
                    Console.Write("-");
                }
                Console.Write($"{(float)((float)m / (float)n)}\n");
                return;
            }
            // part 2 : verificam cazul de fractie periodica simpla
            aux = (int)Math.Abs(n);
            int count = 0;
            for (int i = 0; i < 2; i++) // se verifica daca numitorul se poate imparte cu 2 sau 5 
            {
                while (aux % simplecheck[i] == 0)
                {
                    aux /= simplecheck[i];
                    count++;
                }
                // Console.WriteLine(aux);
            }
           // Console.WriteLine();
          //  Console.WriteLine(count);

            if (count == 0) // daca numitorul nu se poate imparte nici cu 2 nici cu 5 devine periodica simpla
            {
                if (semnm * semnn < 0)
                {
                    Console.Write("-");
                }
                Console.Write($"{pintreaga}.");
                Console.Write("(");
                double prest = m - pintreaga * n;
                int periodlength = 1;
                for (int j = 1; j < 15; j++) // aici se gaseste cat de lung este perioada factiei, pentru o perioada care are o lungime de peste 15 cifre, se pun ... dupa a 15-a cifra pentru a nu intra in probeleme de stocare a valorii
                {
                    if ((Math.Pow(10, j) - 1) % n == 0)
                    {
                        periodlength = j;
                        break;
                    }
                    else periodlength = 15;
                }
                double perioada = (double)Math.Floor(((double)Math.Pow(10, periodlength) * prest) / n); // algoritmul care gaseste perioada din fractie si o stocheaza
                string period1length = Convert.ToString(perioada);
                int periodlengthint = period1length.Length; // aici se pun 0-uri daca perioada incepe cu 0
                while (periodlengthint < periodlength)
                {
                    Console.Write("0");
                    periodlengthint++;
                }
                if (periodlength == 15)
                {
                    Console.Write($"{perioada}...) (perioada este de peste 15 cifre lunga)\n");
                }
                else Console.Write($"{perioada})\n");
                return; 
            }
       //     // part 3 : perioada mixta 
            aux = (int)Math.Abs(n);
            int[] pwr = new int[2];
            for (int i = 0; i < 2; i++) // algoritmul stocheaza de cate ori se imparte numitorul cu 2 sau 5 , si le stocheaza intr-un tablou, acest numar este important pentru a gasi lungimea partii neperiodice
            {
                int count2 = 0;
                while (aux % simplecheck[i] == 0)
                {
                    aux /= simplecheck[i];
                    count2++;
                    pwr[i] = count2;
                }
            }
            if (semnm * semnn < 0)
            {
                Console.Write("-");
            }
            // determinarea lungimii numerelor neperiodice
            Console.Write($"{pintreaga}.");
            
            int neperiodic = pwr.Max(); // lungimea partii neperiodice din numarul cu perioada mixta
            double prestintreg = m - n * pintreaga; // din acesta se va calcula partea neperiodica
            double prestneperiodic = prestintreg*Math.Pow(10, neperiodic); 
            double neperiodiccifra = Math.Floor(prestneperiodic / n); // cifrele neperiodice din numar
            int neperiodiclength = Convert.ToString(neperiodiccifra).Length;
            if (n > m && pwr.Max() > 1) // algoritmul scrie 0-uri dupa punctul zecimal inainte de a calcula perioada
            {
                while (neperiodiclength < pwr.Max())
                {
                    Console.Write("0");
                    neperiodiclength++;
                }
            }
            Console.Write(neperiodiccifra);
            Console.Write("(");
            int periodlength2 = 1;
            for (int j = 1; j < 15; j++) // algoritm de a gasi lungimea perioadei ( in cazul in care perioada este de peste 15 cifre s-ar putea ca algoritmul sa rateze cifra 0 daca perioada incepe cu cifra 0 )
            {
                if ((Math.Pow(10, j) - 1) % aux == 0)
                {
                    periodlength2 = j;
                    break;
                }
                else periodlength2 = 15; // daca perioada este mai lunga decat 15 cifre, calculam primele 15 cifre ale perioadei
            }
            double prest2 = prestintreg - (Math.Pow(10, -neperiodic) * neperiodiccifra * n);  // restul care urmeaza sa fie impartit cu n pentru a gasi perioada
            double perioada2 = (double)Math.Floor((double)Math.Pow(10, periodlength2) * prest2 * Math.Pow(10, neperiodic) / n);
            string period2length = Convert.ToString(perioada2);
            int period2lengthint = period2length.Length; // aici se pun 0-uri daca perioada incepe cu 0
            while (period2lengthint < periodlength2) 
            {
                Console.Write("0");
                period2lengthint++;
            }
            if (periodlength2 == 15)
            {
                Console.Write($"{perioada2}...) (perioada este de peste 15 cifre lunga)\n");
            }
            else Console.Write($"{perioada2})\n");
        } 
        // To-do p20 , sa afiseze perioada mai lunga de 15 cifre 
        /// <summary>
        /// Test pt numar daca are exact 2 cifre care se pot repeta
        /// </summary>
        private static void P19()
        {
            Console.WriteLine("ex 19: Determinati daca un numar e format doar cu 2 cifre care se pot repeta. \n");
            Console.Write("n = ");
            long n;
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            long aux = (long)Math.Abs(n);
            if ( aux < 10)
            {
                Console.WriteLine($"\nNu, in acest caz  numarul este alcatuit dintr-o singura cifra");
                return;
            }
            //int[] cifre = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] nrcifre = new int[10];
            for (int j = 0; j < aAsString.Length; j++)
            {
                int count = 0;
                for (int i = 0; i < nrcifre.Length; i++)
                {
                    if (aux % 10 == i)
                    {
                        count++;
                        nrcifre[i] = count;
                        break;
                    }                   
                //    Console.WriteLine(nrcifre[i]); // pt inregistrarea existentei cifrei in nr introdus
                }
                aux /= 10;

            }
            int countcifre = 0;
            for (int k = 0; k < nrcifre.Length; k++)
            {
                if (nrcifre[k] > 0) countcifre++;

            }
            if (countcifre > 2)
            {
                Console.WriteLine("\nNu , numarul introdus nu este format din doar 2 cifre care se pot repeta.");
            }
            else Console.WriteLine("Da , numarul introdus este format din doar 2 cifre care se pot repeta.");
        }
        /// <summary>
        /// Descompunere in factori primi ( functioneaza pt orice numar pana la int32.maxvalue )
        /// </summary>
        private static void P18()
        {
            /* int n;
            List<int> primeslist = new List<int>();
            int prime = 3;
            primeslist.Add(2);
            primeslist.Add(3);
            // primele 2 nr prime, de aici le genereaza calculatorul
            Console.WriteLine("ex 18: Afisati descompunerea in factori primi ai unui numar 'n'.\n");
            // Console.WriteLine(primes.Count());
            Console.Write("n = ");
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            if (n == 0)
            {               
                Console.WriteLine("Pentru n = 0, descompunerea in factori primi nu exista");
                return;
            }
            while (prime < Math.Sqrt(Math.Abs(n))) // genereaza toate numerele prime necesare descompunerii numarului
            {
                bool isprime = true;
                prime = prime + 2;
                for (int i = 3; i < prime; i++) 
                {
                    if (prime % i == 0)
                    {
                        isprime = false;
                        break;
                    }                                          
                }
                if (isprime)
                {
                    primeslist.Add(prime);
                }
            }
            //pt verificarea elementelor listei
            //for (int i = 0; i < primeslist.Count; i++)
            //{
            //    Console.WriteLine(primeslist[i]);
            //}
            int[] primes = primeslist.ToArray(); // intr-un tablou sa nu avem probleme de indexare
            int[] pwr = new int[primes.Length];
            int semn = n / (int)Math.Abs(n);
            int aux = (int)Math.Abs(n);
            for (int i = 0; i < primes.Length; i++)
            {
                int count2 = 0;
                while (aux % primes[i] == 0)
                {
                    aux /= primes[i];
                    count2++;
                    pwr[i] = count2;
                }
            }
            ////for (int j = 0; j <= 999; j++)
            ////{
            ////    Console.WriteLine(pwr[j]);
            ////}
            Console.Write($"\nDescompunerea in factori primi ai numarului {n} este: \n ");
            if (n < 0)
            {
                Console.Write($"{semn}^1 x");
            }
            int countk = 0;
            for (int k = 0; k < primes.Length; k++)
            {
                if (pwr[k] != 0)
                {                
                    if (countk > 0) Console.Write($"x");
                    Console.Write($" {primes[k]}^{pwr[k]} ");
                    countk++;
                }
            }
            if (aux > 1)
            {   
            Console.Write($"x {aux}^1");
            }
            Console.WriteLine(); */
            int n;
            Console.WriteLine("ex 18: Afisati descompunerea in factori primi ai unui numar 'n'.\n");
            Console.Write("n = ");
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            Console.WriteLine();
            if (Math.Abs(n) <= 1)
            {
                Console.WriteLine("Nu are factori primi!");
                return;
            }
            bool semn = false;
            if (n < 0)
            {
                semn = true;
                n = Math.Abs(n);
            }
            if (semn)
            {
                Console.Write("-1 x");
            }
            bool start = true;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && n > 0)
                {
                    int count = 1;
                    if (start) 
                    { 
                        Console.Write(" " + i); 
                    }
                    else
                    {
                        Console.Write(" x " + i);
                    }
                    start = false;
                    n /= i;
                    while (n % i == 0 && n > 0)
                    {
                        count++;
                        n /= i;
                    }
                    Console.Write($"^{count}");
                }
            }                
        }
        /// <summary>
        /// CMMDC & CMMMC
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("ex 17: Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.\n");
            long a, b, cmmdc, cmmmc, auxa, auxb;
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!\n");
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!long.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou! \n");
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            if (a > b)
            {
                auxa = a;
                auxb = b;
            }
            else
            {
                auxa = b;
                auxb = a;
            }
            long r;
            while ( auxb != 0 )
            {
                r = auxa % auxb;
                auxa = auxb;
                auxb = r;
            }
            cmmdc = auxa;
            cmmmc = (a * b) / cmmdc;            
            Console.WriteLine($"\nCMMDC ({a};{b}) = {cmmdc}");
            Console.WriteLine($"CMMMC ({a};{b}) = {cmmmc}");
        }
        /// <summary>
        /// 5 nr in ordine crescatoare ( fara tablou )
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("ex 16: Se dau 5 numere. Sa se afiseze in ordine crescatoare. ( Fara tablouri )");
            float a, b, c, d, e;
            float min = 0; // minim
            float min2 = 0; // penultim
            float med = 0; // mijloc
            float max2 = 0; // secund
            float max = 0; // maxim
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            Console.Write("c = ");
            var cAsString = Console.ReadLine();
            while (!float.TryParse(cAsString, out c))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("c = ");
                cAsString = Console.ReadLine();
            }
            Console.Write("d = ");
            var dAsString = Console.ReadLine();
            while (!float.TryParse(dAsString, out d))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("d = ");
                dAsString = Console.ReadLine();
            }
            Console.Write("e = ");
            var eAsString = Console.ReadLine();
            while (!float.TryParse(eAsString, out e))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("e = ");
                eAsString = Console.ReadLine();
            }
            if (a < b)
            {
                min = a;
                max = b;
            }
            if (b < a)
            {
                min = b;
                max = a;
            }
            a = min;
            b = max;

            if (c < a) // aici a < b 
            {
                min = c;
                med = a;
            }
            else if (c > b)
            {
                max = c;
                med = b;
            }
            else
            {
                med = c;
            }
            a = min;
            b = med;
            c = max;
            if (d < min) // aici deja a < b < c; 
            {
                min = d;
                med = a;
                max2 = b;
                max = c;
            }
            else if (d > min)
            {
                if (d > max)
                {
                    max = d;
                    max2 = c;
                }
                else if (d > med)
                {
                    max2 = d;
                }
            }
            a = min;
            b = med;
            c = max2;
            d = max;
            if ( e < min ) // de aici valorile sunt odornate astfel : a < b < c < d 
            {
                min = e;
                min2 = a;
            }
            else if ( e > min)
            {
                if (e > max)
                {
                    max = e;
                    max2 = d;
                    med = c;
                    min2 = b;
                }
                else if (e > max2)
                {
                    max2 = e;
                    med = c;
                    min2 = b;
                }
                else if (e > med)
                {
                    med = e;
                    min2 = b;
                }
                else
                    min2 = e;
            }
            //// 
            //a = min;
            //b = min2;
            //c = med;
            //d = max2;
            //e = max;
            //// Astea in cazul in care trebuie o a 6-ea cifra, cele 5 sa fie deja in ordinea a < b < c < d < e
            Console.WriteLine();
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {min} , {min2} , {med} , {max2} , {max}");
        }
        /// <summary>
        /// 3 nr in ordine crescatoare
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("ex 15: Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            float a, b, c;
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            Console.Write("c = ");
            var cAsString = Console.ReadLine();
            while (!float.TryParse(cAsString, out c))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("c = ");
                cAsString = Console.ReadLine();
                Console.WriteLine();
            }
            float[] arr = new float[] {a,b,c};
            Array.Sort(arr);
            Console.WriteLine();
            Console.WriteLine("Valorile introduse in ordine crescatoare sunt:");
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]+" ");
            }
        }
        /// <summary>
        /// test palindrom
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("ex 14: Determianti daca un numar n este palindrom.");
            long n;
            Console.WriteLine();
            Console.Write("n = ");
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            long nr = n;
            long inv = 0;
            while (nr != 0)
            {
                inv = inv * 10 + nr % 10;
                nr /= 10;
            }
            if (n == inv)
                Console.WriteLine($"Numarul {n} este palindrom");
            else Console.WriteLine($"Numarul {n} nu este palindrom");

        }
        /// <summary>
        /// Nr de ani bisecti dintr-un interval
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("ex 13: Determianti cati ani bisecti sunt intre anii 'y1 si y2'.");
            Console.WriteLine();
            Console.Write("y1 = ");
            int an;
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out an))
            {
                Console.WriteLine("Trebuie sa introduci un an! Incearca din nou!");
                Console.WriteLine();
                Console.Write("y1 = ");
                aAsString = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("y2 = ");
            int an2;
            var a2AsString = Console.ReadLine();
            while (!int.TryParse(a2AsString, out an2))
            {
                Console.WriteLine("Trebuie sa introduci un an! Incearca din nou!");
                Console.WriteLine();
                Console.Write("y2 = ");
                a2AsString = Console.ReadLine();
            }
            if (an > an2)
            {
                int x;
                x = an;
                an = an2;
                an2 = x;
            }
            int count = 0;
            for (int i = an; i <= an2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    count++;
                }
                else if (i % 400 == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"In intervalul de ani [{an},{an2}] nu este nici un an bisect");
            }
            else if (count == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"In intervalul de ani [{an},{an2}] este un singur an bisect");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"In intervalul de ani [{an},{an2}] sunt {count} ani bisecti");
            }
        }
        /// <summary>
        /// Returnare fortata ai unui numar diferit de 0
        /// </summary>
        /// <returns></returns>
        private static long P12_1()
        {
            long n;
            Console.Write("n = ");
            var nAsString = Console.ReadLine();
            while (!long.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            if (n == 0)
            {
                Console.WriteLine("'n' trebuie sa fie diferit de 0!");
                n = P12_1();
                return n;
            }
            return n;
        }
        /// <summary>
        /// Test divizie cu un numar dintr-un interval
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("ex 12: Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
            Console.WriteLine();
            long a, b, n;
            long count = 0;
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!long.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            if (a > b)
            {
                long x;
                x = a;
                a = b;
                b = x;
            }
            Console.Write("n = ");
            var nAsString = Console.ReadLine();
            while (!long.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            if (n == 0)
            {
                Console.WriteLine("'n' trebuie sa fie diferit de 0!");
                n = P12_1();
            }
            for (long i = a; i <= b; i++)
            {
                if (i % n == 0)
                    count++;
            }
            if (count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($" In intervalul [{a},{b}] nu exista nici un numar divizibil cu {n}");
            }
            else if (count == 1)
            {
                Console.WriteLine();
                Console.WriteLine($" In intervalul [{a},{b}] exista un numar divizibil cu {n}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" In intervalul [{a},{b}] sunt {count} numere divizibile cu {n}");
            }
        }
        /// <summary>
        /// Inversarea ordinii cifrelor
        /// </summary>
        private static void P11()
        {
            long n;
            Console.WriteLine("ex 11: Afisati in ordine inversa cifrele unui numar 'n'");
            Console.WriteLine();
            Console.Write("n = ");
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            Console.Write($"\nCifrele in ordine inversa a numarului {n} sunt: ");
            long nr = Math.Abs(n); // inversez cifrele fara semn
            long inv = 0;
            long nr0 = Math.Abs(n);
            while (nr0 % 10 == 0) // pentru a scrie 0-urile daca numarul se termina in unul sau mai multe 0-uri
            {
                nr0 /= 10;
                Console.Write("0");
            }
            while (nr != 0)
            {
                inv = inv * 10 + nr % 10;
                nr /= 10;
            }
            Console.Write($"{inv}"); // habar nu am daca ar trebui cu semn sau nu
        }
        /// <summary>
        /// Test de primalitate
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("ex 10: Test de primalitate: determinati daca un numar 'n' este prim.");
            Console.WriteLine();
            Console.Write("n = ");
            int n; 
            var nAsString = Console.ReadLine();
            while (!int.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            int div = (int)Math.Abs(n);
            if (div < 2)
            {
                Console.WriteLine();
                Console.WriteLine($"Numarul {n} nu este prim");
                return;
            }
            if (div % 2 == 0 && div != 2)
            {
                Console.WriteLine();
                Console.WriteLine($"Numarul {n} nu este prim");
                return;
            }
            for (int i = 3; i <= Math.Sqrt(div); i++)
            {
                if (div % i == 0)
                {
                    Console.WriteLine($"Numarul {n} nu este prim");
                    return;
                }               
            }
                Console.WriteLine();
                Console.WriteLine($"Numarul {n} este prim");
        }
        /// <summary>
        /// Afisare toti divizori
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("ex 9: Afisati toti divizorii numarului 'n'");
            Console.WriteLine();
            Console.Write("n = ");
            long n;
            var nAsString = Console.ReadLine();
            while (!long.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            long div = (long)Math.Abs(n);
            Console.WriteLine($"Divizorii lui {n} sunt:");
            Console.Write("+-1");
            for (long i = 2; i <= div; i++)
            {
                if (div % i == 0)
                {
                    Console.Write($" , +-{i}");
                }
            }
        }
        /// <summary>
        /// Swap de variabile fara variabila extra
        /// </summary>
        private static void P8()
        {
            float a, b;
            Console.WriteLine("ex 8: (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine();
            Console.WriteLine("Variabilele inversate cu succes!");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
        /// <summary>
        /// Swap de variabile simpla
        /// </summary>
        private static void P7()
        {
            float a, b, x;          
            Console.WriteLine("ex 7: (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            x = a;
            a = b;
            b = x;
            Console.WriteLine();
            Console.WriteLine("Variabilele inversate cu succes!");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
        /// <summary>
        /// Returnare fortata a unui nr pozitiv
        /// </summary>
        /// <returns></returns>
        private static float P6_3()
        {
            float c;
            Console.WriteLine();
            Console.Write("c = ");
            var cAsString = Console.ReadLine();
            while (!float.TryParse(cAsString, out c))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("c = ");
                cAsString = Console.ReadLine();
            }
            if (c <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                c = P6_3();
            }
            return c;
        }
        /// <summary>
        /// Returnare fortata a unui nr pozitiv
        /// </summary>
        /// <returns></returns>
        private static float P6_2()
        {
            float b;
            Console.WriteLine();
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            if (b <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                b = P6_2();
            }
            return b;
        }
        /// <summary>
        /// Returnare fortata a unui nr pozitiv
        /// </summary>
        /// <returns></returns>
        private static float P6_1()
        {
            float a;
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            if (a <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                a = P6_1();
            }
            return a;
        }
        /// <summary>
        /// Test de triunghi
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("ex 6: Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            float a, b, c;
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            if (a <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                a = P6_1();
            }
            Console.WriteLine();
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            if (b <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!!");
                b = P6_2();
            }
            Console.WriteLine();
            Console.Write("c = ");
            var cAsString = Console.ReadLine();
            while (!float.TryParse(cAsString, out c))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                Console.WriteLine();
                Console.Write("c = ");
                cAsString = Console.ReadLine();
            }
            if (c <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trebuie sa introduci un numar pozitiv diferit de 0! Incearca din nou!");
                c = P6_3();
            }
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine();
                Console.WriteLine($"Numerele {a} , {b} , {c} pot forma un triunghi");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Numerele {a} , {b} , {c} nu pot forma un triunghi");
            }
        }
        /// <summary>
        /// A 'k'-a cifra dintr-un numar, citit de la dreapta la stanga
        /// </summary>
        private static void P5()
        {
            long numar;
            long cifra = 0;
            Console.WriteLine("ex 5: Extrageti si afisati a 'k' - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
            Console.WriteLine();
            Console.Write("numar = ");
            var aAsString = Console.ReadLine();
            while (!long.TryParse(aAsString, out numar))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("numar = ");
                aAsString = Console.ReadLine();
            }
            int k;
            Console.WriteLine();
            Console.Write("k = ");
            var kAsString = Console.ReadLine();
            while (!int.TryParse(kAsString, out k))
            {
                Console.WriteLine("Trebuie sa introduci un numar intreg! Incearca din nou!");
                Console.WriteLine();
                Console.Write("k = ");
                kAsString = Console.ReadLine();
            }
            long aux = (long)Math.Abs(numar);
            long aux2 = aux;
            int count = 1;
            while (aux2 > 1)
            {
                aux2 /= 10;
                count++;
            }
            if (k <= count)
            {
                for (int i = 1; i <= k; i++)
                {
                    cifra = aux % 10;
                    aux /= 10;
                }
                Console.WriteLine();
                Console.WriteLine($"A {k}-a cifra luata din sfarsitul numarului {numar} este {cifra}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"A {k}-a cifra luata din sfarsitul numarului {numar} nu exista, k fiind mai mare decat lungimea numerelor de cifre ai numarului.");
            }
        }
        /// <summary>
        /// Test de an bisect
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("ex 4: Detreminati daca un an 'y' este an bisect.");
            Console.WriteLine();
            Console.Write("y = ");
            int an;
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out an))
            {
                Console.WriteLine("Trebuie sa introduci un an! Incearca din nou!");
                Console.WriteLine();
                Console.Write("y = ");
                aAsString = Console.ReadLine();
            }
            if (an % 4 == 0 && an % 100 != 0)
            {
                Console.WriteLine();
                Console.WriteLine($" {an} este un an bisect");
            }
            else if (an % 400 == 0)
            {
                Console.WriteLine();
                Console.WriteLine($" {an} este un an bisect");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" {an} este un an obisnuit");
            }

        }
        /// <summary>
        /// Test de divizie 2 numere
        /// </summary>
        private static void P3()
        {
            float n, k;
            Console.WriteLine("ex 3: Determinati daca 'n' se divide cu 'k', unde 'n' si 'k' sunt date de intrare.");
            Console.WriteLine();
            Console.Write("n = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("k = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out k))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("k = ");
                bAsString = Console.ReadLine();
            }
            if (k == 0)
                Console.WriteLine("'k' trebuie sa fie diferit de 0, divizia cu 0 nu exista!");
            else
            {
                if (n % k == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{n} este divizibil cu {k}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{n} nu este divizibil cu {k}");
                }
            }
        }
        /// <summary>
        /// Ecuatia de GR2
        /// </summary>
        private static void P2()
        {
            float a, b, x, c, d, delta, CDelta, x1, x2;
            Console.WriteLine("ex 2: Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            Console.Write("c = ");
            var cAsString = Console.ReadLine();
            while (!float.TryParse(cAsString, out c))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("c = ");
                cAsString = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Ecuatia de gradul II introdus este: {a}x^2 + {b}x + {c} = 0");
            Console.WriteLine();
            d = b * b - (4 * a * c);
            if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("0 = 0 adevarat pentru orice x necunoscut.");
            else if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                        Console.WriteLine("Fiindca a = 0 si b = 0 ecuatia nu are solutie.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Fiindca a = 0, ecuatie devine de grad I: {b}x + {c} = 0");
                    x = -c / b;
                    Console.WriteLine($"Cu solutia: x = {x}");
                }
            }
            else
            {
                delta = (float)Math.Sqrt(d);
                CDelta = (float)Math.Sqrt(Math.Abs(d));
                if (d > 0)
                {
                    x1 = (-b + delta) / (2 * a);
                    x2 = (-b - delta) / (2 * a);
                    Console.WriteLine("Solutiile ecuatiei sunt: ");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else
                {
                    if (d == 0)
                    {
                        x = -b / (2 * a);
                        Console.WriteLine("Solutia ecuatiei este: ");
                        Console.WriteLine($"x1 = x2 = {x}");
                    }
                }
                if (d < 0)
                {
                    float x1C, x2C;
                    x1 = -b / (2 * a);
                    x1C = CDelta / (2 * a);
                    x2 = -b / (2 * a);
                    x2C = -CDelta / (2 * a);

                    Console.WriteLine($"Ecuatia are radacini complexe:");
                    Console.WriteLine($"x1 = {x1} + {x1C}i ");
                    Console.WriteLine($"x2 = {x2} + {x2C}i ");
                }
            }

        }
        /// <summary>
        /// Ecuatia de GR1
        /// </summary>
        private static void P1()
        {
            float a, b, x;
            Console.WriteLine("ex 1: Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine();
            Console.Write("a = ");
            var aAsString = Console.ReadLine();
            while (!float.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write("b = ");
            var bAsString = Console.ReadLine();
            while (!float.TryParse(bAsString, out b))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("b = ");
                bAsString = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Ecuatia de gradul I introdus este: {a}x + {b} = 0");
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Solutia ecuatiei este:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                if (b != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ecuatia nu are solutie daca coeficientul necunoscutei este 0");
                }
                else
                    Console.WriteLine("0 = 0 adevarat pentru orice x necunoscut.");
            }
        }

        private static void Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Pentru a reveni la meniul de selectie apasati orice buton.");
            Console.ReadKey();
        }
        private static void Start()
        {
            Console.Clear();
        }
    }
}

