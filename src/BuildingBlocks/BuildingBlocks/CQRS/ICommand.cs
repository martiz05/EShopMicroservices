using MediatR;

namespace BuildingBlocks.CQRS;

/// <summary>
/// Esta interfaz es para operaciones sin respuestas
/// </summary>
public interface ICommand: ICommand<Unit>
{

}


/// <summary>
/// Esta interfaz es para operaciones con respuestas
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface ICommand<out TResponse>: IRequest<TResponse>
{
}
