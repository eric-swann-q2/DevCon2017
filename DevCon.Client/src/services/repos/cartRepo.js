import apiHelper from '../apiHelper'

export class ProductRepo {
  
  retrieveCart(cartId) {
    return apiHelper.get(`query/carts/${cartId}`)
  }

  createCart() {
    return apiHelper.post('command/carts', {
      userId: 'Meister Brau'
    })
  }

  addItemToCart(cartId, cartItem) {
    return apiHelper.put(`command/carts/${cartId}/items/${cartItem.sku}`, cartItem)
  }
}

const _productRepo = new ProductRepo()

export default _productRepo
