using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Dane_Osobowe_Poprawione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCześć podaj mi swoje imię.\n");
            var name = Console.ReadLine();
            Console.WriteLine($"\nWitaj {name} podaj mi teraz proszę rok twoich urodzin.\n");
            var year = GetYearOfBirth();
            Console.WriteLine($"\nWitaj {name} podaj mi teraz proszę miesiąc twoich urodzin.\n");
            var month = GetMonthOfBirth();
            Console.WriteLine($"\nWitaj {name} podaj mi teraz proszę dzień twoich urodzin.\n");
            var day = GetDayOfBirth(year, month);

            Console.WriteLine("\nW jakiej miejscowości się urodziłeś?\n");
            var cityOfBirth = Console.ReadLine();

            var dataurodzenia = new DateTime(year, month, day);
            var datareferencyjna = DateTime.Now;
            var Years = 0;
            if (datareferencyjna.DayOfYear < dataurodzenia.DayOfYear)
                Years = datareferencyjna.Year - dataurodzenia.Year - 1;
            else
                Years = datareferencyjna.Year - dataurodzenia.Year;

            Console.WriteLine($"\nCześć, masz na imię {name}, masz {Years} lat i urodziłeś się w {cityOfBirth}\n");
            Console.ReadLine();
        }

        private static int GetDayOfBirth(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth) || day < 1)
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj ponownie dzień, w którym się urodziłeś.\n");
                    continue;
                }
                return day;
            }
        }

        private static int GetMonthOfBirth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj ponownie miesiąc, w którym się urodziłeś\n");
                    continue;
                }
                return month;
            }
        }
        private static int GetYearOfBirth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > DateTime.Now.Year)
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj ponownie swój rok urodzenia\n");
                    continue;
                }
                return year;
            }
        }

    }
}
