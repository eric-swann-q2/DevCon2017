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
import ProductTile from './ProductTile'

export default {
  name: 'product-list',
  async created() {
    await this.fetchData()
  },
  components: {
    ProductTile
  },
  methods: {
    async fetchData() {
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

<style scoped>
.main-margin {
  margin: 10px;
}
</style>


