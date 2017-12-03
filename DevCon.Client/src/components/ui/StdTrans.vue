<template>
  <q-transition enter="slideInLeft" leave="fadeOutRight" mode="out-in">
    <slot></slot>
  </q-transition>
</template>

<script>
export default {
  name: 'std-trans',
}
</script>
