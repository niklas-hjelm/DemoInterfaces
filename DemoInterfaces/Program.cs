using DemoInterfaces;

Car myCar = new Car();

myCar.Content = "Jag";

myCar.MakeSound();
myCar.Move();

Console.WriteLine(myCar.Content);

Truck myTruck = new Truck();
myTruck.Content = "1000l coca-cola";
myTruck.Capacity = 200_000;

myTruck.MakeSound();
myTruck.Move();

Console.WriteLine(myTruck.Content);
Console.WriteLine(myTruck.Capacity);


RaceCar myRaceCar = new RaceCar();
myRaceCar.Content = "1 coca-cola";
myRaceCar.MakeSound();
myRaceCar.Move();

Console.WriteLine(myRaceCar.Content);