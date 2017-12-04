<template>
  <q-list>
    <q-list-header class="menuHeader"><img src="/statics/logo_small.png" />
      <span class="menuHeaderText text-grey-8">Mega Awesome Speaker Store</span>
    </q-list-header>
    <q-side-link sparse class="relative-position" :item="true" v-for="(item, i) in navItems" :key="i" :to="item.path" :exact="item.meta.exact" >
      <q-item-side :icon="item.meta.icon" color="primary" />
      <q-item-main :label="item.meta.navText" class="text-grey-8" />
    </q-side-link>
  </q-list>
</template>

<script>
export default {
  name: 'side-nav',
  props: ['routes'],
  computed: {
    navItems() {
      const items = []
      this.routes.forEach(x => {
        if (x.meta && x.meta.includeInNav) {
          items.push(x)
        }
      })
      return items
    }
  }
}
</script>

<style scoped>
.menuHeaderText {
  position: relative;
  top: -5px;
  left: 15px;
}

.menuHeader {
  margin-top: 10px;
}
</style>

