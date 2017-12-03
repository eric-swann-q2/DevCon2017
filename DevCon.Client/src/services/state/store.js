import Vuex from 'vuex'
import Vue from 'vue'
import mutations from './mutations'
import apiStoreHelper from './apiStoreHelper'

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
    lastCommandResult: null
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
    }
  },

  actions: {
    // async retrieveServices({ state, commit }) {
    //   if (state.services.length === 0) {
    //     const result = await apiStoreHelper.processApiGetCall(commit, serviceRepo.getServiceList())
    //     commit(mutations.SET_SERVICES, result.data)
    //   }
    // }
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
