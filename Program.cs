using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Zadanie_B2
{
     
    class Program
    {
        
        static int CiągFibbonaciego(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            int c=0;
            for(int i =0; i<n; i++)
            {
                c =CiągFibbonaciego(n-2) + CiągFibbonaciego(n - 1);
            }
            return c;
        }
        static void WyswFibb(int n)
        {
            for(int i =1; i<=n; i++)
            {
                Console.WriteLine(CiągFibbonaciego(i));
                    
            }
        }
        static string ciągi(string s, int n)
        { 
            
                if (n > 0)
                {
                    string słowo = s;
                    for (int i = 1; i < n; i++)
                    {
                        s = słowo + " " + s;
                    }
                    return s;
                }
                else
                {
                    if (n == 0)
                    {
                        return "";
                    }
                    else
                    {
                        Console.WriteLine("Podaj numer nieujemny!");
                        return "";
                    }
                }
            
        }
        static string łączenie(string a, string b)
        {
            a = a + b;
            return a;
        }
        static bool Bramkaand(bool a, bool b)
        {
            return a && b;
        }
        static bool BramkaOR(bool a, bool b)
        {
            return a || b;
        }
        static double objkula(double r)
        {
            return r * r * r * 3.14 * 1.33;
        }
        static double masakuli(double r, double q)
        {
            return objkula(r) * q;
        }
        static double polekuli(double r)
        {
            return 4 * 3.14 * r * r;
        }
        static void paramkuli(double r, double q)
        {
            Console.WriteLine("objętść: " + objkula(r)+"m^3");
            Console.WriteLine("masa: " + masakuli(r, q)+"kg");
            Console.WriteLine("pole: " + polekuli(r)+"m^2");
        }
        static void interfejs()
        {
            Console.WriteLine("zadania z wykorzystaniem ciągu Fibonacciego --> \"fibonacci\"");
            Console.WriteLine("zadania z łączeniem tekstu --> \"string\"");
            Console.WriteLine("bramki logiczne --> \"bramka\"");
            Console.WriteLine("parametry kuli --> \"kula\"");
            Console.WriteLine("wyjdź z programu --> \"koniec\"");   
            WybórOpcji();
        }
        static void WybórOpcji()
        {
            string opcja = Console.ReadLine();
            switch (opcja)
            {
                case "fibonacci":
                    Console.WriteLine("podaj rozmiar ciągu");
                    string SłowoNumerCiągu = Console.ReadLine();
                    int NumerCiągu = Convert.ToInt32(SłowoNumerCiągu);
                    MenuFibonacci(NumerCiągu);
                    zatwierdź();
                    break;
                case "string":
                    MenuString();
                    zatwierdź();
                    break;
                case "bramka":
                    Console.WriteLine("podaj wartość logiczną");
                    bool a = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("podaj drugą wartość logiczną");
                    bool b = Convert.ToBoolean(Console.ReadLine());
                    MenuBramka(a, b);
                    break;
                case "kula":
                    Console.WriteLine("podaj promień w metrach");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("podaj gęstość w kg/m^3");
                    double q = Convert.ToDouble(Console.ReadLine());                   
                    MenuKula(r, q);
                    break;
                case "koniec":
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + opcja + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void MenuKula(double r, double q)
        {
            Console.WriteLine("oblicz objętość --> \"objetosc\"");
            Console.WriteLine("oblicz masę --> \"masa\"");
            Console.WriteLine("oblicz pole powierzchnii --> \"pole\"");
            Console.WriteLine("wyświetl wszystkie parametry --> \"param\"");
            Console.WriteLine("wyjdź do menu --> \"menu\"");
            string WybórOpcji = Console.ReadLine();
            switch (WybórOpcji)
            {
                case "objetosc":
                    Console.WriteLine(objkula(r)+"m^3");
                    zatwierdź();
                    MenuKula(r, q);
                    break;
                case "masa":
                    Console.WriteLine(masakuli(r, q)+"kg");
                    zatwierdź();
                    MenuKula(r, q);
                    break;
                case "pole":
                    Console.WriteLine(polekuli(r)+"m^2");
                    zatwierdź();
                    MenuKula(r, q);
                    break;
                case "param":
                    paramkuli(r, q);
                    zatwierdź();
                    MenuKula(r, q);
                    break;
                case "menu":
                    interfejs();
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + WybórOpcji + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void MenuFibonacci(int NumerUżytkownika)
        {
            Console.WriteLine("Wyświetl wartość ciągu po podanym numerze --> \"wartosc\"");
            Console.WriteLine("wyświetl cały ciąg --> \"caly\"");
            Console.WriteLine("wyjdź do menu --> \"menu\"");
            string WybórOpcji = Console.ReadLine();
            switch (WybórOpcji)
            {
                case "wartosc":
                    Console.WriteLine(CiągFibbonaciego(NumerUżytkownika));
                    zatwierdź();
                    MenuFibonacci(NumerUżytkownika);
                    break;
                case "caly":
                    WyswFibb(NumerUżytkownika);
                    zatwierdź();
                    MenuFibonacci(NumerUżytkownika);
                    break;
                case "menu":
                    interfejs();
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + WybórOpcji + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void MenuString()
        {
            Console.WriteLine("Powiel słowo --> \"powiel\"");
            Console.WriteLine("Połącz słowa --> \"polacz\"");
            Console.WriteLine("wyjdź do menu --> \"menu\"");
            string WybórOpcji = Console.ReadLine();
            switch (WybórOpcji)
            {
                case "powiel":
                    Console.WriteLine("podaj słowo");
                    string s = Console.ReadLine();
                    Console.WriteLine("podaj numer");
                    string n = Console.ReadLine();
                    Console.WriteLine(ciągi(s, Convert.ToInt32(n)));
                    zatwierdź();
                    MenuString();
                    break;
                case "polacz":
                    Console.WriteLine("podaj słowo");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("podaj drugie słowo");
                    string s2 = Console.ReadLine();
                    Console.WriteLine(łączenie(s1, s2));
                    zatwierdź();
                    MenuString();
                    break;
                case "menu":
                    interfejs();
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + WybórOpcji + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void zatwierdź()
        {
            Console.WriteLine("wyjdź z programu --> \"koniec\"");
            Console.WriteLine("wyjdź do głównego menu --> \"menu\"");
            Console.WriteLine("wyjdź do menu działania --> \"wroc\"");
            string menuKoniec = Console.ReadLine();
            switch (menuKoniec)
            {
                case "menu":
                    interfejs();
                    break;
                case "koniec":
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;
                case "wroc":
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + menuKoniec + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void MenuBramka(bool a, bool b)
        {
            Console.WriteLine("bramka and --> \"and\"");
            Console.WriteLine("bramka or --> \"or\"");
            Console.WriteLine("wyjdź do menu --> \"menu\"");
            string WybórOpcji = Console.ReadLine();
            switch (WybórOpcji)
            {
                case "and":
                    Console.WriteLine(Bramkaand(a, b));
                    zatwierdź();
                    MenuBramka(a, b);
                    break;
                case "or":
                    Console.WriteLine(BramkaOR(a, b));
                    zatwierdź();
                    MenuBramka(a, b);
                    break;
                case "menu":
                    interfejs();
                    break;
                default:
                    Console.WriteLine("nieznana nazwa: \"" + WybórOpcji + "\", proszę spróbuj jeszcze raz.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj! W czym mogę CI pomóc?");
            while (1 == 1)
            {
                interfejs();
            }
        }
    }
}
