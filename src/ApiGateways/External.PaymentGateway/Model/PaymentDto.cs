﻿using System;

namespace Orion.External.PaymentGateway.Model
{
    public class PaymentDto
    {
        public Guid OrderId { get; set; }
        public int Total { get; set; }

    }
}
