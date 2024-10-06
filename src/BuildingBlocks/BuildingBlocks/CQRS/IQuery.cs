
using MediatR;

namespace BuildingBlocks.CQRS;
// Esta interfaz es para operaciones de lectura en el CQRS
public interface IQuery<out TResponse>: IRequest<TResponse>
    where TResponse: notnull
{
}
