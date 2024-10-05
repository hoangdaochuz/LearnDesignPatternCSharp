namespace DesignPattern;

public class DogFactory:IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Dog();
    }
}