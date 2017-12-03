// === DEFAULT / CUSTOM STYLE ===
// WARNING! always comment out ONE of the two require() calls below.
// 1. use next line to activate CUSTOM STYLE (./src/themes)
// require(`./themes/app.${__THEME}.styl`)
// 2. or, use next line to activate DEFAULT QUASAR STYLE
require(`quasar/dist/quasar.${__THEME}.css`)
// ==============================

// Uncomment the following lines if you need IE11/Edge support
// require(`quasar/dist/quasar.ie`)
// require(`quasar/dist/quasar.ie.${__THEME}.css`)

import Vue from 'vue'
import Quasar, {
  QLayout, QTabs, QTab, QTabPane, QRouteTab,
  QCard, QCardMain, QCardSeparator, QCardActions, QCardTitle, QCardMedia,
  QTransition, QSlideTransition,
  QToolbar, QToolbarTitle, QAlert,
  QBtn, QIcon, QPopover, QTooltip, QModal,
  QField, QInput, QRadio, QSelect, QToggle, QChipsInput,
  QList, QListHeader, QSideLink, QCollapsible,
  QItemSide, QItemMain, QItemSeparator, QItem, QItemTile,
  Ripple
} from 'quasar'
import uiRegistrar from './components/ui/ComponentRegistrar'
import router from './router'
import { sync } from 'vuex-router-sync'
import store from './services/state/store' // vuex 
import 'quasar-extras/animate/slideInLeft.css'
import 'quasar-extras/animate/fadeOutRight.css'

Vue.config.productionTip = false
Vue.use(Quasar, {
  components: [QLayout, QTabs, QTab, QTabPane, QRouteTab,
    QCard, QCardMain, QCardSeparator, QCardActions, QCardTitle, QCardMedia,
    QTransition, QSlideTransition,
    QToolbar, QToolbarTitle, QAlert,
    QBtn, QIcon, QPopover, QTooltip, QModal,
    QField, QInput, QRadio, QSelect, QToggle, QChipsInput,
    QList, QListHeader, QSideLink, QCollapsible,
    QItemSide, QItemMain, QItemSeparator, QItem, QItemTile],
  directives: [Ripple]
})

uiRegistrar.registerAll(Vue)

sync(store, router) // done. Returns an unsync callback fn

if (__THEME === 'mat') {
  require('quasar-extras/roboto-font')
}
import 'quasar-extras/material-icons'
// import 'quasar-extras/animate'

Quasar.start(() => {
  /* eslint-disable no-new */
  new Vue({
    el: '#q-app',
    store,
    router,
    render: h => h(require('./App').default)
  })
})
