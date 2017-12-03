module.exports = {
  root: true,
  parser: 'babel-eslint',
  parserOptions: {
    sourceType: 'module'
  },
  env: {
    browser: true
  },
  // https://github.com/feross/standard/blob/master/RULES.md#javascript-standard-style
  extends: [
    'prettier'
  ],
  // required to lint *.vue files
  plugins: [
    'html',
    'import',
    'prettier'
  ],
  globals: {
    'DEV': true,
    'PROD': true,
    '__THEME': true,
    'describe': true,
    'expect': true,
    'test': true
  },
  // add your custom rules here
  'rules': {
    // allow paren-less arrow functions
    'arrow-parens': 0,
    'one-var': 0,
    'import/first': 0,
    'import/named': 2,
    'import/namespace': 2,
    'import/default': 2,
    'import/export': 2,
    // allow debugger during development
    'no-debugger': process.env.NODE_ENV === 'production' ? 2 : 0,

    "comma-dangle": ["error", "only-multiline"],
    "space-before-function-paren": ["error", "never"],
    "object-property-newline": "off"
  }
}
