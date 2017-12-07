<template>
  <titled-card title="Removed Products Report">
    <q-list highlight>
      <q-item v-for="(product, i) in products" :key="i" >
        <q-item-main>
          <q-item-tile label>Sku: {{product.sku}}</q-item-tile>
          <q-item-tile sublabel>Removed Count: {{product.count}}</q-item-tile>
        </q-item-main>
      </q-item>
    </q-list>
  </titled-card>
</template>

<script>
import actions from '../services/state/actions'

export default {
  name: 'removed-products-report',
  created() {
    this.fetchData()
  },
  methods: {
    fetchData() {
      return this.$store.dispatch(actions.RETRIEVE_REMOVED_PRODUCTS_REPORT)
    }
  },
  computed: {
    products() {
      return this.$store.state.removedProductsReport.products
    }
  }
}
</script>



