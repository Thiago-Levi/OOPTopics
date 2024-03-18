using System;
using System.Data.Common;
using MyApp.Entities;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Order myFirstOrder = new Order { Id = 1090, Status = OrderStatus.PendingPayment };
      myFirstOrder.Show();

      //Converte de enum para string
      string stg = OrderStatus.PendingPayment.ToString();

      //Converte de String para enum
      OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

      System.Console.WriteLine(stg);
      System.Console.WriteLine(os);

    }
  }
}