class Police : Person
{
    private string _weapons;
    public Police(string firstName, string lastname, int age, double weight, string weapons)
    : base(firstName, lastname, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"Police: Weapons: {_weapons}: {GetPersonInformation()}";
    }
}