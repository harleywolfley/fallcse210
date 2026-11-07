using System.ComponentModel;

class Person
{
    private string _firstname;
    private string _lastname;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastname, int age, double weight)
    {
        _firstname = firstName;
        _lastname = lastname;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return $"{_firstname} {_lastname} is {_age} years old and weighs {_weight}";
    }
}