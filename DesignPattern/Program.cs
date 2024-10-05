using DesignPattern;
using SingletonPattern.AdapterPattern;
using SingletonPattern.BuilderPattern;
using SingletonPattern.DecoratorPattern;
using SingletonPattern.DependencyInjection;
using SingletonPattern.FacadePattern;

public class Program
{
    public static void Main()
    {
        // Singleton Pattern
        // Singleton s1 = Singleton.Instance;
        // Singleton s2 = Singleton.Instance;
        // System.Console.WriteLine(s1.Equals(s2));
        
        // Factory Pattern
        // IAnimalFactory dogFactory = new DogFactory();
        // IAnimalFactory catFactory = new CatFactory();
        // IAnimal dog = dogFactory.CreateAnimal();
        // IAnimal cat = catFactory.CreateAnimal();
        // dog.MakeNoise();
        // cat.MakeNoise();
        
        // Builder Pattern
        // Person person = new PersonBuilder()
        //                     .CreatePerson()
        //                     .WithFirstName("Khai")
        //                     .WithLastName("Nguyen")
        //                     .WithAge(22)
        //                     .WithAddress("Ho Chi Minh")
        //                     .Build();
        //
        // Console.WriteLine(person.toString());
        
        // Dependency Injection Pattern
        // // The Service A is using MySQL to store data
        // IDataAccessLayer mySqlDataAccessLayer = new SqlDataAccessLayer();
        // BusinessLayer serviceABusinessLayer = new BusinessLayer(mySqlDataAccessLayer);
        // serviceABusinessLayer.SaveData("Hello Khai");   
        //
        // // The service B is using MongoDB to store data
        // IDataAccessLayer mongoDBAccessLayer = new MongoDataAccessLayer();
        // BusinessLayer serviceBBusinessLayer  = new BusinessLayer(mongoDBAccessLayer);
        // serviceBBusinessLayer.SaveData("Hello Khai kkk");
        
        // Adapter pattern
        // InternalPaymentMethod inSystemPayment = new InSystemPayment();
        // inSystemPayment.PayProcess(30);
        //
        // ThirdPartySystemPayment thirdPartySystemPayment = new ThirdPartySystemPayment();
        // InternalPaymentMethod customPaymentMethod = new ThirdPartyPaymentSystemAdapter(thirdPartySystemPayment);
        // customPaymentMethod.PayProcess(30);
        
        // Decorator pattern
        // ICoffee simpleCoffee = new SimpleCoffee();
        // System.Console.WriteLine(simpleCoffee.getDescription()+" "+ simpleCoffee.GetPrice());
        // ICoffee milkCoffee = new MilkCoffee(simpleCoffee);
        // System.Console.WriteLine(milkCoffee.getDescription()+ " "+ milkCoffee.GetPrice());
        
        // FacadePattern
        UpdateUserMVCFacade _updateUserMVCFacade = new UpdateUserMVCFacade();
        _updateUserMVCFacade.UpdateUserFlow();
    }
}
