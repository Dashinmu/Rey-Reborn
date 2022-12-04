<template>
  <q-page class="flex flex-center">
   <q-item> 
    <q-item-section style="background-color: #040426; color: white;">
          <section v-if="status" class="Info_Page">
            <div class="Game_name">{{game.name}}</div>
            <div>-----------------------------------------------------------</div>
            <div>
              <img :src="game.header_image">
            </div>
            <div>-----------------------------------------------------------</div>
            <h3>Об игре:</h3>
            <div v-html="game.about_the_game"></div>
            
            <div>-----------------------------------------------------------</div>
            <div v-for="develop in game.developers">
              <p>Производство фром {{develop}}</p>
            </div>
            <div>-----------------------------------------------------------</div>
            <div v-for="categories in game.categories">
              {{categories.description}}
            </div>
            <div>-----------------------------------------------------------</div>
            <p>Скринчики-красавчики</p>
              <Gallery :screens = "game.screenshots" />
          </section>
          <section v-else>
            <h2>Данная игра не доступна по ссылке</h2>
          </section>
          
      
    </q-item-section>
  </q-item>
  </q-page>
</template>

<script>
import Gallery from 'components/Gallery.vue'
import axios from 'axios';
import { Loading } from 'quasar';
export default
{
  components: {Gallery},
  data () {
    return {
      game: [],
      status: []
    }
  },
  methods : {
    async getPost() {
      Loading.show({
        message: 'Ожидание'
      })
      try {
        const id = this.$route.params.id;
        const response = await axios.get(`https://steam.xenista.ru/?appids=${id}`);
        console.log(response.data[id].data)
        this.game = response.data[id].data;
        this.status = response.data[id].success;
        
      }
      catch(e) {
        alert('Ошибка' + e);
      }
      Loading.hide()
    }
  },
  mounted() {
    this.getPost();
  }
}
</script>

<style>
.Game_name {
  font-size: 150%;
}
h2{
  font-size: 24px;
  margin-top: 0;
  margin-bottom: 10px;
  padding-bottom: 0;
}
h3{
  font-size: 20px;
  margin-top: 0;
  margin-bottom: 10px;
  padding-bottom: 0;
}
</style>