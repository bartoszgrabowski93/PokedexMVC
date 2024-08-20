using Workshops.Controllers;
using Workshops.Models;
namespace Workshops.Patterns
{
    public interface IHandler<T>
    {
        public Task Handle(T input);
    }

    public class ExampleHandler : IHandler<PersonRequest>
    {
        public Task Handle(PersonRequest input)
        {

            Person person = null;
            PersonBuilder builder = new PersonBuilder();
            person = builder
                .Add(...)
                .Add(...)
                .Build();

            /*
            if (string.IsNullOrEmpty(input.Pesel))
                person = new Person.Simple(Guid.NewGuid(), input.Name, input.Surname);
            else
                person = new Person.WithPesel(Guid.NewGuid(), input.Name, input.Surname, input.Pesel);
            */
            return Task.CompletedTask;
        }

    }
}
