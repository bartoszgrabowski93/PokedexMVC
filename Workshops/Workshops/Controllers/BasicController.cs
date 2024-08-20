using Microsoft.AspNetCore.Mvc;
using Workshops.Models;
using Workshops.Patterns;

namespace Workshops.Controllers;

//ProblemDetails - poczytać o tym 

public record PersonRequest(string Name, string Surname, string? Pesel = null);

public record PersonResponse(Guid Id, string Name, string Surname, string? Pesel = null);

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IResult Get([FromRoute]Guid id)
    {
        //3 todo get from repository
        var person = new Person.Simple(Guid.NewGuid(), "Ala", "Kowalska");
        var personResponse = new PersonResponse(person.Id, person.Name, person.Surname);


        return Results.Ok(personResponse);
    }

    [HttpPost]
    public IResult Add([FromBody] PersonRequest person) 
    { 
        ExampleHandler handler = new ExampleHandler();
        handler.Handle(person);
        return Results.Ok(person);
    }
}
