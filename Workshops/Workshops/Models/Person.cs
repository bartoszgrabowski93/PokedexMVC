namespace Workshops.Models;

// TODO1: valueObjects
public abstract record RepositoryObject(Guid Id);
public abstract record Person(Guid Id) : RepositoryObject(Id)
{
   // public Guid Id { get; set; }
   // public string Name { get; set; }
   // public string Surname { get; set; }
   // public string? Pesel {  get; set; }
    
public record Simple(Guid Id, string Name, string Surname) : Person(Id)
{
  
            

}

public record WithPesel(Guid Id, string Name, string Surname, string Pesel) : Person(Id)
{

}
}
