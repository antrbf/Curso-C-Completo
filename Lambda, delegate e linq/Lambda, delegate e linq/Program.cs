using Lambda__delegate_e_linq.Entities;
using System;
using System.Collections.Generic;
/*
*Resumo da aula 
public void Sort(Comparison<T> comparison)
• Referência simples de método como parâmetro
• Referência de método atribuído a uma variável tipo delegate
• Expressão lambda atribuída a uma variável tipo delegate
• Expressão lambda inline
*/
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}