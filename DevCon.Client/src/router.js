import Vue from "vue"
import Router from "vue-router"

Vue.use(Router);

function load(component) {
  // '@' is aliased to src/components
  return () => import(`@/${component}.vue`)
}

export const routes = [
  { path: "/", component: load("Hello") },

  // Always leave this last one
  { path: "*", component: load("Error404") } // Not found
]

const _router = new Router({
  mode: "hash",
  scrollBehavior: () => ({ y: 0 }),
  routes: routes
})

export default _router
