import Vue from "vue"
import Router from "vue-router"
import ProductList from './components/ProductList'
import Cart from './components/Cart'

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
    meta: { navText: 'Shop til ye drop!', icon: 'store', includeInNav: true }
  },
  {
    path: '/cart',
    component: Cart,
    meta: { navText: 'Ma stuff', icon: 'shopping_cart', includeInNav: true }
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
