<template>
  <div class="main-margin">
    <div class="row xs-gutter">
      <div v-for="(product, i) in products" :key="i">
        <product-tile :value="product" />
      </div>
    </div>
  </div>
</template>

<script>
import actions from '../services/state/actions'
import ProductTile from './CartItem'

export default {
  name: 'cart',
  async created() {
    await this.fetchData()
  },
  components: {
    ProductTile
  },
  methods: {
    async fetchData() {
      return this.$store.dispatch(actions.RETRIEVE_CART)
    }
  },
  computed: {
    products() {
      return this.$store.state.cart.products
    }
  }
}
</script>

<style scoped>
.main-margin {
  margin: 10px;
}
</style>


