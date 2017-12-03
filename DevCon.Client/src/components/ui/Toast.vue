<template>
  <q-transition enter="flipInX" leave="fadeOut">
    <div @click="dismiss()" v-show="isVisible" class="fixed-top toast">
      <div class="row">
        <div class="col"></div>
        <div>
          <q-alert color="positive" icon="thumb_up" :value="true">
            <ul>
              <li v-for="(message, index) in localMessages" :key="index">
                {{message.text}}
              </li>
            </ul>
          </q-alert>
        </div>
        <div class="col"></div>
      </div>
    </div>
  </q-transition>
</template>

<script>
import 'quasar-extras/animate/flipInX.css'
import 'quasar-extras/animate/fadeOut.css'

export default {
  name: 'toast',
  props: ['messages'],
  data() {
    return {
      isVisible: false,
      timeout: 4000,
      localMessages: []
    }
  },
  watch: {
    messages: {
      handler(newMessages) {
        this.localMessages = newMessages
        if (newMessages && newMessages.length > 0) {
          this.isVisible = true
          setTimeout(() => { this.isVisible = false }, this.timeout)
        }
      }
    }
  },
  methods: {
    dismiss() {
      this.isVisible = false
    }
  }
}
</script>

<style scoped>
.toast {
  z-index: 10000;
}

ul {
  list-style-type: none;
  padding-left: 0px;
  margin-left: 10px;
  margin-right: 15px;
}
</style>
