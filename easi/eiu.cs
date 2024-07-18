public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name; // CS8618: Name is non-nullable and must be initialized
        Age = age;   // No warning here because int is not a reference type
    }
}
