import mutations from './mutations'
import loadingStatus from '../loadingStatus'

class ApiStoreHelper {
  async processApiCall(commit, apiFunc, hideDefaultSuccessMessage) {
    this.apiCallStarted(commit)
    const result = await apiFunc
    if (result.hasErrors) {
      this.apiCallFailed(commit, result.errors)
    } else {
      this.apiCallSucceeded(commit, result.messages, hideDefaultSuccessMessage)
    }
    return result
  }

  processApiGetCall(commit, apiFunc) {
    return this.processApiCall(commit, apiFunc, true)
  }

  apiCallStarted(commit) {
    loadingStatus.show()
    commit(mutations.SET_PROCESSING, { root: true })
  }

  apiCallSucceeded(commit, messages, hideDefaultMessage) {
    loadingStatus.hide()
    if ((!messages || messages.length === 0) && !hideDefaultMessage) {
      messages = [{ text: 'Operation succeeded!' }]
    }
    commit(mutations.SET_SUCCESS, messages, { root: true })
  }

  apiCallFailed(commit, errors) {
    loadingStatus.hide()
    if (!errors || errors.length === 0) {
      errors = [{ text: 'Operation failed!' }]
    }
    commit(mutations.SET_ERROR, errors, { root: true })
  }
}

const _apiStoreHelper = new ApiStoreHelper()

export default _apiStoreHelper
