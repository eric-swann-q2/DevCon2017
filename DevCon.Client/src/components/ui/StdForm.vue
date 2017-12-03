<template>
  <form v-on:submit.prevent="onSubmit">
    <slot></slot>
  </form>
</template>

<script>
export default {
  name: 'std-form',
  methods: {
    onSubmit() {
      return false
    }
  }
}
</script>