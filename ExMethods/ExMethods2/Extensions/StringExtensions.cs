using System.Collections.Generic;
using System.Text;

/*
 * Vamos criar um extension method chamado "Cut(int)" na classe String
para receber um valor inteiro como parâmetro e gerar um recorte do
string original daquele tamanho. Por exemplo:
String s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));
"Good morni..."
 */

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
