import Vuex from 'vuex'
import Vue from 'vue'
import mutations from './mutations'
import actions from './actions'
import apiStoreHelper from './apiStoreHelper'
import productRepo from '../repos/productRepo'
import cartRepo from '../repos/cartRepo'

Vue.use(Vuex)

export const ProcessingStatus = {
  NotProcessing: 0,
  Processing: 1,
  Success: 2,
  Error: 3
}

const store = new Vuex.Store({
  strict: true,
  state: {
    processingStatus: ProcessingStatus.NotProcessing,

    errors: [],
    messages: [],
    lastCommandResult: null,

    cartId: null,
    cart: { cartTotal: 0, products: [] },

    products: [],

    removedProductsReport: { products: [] }
  },
  mutations: {
    setProcessing(state) {
      state.processingStatus = ProcessingStatus.Processing
    },
    setSuccess(state, messages) {
      state.processingStatus = ProcessingStatus.Success
      state.errors = []
      if (messages) {
        state.messages = messages
      }
    },
    setError(state, errors) {
      state.processingStatus = ProcessingStatus.Error
      if (errors) {
        state.errors = errors
      }
      state.messages = []
    },

    setProducts(state, products) {
      state.products = products
    },
    setCartId(state, cartId) {
      state.cartId = cartId
    },
    setCart(state, cart) {
      state.cart = cart
    },

    setRemovedProductsReport(state, report) {
      state.removedProductsReport = report
    }
  },

  actions: {
    async retrieveProducts({ state, commit }) {
      if (state.products.length === 0) {
        const result = await apiStoreHelper.processApiGetCall(commit, productRepo.retrieveProducts())
        commit(mutations.SET_PRODUCTS, result.data)
      }
    },

    async createCart({ state, commit }) {
      if (!state.cartId) {
        const result = await apiStoreHelper.processApiCall(commit, cartRepo.createCart(), true)
        commit(mutations.SET_CART_ID, result.data.cartId)
      }
    },
    async retrieveCart({ state, dispatch, commit }) {
      if (!state.cartId) {
        await dispatch(actions.CREATE_CART)
      }
      const result = await apiStoreHelper.processApiGetCall(commit, cartRepo.retrieveCart(state.cartId))
      commit(mutations.SET_CART, result.data)
    },
    async addItemToCart({ state, dispatch, commit }, cartItem) {
      const result = await apiStoreHelper.processApiCall(commit, cartRepo.addItemToCart(state.cartId, cartItem))
      dispatch(actions.RETRIEVE_CART)
    },
    async updateCartItemQuantity({ state, dispatch, commit }, cartItem) {
      const result = await apiStoreHelper.processApiCall(commit, cartRepo.updateCartItemQuantity(state.cartId, cartItem))
      dispatch(actions.RETRIEVE_CART)
    },
    async removeCartItem({ state, dispatch, commit }, cartItem) {
      const result = await apiStoreHelper.processApiCall(commit, cartRepo.removeCartItem(state.cartId, cartItem))
      dispatch(actions.RETRIEVE_CART)
    },

    async retrieveRemovedProductsReport({ commit }) {
      const result = await apiStoreHelper.processApiGetCall(commit, productRepo.retrieveRemovedProductsReport())
      commit(mutations.SET_REMOVED_PRODUCTS_REPORT, result.data)
    }
  },
  getters: {
    hasErrors(state) {
      return state.errors.length > 0
    },
    isProcessing(state) {
      return state.processingStatus === ProcessingStatus.Processing
    }
  }
})

export default store
