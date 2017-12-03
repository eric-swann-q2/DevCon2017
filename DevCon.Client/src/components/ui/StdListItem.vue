<template>
  <q-item class="item-style">
    <slot />
  </q-item>
</template>

<script>
export default {
  name: 'std-list-item'
}
</script>

<style scoped>
  .item-style {
    padding-right:6px;
    padding-left:6px
  }
</style>

