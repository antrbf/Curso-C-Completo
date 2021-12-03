using Enumerações_e_Composição.Entities;
using Enumerações_e_Composição.Entities.Enums;
using System;

namespace Enumerações_e_Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

        }
    }
}