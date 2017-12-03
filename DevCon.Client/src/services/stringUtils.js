class StringUtils {
  camelToLabel(camelString) {
    return (
      camelString
        .replace(/([A-Z])/g, ' $1')
        // uppercase the first character
        .replace(/^./, str => str.toUpperCase())
    )
  }

  toIntValue(value) {
    const intVal = parseInt(value)
    if (isNaN(intVal)) {
      return null
    }
    return intVal
  }
}

const _stringUtils = new StringUtils()

export default _stringUtils
