<template>
  <div v-show="hasMessages">
    <message v-for="(item, i) in messages" :key="i">{{item.text}}</message>
  </div>
</template>

<script>
import Message from './Message'

export default {
  name: 'message-list',
  components: {
    Message
  },
  props: ['messages'],
  computed: {
    hasMessages() {
      return this.messages && this.messages.length > 0
    }
  }
}
</script>