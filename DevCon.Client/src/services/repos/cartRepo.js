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

  updateCartItemQuantity(cartId, cartItem) {
    return apiHelper.put(`command/carts/${cartId}/items/${cartItem.sku}/quantity`, cartItem)
  }

  removeCartItem(cartId, cartItem) {
    return apiHelper.delete(`command/carts/${cartId}/items/${cartItem.sku}`)
  }
}

const _productRepo = new ProductRepo()

export default _productRepo
