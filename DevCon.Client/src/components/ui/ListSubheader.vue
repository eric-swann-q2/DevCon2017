<template>
  <div :class="{ 'top-margin': topMargin }">
    <q-item-tile sublabel class="bg-light button-container">
      <div class="label-text">{{title}}</div>
      <div class="label-text">{{itemId}}</div>
      <q-btn v-if="showRemove" class="remove-button" small flat @click="remove"><q-icon name="clear" /><q-tooltip>Remove</q-tooltip></q-btn>
      <q-btn v-if="showCopy" class="command-button" small flat @click="copy"><q-icon name="content_copy" /><q-tooltip>Copy</q-tooltip></q-btn>
      <q-btn v-if="showMoveDown" class="command-button" small flat @click="moveDown"><q-icon name="arrow_downward" /><q-tooltip>Move down</q-tooltip></q-btn>
      <q-btn v-if="showMoveUp" class="command-button" small flat @click="moveUp"><q-icon name="arrow_upward" /><q-tooltip>Move up</q-tooltip></q-btn>
    </q-item-tile>
  </div>
</template>

<script>
export default {
  name: 'list-subheader',
  props: {
    showRemove: {
      type: Boolean,
      default: false
    },
    showMoveUp: {
      type: Boolean,
      default: false
    },
    showMoveDown: {
      type: Boolean,
      default: false
    },
    showCopy: {
      type: Boolean,
      default: false
    },
    topMargin: {
      type: Boolean,
      default: false
    },
    title: {},
    itemId: {}
  },
  methods: {
    remove() {
      this.$emit('remove')
    },
    moveUp() {
      this.$emit('moveUp')
    },
    moveDown() {
      this.$emit('moveDown')
    },
    copy() {
      this.$emit('copy')
    }
  }
}
</script>


<style scoped>
.top-margin {
  margin-top: 10px;
}

.button-container {
  overflow: hidden;
  min-height: 25px;
  margin-top: auto;
  margin-bottom: auto;
}

.remove-button {
  float: right;
  margin-left: 5px;
  width: 15px;
}
.command-button {
  float: right;
  width: 15px;
}
.label-text {
  float: left;
  line-height: 25px;
  margin-left: 5px;
}

.q-btn-small {
  min-height: 25px;
}
</style>


