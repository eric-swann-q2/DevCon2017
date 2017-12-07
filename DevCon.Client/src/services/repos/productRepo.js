import apiHelper from '../apiHelper'

export class ProductRepo {
  
  retrieveProducts(tenantId) {
    return apiHelper.get('query/products')
  }
}

const _productRepo = new ProductRepo()

export default _productRepo
