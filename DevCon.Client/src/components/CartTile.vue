<template>
  <q-card inline class="card">
    <q-card-media class="image-container">
      <img class="image" :src="value.image">
    </q-card-media>
    <q-card-title>
      <div>${{value.salePrice}}</div>
      <div slot="subtitle">SKU: {{value.sku}}</div>
      <div v-if="value.customerTopRated" slot="right" class="favorite">
        <q-icon name="favorite" class="text-pink">
          <q-tooltip>Customer Top Rated</q-tooltip>
        </q-icon>
      </div>
    </q-card-title>
    <q-card-main class="description">
      {{value.name}}
    </q-card-main>
    <q-card-separator />
    <q-card-actions>
      <div class="col actions">
        <div class="row xs-gutter">
          <div class="col-5">
            <q-btn color="green-5" @click="remove()">Remove</q-btn>
          </div>
          <div class="col-5">
            <q-input class="quantity" :min="1" :max="99" type="number" prefix="Quantity: " :value="value.quantity" @blur="changeQuantity" />
          </div>
        </div>
      </div>
    </q-card-actions>
  </q-card>
</template>

<script>
import actions from '../services/state/actions'

export default {
  name: 'cart-tile',
  props: ['value'],
  methods: {
    changeQuantity(event) {
      this.value.quantity = event.srcElement.value
      this.$store.dispatch(actions.UPDATE_CART_ITEM_QUANTITY, {
        sku: this.value.sku,
        quantity: this.value.quantity
      })
    },
    remove() {
      this.$store.dispatch(actions.REMOVE_CART_ITEM, {
        sku: this.value.sku
      })
    }
  }
}
</script>

<style scoped>
.card {
  width: 275px;
}

.q-card-container {
  padding: 10px;
}

.image-container {
  padding: 10px;
}

.image {
  margin: auto;
  height: 150px;
  width: auto;
}

.description {
  min-height: 70px;
}

.favorite {
  padding-right: 15px;
}

.quantity {
  margin-top: 0px;
  margin-bottom: 0px;
}

.actions {
  margin-left: 5px;
  margin-right: 5px;
}
</style>
