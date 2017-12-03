import axios from 'axios'
import appSettings from './appSettings'

export class ApiHelper {
  constructor() {
    this._httpClient = axios.create({
      baseURL: appSettings.baseUrl,
      validateStatus: (status) => status < 999,
    })
  }

  async post(url, data, requestConfig = null) {
    const response = await this._httpClient.post(url, data, requestConfig)
    return this._processResponse(response)
  }

  async put(url, data, requestConfig = null) {
    const response = await this._httpClient.put(url, data, requestConfig)
    return this._processResponse(response)
  }

  async get(url, requestConfig = null) {
    const response = await this._httpClient.get(url, requestConfig)
    return this._processResponse(response)
  }

  async delete(url, requestConfig = null) {
    const response = await this._httpClient.get(url, requestConfig)
    return this._processResponse(response)
  }

  get rawClient() {
    return this._httpClient
  }

  _processResponse(response) {
    if (response.status < 400) {
      let data = null
      if (response.data && response.data.data) {
        data = response.data.data
      }
      return { status: response.status, data: data, hasErrors: false }
    }

    let messages = []
    switch (response.status) {
      case 401:
        messages.push({ text: 'Authentication failed or expired, please log in' })
        break
      case 403:
        messages.push({ text: 'You do not have permissions to perform the requested operation' })
        break
      case 404:
        messages.push({ text: 'Requested resource not found' })
        break
      default:
        messages.push({ text: 'An unexpected error occurred, check the console for details' })
        console.error(response)
        break
    }

    if (response.data && response.data.errors && response.data.errors.length > 0) {
      messages = response.data.errors
    }
    return { status: response.status, errors: messages, hasErrors: true }
  }
}

const _apiHelper = new ApiHelper()

export default _apiHelper
