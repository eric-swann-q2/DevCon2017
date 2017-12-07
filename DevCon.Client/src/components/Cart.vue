<template>
  <titled-card :title="title">
    <div class="row xs-gutter">
      <div v-for="(product, i) in products" :key="i">
        <cart-tile :value="product" />
      </div>
    </div>
  </titled-card>
</template>

<script>
import actions from '../services/state/actions'
import CartTile from './CartTile'

export default {
  name: 'cart',
  async created() {
    await this.fetchData()
  },
  components: {
    CartTile
  },
  methods: {
    async fetchData() {
      return this.$store.dispatch(actions.RETRIEVE_CART)
    }
  },
  computed: {
    products() {
      return this.$store.state.cart.products
    },
    title() {
      let title = "My Cart"
      const total = this.$store.state.cart.cartTotal
      if(total && total > 0) {
        title = `${title} - Cart Total: ${total.toLocaleString('en-US', { style: 'currency', currency: 'USD' })}`
      }
      return title
    }
  }
}
</script>



