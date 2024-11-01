using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ex_mylib_nima_zarrabi
{

    public static class Ext
    {
        /// Corps de la fonction à compléter
        public static int ReadInt(this string prompt)
        {
            int result;
            do
            {
                Console.Write(prompt);
                result = Convert.ToInt32(Console.ReadLine());
            } while (result == -1);
            return result;
        }

        public static void Write(this string prompt, ConsoleColor color)
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(prompt);
            Console.ForegroundColor = current;
        }

        public static int ToIntSafe(this string prompt, int defaultValue)
        {
            Regex regex = new Regex("[^0-9]");

            if (!regex.IsMatch(prompt))
            {
                try { Convert.ToInt64(prompt); }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                const Int32 MAXINTVALUE = 2147483647;
                const Int32 MININTVALUE = -2147483648;

                    if (Convert.ToInt64(prompt) > MAXINTVALUE)
                    { return MAXINTVALUE; }
                    else if (Convert.ToInt64(prompt) < MININTVALUE)
                    { return MININTVALUE; }
                    else { return Convert.ToInt32(prompt); }
            }
            else
            {
                Console.Error.WriteLine("Veillez entrer un chiffre");
                return defaultValue;
            }
        }

        public static int ToIntSafe(this string prompt)
        {
            int defaultValue = 0;
            Regex regex = new Regex("[^0-9]");

            if (!regex.IsMatch(prompt))
            {
                try { Convert.ToInt64(prompt); }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                const Int32 MAXINTVALUE = 2147483647;
                const Int32 MININTVALUE = -2147483648;

                if (Convert.ToInt64(prompt) > MAXINTVALUE)
                { return MAXINTVALUE; }
                else if (Convert.ToInt64(prompt) < MININTVALUE)
                { return MININTVALUE; }
                else { return Convert.ToInt32(prompt); }
            }
            else
            {
                Console.Error.WriteLine("Veillez entrer un chiffre");
                return defaultValue;
            }
        }


        public static string RandomString(this Random random, int length)
        {
            var stringChars = new char[length];
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public static bool RandomBool(this Random random)
        {
            return (random.Next(0, 1) > 0 ? true : false);
        }
    }
}
