class Worker
{
  private string Name;
  private double BaseSalary;
  private WorkerLevel Level;
  private Department Department;
  private List<Contract> Contracts = new List<Contract>();


  public Worker(string name, double baseSalary, WorkerLevel level, string departmentOfWorker)
  {
    Name = name;
    BaseSalary = baseSalary;
    Level = level;
    Department = new Department(departmentOfWorker);
  }


  public void ShowObjectWorker()
  {
    System.Console.WriteLine($"{Name}; {BaseSalary:C}; {Level}; {Department.Name}");
  }

  public void addContract(Contract contract)
  {
    Contracts.Add(contract);
  }

  // public void removeContract(Contract contract)
  // {
  //   Contracts.Remove(contract);
  // }

  public void ShowAllContracts()
  {
    foreach (var contract in Contracts)
    {
      contract.ShowObjectContract();
    }
  }

  public double Income(int month, int year)
  {
    double totalIncoming = BaseSalary;

    foreach (Contract contract in Contracts)
    {


      if (contract.Date.Month == month && contract.Date.Year == year)
      {
        totalIncoming += contract.TotalValue();
      }
    }

    return totalIncoming;
  }


}

