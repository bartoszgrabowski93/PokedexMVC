using Workshops.Models;

namespace Workshops.Patterns;



public class PersonBuilder
{
    private string name, surname, pesel;

    public PersonBuilder AddName(string name)
    {
        this.name = name;
        return this;
    }

    // TODO ustawić pola w zależności od T
    /* public PersonBuilder Add(T valueObject)
    {

    }*/

    public Person Build()
    {
        if (string.IsNullOrEmpty(pesel))
            return new Person.Simple(Guid.NewGuid(), name, surname);
        else
         return new Person.WithPesel(Guid.NewGuid(), name, surname, pesel);
    }
}
