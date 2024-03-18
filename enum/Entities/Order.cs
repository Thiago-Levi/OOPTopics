using System.Net;

namespace MyApp.Entities
{
  class Order
  {
    public int Id { private get; set; }
    public DateTime Moment = DateTime.Now;
    public OrderStatus Status { private get; set; }




    public void Show()
    {
      System.Console.WriteLine($"Id: {Id} \t Moment: {Moment} \t {Status} ");
    }

  }
}
