import Vue from "vue"
import Router from "vue-router"
import ProductList from './components/ProductList'

Vue.use(Router);

function load(component) {
  // '@' is aliased to src/components
  return () => import(`@/${component}.vue`)
}

export const routes = [
  {
    path: '/',
    redirect: '/productlist'
  },
  {
    path: '/productlist',
    component: ProductList,
    meta: { navText: 'Products', icon: 'store', includeInNav: true }
  },

  // Always leave this last one
  { path: "*", component: load("Error404") } // Not found
]

const _router = new Router({
  mode: "hash",
  scrollBehavior: () => ({ y: 0 }),
  routes: routes
})

export default _router
