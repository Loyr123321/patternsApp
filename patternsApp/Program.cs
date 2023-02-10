using patternsApp;
using patternsApp.Strategy_Pattern;
using patternsApp.Strategy_Pattern.Strategies;
using System;






// ПАТТЕРН "АБСТРАКТНАЯ ФАБРИКА"

//interface IEngine
//{
//    void ReleaseEngine();
//}

//class JapaneseEngine : IEngine
//{
//    public void ReleaseEngine() => Console.WriteLine("Японский двигатель");

//}

//class RussianEngine : IEngine
//{
//    public void ReleaseEngine() => Console.WriteLine("Российский двигатель");
//}

//interface ICar
//{
//    void ReleaseCar(IEngine engine);
//}

//class JapaneseCar : ICar
//{
//    public void ReleaseCar(IEngine engine)
//    {
//        Console.WriteLine("Собрали японское авто: ");
//        engine.ReleaseEngine();

//    }

//}

//class RussianCar : ICar
//{
//    public void ReleaseCar(IEngine engine)
//    {
//        Console.WriteLine("Собрали русское авто:");
//        engine.ReleaseEngine();
//    }

//}

//interface IFactory
//{
//    IEngine createEngine();
//    ICar createCar();
//}

//class JapaneseFactory : IFactory
//{
//    public ICar createCar() => new JapaneseCar();
//    public IEngine createEngine() => new JapaneseEngine();
//}
//class RussianFactory : IFactory
//{
//    public ICar createCar() => new RussianCar();
//    public IEngine createEngine() => new RussianEngine();
//}

// ПАТТЕРН "АБСТРАКТНАЯ ФАБРИКА"

// ПАТТЕРН "СТРОИТЕЛЬ"





// ПАТТЕРН "СТРОИТЕЛЬ"
//List<Employee> employees = new()
//{
//    new Employee { Name="Ivan", Salary= 100},
//    new Employee { Name = "Boris", Salary = 167 },
//    new Employee { Name = "Fedor", Salary = 250 }
//};
//var builder = new EmployeeReportBuilder(employees);

//var director = new EmployeeReportDirector(builder);

//director.Build();

//var report = builder.GetReport();
//Console.WriteLine(report);

// ПАТТЕРН "СТРОИТЕЛЬ"

// ПАТТЕРН "СТРАТЕГИЯ"
Hero hero = new("Squidward");
hero.Attack();

hero.SetWeapon(new Plunger());

hero.Attack();

Console.ReadLine();


// ПАТТЕРН "СТРАТЕГИЯ"

