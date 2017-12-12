//using System.Threading.Tasks;
//using Cars.Commands;
//using Cars.EventSource.Storage;
//using DevCon.Command.Services.Domain;
//
//namespace DevCon.Command.Services.Commands.CreateCart
//{
//    public class CreateCartHandler : ICreateCartHandler
//    {
//        private readonly ISession _session;
//        private readonly IRepository _repository;
//
//        public CreateCartHandler(ISession session, IRepository repository)
//        {
//            _session = session;
//            _repository = repository;
//        }
//
//        public async Task<DefaultResponse> ExecuteAsync(CreateCartCommand command)
//	    {   
//            var cartCreator = new CartAggregate(command.UserId);
//	        _repository.Add(cartCreator);
//	        await _session.CommitAsync();
//
//            return new DefaultResponse(cartCreator.AggregateId);
//	    }
//
//    }
//
//    public interface ICreateCartHandler : ICommandHandler<CreateCartCommand>
//    {
//    }
//}
