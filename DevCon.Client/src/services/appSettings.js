
// These values will be substituted by the deployment tool
const _baseUrl = '#{BaseApiUrl}'

export class AppSettings {
  get baseUrl() {
    return this._getValueOrDefault(_baseUrl, 'http://localhost:5000/')
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
