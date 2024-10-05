using DesignPattern;
using SingletonPattern.AdapterPattern;
using SingletonPattern.BridgePattern;
using SingletonPattern.BuilderPattern;
using SingletonPattern.CommandPattern;
using SingletonPattern.DecoratorPattern;
using SingletonPattern.DependencyInjection;
using SingletonPattern.FacadePattern;
using SingletonPattern.ObserverPattern;
using SingletonPattern.StrategyPattern;

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
        //UpdateUserMVCFacade _updateUserMVCFacade = new UpdateUserMVCFacade();
        //_updateUserMVCFacade.UpdateUserFlow();
        
        // Bridge Pattern
        // IDatabase mySqlDatabase = new MySQLDatabase();
        // RefinedDatabaseManager mySqlDatabaseManager = new RefinedDatabaseManager(mySqlDatabase);
        // mySqlDatabaseManager.Connect();
        // mySqlDatabaseManager.RunQuery("Select * from Customers");
        // mySqlDatabaseManager.RunQueries(["Select * from Customers","Select * from Cart"]);
        // mySqlDatabaseManager.Disconnect();
        //
        // IDatabase mongoDatabase = new MongoDatabase();
        // RefinedDatabaseManager mongoDatabaseManager = new RefinedDatabaseManager(mongoDatabase);
        // mongoDatabaseManager.Connect();
        // mongoDatabaseManager.RunQuery("Select * from Customers");
        // mongoDatabaseManager.RunQueries(["Select * from Customers","Select * from Cart"]);
        // mongoDatabaseManager.Disconnect();
        
        // ObserverPattern
        // YoutubeChannel youtubeChannel = new YoutubeChannel();
        // Subcriber subcriber1 = new Subcriber(youtubeChannel,"Khai1", []);
        // Subcriber subcriber2 = new Subcriber(youtubeChannel,"Khai2", []);
        // Subcriber subcriber3 = new Subcriber(youtubeChannel,"Khai3", []);
        // youtubeChannel.Subscribe(subcriber1);
        // youtubeChannel.Subscribe(subcriber2);
        // // youtubeChannel.Subscribe(subcriber3);
        // youtubeChannel.NewNotification = "youtubeChannel has posted a new video1";
        // youtubeChannel.NewNotification = "youtubeChannel has posted a new video2";
        // youtubeChannel.NewNotification = "youtubeChannel has posted a new video3";
        //
        // List<string> subcriber1Notifications = subcriber1.GetNotifications();
        // System.Console.WriteLine("Notification subcriber 1");
        // foreach (var noti in subcriber1Notifications)
        // {
        //     System.Console.WriteLine(noti);
        // }
        // List<string> subcriber3Notifications = subcriber3.GetNotifications();
        // System.Console.WriteLine("Notification subcriber 3");
        // foreach (var noti in subcriber3Notifications)
        // {
        //     System.Console.WriteLine(noti);
        // }
        
        // Command Pattern
        // TelevisionReceiver televisionReceiver = new TelevisionReceiver();
        // ICommand _increaseVolume = new IncreaseVolumeCommand(televisionReceiver);
        // ICommand _decreaseVolume = new DecreaseVolumeCommand(televisionReceiver);
        //
        // RemoteControlInvoker remoteControl = new RemoteControlInvoker(_increaseVolume, _decreaseVolume);
        // remoteControl.IncreaseExecute();
        // remoteControl.IncreaseExecute();
        // remoteControl.IncreaseExecute();
        // remoteControl.IncreaseExecute();
        // remoteControl.IncreaseExecute();
        // remoteControl.DecreaseExecute();
        //
        // System.Console.WriteLine("Current volume: "+televisionReceiver.Volume);
        
        // Strategy Pattern
        string typePayment = "Paypal";
        IStrategy paymentStrategy;
        if (typePayment == "Momo")
        {
            paymentStrategy = new MomoPaymentStrategy();
        }
        else
        {
            paymentStrategy = new PaypalPaymentStrategy();
        }
        
        PaymentContext paymentContext = new PaymentContext(paymentStrategy);
        paymentContext.ExecutePayment();

    }
}
