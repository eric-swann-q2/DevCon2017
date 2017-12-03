<template>
  <!-- Don't drop "q-app" class -->
  <div id="q-app">
    <q-layout ref="layout" view="hHh Lpr fff" v-model="drawerVisible" :left-class="{'bg-grey-2': true}">
      <q-toolbar slot="header">
        <q-btn flat @click="$refs.layout.toggleLeft()">
          <q-icon name="menu" />
        </q-btn>
        <q-toolbar-title>
          {{title}}
        </q-toolbar-title>
      </q-toolbar>

      <div slot="left">
        <side-nav :routes="routes" />
      </div>

      <div>
        <toast :messages="messages" />
        <message-list :messages="errors"></message-list>
        <std-trans>
          <router-view></router-view>
        </std-trans>
      </div>
    </q-layout>
  </div>
</template>

<script>
import { routes } from "./router";

export default {
  name: "index",
  data() {
    return {
      routes: routes,
      title: "DevCon 2017 Store",
      drawerVisible: {
        left: true,
        right: false
      }
    };
  },
  computed: {
    isProcessing() {
      return this.$store.getters.isProcessing;
    },
    errors() {
      return this.$store.state.errors;
    },
    messages() {
      return this.$store.state.messages;
    }
  }
};
</script>

