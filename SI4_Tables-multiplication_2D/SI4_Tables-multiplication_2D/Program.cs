/* Author : David ROUMANET
 * Desc.  : simple program to show how to use two nested loops
 * Date   : 09 december 2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Table de Multiplication (Tableau 2D)");
            for (int y = 1; y < 11; y++) {
                // First loop : print each new line

                for (int x = 1; x < 11; x++) {
                    // Second loop, for each row on the line 
                    Console.Write(x * y + "\t");    // use Write rather WriteLine. \t is just a tabulation
                }

                Console.WriteLine();    // at the end of line, jump to the next line
            }
            Console.ReadLine();
        }
    }
}
