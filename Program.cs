using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fundamentele_Programarii
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
            //P22();
            //P23();
            //P24();
            //P25();
            //P26();
            //P27();
            //P28();
            //P29();
            //P30();
            //P31();
            //P32();
            //P33();
            //P34();
            //P35();
            //P36();
            //P37();
            //P38();
            //P39();
            //P40();
            //P41();
            //P42();
            //P43();
            //P44();
            //P45();
            //P46();
            //P47();
            //P48();
            //P49();
            //P50();
            //P51();
            //P52();
            //P53();
            //P54();
            //P55();
            //P56();
            //P57();
            //P58();
            //P59();
            //P60();
            //P61();
            //P62();
            //P63();
            //P64();
            //P65();
            //P66();
            //P67();
            //P68();
            //P69();
        }

        /// <summary>
        /// Se dau înălțimile a n copii, numerotați de la 1 la n, exprimate prin numere naturale. Afișați 
        /// numerele de ordine ale copiilor în ordinea crescătoare a înălțimii lor.
        /// </summary>
        private static void P69()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[100];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]); // citim cele n inaltimi
            }

            int minv,poz;

            for (int j = 0; j < n; j++)
            {
                minv = int.MaxValue;
                poz = -1;
                for (int i = 0; i < n; i++)
                {
                    if (v[i] < minv)
                    {
                        minv = v[i]; // Aflam minimul din vector
                        poz = i;  // poz este pozitia elementului minim
                    }
                }
                if (poz != -1)
                {
                    Console.Write($"{poz + 1} "); // Afisam pozitia minimului
                    v[poz] = int.MaxValue;  //Punem pe pozitia minimului o valoare mare pentru a afla urmatorul minim
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se citește un șir cu n numere naturale. Să se verifice dacă prin rearanjarea elementelor șirului se 
        /// poate obține un șir palindrom.
        /// </summary>
        private static void P68()
        {
            int n, k1 = 0, maxim = -1;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            int[] frecventa = new int[10000];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                frecventa[v[i]]++; // punem in vectorul frecventa numarul de aparitii a fiecarui element
                if (v[i] > maxim)  // determinam elementul maxim din vector pentru eficienta
                    maxim = v[i];
            }
            // parcurgem vectorul de frecventa
            for (int i = 0; i < maxim; i++)
            {
                if (frecventa[i] % 2 == 1)
                    k1++;
            }
            // pentru ca sirul sa fie palindrom trebuie sa existe maxim un element care apare o singura data in vector
            if (k1 == 0 || k1 == 1)
                Console.WriteLine("Sirul poate fi rearanjat astfel incat sa se obtina un sir palindrom");
            else
                Console.WriteLine("Sirul nu poate fi rearanjat astfel incat sa se obtina un sir palindrom");
        }

        /// <summary>
        /// Să se scrie un program care ordonează crescător elementele din prima jumătate a unui vector 
        /// și descrescător elementele din a doua jumătate.
        /// </summary>
        private static void P67()
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            // citim vectorul
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            // ordonam crescător elementele din prima jumătate a vectorului
            for (int i = 0; i < n / 2; i++)
                for (int j = i + 1; j < n / 2; j++)
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            // ordonam descrescător elementele din a doua jumătate a vectorului
            for (int i = n / 2; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            // afisam vectorul
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// CRB are un șir cu n numere naturale diferite. Nu știe ce să facă cu ele și le aranjează în ordine 
        /// descrescătoare. Apoi observă că anumite numere se află pe aceeași poziție ca în șirul inițial.
        /// Ajutați pe CRB să determine câte elemente din șir respectă această regulă.
        /// </summary>
        private static void P66()
        {
            int n, cate = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            int[] poz = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                poz[v[i]] = i; // punem in vectorul poz pozitiile elementelor din vectorul v
            }
            // aranjam vectorul in ordine descrescatoare
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            // numaram cate numere se află pe aceeași poziție ca în șirul inițial
            for (int i = 0; i < n; i++)
                if (poz[v[i]] == i)
                    cate++;
            Console.WriteLine($"{cate} elemente din vector respecta regula ceruta");
        }

        /// <summary>
        /// Se dă un şir cu n elemente, numere naturale. Să se afişeze, în ordine crescătoare, toate valorile 
        /// distincte care se pot obţine ca sumă de două elemente distincte din şir.
        /// </summary>
        private static void P65()
        {
            int n, m = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            int[] result = new int[100];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            // determinam daca exista elemente care se pot obţine ca sumă de două elemente distincte din şir
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (v[i] == (v[j] + v[k]) && v[j] != v[k])
                        {
                            result[m] = v[i];
                            m++;
                        }
                    }
                }
            }
            m--;
            // ordonam vectorul result in ordine crescatoare
            for (int i = 0; i < m; i++)
                for (int j = i + 1; j < m; j++)
                    if (result[i] > result[j])
                    {
                        int aux = result[i];
                        result[i] = result[j];
                        result[j] = aux;
                    }
            // afisam rezultatul
            for (int i = 0; i < m; i++)
                Console.Write($"{result[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se dau n, un număr natural și n numere întregi. Folosind un alt vector, să se aşeze numerele 
        /// pare la început.Exemplu: Date de intrare: n=4 și numerele: 3, 4, 6, 5 Date de ieşire: 4 6 3 5.
        /// </summary>
        private static void P64()
        {
            int n, k = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[100];
            int[] u = new int[100];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 == 0)
                    u[k++] = v[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 != 0)
                    u[k++] = v[i];
            }
            for (int i = 0; i < k; i++)
                Console.Write($"{u[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Să se extragă dintr-un vector elementele care au ultima cifră egală cu k şi să se formeze cu  ele un alt vector.
        /// Să se afişeze cei doi vectori, unul sub altul.
        /// Exemplu: dacă se dau n = 3, k= 7,v[]={ 17, 23, 47}, atunci vectorul u va fi {17, 47}.
        /// </summary>
        private static void P63()
        {
            int n, k;
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[100];
            int[] u = new int[100];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 10 == k)
                {
                    for (int j = i; j < n; j++)
                        v[j] = v[j + 1];
                    n--;
                    i--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                u[i] = v[i];
                Console.Write($"{u[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se citesc de la tastatură n, un număr natural mai mic decât 100 și cele n elemente reale ale unui vector.
        /// Se cere să se insereze între oricare două elemente ale vectorului media lor aritmetică.
        /// </summary>
        private static void P62()
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            double[] v = new double[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = double.Parse(t[i]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j >= i + 1; j--)
                    v[j + 1] = v[j];
                v[i + 1] = (v[i] + v[i + 2]) / 2;
                n++;
                i++;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se citesc de la tastatură un număr întreg x, k<=n<=1000, două numere naturale și n numere 
        /// întregi.Inserați elementul x în vector pe poziția k. (elementele din poziţiile k, k+1,.......n
        /// trebuie să se deplaseze cu o poziţie spre dreapta pentru a face loc noii valori x introduse în
        /// poziţia k; dimensiunea vectorului creşte cu o unitate).
        /// </summary>
        private static void P61()
        {
            int n, k, x;
            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = n - 1; i >= k; i--)
                v[i + 1] = v[i];
            v[k] = x;
            n++;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi. 
        /// Eliminați din vector toate elementele egale cu k. (Pentru a determina ultimul element cu o
        /// anumită proprietate, se parcurge vectorul de la dreapta spre stânga (în ordinea descrescătoare
        /// a indicilor până când găsim primul element cu proprietatea cerută sau până când epuizăm elementele vectorului).
        /// </summary>
        private static void P60()
        {
            int n, k;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    for (int j = i; j < n; j++)
                        v[j] = v[j + 1];
                    n--;
                    i--;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se citesc de la tastatură poz<=n<=1000, două numere naturale și n numere întregi. Eliminați 
        /// din vector elementul aflat pe poziția poz. (pentru eliminarea elementului din poziţia poz, se
        /// observă că primele poz-1 elemente rămân neschimbate, în timp ce elementele din poziţiile
        /// poz+1, poz+2,…….,n se deplasează cu o poziţie spre stânga pentru a “umple” golul rămas
        /// prin eliminarea elementului din poziţia poz.Evident, dimensiunea vectorului scade cu o unitate).
        /// </summary>
        private static void P59()
        {
            int n, poz;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("poz= ");
            poz = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = poz; i < n - 1; i++)
                v[i] = v[i + 1];
            n--;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi. 
        /// Determinați poziția ultimului element din vector cu proprietatea că este egal cu k. (Pentru a
        /// determina ultimul element cu o anumită proprietate, se parcurge vectorul de la dreapta spre
        /// stânga(în ordinea descrescătoare a indicilor până când găsim primul element cu proprietatea
        /// cerută sau până când epuizăm elementele vectorului).
        /// </summary>
        private static void P58()
        {
            int n, k, poz = 0;
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] == k)
                    poz = i;
            }
            if (poz != 0)
                Console.WriteLine($"Pozitia elementului cerut este: {poz}");
            else
                Console.WriteLine("Nu exista astfel de elemente in vectorul dat");
        }

        /// <summary>
        /// Se citesc de la tastatură n<=100, un număr natural și n numere întregi. Determinați poziția 
        /// primului element din vector cu proprietatea că este medie aritmetică între succesorul și
        /// predecesorul său. (Pentru a determina primul element(de indice minim) cu o anumită
        /// proprietate, se parcurge vectorul de la stânga la dreapta până când găsim primul element cu
        /// proprietatea cerută sau până când epuizăm elementele vectorului).
        /// </summary>
        private static void P57()
        {
            int n, poz = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (int i = 1; i < n - 1; i++)
            {
                if ((double)v[i] == (double)(v[i - 1] + v[i + 1]) / 2)
                {
                    poz = i;
                    break;
                }
            }
            if (poz != 0)
                Console.WriteLine($"Pozitia elementului cerut este: {poz}");
            else
                Console.WriteLine("Nu exista astfel de elemente in vectorul dat");
        }

        /// <summary>
        /// Să se construiască un vector v cu primii termeni ai şirului lui Fibonacci. Şirul are primii
        /// doi termeni egali cu 1 şi fiecare din termenii următori este egal cu suma dintre termenul
        /// precedent şi termenul anteprecedent
        /// </summary>
        private static void P56()
        {
            int n;
            Console.WriteLine("Cati termeni ai sirului Fibonacci doriti sa se afiseze?");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            v[0] = v[1] = 1;
            for (int i = 2; i < n; i++)
            {
                v[i] = v[i - 2] + v[i - 1];
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }

        /// <summary>
        /// Fie X un vector cu n componente numere întregi. Să se calculeze expresia: e=x1-x2+x3-x4+….±xn.
        /// </summary>
        private static void P55()
        {
            int n, s = 0, dif = 0, e;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (i % 2 == 0)
                    s = s + v[i];
                else
                    dif = dif + v[i];
            }
            e = s - dif;
            Console.WriteLine($"Expresia data are valoarea: {e}");
        }

        /// <summary>
        /// Functia care determina raportul dintre elem pare si elem impare dintr-un vector.
        /// </summary>
        private static void P54()
        {
            int n, pare = 0, impare = 0;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 != 0)
                    impare++;
                else
                    pare++;
            }
            Console.WriteLine($"Raportul dintre elementele pare si elementele impare din vector este de {pare}:{impare}");
        }

        /// <summary>
        /// Functia care determina daca un vector dat are numai elem pare.
        /// </summary>
        private static void P53()
        {
            int n;
            bool ok = true;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 != 0)
                    ok = false;
            }
            if (ok)
                Console.WriteLine("Vectorul dat are numai elemente pare");
            else
                Console.WriteLine("Vectorul dat contine si elemente impare");
        }

        /// <summary>
        /// Functia care determina daca un vector dat are numai elem impare.
        /// </summary>
        private static void P52()
        {
            int n;
            bool ok = true;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 == 0)
                    ok = false;
            }
            if (ok)
                Console.WriteLine("Vectorul dat are numai elemente impare");
            else
                Console.WriteLine("Vectorul dat contine si elemente pare");
        }

        /// <summary>
        /// Functia care determina minimul unui vector dat.
        /// </summary>
        private static void P51()
        {
            int n, minim = int.MaxValue;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] < minim)
                    minim = v[i];
            }
            Console.WriteLine($"Minimul vectorului dat este: {minim}");
        }

        /// <summary>
        /// Functia care determina daca un vector dat e ordonat crescator.
        /// </summary>
        private static void P50()
        {
            int n;
            bool ok = true;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            v[0] = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] < v[i - 1])
                    ok = false;
            }
            if (ok)
                Console.WriteLine("Vectorul dat este ordonat crescator");
            else
                Console.WriteLine("Vectorul dat nu este ordonat crescator");
        }

        /// <summary>
        /// Sa se scrie o functie care calculeaza media aritmetica a elementelor pare dintr-un vector de numere intregi
        /// </summary>
        private static void P49()
        {
            int n;
            double suma = 0, k = 0;
            Console.Write("Dati dimensiunea vectorului: ");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 == 0)
                {
                    suma += v[i];
                    k++;
                }
            }
            double ma = suma / k;
            Console.WriteLine($"Media aritmetica a elementelor pare din vector este: {ma}");
        }

        /// <summary>
        /// Să se scrie un program care adună două matrici de dimensiune n x n.
        /// </summary>
        private static void P48()
        {
            int n, i, j;
            int[,] a = new int[100, 100];
            int[,] b = new int[100, 100];
            int[,] c = new int[100, 100];
            Console.Write("Dati dimensiunea matricei: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele primei matrice:");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Introduceti elementele celei de a doua matrice:");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Suma celor doua matrice este:");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write($"{c[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99 într-un tablou
        /// și care afișează numerele care se repetă în tablou
        /// </summary>
        private static void P47()
        {
            int[] v = new int[100];
            int[] ap = new int[100];
            Console.WriteLine("Numerele din tabloul initial sunt: ");

            Random x = new Random();
            for (int i = 0; i < 100; i++)
            {
                v[i] = x.Next(0, 100);
                ap[v[i]]++;
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Numerele care se repeta in tablou sunt: ");
            for (int i = 0; i < 100; i++)
            {
                if (ap[v[i]] > 1)
                {
                    Console.Write($"{v[i]} ");
                    ap[v[i]] = 0;
                }
            }
        }

        /// <summary>
        /// Un palindrom este un număr sau o frază care se citește la fel de la început cât și de la sfârșit. 
        /// </summary>
        /// <example>
        /// De exemplu, fiecare dintre următoarele numere întregi formate din cinci cifre este un
        /// palindrom: 12321, 55555, 45554 și 11611. Să se scrie o functie care primeste un număr și
        /// verifică dacă este palindrom sau nu. (Utilizați operatorii de împărțit și rest pentru a separa
        /// numărul în cifre individuale).
        /// </example>
        private static void P46()
        {
            int x;
            Console.Write("Introduceti un numar natural: ");
            x = int.Parse(Console.ReadLine());
            if (palindrom(x))
                Console.WriteLine($"Numarul {x} este palindrom");
            else
                Console.WriteLine($"Numarul {x} nu este palindrom");
        }

        // Functie pentru a determina daca un numar este palindrom sau nu
        private static bool palindrom(int x)
        {
            int og = 0, cx = x;
            while (cx != 0)
            {
                og = og * 10 + cx % 10;
                cx /= 10;
            }
            if (og == x)
                return true;
            else
                return false;
        }

        /// <summary>
        ///  Să se scrie o funcție care inversează elementele memorate într-un tablou
        /// </summary>
        private static void P45()
        {
            int n;
            int[] v = new int[100];
            Console.Write("Introduceti lungimea tabloului: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti elementele tabloului: ");
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Tabloul initial este: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            Console.Write("Elementele inversate ale tabloului sunt: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Să se scrie o functie pentru aflarea tablei inmulțirii unui număr utilizând bucla for și reprezentați-o 
        /// în formatul corespunzător
        /// </summary>
        private static void P44()
        {
            int n;
            Console.Write("Dati un numar pentru a afla tabla inmultirii a acestui numar: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"{n}*{i}={n * i}");
            }
        }

        /// <summary>
        /// Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou.
        /// </summary>
        /// <example>
        /// De exemplu introduceți lungimea tabloului: 5.
        /// Introduceți elementele tabloului: 9 10 20 8 7
        /// Tabloul inițial este: 9 10 20 8 7
        /// Pătratul elementelor tabloului inițial este: 81 100 400 64 49
        /// ///</example>
        private static void P43()
        {
            int n, patrat;
            int[] v = new int[100];
            Console.Write("Introduceti lungimea tabloului: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti elementele tabloului: ");
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Tabloul initial este: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Patratul elementelor tabloului initial este: ");
            for (int i = 0; i < n; i++)
            {
                patrat = v[i] * v[i];
                Console.Write($"{patrat} ");
            }
        }

        /// <summary>
        /// Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.
        /// </summary>
        private static void P42()
        {
            int x, cub;
            Console.WriteLine("Introduceti un numar natural:");
            x = int.Parse(Console.ReadLine());
            for (cub = 1; cub * cub * cub <= x; cub++)
            {
                if (cub * cub * cub == x)
                {
                    Console.WriteLine($"Numarul {x} este cub perfect");
                    return;
                }
            }
            Console.WriteLine($"Numarul {x} nu este cub perfect");
        }

        /// <summary>
        /// Un muncitor lucrează n zile pentru a termina o lucrare. Scrieti o functie prin care sa se 
        /// determine câte zile sunt necesare pentru a termina aceeaşi lucrare o echipă de m muncitori
        /// </summary>
        private static void P41()
        {
            int n, m, zile;
            Console.WriteLine("In cate zile termina un muncitor lucrarea?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cati muncitori sunt?");
            m = int.Parse(Console.ReadLine());
            zile = n / m;
            if (n % m != 0)
                zile++;
            Console.WriteLine($"{m} muncitori termina lucrarea in {zile} zile");
        }

        /// <summary>
        /// Viteza unui automobil este de v km/h. Scrieti o functie prin care sa exprimaţi această viteză în m/s.
        /// </summary>
        private static void P40()
        {
            double v, result = 0;
            Console.Write("Dati viteza automobilului in km/h: ");
            v = double.Parse(Console.ReadLine());
            result = v / 3.6;
            Console.WriteLine($"Viteza automobilului este de {result} m/s");
        }

        /// <summary>
        /// Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore, minute şi secunde.
        /// </summary>
        private static void P39()
        {
            int o1, o2, m1, m2, s1, s2, ore, minute, secunde;
            Console.WriteLine("Dati primul moment:");
            Console.Write("Ora:");
            o1 = int.Parse(Console.ReadLine());
            Console.Write("Minute:");
            m1 = int.Parse(Console.ReadLine());
            Console.Write("Secunde:");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati al doilea moment:");
            Console.Write("Ora:");
            o2 = int.Parse(Console.ReadLine());
            Console.Write("Minute:");
            m2 = int.Parse(Console.ReadLine());
            Console.Write("Secunde:");
            s2 = int.Parse(Console.ReadLine());
            DateTime h1 = new DateTime(2021, 12, 12, o1, m1, s1);
            DateTime h2 = new DateTime(2021, 12, 12, o2, m2, s2);
            TimeSpan o;
            if (h1 > h2)
                o = h1 - h2;
            else
                o = h2 - h1;
            ore = o.Hours;
            minute = o.Minutes;
            secunde = o.Seconds;
            string timeDiff = ore.ToString("00") + " ore" + minute.ToString(" 00") + " minute" + secunde.ToString(" 00") + " secunde";
            Console.Write($"Diferenta dintre momente este de {timeDiff}");
            Console.WriteLine();
        }

        /// <summary>
        ///  Scrieţi o functie care să calculeze factorialul unui număr întreg n.
        /// </summary>
        private static void P38()
        {
            int n, f = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                f = f * i;
            Console.WriteLine($"{n}!={f}");
        }

        /// <summary>
        /// Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci, şir definit de relaţia 
        /// de recurenta: f(n)=f(n-2)+f(n-1); f(1)=1, f(2)=1.
        /// </summary>
        private static void P37()
        {
            int n, f1, f2, f3;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            f1 = f2 = 1;
            Console.Write($"{f1}, {f2}, ");
            n = n - 2;
            while (n != 0)
            {
                f3 = f1 + f2;
                Console.Write($"{f3}, ");
                f1 = f2;
                f2 = f3;
                n--;
            }
        }

        /// <summary>
        /// Scrie o metodă care primește ca parametru un număr natural x și apoi afișează: 
        /// -cifrele numărului(în ordine inversă)
        /// -suma cifrelor
        /// ///</summary>
        /// ///<example>
        /// n == 21304
        /// Cifrele numărului sunt: 4, 0, 3, 1, 2,
        /// Suma cifrelor este: 10
        /// </example>

        private static void P36()
        {
            int x;
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            Cifre(x);
        }

        private static void Cifre(int x)
        {
            int suma = 0;
            Console.Write("Cifrele numarului sunt:");
            while (x != 0)
            {
                suma = suma + x % 10;
                Console.Write($"{x % 10}, ");
                x /= 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma cifrelor este: {suma}");
        }

        /// <summary>
        /// Scrieti o functie cu numele putere care primeste prin parametrul n un numar natural cu cel mult 9
        /// cifre si care furnizeaza prin parametrii x si k doua numere naturale cu proprietatea ca n = x^k si x este minim.

        /// </summary>
        private static void P35()
        {
            int n;
            int x = 0, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            putere(n, ref x, ref k);
            Console.WriteLine($"x={x} si k={k}");
        }

        private static void putere(int n, ref int x, ref int k)
        {
            for (x = 1; x <= n; x++)
            {
                for (k = 1; k <= n; k++)
                    if (x * k == n)
                        return;
            }
        }

        /// <summary>
        /// Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în 
        /// grade şi una care să facă transformarea inversă.
        /// </summary>
        private static void P34()
        {
            RadianiToGrade();
            Console.WriteLine();
            GradeToRadiani();
        }

        private static void GradeToRadiani()
        {
            double unghi;
            double radiani;
            Console.Write("Dati valoarea unghiului in grade:");
            unghi = double.Parse(Console.ReadLine());
            radiani = (Math.PI * unghi) / 180;
            Console.WriteLine($"Unghiul are {radiani} radiani");
        }

        private static void RadianiToGrade()
        {
            double grade;
            double unghi;
            Console.Write("Dati valoarea unghiului in radiani:");
            unghi = double.Parse(Console.ReadLine());
            grade = (180 * unghi) / Math.PI;
            Console.WriteLine($"Unghiul are {grade} grade");
        }

        /// <summary>
        ///  Să se afişeze toate numerele prime de 3 cifre care citite invers sunt tot numere prime.
        /// </summary>
        private static void P33()
        {
            for (int i = 100; i < 1000; i++)
                if (prim((i % 10) * 100 + (i / 10 % 10) * 10 + i / 100))
                    Console.Write($"{i} ");
        }

        /// <summary>
        /// Să se afişeze primele n numere prime care au suma cifrelor mai mică sau egală cu m
        /// </summary>
        private static void P32()
        {
            int n, m;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            for (int i = 2; n != 0; i++)
            {
                if (prim(i) && SumCif(i) <= m)
                {
                    n--;
                    Console.Write($"{i} ");
                }
            }
        }

        /// <summary>
        /// Să se genereze toate numerele prime mai mici decât numărul natural n dat.
        /// </summary>
        private static void P31()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
                if (prim(i))
                    Console.Write($"{i} ");
        }

        /// <summary>
        /// Să se transforme un număr din baza 10 în baza p<10. Să se transforme un număr din baza p<10 în baza 10
        /// </summary>
        private static void P30()
        {
            int n, p, i = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());
            int[] v = new int[20];
            while (n != 0)
            {
                v[i] = n % p;
                n /= p;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.Write(v[j]);
            Console.WriteLine();

            int rez = 0, k = 0;
            int[] a = new int[20];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                a[k] = n % 10;
                k++;
                n /= 10;
            }
            for (int j = k; j >= 0; j--)
                rez = rez * p + a[j];
            Console.WriteLine(rez);
        }

        /// <summary>
        /// Să se listeze toate numerele ≤n, a căror sumă a cifrelor este divizibilă prin 5. 
        /// </summary>
        private static void P29()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
                if (SumCif(i) % 5 == 0)
                    Console.Write($"{i} ");
        }

        /// <summary>
        /// Să se afişeze toate numerele de 3 cifre care, citite invers, sunt tot numere prime.
        /// </summary>
        private static void P28()
        {
            for (int i = 100; i < 1000; i++)
                if (prim((i % 10) * 100 + (i / 10 % 10) * 10 + i / 100))
                    Console.Write($"{i} ");
        }

        /// <summary>
        /// Să se afişeze primele n numere prime care au suma cifrelor ≤m.
        /// </summary>
        private static void P27()
        {
            int n, m;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            for (int i = 2; n != 0; i++)
            {
                if (prim(i) && SumCif(i) <= m)
                {
                    n--;
                    Console.Write($"{i} ");
                }
            }
        }

        // Functie pentru determinarea sumei cifrelor unui numar intreg
        private static int SumCif(int i)
        {
            int suma = 0;
            while (i != 0)
            {
                suma = suma + i % 10;
                i /= 10;
            }
            return suma;
        }

        /// <summary>
        /// Să se afişeze toate numerele prime mai mici sau egale cu un numar m dat.
        /// </summary>
        private static void P26()
        {
            int m;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            for (int i = 2; i <= m; i++)
                if (prim(i))
                    Console.Write($"{i} ");
        }

        /// <summary>
        /// Un număr se numeşte “palindrom” dacă citit invers este acelaşi număr. Să se verifice dacă un 
        /// număr este sau nu palindrom.
        /// </summary>
        private static void P25()
        {
            int n, og = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int cn = n;
            while (cn != 0)
            {
                og = og * 10 + cn % 10;
                cn /= 10;
            }
            if (og == n)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        /// <summary>
        /// Se citeşte un număr natural. Câte cifre conţine ?
        /// </summary>
        private static void P24()
        {
            int n, cifre = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int cn = n;
            while (cn != 0)
            {
                cifre++;
                cn /= 10;
            }
            Console.WriteLine($"Numarul {n} contine {cifre} cifre");
        }

        /// <summary>
        /// Efectuaţi împărţirea întreagă a două numere, făra a utiliza operatorii / şi %, ci doar scăderi repetate.
        /// </summary>
        private static void P23()
        {
            int a, b, cat = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int ca = a, cb = b;
            if (a < b)
                cat = 0;
            else if (a == b) cat = 1;
            else
            {
                while (ca - cb >= 0)
                {
                    ca = ca - cb;
                    cat++;
                }
            }
            Console.WriteLine($"Catul dintre {a} si {b} este {cat}");
        }

        /// <summary>
        /// Să se calculeze produsul a două numere naturale prin adunări repetate. 
        /// </summary>
        private static void P22()
        {
            int a, b, p = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                p = p + b;
            Console.WriteLine($"Produsul dintre {a} si {b} este {p}");
        }

        /// <summary>
        /// Se citesc 3 numere naturale n, p şi k, apoi un şir de n numere naturale. Câte dintre acestea, împărţite la p dau restul k ?
        /// </summary>
        private static void P21()
        {
            int n, p, k, x, cate = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(t[i]);
                if (x % p == k)
                    cate++;
            }
            Console.WriteLine($"{cate} numere din sir dau restul {k} la impartirea cu {p}");
        }

        /// <summary>
        /// Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0. Să se calculeze media aritmetică a numerelor din şir.
        /// </summary>
        private static void P20()
        {
            double x, suma, k;
            double ma;

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\r', '\t' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            x = int.Parse(t[0]);
            suma = x;
            k = 1;
            int i = 1;

            while (x != 0)
            {
                x = int.Parse(t[i]);
                i++;
                suma = suma + x;
                k++;
            }
            ma = suma / (k - 1);
            Console.WriteLine($"Media aritmetica a numerelor din sir este: {ma}");
        }

        /// <summary>
        /// Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de genul:
        /// Ce doriţi să calculăm? Aria sau perimetrul?. Dacă se va răspunde prin ‘aria’ atunci se va calcula şi afişa aria, altfel perimetrul.
        /// </summary>
        private static void P19()
        {
            double a, b, c, aria, perimetrul, semiperimetrul;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam? Aria sau Perimetrul?");

            string line = Console.ReadLine();
            switch (line)
            {
                case "aria":
                    semiperimetrul = (a + b + c) / 2;
                    aria = Math.Sqrt(semiperimetrul * (semiperimetrul - a) * (semiperimetrul - b) * (semiperimetrul - c));
                    Console.WriteLine($"Aria numerelor {a},{b},{c} este {aria}");
                    break;
                case "perimetrul":
                    perimetrul = a + b + c;
                    Console.WriteLine($"Perimetrul numerelor {a},{b},{c} este {perimetrul}");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Să se scrie un program care să citească două numere reale a şi b. Apoi să pună utilizatorului o întrebare:
        /// Ce doriţi să calculăm ? Media aritmetică(1) sau geometrică(2)?. Dacă se va răspunde prin 1, se va calcula 
        /// şi afişa media aritmetică, iar pentru 2 media geometrică(numai dacă numerele sunt pozitive!
        /// iar de nu, se va afişa ‘eroare !’). Dacă nu se răspunde prin 1 sau 2 se va produce un sunet în difuzor.

        /// </summary>
        private static void P18()
        {
            double a, b, ma, mg;
            int optiune;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam? Media aritmetica(1) sau geometrica(2) ?");
            optiune = int.Parse(Console.ReadLine());
            if (optiune == 1)
            {
                ma = (a + b) / 2;
                Console.WriteLine($"Media aritmetica dintre {a} si {b} este {ma}");
                return;
            }
            if (optiune == 2)
            {
                if (a >= 0 && b >= 0)
                {
                    mg = Math.Sqrt(a * b);
                    Console.WriteLine($"Media geometrica dintre {a} si {b} este {mg}");
                }
                else
                    Console.WriteLine("Eroare!");
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                Console.WriteLine("Optiune invalida!");
            }
        }

        /// <summary>
        /// Un punct material se află la distanţa x0 de origine, la momentul iniţial t0, când începe să se mişte 
        /// rectiliniu uniform. Știind că la momentul t se află la distanţa x faţă de origine, să se
        /// determine viteza v de mişcare a punctului material, la momentul t
        /// </summary>
        private static void P17()
        {
            int x, x0, t, t0, v;
            Console.Write("x0=");
            x0 = int.Parse(Console.ReadLine());
            Console.Write("t0=");
            t0 = int.Parse(Console.ReadLine());
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            Console.Write("t=");
            t = int.Parse(Console.ReadLine());
            v = (x - x0) / (t - t0);
            Console.WriteLine($"Viteza de miscare a punctului material la momentul t={t} este de {v} m/s");
        }

        /// <summary>
        /// O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?
        /// </summary>
        private static void P16()
        {
            int n, r;
            Console.Write("Dati numarul de foi:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Dati numarul de randuri de pe pagina:");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cartea are {n * r} randuri");
        }

        /// <summary>
        /// Scrieţi un program care să calculeze factorialul unui număr întreg n.
        /// </summary>
        private static void P15()
        {
            int n, f = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                f = f * i;
            Console.WriteLine($"n!={f}");
        }

        /// <summary>
        ///  Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, 
        ///  şi să determine cel mai mic număr şi cel mai mare număr citit.
        /// </summary>
        private static void P14()
        {
            int x, minv, maxv;
            minv = int.MaxValue;
            maxv = int.MinValue;
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\r', '\t' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int i = 1;

            x = int.Parse(t[0]);
            while (x != 0)
            {
                x = int.Parse(t[i]);
                if (x < minv && x != 0)
                    minv = x;
                if (x > maxv && x != 0)
                    maxv = x;
                i++;
            }
            Console.WriteLine($"Cel mai mare numar citit este {maxv}, iar cel mai mic numar este {minv}");
        }

        /// <summary>
        /// Elaboraţi un program care să tipărească tabela corespunzătoare Celsius-Fahrenheit
        /// </summary>
        private static void P13()
        {
            float f;
            Console.WriteLine("Celsius  |   Fahrenheit");
            for (int c = 0; c <= 300; c++)
            {
                f = c * (float)1.8 + 32;
                Console.WriteLine($"     {c}   |   {f}");
            }
        }

        /// <summary>
        /// Elaboraţi un program care să tipărească tabela de temperaturi Fahrenheit şi echivalenţele lor în centigrade
        /// sau grade Celsius, folosind formula: C=(5/9)*(F-32), între valorile extreme 0 şi 300 grade Fahrenheit.

        /// </summary>
        private static void P12()
        {
            float c;
            Console.WriteLine("Fahrenheit  |   Celsius");
            for (int f = 0; f <= 300; f++)
            {
                c = (f - 32) / (float)1.8;
                Console.WriteLine($"        {f}   |   {c}");
            }
        }

        /// <summary>
        /// Să se determine dacă două numere sunt prime între ele sau nu.
        /// </summary>
        private static void P11()
        {
            int a, b, r;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int ca = a, cb = b;
            r = ca % cb;
            while (r != 0)
            {
                ca = cb;
                cb = r;
                r = ca % cb;
            }
            if (cb == 1)
                Console.WriteLine($"Numerele {a} si {b} sunt prime intre ele");
            else
                Console.WriteLine($"Numerele {a} si {b} nu sunt prime intre ele");

        }

        /// <summary>
        /// Să se afişeze primele n numere prime.
        /// </summary>
        private static void P10()
        {
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            k = n;
            for (int i = 2; ; i++)
            {
                if (prim(i) && k != 0)
                {
                    Console.Write($"{i} ");
                    k--;
                }
                if (k == 0)
                    break;
            }
        }

        // Functie pentru a determina daca un numar este prim sau nu
        private static bool prim(int i)
        {
            int d;
            if (i < 2)
                return false;
            if (i % 2 == 0 && i != 2)
                return false;
            for (d = 3; d * d <= i; d = d + 2)
            {
                if (i % d == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două numere întregi a şi b.

        /// </summary>
        private static void P9()
        {
            int a, b, r, cmmdc, cmmmc;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int ca = a, cb = b;
            r = ca % cb;
            while (r != 0)
            {
                ca = cb;
                cb = r;
                r = ca % cb;
            }
            cmmdc = cb;
            cmmmc = (a * b) / cmmdc;
            Console.WriteLine($"Cel mai mare divizor comun dintre {a} si {b} este {cmmdc}");
            Console.WriteLine($"Cel mai mic multiplu comun dintre {a} si {b} este {cmmmc}");
        }

        /// <summary>
        /// Fie a.Să se scrie un algoritm pentru calculul mediei aritmetice, geometrice şi armonice a tuturor divizorilor lui a.
        /// </summary>
        private static void P8()
        {
            double a, suma = 0, k = 0, p = 1, sumainverse = 0;
            a = int.Parse(Console.ReadLine());
            double ma, mg, mh;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    suma = suma + i;
                    k++;
                    p = p * i;
                    sumainverse = sumainverse + 1 / i;
                }
            }
            ma = (double)(suma / k);
            mg = (double)Math.Sqrt(p);
            mh = (double)(k / sumainverse);
            Console.WriteLine($"Media aritmetica a divizorilor lui {a} este {ma}");
            Console.WriteLine($"Media geometrica a divizorilor lui {a} este {mg}");
            Console.WriteLine($"Media armonica a divizorilor lui {a} este {mh}");
        }

        /// <summary>
        /// Fie n,k. Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte k
        /// </summary>
        private static void P7()
        {
            int n, k, combinari;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            combinari = Factorial(n) / (Factorial(k) * Factorial(n - k));
            Console.WriteLine($"Combinari de {n} luate cate {k} = {combinari}");
        }

        // Functie pentru determinarea factorialului unui numar natural
        private static int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * i;
            return f;
        }

        /// <summary>
        /// Două numere întregi x şi y sunt "prietene" dacă suma divizorilor numărului x este egală cu 
        /// suma divizorilor numărului y. Să se găsească numerele "prietene" din intervalul [a, b]
        /// </summary>
        private static void P6()
        {
            int a, b, k = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    if (SumDiv(i) == SumDiv(j) && i != j)
                    {
                        Console.Write($"({i},{j}),");
                        k++;
                    }
                }
            }
            if (k == 0)
                Console.WriteLine($"In intervalul [{a},{b}] nu exista numere prietene");

        }

        // Functie pentru determinarea sumei divizorilor unui numar intreg
        private static int SumDiv(int x)
        {
            int suma = 0;
            for (int i = 1; i <= x; i++)
                if (x % i == 0)
                    suma = suma + i;
            return suma;
        }

        /// <summary>
        /// Să se determine numerele perfecte din intervalul [a,b], pentru a,b date.
        /// </summary>
        private static void P5()
        {
            int a, b, aux, suma, cate = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            for (int i = a; i <= b; i++)
            {
                suma = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        suma = suma + j;
                }
                if (suma == i)
                {
                    Console.WriteLine($"{i} ");
                    cate++;
                }
            }
            if (cate == 0)
                Console.WriteLine($"In intervalul [{a},{b}] nu exista numere perfecte");

        }

        /// <summary>
        /// Să se verifice dacă numărul n este perfect.(Un număr n este perfect dacă este egal cu suma 
        /// divizorilor lui diferiţi de n; exemplu: 6=1+2+3)
        /// </summary>
        private static void P4()
        {
            int n, suma = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    suma = suma + i;
            }
            if (suma == n)
                Console.WriteLine($"Numarul {n} este un numar perfect");
            else
                Console.WriteLine($"Numarul {n} nu este un numar perfect");
        }

        /// <summary>
        /// Fie i,j,k. Să se determine restul împărţirii numărului natural i^j la k.
        /// </summary>
        private static void P3()
        {
            int i, j, k, p, result;
            Console.Write("i=");
            i = int.Parse(Console.ReadLine());
            Console.Write("j=");
            j = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            p = 1;
            for (int m = 1; m <= j; m++)
            {
                p = i * i;
            }
            result = p % k;
            Console.WriteLine($"Restul impartirii numarului {i}^{j} la {k} este: {result}");
        }

        /// <summary>
        /// Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică: 
        /// adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
        /// selectarea funcției calculatorului). După selectarea opțiunii dorite, programul trebuie să
        /// ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii, 
        /// înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.
        /// </summary>
        private static void P2()
        {
            int operatie;
            Console.WriteLine("Ce operatie doriti sa efectuati?");
            Console.WriteLine("1 = adunare  2 = scadere  3 = inmultire  4 = impartire  5 = radical  6 = modul");
            operatie = int.Parse(Console.ReadLine());

            switch (operatie)
            {
                case 1:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti doua valori pe care doriti sa le adunati");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a + b;
                        Console.WriteLine($"{a}+{b}={result}");
                    }
                    break;
                case 2:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti doua valori pe care doriti sa le scadeti");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a - b;
                        Console.WriteLine($"{a}-{b}={result}");
                    }
                    break;
                case 3:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti doua valori pe care doriti sa le inmultiti");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a * b;
                        Console.WriteLine($"{a}*{b}={result}");
                    }
                    break;
                case 4:
                    {
                        int a, b;
                        double result;
                        Console.WriteLine("Introduceti doua valori pe care doriti sa le impartiti");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = (double)a / b;
                        Console.WriteLine($"{a}/{b}={result}");
                    }
                    break;
                case 5:
                    {
                        int a;
                        double result;
                        Console.WriteLine("Introduceti un numar natural pentru care doriti sa aflati radicalul numarului");
                        a = int.Parse(Console.ReadLine());
                        if (a < 0)
                        {
                            Console.WriteLine("Numarul introdus nu este un numar natural!");
                            break;
                        }
                        result = Math.Sqrt(a);
                        Console.WriteLine($"sqrt({a})={result}");
                    }
                    break;
                case 6:
                    {
                        int a, result;
                        Console.WriteLine("Introduceti un numar intreg pentru care doriti sa aflati modulul");
                        a = int.Parse(Console.ReadLine());
                        result = Math.Abs(a);
                        Console.WriteLine($"|{a}|={result}");
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch.
        /// </summary>
        private static void P1()
        {
            float c, f;
            int optiune;
            Console.WriteLine("Introduceti o optiune");
            Console.WriteLine("1 = Celsius -> Fahrenheit  2 = Fahrenheit -> Celsius");
            optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    Console.WriteLine("Dati o temperatura in grade Celsius:");
                    c = float.Parse(Console.ReadLine());
                    f = c * (float)1.8 + 32;
                    Console.WriteLine($"Temperatura in grade Fahrenheit corespunzatoare este {f}");
                    break;
                case 2:
                    Console.WriteLine("Dati o temperatura in grade Fahrenheit:");
                    f = float.Parse(Console.ReadLine());
                    c = (f - 32) / (float)1.8;
                    Console.WriteLine($"Temperatura in grade Celsius corespunzatoare este {c}");
                    break;
                default:
                    break;
            }
        }
    }
}
