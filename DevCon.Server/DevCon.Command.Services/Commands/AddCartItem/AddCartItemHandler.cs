//using System.Threading.Tasks;
//using Cars.Commands;
//using Cars.EventSource;
//using Cars.EventSource.Storage;
//using DevCon.Command.Services.Domain;
//
//namespace DevCon.Command.Services.Commands.AddCartItem
//{
//    public class CreateCartHandler : IAddCartItemHandler
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IRepository _repository;
//
//        public CreateCartHandler(IUnitOfWork unitOfWork, IRepository repository)
//        {
//            _unitOfWork = unitOfWork;
//            _repository = repository;
//        }
//
//        public async Task<DefaultResponse> ExecuteAsync(AddCartItemCommand command)
//        {
//            var cart = await _repository.GetByIdAsync<Cart>(command.CartId);
//            cart.AddCartItem(command.Sku, command.Name, command.SalePrice, command.Quantity, command.CustomerTopRated, command.Image);
//
//            await _repository.AddAsync(cart);
//            await _unitOfWork.CommitAsync();
//
//            return new DefaultResponse(cart.AggregateId);
//	    }
//
//    }
//
//    public interface IAddCartItemHandler : ICommandHandler<AddCartItemCommand>
//    {
//
//    }
//}
