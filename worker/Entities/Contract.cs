using System;
class Contract
{
  public DateTime Date { get; }
  public double ValuePerHour { get; set; }
  public int Hours { get; set; }


  public Contract(string dateStringFormat, double valuePerHour, int hours)
  {
    Date = DateTime.Parse(dateStringFormat);
    ValuePerHour = valuePerHour;
    Hours = hours;

  }
  public double TotalValue()
  {
    return ValuePerHour * Hours;
  }

  public void ShowObjectContract()
  {
    System.Console.WriteLine($"{Date}; {ValuePerHour:C}; {Hours}");
  }



}
//date.Day;
//date.Month;
//date.Year

//