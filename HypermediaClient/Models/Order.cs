﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HypermediaClient {
    public class Order {
        public Order() {
            Id = Guid.NewGuid();
            Lines = new List<OrderLine>();
            CreatedDate = DateTimeOffset.UtcNow;
        }

        public Guid Id { get; }
        public int Number { get; set; }
        public DateTimeOffset CreatedDate { get; }
        public Address DeliveryAddress { get; set; }
        public IList<OrderLine> Lines { get; }
        public decimal NetAmount => Lines.Sum(x => x.Amount);
    }
}