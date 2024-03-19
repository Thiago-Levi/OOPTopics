using System;


Worker myWorker = new Worker("Alex", 29000, WorkerLevel.MID_LEVEL, "Design");
//myWorker.ShowObjectWorker();

double baseSalary = 1200.00;

Contract contractA = new Contract("20/08/2018", 50, 20);
Contract contractB = new Contract("13/06/2018", 30, 18);
Contract contractC = new Contract("25/08/2018", 80, 10);


myWorker.addContract(contractA);
myWorker.addContract(contractB);
myWorker.addContract(contractC);
//myWorker.ShowAllContracts();

int month = 8;
int year = 2018;


myWorker.Income(month, year);




