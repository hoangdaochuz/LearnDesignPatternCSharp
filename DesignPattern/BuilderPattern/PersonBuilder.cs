namespace SingletonPattern.BuilderPattern;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public string toString()
    {
        return FirstName + " " + LastName + " " + Age + " " + Address;
    }
}


public class PersonBuilder
{
    private Person person = null;

    public PersonBuilder CreatePerson()
    {
        person = new Person();
        return this;
    }

    public PersonBuilder WithFirstName(string firstName)
    {
        person.FirstName = firstName;
        return this;
    }

    public PersonBuilder WithLastName(string lastName)
    {
        person.LastName = lastName;
        return this;
    }

    public PersonBuilder WithAge(int age)
    {
        person.Age = age;
        return this;
    }

    public PersonBuilder WithAddress(string address)
    {
        person.Address = address;
        return this;
    }

    public Person Build()
    {
        return person;
    }
    
}