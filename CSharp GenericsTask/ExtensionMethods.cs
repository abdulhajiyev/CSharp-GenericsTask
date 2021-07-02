using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CSharp_GenericsTask
{
    static class ExtensionMethods
    {
        public static void Method1(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Debtors with emails in rhyta.com or dayrep.com domains: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user =>
                user.Email.Contains("rhyta.com") || user.Email.Contains("dayrep.com")))
            {
                Console.WriteLine(debtor.ToString());
            }
        } //rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

        public static void Method2(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDebtors between the ages of 26 and 36");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user =>
                DateTime.Now.Year - user.BirthDay.Year > 26 && DateTime.Now.Year - user.BirthDay.Year < 36))
            {
                Console.WriteLine(debtor.ToString());
            }
        } // Yashi 26-dan 36-ya qeder olan borclulari cixartmag

        public static void Method3(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDebtors with no more than 5,000 in debt");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user => user.Debt < 5000))
            {
                Console.WriteLine(debtor.ToString());
            }
        } // Borcu 5000-den cox olmayan borclularic cixartmag

        public static void Method4(List<Debtor> debtors)
        {
            //var ch = '.';
            var users = debtors.Where(user =>
                user.FullName.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray().Length > 18 &&
                user.Phone.Count(n => n == '7') >= 2);
            //var users = debtors.Where(user => user.FullName.Select(x => string.Join("", x.Split(' ', '.'))).ToArray());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors with 18 or more characters in their FullName and 2 or more digit 7 in their phone number");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        } // Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq

        public static void Method5(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors who were born in Winter");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user =>
                user.BirthDay.Month is 12 or 1 or 2))
            {
                Console.WriteLine(debtor.ToString());
            }
        } // Qishda anadan olan borclulari cixardmaq

        public static void Method6(List<Debtor> debtors)
        {
            var sum = 0;
            var count = 0;
            foreach (var debtor in debtors)
            {
                sum += debtor.Debt;
                count++;
            }

            var average = sum / count; // 6463
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors who have debt more than the average of the total debt");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user => user.Debt > average))
            {
                Console.WriteLine(debtor.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nSorted surnames A-Z");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.OrderBy(user => user.FullName.Split()[2]))
            {
                Console.WriteLine(debtor.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nSorted debts Largest to Smallest");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.OrderByDescending(user => user.Debt))
            {
                Console.WriteLine(debtor.ToString());
            }
        } // Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek

        public static void Method7(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors who don't have  digit 8 in their phone number");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var debtor in debtors.Where(user => user.Phone.Count(n => n == '8') == 0))
            {
                Console.WriteLine(@$"
Surname: {debtor.FullName.Split()[2]}
Age: {DateTime.Now.Year - debtor.BirthDay.Year}
Debt: {debtor.Debt}
Phone: {debtor.Phone}");
            }
        } // Telefon nomresinde 8 olmayan borclularin yalniz familyasin,yashin ve umumi borcun meblegin cixarmaq

        public static void Method8(List<Debtor> debtors)
        {
        }

        public static void Method9(List<Debtor> debtors)
        {
        }

        public static void Method10(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\n5 debtors with the largest debt");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.OrderByDescending(debtor => debtor.Debt).Take(5))
            {
                Console.WriteLine(debtor.ToString());
            }
        } // Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

        public static void Method11(List<Debtor> debtors)
        {
            var total = debtors.Select(user => user.Debt).Sum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                $"\nTotal debt: {total}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Method12(List<Debtor> debtors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"\nList of World War II debtors");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var debtor in debtors.Where(user => user.BirthDay.Year is >= 1941 and <= 1945))
            {
                Console.WriteLine(debtor.ToString());
            }
        }

        public static void Method13(List<Debtor> debtors)
        {
        }

        public static void Method14(List<Debtor> debtors)
        {
        }

        public static void Method15(List<Debtor> debtors)
        {
        }

        public static void Method16(List<Debtor> debtors)
        {
        }
    }
}