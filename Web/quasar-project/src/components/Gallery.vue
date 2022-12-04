<!-- <template>
    <div class="q-pa-md">
      <q-carousel 
        v-model="slide"
        transition-prev="slide-right"
        transition-next="slide-left"
        swipeable
        animated
        control-color="primary"
        thumbnails
        infinite
        padding
        arrows
        height="300px"
        class="bg-grey-1 shadow-2 rounded-borders"
      >
        <q-carousel-slide class="column no-wrap">
            <q-img class="rounded-borders col-4 full-height" :src="screen[0].path_thumbnail" />
            <q-img class="rounded-borders col-4 full-height" :src="screen[1].path_thumbnail" />
            <q-img class="rounded-borders col-4 full-height" :src="screen[2].path_thumbnail" />
        </q-carousel-slide>
      </q-carousel>
    </div>
  </template>
 -->
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