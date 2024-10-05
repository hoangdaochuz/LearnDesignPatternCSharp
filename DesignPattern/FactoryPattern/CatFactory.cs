namespace DesignPattern;

public class CatFactory:IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cat();
    }
}