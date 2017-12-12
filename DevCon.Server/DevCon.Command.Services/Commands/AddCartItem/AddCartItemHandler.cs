using System.Threading.Tasks;
using Cars.Commands;
using Cars.EventSource.Storage;
using DevCon.Command.Services.Domain;

namespace DevCon.Command.Services.Commands.AddCartItem
{
    public class AddCartItemHandler : IAddCartItemHandler
    {
        private readonly ISession _unitOfWork;
        private readonly IRepository _repository;

        public AddCartItemHandler(ISession session, IRepository repository)
        {
            _unitOfWork = session;
            _repository = repository;
        }

        public async Task<DefaultResponse> ExecuteAsync(AddCartItemCommand command)
        {
            var cart = await _repository.GetByIdAsync<CartItemAggregate>(command.CartId);
            cart.AddCartItem(command.Sku, command.Name, command.SalePrice, command.Quantity, command.CustomerTopRated, command.Image);

            _repository.Add(cart);
            await _unitOfWork.CommitAsync();

            return new DefaultResponse(cart.AggregateId);
	    }
    }

    public interface IAddCartItemHandler : ICommandHandler<AddCartItemCommand>
    {

    }
}
