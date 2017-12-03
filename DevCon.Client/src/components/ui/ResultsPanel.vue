<template>
  <titled-card :title="title" :is-warning="isWarning">
    <q-list no-border>
      <div v-show="resultMessages">
        <q-item v-for="(item, i) in resultMessages" :key="i">
          <q-item-main>
            <q-item-tile label>{{item.name}}</q-item-tile>
          </q-item-main>
        </q-item>
      </div>
      <div v-show="failureMessages">
        <q-item-separator />
        <q-list-header>Failed</q-list-header>
        <q-item v-for="(item, i) in failureMessages" :key="i">
          <q-item-side>
            <q-item-tile icon="error" color="negative" />
          </q-item-side>
          <q-item-main>
            <q-item-tile label>{{item.name}}</q-item-tile>
            <q-item-tile sublabel>{{item.message}}</q-item-tile>
          </q-item-main>
        </q-item>
      </div>
      <div v-show="successMessages">
        <q-item-separator />
        <q-list-header v-show="successMessages">Succeeded</q-list-header>
        <q-item v-for="(item, i) in successMessages" :key="i">
          <q-item-side>
            <q-item-tile icon="check_circle" color="positive" />
          </q-item-side>
          <q-item-main>
            <q-item-tile label>{{item.name}}</q-item-tile>
          </q-item-main>
        </q-item>
      </div>
    </q-list>
  </titled-card>
</template>

<script>
import TitledCard from './TitledCard'

export default {
  name: 'results-panel',
  props: ['title', 'successMessages', 'failureMessages', 'resultMessages'],
  components: {
    TitledCard
  },
  computed: {
    isWarning() {
      return this.failureMessages && this.failureMessages.length > 0
    }
  }
}
</script>
