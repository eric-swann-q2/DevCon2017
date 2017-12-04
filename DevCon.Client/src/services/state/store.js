import Vuex from 'vuex'
import Vue from 'vue'
import mutations from './mutations'
import apiStoreHelper from './apiStoreHelper'
import productRepo from '../repos/productRepo'

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

    products: []
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
    }
  },

  actions: {
    async retrieveProducts({ state, commit }) {
      if (state.products.length === 0) {
        const result = await apiStoreHelper.processApiGetCall(commit, productRepo.getProducts())
        commit(mutations.SET_PRODUCTS, result.data)
      }
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
