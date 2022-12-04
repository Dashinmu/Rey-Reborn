<template>
    <div class="q-pa-md">
      <q-page class="flex flex-center">
        <div class="row  q-col-gutter-md">
          <div class=" col-12 col-sm-6 col-md-4 col-lg-4" v-for="game in games" :key="game.appid" >
            <q-item class="no-padding" exact clickable v-ripple :to="`/GameList/${game.appid}`">
            <q-card class="my-card"  >
              <img :src="'https://steamcdn-a.akamaihd.net/steam/apps/'+game.appid+'/header.jpg'">
              
                <q-card-section>
                  <div class="text-h6 q-mb-xs">{{game.name}}</div>
                    <q-btn flat round color="red" icon="favorite"></q-btn>
                   
                </q-card-section>
              </q-card>
              </q-item>
      </div>
  </div>
     
      </q-page>
  
  </div>
    </template>
    
    <script>
    //import Image from '../assets/ErrImg.jpg'
    import axios from 'axios'
    export default {
      data() {
        return{
          games:[],
        }
      },
      methods : {
        async getPosts(){
        try {
          const response = await axios.get('https://steam.xenista.ru/');
          this.games=response.data;
        }
        catch (e){
          alert('Ошибка');
        }
      }
  
      },
      mounted () {
        this.getPosts()
      },
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