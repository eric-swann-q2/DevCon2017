<template>
  <div @click="dismiss()">
    <q-alert color="negative" icon="error" enter="flipInX" leave="flipOutX" appear :dismissible="dismissible" :value="isVisible">
      <slot></slot>
    </q-alert>
  </div>
</template>

<script>
import 'quasar-extras/animate/flipInX.css'
import 'quasar-extras/animate/flipOutX.css'

export default {
  name: 'message',
  props: {
    dismissible: {
      default: true,
      type: Boolean
    },
    value: {
      default: true,
      type: Boolean
    }
  },
  data() {
    return { visible: true }
  },
  methods: {
    dismiss() {
      if (this.dismissible) {
        this.visible = false
      }
    }
  },
  computed: {
    isVisible() {
      return this.value && this.visible
    }
  }
}
</script>


