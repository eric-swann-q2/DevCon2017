<template>
  <div>
    <slot></slot>
    <div class="main-margin">
      <std-trans>
        <router-view></router-view>
      </std-trans>
    </div>
  </div>
</template>
<script>

export default {
  name: 'tab-router-view'
}
</script>

<style scoped>
.main-margin {
  margin: 15px 10px 0 10px;
}
</style>
