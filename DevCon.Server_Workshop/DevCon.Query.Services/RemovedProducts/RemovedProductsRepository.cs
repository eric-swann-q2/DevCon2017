﻿//using System.Threading.Tasks;
//using Cars.Projections;
//
//namespace DevCon.Query.Services.RemovedProducts
//{
//    public class RemovedProductsRepository : IRemovedProductsRepository
//    {
//        private readonly IProjectionRepository _repository;
//
//        public RemovedProductsRepository(IProjectionRepository repository)
//        {
//            _repository = repository;
//        }
//
//        public async Task<RemovedProductsProjection> GetProjectionAsync()
//        {
//            var result = await _repository.RetrieveAsync<RemovedProductsProjection>(Constants.ProjectionId) 
//                ?? new RemovedProductsProjection();
//            return result;
//        }
//    }
//
//    public interface IRemovedProductsRepository
//    {
//        Task<RemovedProductsProjection> GetProjectionAsync();
//    }
//}