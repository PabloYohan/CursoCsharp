using System;
using System.Globalization;
using System.Collections.Generic;
using exercicio.Entities.Enums;
using System.Text;


namespace exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();


        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach(OrderItem c in Items)
            {
                double value = c.SubTotal();
                soma += value;
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("Order moment: "+ Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            a.AppendLine("Order status: " + Status);
            a.AppendLine("Client: " + Client);
            a.AppendLine("Order items: ");
            foreach(OrderItem c in Items)
            {
                a.AppendLine(c.ToString());
            }
            a.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return a.ToString();
        }
    }
}
