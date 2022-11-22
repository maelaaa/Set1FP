using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1FP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Rezolvati ecuatia de gradul I cu o necunoscuta: ax+b = 0");
            Console.WriteLine("2. Rezolvati ecuatia de gradul II: ax^2+bx+c=0");
            Console.WriteLine("3. Determinati daca n se divide cu k");
            Console.WriteLine("4. Detreminati daca un an y este an bisect");
            Console.WriteLine("5. Afisarea cifrei k dintr-un numar, de la dreapta la stanga");
            Console.WriteLine("6. Verificare daca 3 nr pozitive a, b si c pot fi lungimile laturilor unui triunghi");
            Console.WriteLine("7. Inversarea a 2 valori");
            Console.WriteLine("8. Inversarea a 2 valori fara alte variabile");
            Console.WriteLine("9. Afisarea tuturor divizorilor lui n");
            Console.WriteLine("10. Verificare numar prim");
            Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n");
            Console.WriteLine("12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
            Console.WriteLine("13. Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("14. Determianti daca un numar n este palindrom");
            Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare");
            Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare");
            Console.WriteLine("17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere; se foloseste alg. lui Euclid");
            Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.");
            Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta");
            Console.WriteLine("20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul)");
            Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\"");
            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    P1();
                    break;
                case 2:
                    P2();
                    break;
                case 3:
                    P3();
                    break;
                case 4:
                    P4();
                    break;
                case 5:
                    P5();
                    break;
                case 6:
                    P6();
                    break;
                case 7:
                    P7();
                    break;
                case 8:
                    P8();
                    break;
                case 9:
                    P9();
                    break;
                case 10:
                    P10();
                    break;
                case 11:
                    P11();
                    break;
                case 12:
                    P12();
                    break;
                case 13:
                    P13();
                    break;
                case 14:
                    P14();
                    break;
                case 15:
                    P15();
                    break;
                case 16:
                    P16();
                    break;
                case 17:
                    P17();
                    break;
                case 18:
                    P18();
                    break;
                case 19:
                    P19();
                    break;
                case 20:
                    P20();
                    break;
                case 21:
                    P21();
                    break;
                
            }
        }
       
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// folosesc cautarea binara
        /// </summary>
        private static void P21()
        {
            Console.WriteLine("Introduceti:");
            Console.WriteLine("1, daca numarul este mai mare");
            Console.WriteLine("-1, daca numarul este mai mic");
            Console.WriteLine("10, daca numarul a fost gasit");
            Console.WriteLine();
            int s, d, mij;
            s = 1;
            d = 1024;
            mij = (s + d) / 2;
            Console.WriteLine($"cum este valoarea fata de {mij}?");
            
            int k = int.Parse(Console.ReadLine());
            if (k == 10)//adica nr e gasit
                Console.WriteLine($"Valoarea cautata este {mij}");
            else
            {
                while (k != 10 && s <= d)
                {
                    if (k == 1)//adica daca nr e mai mare
                        s = mij + 1;
                    else
                        d = mij - 1;
                    mij = (s + d) / 2;
                    Console.WriteLine($"cum este valoarea fata de {mij}?");
                    k = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Valoarea la care te gandesti este {mij}");
            }
        }

        /// <summary>
        /// Afiseaza fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul)
        /// O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        /// O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        /// O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5
        /// </summary>
        /// <example>13/30 = 0.4(3)</example>
        private static void fractie2(int m,int n)
        {
            // TODO aducem fractia la forma ireductibila. 
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        private static void P20()
        {
            Console.WriteLine("Introduceti numaratorul si numitorul fractiei");
            int m = int.Parse(Console.ReadLine());//numarator
            int n = int.Parse(Console.ReadLine());//numitor

            int p2 = 0, p5=0, aux;
            aux = n;
            if ((float)m / n == (int)m / n)
                Console.WriteLine($"fractie cu rezultat intreg= {m / n}");
            else
            {
                while (aux % 2 == 0)
                {
                    p2++;
                    aux /= 2;
                }
                while (aux % 5 == 0)
                {
                    p5++;
                    aux /= 5;
                }
                if (aux == 1)
                    Console.WriteLine($"fractie neperiodica: {(float)m / n}");
                else
                    if (p2 != 0 || p5 != 0)
                {
                    Console.WriteLine($"fractie periodica mixta:");
                    fractie2(n, m);
                }
                else
                {

                    Console.WriteLine($"fractie periodica simpla: ");
                    fractie2(m, n);
                }
            }
        }

        /// <summary>
        /// Determina daca un numar e format doar cu 2 cifre care se pot repeta
        /// </summary>
        /// <example>De ex. 23222 sau 9009000 sunt astfel de numere </example>
        /// <example>593 si 4022 nu sunt.</example>
        private static void P19()
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            int c1, c2, c3, uc;
            c2 = c3 = -1;
            c1 = n % 10;
            n /= 10;
            while(n!=0)
            {
                uc = n % 10;
                if (c2 == -1 && uc!=c1)
                    c2 = uc;
                if (c3 == -1 && uc != c2 && uc!=c1)
                    c3 = uc;
                n /= 10;
            }
            if (c2 == -1)
                Console.WriteLine("numarul este format din cifre identice");
            else
                if(c3==-1)
                    Console.WriteLine("numarul este format doar din 2 cifre distincte");
                else
                    Console.WriteLine("numarul este format din mai mult de 2 cifre distincte");
        }

        /// <summary>
        /// descompune nr in factori primi
        /// </summary>
        /// <example>n = 1176 afisati 2^3 x 3^1 x 7^2. </example>
        private static void P18()
        {
            Console.WriteLine("Introduceti numarul");
            int n=int.Parse(Console.ReadLine());
            int nrp, d=2;
            while(n>1)
            {
                nrp = 0;
                while(n%d==0)
                {
                    nrp++;
                    n /= d;
                }
                if (nrp != 0)
                    if (n != 1)
                    {
                        if (nrp != 1)
                            Console.Write($"{d}^{nrp} x ");
                        else
                            Console.Write($"{d} x ");
                    }
                    else
                    {
                        if (nrp != 1)
                            Console.WriteLine($"{d}^{nrp}");
                        else
                            Console.WriteLine($"{d}");
                    }
                d++;
            }
        }

        /// <summary>
        ///  Determiana cel mai mare divizor comun si cel mai mic multiplu comun a doua numere
        ///  se foloseste algoritmul lui Euclid
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("Introduceti cele 2 valori");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cmmdc, cmmmc, r, aux1, aux2;
            aux1 = a;
            aux2 = b;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            cmmdc = a;
            cmmmc =( aux1*aux2) / cmmdc;
            Console.WriteLine($"cel mai mare divizor comun: {cmmdc}");
            Console.WriteLine($"cel mai mic multimplu comun: {cmmmc}");

            ///cmmdc prin scaderi repetate
            ///while(a!=b)
            ///{
            ///   if(a>b)
            ///     a=a-b;
            ///   else
            ///     b=b-a;
            ///}
            ///cw: a;
        }

        /// <summary>
        /// ordoneaza 5 nr 
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("Introduceti cele 5 valori");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int t;
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (a > c)
            {
                t = a;
                a = c;
                c = t;
            }
            if (a > d)
            {
                t = a;
                a = d;
                d = t;
            }
            if (a > e)
            {
                t = a;
                a = e;
                e = t;
            }
            if (b > c)
            {
                t = b;
                b = c;
                c = t;
            }
            if (b > d)
            {
                t = b;
                b = d;
                d = t;
            }
            if (b > e)
            {
                t = b;
                b = e;
                e = t;
            }
            if (c > d)
            {
                t = c;
                c = d;
                d = t;
            }
            if (c > e)
            {
                t = c;
                c = e;
                e = t;
            }
            if (d > e)
            {
                t = d;
                d = e;
                e = t;

            }
            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }

        /// <summary>
        /// ordoneaza 3 numere crescator
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("Introduceti cele 3 valori");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minim;
            minim = a;
            if (b < minim)
            {
                minim = b;
            }
            if (c < minim)
            {
                minim = c;
            }
            int maxim;
            maxim = a;
            if (b > maxim)
            {
                maxim = b;
            }
            if (c > maxim)
            {
                maxim = c;
            }

            Console.WriteLine($"{minim} {a + b + c - minim - maxim} {maxim}");
            /*
            minim = Math.Min(a, Math.Min(b, c));
            maxim = Math.Max(b, Math.Max(c, a));
            Console.WriteLine($"{minim} {a + b + c - minim - maxim} {maxim}");
             */
        }

        /// <summary>
        /// verifica daca un nr este palindrom
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            int pal=0, aux;
            aux = n;
            while(aux!=0)
            {
                pal = pal * 10 + aux % 10;
                aux /= 10;
            }
            if (pal == n)
                Console.WriteLine("este palindrom");
            else
                Console.WriteLine("nu este palindrom");
        }

        /// <summary>
        /// Determiana cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("Introduceti cei 2 ani");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nr=0,y;
            for (y = y1; y <= y2; y++)
                if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                    nr++;
            Console.WriteLine(nr);

        }

        /// <summary>
        /// Determina cate nr divizibile cu n exista in [a,b]
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("Introduceti capetele intervalului [a,b] si valoarea n");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nr;
            nr = (b - a - 1) / n;
            if (a % n == 0)
                nr++;
            if (b % n == 0)
                nr++;
            Console.WriteLine(nr);

        }

        /// <summary>
        /// afiseaza cifrele unui numar in ordine inversa
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            while(n!= 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// verifica daca un nr este prim
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            if (n < 2)
            {
                Console.WriteLine("Nu e prim");
            }
            else
                if (n == 2)
            {
                Console.WriteLine("E prim");
            }
            else
            {
                for (int d = 2; d * d <= n; d++)
                {
                    if (n % d == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim == true)
                    Console.WriteLine("E prim");
                else
                    Console.WriteLine("Nu e prim");
            }

        }

        /// <summary>
        /// Afiseaza toti divizorii unui numar
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("Introduceti numarul");
            int n=int.Parse(Console.ReadLine());
            int d;
            for (d = 1; d <= n / 2; d++)
                if (n % d == 0)
                    Console.Write($"{d} ");
            Console.WriteLine(n);
        }

        /// <summary>
        /// (Swap restrictionat) Inversarea a 2 valori fara utilizarea altor variabile
        /// </summary>
        private static void P8()
        {
            Console.WriteLine($"Introduceti cele 2 valori a si b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            //(a, b) = (b, a); ALTERNATIVA MAI BUNA 

            Console.WriteLine($"{a} {b}");
        }

        /// <summary>
        /// interschimba 2 valori cu ajutorul instructiunii SWAP
        /// </summary>
        private static void P7()
        {
            Console.WriteLine($"Introduceti cele 2 valori a si b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"{a} {b}");
        }

        /// <summary>
        /// Verificare daca 3 nr pozitive a, b si c pot fi lungimile laturilor unui triunghi
        /// </summary>
        private static void P6()
        {
            Console.WriteLine($"Introduceti laturile a, b, c ale triunghiului");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < b + a)
                Console.WriteLine("da");
            else
                Console.WriteLine("nu");
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("Introduceti n si a k-a cifra");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nr = 0;
            while(n!=0)
            {
                nr++;
                if(nr==k)
                {
                    Console.WriteLine(n % 10);
                    break;
                }
                n /= 10;
            }
        }

        /// <summary>
        /// Determina daca un an e bisect
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("Introduceti anul");
            int y=int.Parse(Console.ReadLine());
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");
        }

        /// <summary>
        /// Determina daca n se divide cu k
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("Introduceti n, k");
            int n=int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (k != 0)
            {
                if (n % k == 0)
                    Console.WriteLine($"{n} se divide cu {k}");
                else
                    Console.WriteLine($"{n} nu se divide cu {k}");
            }
            else
                Console.WriteLine("eroare; k=0");
        }
        /// <summary>
        /// Rezolva ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("Introduceti parametrii ecuatiei ax^2+bx+c");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c=  int.Parse(Console.ReadLine());
            int delta;
            float x1, x2,x;
            bool i = false;

            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (float)((-b) - Math.Sqrt(delta) / 2 * a);
                x2 = (float)((-b) + Math.Sqrt(delta) / 2 * a);
                Console.WriteLine($"x1= {x1} x2= {x2}");
            }
            else
                if (delta == 0)
            {
                x = (float)-b / 2 * a;
                Console.WriteLine($"x1=x1= {x}");
            }
            else
            {
                Console.WriteLine("Nu exista solutii reale");
                i = true;
            }
            if(i==true)
            {
                Console.WriteLine("Apasati 1 pentru a afla solutiile complexe, 0 in caz contrar");
                int k = int.Parse(Console.ReadLine());
                if (k == 1)
                {
                    Console.WriteLine($"x1= ({-b}+i*{Math.Sqrt(Math.Abs(delta))})/{2*a}");
                    Console.WriteLine($"x2= ({-b}-i*{Math.Sqrt(Math.Abs(delta))})/{2*a}");
                }
                /*else
                    if (k == 0)
                         return;*/
                
            }
        }
        
        /// <summary>
        /// Rezolva ecuatia de gradul I cu o necunoscuta
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine($"Introduceti parametrii a,b ai ecuatiei ax+b=0 pe randuri separate");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            float x;
            if (a != 0)
            {
                x =(float) -b / a;
                Console.WriteLine($"x= {x}");
            }
            else
                if (b == 0)
                     Console.WriteLine("Exista o infinitate de solutii");
                else
                     Console.WriteLine("Nu exista solutie reala");
        }
    }
}
