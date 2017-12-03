
// These values will be substituted by the deployment tool
const _baseUrl = '#{BaseManagementApiUrl}'

export class AppSettings {
  get baseUrl() {
    return this._getValueOrDefault(_baseUrl, 'http://api.q2oao.local/')
  }

  _getValueOrDefault(value, defaultValue) {
    if (value.indexOf('#') === 0) {
      return defaultValue
    }
    return value
  }
}

const _appSettings = new AppSettings()

export default _appSettings
