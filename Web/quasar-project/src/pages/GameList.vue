<template>
  <div class="q-pa-md">
    <q-page class="flex flex-center">
      <div class="row  q-col-gutter-md">
        <div class=" col-12 col-sm-6 col-md-4 col-lg-4"
         v-for="(game, index) in games" :key="game.appid" >
          <q-item
            class="no-padding"
            exact
            clickable
            v-ripple 
            :to="`/GameList/${game.appid}`">
          <q-card class="my-card"  >
            <img :src="game.img" />

              <q-card-section>
                <div class="text-h6 q-mb-xs">{{game.name}}</div>
                  <q-btn flat round color="red" icon="favorite"></q-btn>
                 
              </q-card-section>
            </q-card>
            </q-item>
    </div>
</div>
   <div class="q-pa-lg flex flex-center">
    <q-pagination
      v-model="current"
      color="white"
      :max="page"
      direction-links
      :max-pages="6"
      :boundary-numbers="false"
      active-color="black"
      @click="loadPosts"
    />
  </div>
    </q-page>

</div>
  </template>
  
  <script>
 import{ ref }from 'vue';
  import axios from 'axios'
  export default {
    data() {
      return{
        games:[],
        current: 1,
        total_count: 0,
        page: ref(1),
        limit: 20
      }
    },
 
    methods : 
    {
      async getPosts(pageNum)
      {
        try {
          const response = await axios.get(`https://steam.xenista.ru/?order=name&page=${pageNum}`);
          console.log(response);
          this.games=response.data;
          this.total_count = response.headers.getContentLength();
          if(this.total_count % this.limit == 0)
            this.page = this.total_count / this.limit;
          else
            this.page = this.total_count / this.limit +1;

          this.games.forEach((game, index) => {
            this.checkIfImageExists (
            "https://steamcdn-a.akamaihd.net/steam/apps/"+game.appid+"/header.jpg", index
          );
        });
        }
        catch (e){
          alert('Ошибка');
        }
      }
      , loadPosts() 
        {
            this.getPosts(this.current);
        },

        checkIfImageExists(url, i) {
        const img = new Image();
        img.src = url;
        if (img.complete) {
          this.games[i].img = url
        } else {
          img.onload = () => {
            this.games[i].img = url
          };
          img.onerror = () => {
            this.games[i].img = 'https://i.imgur.com/st2SrKk_d.jpg?maxwidth=640'
          };
        }
      }
    },
    mounted() {
      this.getPosts(1)
    }
  }
  </script>

  <style scoped>
  .q-card__section{
    display: flex;
    align-items: flex-start;
    justify-content: space-between;
  }
  .q-card{
    height: 100%;
  }
  .my-card{
    cursor: pointer;
  }
  .q-item{
    height: 100%;
  }
  .my-card{
    width: 100%;
  }
</style>