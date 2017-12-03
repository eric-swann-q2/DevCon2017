<template>
  <q-card>
    <q-card-title class="card-title shadow-2" :class="titleClass">
      {{title}}
    </q-card-title>
    <q-card-separator />
    <q-card-main class="card-container">
      <slot></slot>
    </q-card-main>
  </q-card>
</template>

<script>
export default {
  name: 'titled-card',
  props: ['title', 'isWarning'],
  computed: {
    titleClass() {
      return {
        'bg-warning': this.isWarning,
        'bg-light': !this.isWarning,
        'text-grey-8': !this.isWarning
      }
    }
  }
}
</script>

<style scoped>
.card-title {
  padding-top: 8px;
  padding-bottom: 8px;
}
</style>

    