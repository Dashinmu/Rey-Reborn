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

            <!-- <q-item
            to="/GameInfo" exact
             clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="send" color="white"/>
              </q-item-section>

              <q-item-section style="color: white;">
                GameInfo
              </q-item-section>
            </q-item>
             -->
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
import EssentialLink from 'components/EssentialLink.vue'

const linksList = [
  {
    title: 'Docs',
    caption: 'quasar.dev',
    icon: 'school',
    link: 'https://quasar.dev'
  },
  {
    title: 'Github',
    caption: 'github.com/quasarframework',
    icon: 'code',
    link: 'https://github.com/quasarframework'
  },
  {
    title: 'Discord Chat Channel',
    caption: 'chat.quasar.dev',
    icon: 'chat',
    link: 'https://chat.quasar.dev'
  },
  {
    title: 'Forum',
    caption: 'forum.quasar.dev',
    icon: 'record_voice_over',
    link: 'https://forum.quasar.dev'
  },
  {
    title: 'Twitter',
    caption: '@quasarframework',
    icon: 'rss_feed',
    link: 'https://twitter.quasar.dev'
  },
  {
    title: 'Facebook',
    caption: '@QuasarFramework',
    icon: 'public',
    link: 'https://facebook.quasar.dev'
  },
  {
    title: 'Quasar Awesome',
    caption: 'Community Quasar projects',
    icon: 'favorite',
    link: 'https://awesome.quasar.dev'
  }
]

export default defineComponent({
  name: 'MainLayout',

  components: {
    EssentialLink
  },

  setup () {
    const leftDrawerOpen = ref(false)

    return {
      essentialLinks: linksList,
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