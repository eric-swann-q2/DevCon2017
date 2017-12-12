using System.Threading.Tasks;
using Cars.Commands;
using Cars.EventSource.Storage;
using DevCon.Command.Services.Domain;

namespace DevCon.Command.Services.Commands.UpdateCartItemQuantity
{
    public class UpdateCartItemQuantityHandler : IUpdateCartItemQuantityHandler
    {
        private readonly ISession _unitOfWork;
        private readonly IRepository _repository;

        public UpdateCartItemQuantityHandler(ISession session, IRepository repository)
        {
            _unitOfWork = session;
            _repository = repository;
        }

        public async Task<DefaultResponse> ExecuteAsync(UpdateCartItemQuantityCommand command)
        {
            var cart = await _repository.GetByIdAsync<CartItemAggregate>(command.CartId);
            cart.UpdatedCartItemQuantity(command.Sku, command.Quantity);
            
	        _repository.Add(cart);
	        await _unitOfWork.CommitAsync();

            return new DefaultResponse(cart.AggregateId);
	    }
    }

    public interface IUpdateCartItemQuantityHandler : ICommandHandler<UpdateCartItemQuantityCommand>
    {

    }
}
