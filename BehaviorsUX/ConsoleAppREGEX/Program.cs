using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppREGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current NumberFormatInfo object to build the regular 
            // expression pattern dynamically.
            NumberFormatInfo nfi = NumberFormatInfo.CurrentInfo;

            // Define the regular expression pattern.
            string pattern;
            pattern = @"^\s*[";
            // Get the positive and negative sign symbols.
            pattern += Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
            // Get the currency symbol.
            pattern += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
            // Add integral digits to the pattern.
            pattern += @"(\d*";
            // Add the decimal separator.
            pattern += Regex.Escape(nfi.CurrencyDecimalSeparator) + "?";
            // Add the fractional digits.
            pattern += @"\d{";
            // Determine the number of fractional digits in currency values.
            pattern += nfi.CurrencyDecimalDigits.ToString() + "}?){1}$";
            /////           ^\s *[\+-] ?\s ?\$?\s ? (\d *\.?\d{ 2}?){ 1}$
             
            Regex rgx = new Regex(pattern);
            Console.WriteLine("{0}    -- PATRON", pattern);
            Console.ReadKey();
            // Define some test strings.
            string[] tests = { "-42", "19.99", "0.001", "100 USD",
                         ".34", "0.34", "1,052.21", "$10.62",
                         "+1.43", "-$0.23" };

            // Check each test string against the regular expression.
            foreach (string test in tests)
            {
                if (rgx.IsMatch(test))
                    Console.WriteLine("{0} is a currency value.", test);
                else
                    Console.WriteLine("{0} is not a currency value.", test);
            }

            Console.ReadKey();
        }
    }
}
