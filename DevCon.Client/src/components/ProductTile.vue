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
          <div class="col-6">
            <q-btn color="green-5" @click="addToCart()">Add to Cart</q-btn>
          </div>
          <div class="col-5">
            <q-input class="quantity" :min="1" :max="99" type="number" prefix="Quantity: " v-model="quantity" @blur="quantityChanged" />
          </div>
        </div>
      </div>
    </q-card-actions>
  </q-card>
</template>

<script>
import actions from '../services/state/actions'

export default {
  name: 'product-tile',
  data() {
    return {
      quantity: 1
    }
  },
  props: ['value'],
  methods: {
    async addToCart() {
      await this.$store.dispatch(actions.ADD_ITEM_TO_CART, {
          sku: this.value.sku,
          name: this.value.name,
          image: this.value.image,
          salePrice: this.value.salePrice,
          customerTopRated: this.value.customerTopRated,
          quantity: this.quantity
        });
      this.quantity = 1
    },
    quantityChanged() {
      if(!this.quantity || this.quantity < 1) {
        this.quantity = 1
      } else if (this.quantity > 99) {
        this.quantity = 99
      }
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
