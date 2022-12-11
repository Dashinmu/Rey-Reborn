<template>
  <div class="q-pa-md">
    <q-carousel
      swipeable
      animated
      v-model="slide"
      thumbnails
      infinite
      arrows
      transition-prev="slide-right"
      transition-next="slide-left"
      style="height: 400px; max-width: 705px;"
    >
      <q-carousel-slide v-for="screen in screens" :name="screen.id" :img-src="screen.path_full" style="background-position: inherit;" />
    </q-carousel>
  </div>
</template>



<script>
import { ref } from 'vue'
export default {
    props: 
    {
      screens: Array
    },
    setup () 
    {
      return {
        slide: ref(1)
      }
    }
}
</script>