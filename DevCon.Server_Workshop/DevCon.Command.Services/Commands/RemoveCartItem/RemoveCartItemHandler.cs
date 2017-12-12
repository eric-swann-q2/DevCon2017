using System.Threading.Tasks;
using Cars.Commands;
using Cars.EventSource.Storage;
using DevCon.Command.Services.Domain;

namespace DevCon.Command.Services.Commands.RemoveCartItem
{
    public class RemoveCartItemHandler : IRemoveCartItemHandler
    {
        private readonly ISession _unitOfWork;
        private readonly IRepository _repository;

        public RemoveCartItemHandler(ISession session, IRepository repository)
        {
            _unitOfWork = session;
            _repository = repository;
        }

        public async Task<DefaultResponse> ExecuteAsync(RemoveCartItemCommand command)
        {
            var cart = await _repository.GetByIdAsync<CartItemAggregate>(command.CartId);
            cart.RemoveCartItem(command.Sku);
            
	        _repository.Add(cart);
	        await _unitOfWork.CommitAsync();

            return new DefaultResponse(cart.AggregateId);
	    }
    }

    public interface IRemoveCartItemHandler : ICommandHandler<RemoveCartItemCommand>
    {

    }
}
