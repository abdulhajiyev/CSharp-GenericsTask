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
            var users = debtors.Where(user => user.Email.Contains("rhyta.com") || user.Email.Contains("dayrep.com"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Debtors with emails in rhyta.com or dayrep.com domains: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        } //rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

        public static void Method2(List<Debtor> debtors)
        {
            var users = debtors.Where(user =>
                DateTime.Now.Year - user.BirthDay.Year > 26 && DateTime.Now.Year - user.BirthDay.Year < 36);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value: "\nDebtors between the ages of 26 and 36");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        } // Yashi 26-dan 36-ya qeder olan borclulari cixartmag

        public static void Method3(List<Debtor> debtors)
        {
            var users = debtors.Where(user => user.Debt < 5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value: "\nDebtors with no more than 5,000 in debt");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
                Console.WriteLine(user.ToString());
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
            var users = debtors.Where(user =>
                user.BirthDay.Month is 12 or 1 or 2);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors who were born in Winter");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
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
            var users = debtors.Where(user => user.Debt > average);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nDebtors who have debt more than the average of the total debt");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }

        }

        public static void Method7(List<Debtor> debtors)
        {
        }

        public static void Method8(List<Debtor> debtors)
        {
        }

        public static void Method9(List<Debtor> debtors)
        {
        }

        public static void Method10(List<Debtor> debtors)
        {
        }

        public static void Method11(List<Debtor> debtors)
        {
        }

        public static void Method12(List<Debtor> debtors)
        {
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