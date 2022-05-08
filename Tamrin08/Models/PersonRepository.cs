using Tamrin08;
using Tamrin08.Models;
namespace Tamrin08.Models;

public class PersonRepository
{
    private static List<Person> people;
    static PersonRepository()
    {
        people = new List<Person>();
        people.Add(new Person
        {
            Name = "Ali",
            Id = "101"
        });
        people.Add(new Person
        {
            Name = "Amir",
            Id = "102"
        });
        people.Add(new Person
        {
            Name = "Hamid",
            Id = "103"
        });
        people.Add(new Person
        {
            Name = "Sepehr",
            Id = "104"
        });
        people.Add(new Person
        {
            Name = "Hadi",
            Id = "105"
        });
    }
    public List<Person> GetAllPeople()
    {
        return people;
    }
}    

