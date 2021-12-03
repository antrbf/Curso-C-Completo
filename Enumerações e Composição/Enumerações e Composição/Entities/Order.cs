﻿using System;
using System.Collections.Generic;
using System.Text;
using Enumerações_e_Composição.Entities.Enums;

namespace Enumerações_e_Composição.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
