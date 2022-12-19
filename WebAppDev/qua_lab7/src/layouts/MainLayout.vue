<template>
  <q-layout view="lHh Lpr lFf">
    <q-header elevated>
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
          Работа с API
        </q-toolbar-title>

      </q-toolbar>
    </q-header>

    <q-drawer
        v-model="leftDrawerOpen"
        show-if-above
        :width="200"
      >
        <q-scroll-area style="height: calc(100% - 150px); border-right: 1px solid #ddd">
          <q-list padding>
            <q-item exact to="/" clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="book" />
              </q-item-section>

              <q-item-section>
                Posts
              </q-item-section>
            </q-item>

            <q-item exact to="/comments" active clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="speaker_notes" />
              </q-item-section>

              <q-item-section>
                Comments
              </q-item-section>
            </q-item>

            <q-item exact to="/album" clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="view_comfy_alt" />
              </q-item-section>

              <q-item-section>
                Album
              </q-item-section>
            </q-item>

            <q-item exact to="/photos" clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="picture_in_picture_alt" />
              </q-item-section>

              <q-item-section>
                Photos
              </q-item-section>
            </q-item>

            <q-item exact to="/tasks" clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="toc" />
              </q-item-section>

              <q-item-section>
                List Tasks
              </q-item-section>
            </q-item>

            <q-item exact to="/users" clickable v-ripple>
              <q-item-section avatar>
                <q-icon name="account_box" />
              </q-item-section>

              <q-item-section>
                Users
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
  name: 'MainLayout'

  , setup () 
  {
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
