using System;


//testing conversion
string workerLevel = "Junior";
WorkerLevel level = Enum.Parse<WorkerLevel>(workerLevel);
double baseSalary = 1200.00;

Worker myWorker = new Worker("Alex", baseSalary, level, "Design");

myWorker.ShowObjectWorker();


Contract contractA = new Contract("20/08/2018", 50, 20);
Contract contractB = new Contract("13/06/2018", 30, 18);
Contract contractC = new Contract("25/08/2018", 80, 10);


myWorker.addContract(contractA);
myWorker.addContract(contractB);
myWorker.addContract(contractC);
myWorker.ShowAllContracts();

//testing conversion input user

string monthAndYear = "08/2018";
int month = Convert.ToInt32(monthAndYear.Substring(0, 2));
int year = Convert.ToInt32(monthAndYear.Substring(3));

double incomeFor = myWorker.Income(month, year);

System.Console.WriteLine($"Income for {monthAndYear}: {incomeFor:C}");




