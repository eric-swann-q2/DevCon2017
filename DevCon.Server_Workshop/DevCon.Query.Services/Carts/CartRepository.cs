﻿//using System;
//using System.Threading.Tasks;
//using Cars.Projections;
//
//namespace DevCon.Query.Services.Carts
//{
//    public class CartRepository : ICartRepository
//    {
//        private readonly IProjectionRepository _repository;
//
//        public CartRepository(IProjectionRepository repository)
//        {
//            _repository = repository;
//        }
//
//        public Task<CartProjection> GetProjectionAsync(Guid cartId)
//        {
//            return _repository.RetrieveAsync<CartProjection>(cartId);
//        }
//    }
//
//    public interface ICartRepository
//    {
//        Task<CartProjection> GetProjectionAsync(Guid cartId);
//    }
//}