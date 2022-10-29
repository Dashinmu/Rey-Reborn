<template>
  <q-layout view = "lHh Lpr lFf">
    <q-header elevated>
      <q-toolbar>
        <q-btn
          flat
          dense
          round
          icon = "menu"
          aria-label = "Menu"
          @click = "toggleLeftDrawer"
        />
      </q-toolbar>
      <div class = "q-px-md q-pt-xl q-mb-md">
        <h3 class = "text-h4 q-mt-none q-mb-none">Список задач</h3>
        <div class = "text-subtitle1">{{getDate}}</div>
      </div>
      <q-img 
        src = "~/assets/pic.png" 
        class = "header-image absolute-top"
      />
    </q-header>
    
    <q-drawer
      v-model = "leftDrawerOpen"
      show-if-above
      bordered
    >
      <q-scroll-area style = "height: calc(100% - 182px); margin-top: 182px; border-right: 1px solid #ddd">
        <q-list padding>
          <q-item exact to = "/" clickable v-ripple>
            <q-item-section avatar>
              <q-icon name = "list" />
            </q-item-section>
            <q-item-section>
              Список задач
            </q-item-section>
          </q-item>

          <q-item to = "/help" exact clickable v-ripple>
            <q-item-section avatar>
              <q-icon name = "help" />
            </q-item-section>
            <q-item-section>
              Помощь
            </q-item-section>
          </q-item>

          <q-item to = "/about" exact clickable v-ripple>
            <q-item-section avatar>
              <q-icon name = "info" />
            </q-item-section>
            <q-item-section>
              Обо мне
            </q-item-section>
          </q-item>
       
        <q-item to = "/They" exact clickable v-ripple>
            <q-item-section avatar>
              <q-icon name = "info" />
            </q-item-section>
            <q-item-section>
              О нас
            </q-item-section>
          </q-item>
        </q-list>
        
      </q-scroll-area>
      

      <q-img class = "absolute-top" src = "https://sun9-66.userapi.com/impg/QiAO7LVKX07d5TNx2uSpY4hLetQNNv7WAKN8BA/yezgGVB6Ee4.jpg?size=1440x1919&quality=95&sign=def1c2c287eba11b35944eed4e6d7c23&type=album" style="height: 182px">
        <div class = "absolute-bottom bg-transparent">
          <q-avatar size = "56px" class = "q-mb-sm">
            <img src = "https://sun9-67.userapi.com/impg/ODFH7cClmtBelBT9WcD2VGOMLrXJuHztoXz09w/vWa5Qvw-pOE.jpg?size=640x640&quality=96&sign=409928a555517fa4c63528b2ea4d53a8&type=album">
          </q-avatar>
          <div class = "text-weight-bold">Dashinmu&Yzpoo</div>
          <div>@hruk.inc</div>
        </div>
      </q-img>
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
  import { date } from 'quasar'
  import { computed } from '@vue/reactivity'

  export default defineComponent({
    name: 'MainLayout'

    , components: 
    {

    }
    , setup() 
    {
      const leftDrawerOpen = ref(false)

      return {
        leftDrawerOpen
        , toggleLeftDrawer() 
        {
          leftDrawerOpen.value = !leftDrawerOpen.value
        }
      }
    }
    , computed: 
    {
      getDate()
      {
        const timeStamp = Date.now();
        return date.formatDate(timeStamp, "dddd, DD MMMM YYYY")
      }
    }
  })
</script>
<style>
  .header-image
  {
    height: 100%;
    z-index: -1;
    opacity: 0.2;
  }
</style>