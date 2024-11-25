public class Model
{
    public string? Name { get; set; }
    public int? Age { get; set; }

    // constructor
    public Model(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Override
    public override string ToString()
    {
        return $"Name: {Name}. Age {Age}"; 
    }
}