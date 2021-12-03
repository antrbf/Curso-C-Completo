using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixação_Enums_e_Composição.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
