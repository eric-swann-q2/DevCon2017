<template>
  <titled-card title="Drop tha' Boom">
    <div class="row xs-gutter">
      <div v-for="(product, i) in products" :key="i">
        <product-tile :value="product" />
      </div>
    </div>
  </titled-card>
</template>

<script>
import actions from '../services/state/actions'
import ProductTile from './ProductTile'

export default {
  name: 'product-list',
  async created() {
    await this.createCart()
    this.fetchData()
  },
  components: {
    ProductTile
  },
  methods: {
    createCart() {
      return this.$store.dispatch(actions.CREATE_CART)
    },
    fetchData() {
      return this.$store.dispatch(actions.RETRIEVE_PRODUCTS)
    }
  },
  computed: {
    products() {
      return this.$store.state.products
    }
  }
}
</script>



