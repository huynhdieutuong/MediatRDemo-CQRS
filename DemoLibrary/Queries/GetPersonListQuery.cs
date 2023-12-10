using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{
    //}
}
