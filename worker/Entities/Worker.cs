class Worker
{
  private string Name;
  private double BaseSalary;
  private WorkerLevel level;
  private Department department;
  private List<Contract> contracts = new List<Contract>();


  public Worker(string name, double baseSalary, WorkerLevel level, string departmentOfWorker)
  {
    Name = name;
    BaseSalary = baseSalary;
    this.level = level;
    this.department = new Department(departmentOfWorker);
  }


  public void ShowObjectWorker()
  {
    System.Console.WriteLine($"{Name}; {BaseSalary:C}; {level}; {department.Name}");
  }

  public void addContract(Contract contract)
  {
    contracts.Add(contract);
  }

  public void removeContract(Contract contract)
  {
    contracts.Remove(contract);
  }

  public void ShowAllContracts()
  {
    foreach (var contract in contracts)
    {
      contract.ShowObjectContract();
    }
  }

  public double Income(int month, int year)
  {

    foreach (var contract in contracts)
    {

      if (contract.date.Month == month && contract.date.Year == year)
      {
        System.Console.WriteLine($"Achei -> {contract.TotalValue()}");
      }
    }

    return 0.0;
  }


}

