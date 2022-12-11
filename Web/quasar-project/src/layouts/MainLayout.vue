<template>
  <q-layout view="lHh Lpr lFf" style="background-color: #040426;">
    <q-header elevated style="background-color: #13124a;">
      <q-toolbar>
        <q-btn
          flat
          dense
          round
          icon="menu"
          aria-label="Menu"
          @click="toggleLeftDrawer"
        />

        <q-toolbar-title>
          Энциклопедия игр в Steam
        </q-toolbar-title>
      </q-toolbar>
    </q-header>

    <q-drawer
        v-model="leftDrawerOpen"
        style="background-color: #0e0d40;"
        show-if-above
        :width="200"
        :breakpoint="500"
      >
        <q-scroll-area class="fit">
          <q-list padding class="menu-list">
            <q-item
            to="/RandomGameList" exact
             clickable v-ripple>
              <q-item-section avatar >
                <q-icon name="style" color="white" />
              </q-item-section>

              <q-item-section style="color: white;">
                Рандом 20
              </q-item-section>
            </q-item>
            <q-item
            to="/GameList" exact
             clickable v-ripple>
              <q-item-section avatar >
                <q-icon name="style" color="white" />
              </q-item-section>

              <q-item-section style="color: white;">
                Список всех игр
              </q-item-section>
            </q-item>

             <q-item
            to="/FindGame" exact
             clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="send" color="white"/>
              </q-item-section>

              <q-item-section style="color: white;">
                Найти игру
              </q-item-section>
            </q-item>
             
          </q-list>
        </q-scroll-area>
      </q-drawer>

    <q-page-container>
      <keep-alive>
      <router-view />
      </keep-alive>
    </q-page-container>
  </q-layout>
</template>

<script>
import { defineComponent, ref } from 'vue'

export default defineComponent({
  name: 'MainLayout',

  components: {
  },

  setup () {
    const leftDrawerOpen = ref(false)

    return {
      leftDrawerOpen,
      toggleLeftDrawer () {
        leftDrawerOpen.value = !leftDrawerOpen.value
      }
    }
  }
})
</script>

<style>
.All_color {
  background-color: black;
}
</style>
