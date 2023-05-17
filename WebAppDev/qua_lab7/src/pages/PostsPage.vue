<template>    
  <div class="q-pa-md" >
    <q-list  v-for="(post,index) in posts" :key="index" bordered separator padding>
      <q-item>
        <q-item-section top avatar>
          <q-avatar>
            {{post.id}}
          </q-avatar>
        </q-item-section>

        <q-item-section>
          <q-item-label>{{post.title}}</q-item-label>
          <q-item-label caption>{{post.body}}</q-item-label>
        </q-item-section>

        <q-item-section side top>
          user {{post.userId}}
        </q-item-section>
      </q-item>
    </q-list>
  </div>
</template>

<script>
import axios from 'axios'
import { defineComponent } from 'vue'

export default defineComponent({
  name: 'PostsPage'

  , data()
  {
    return{
      posts:[]
    }
  }

  , methods: 
  {
    async getPosts()
    {
      try {
        const config = {
          params: {
            _limit: 10,
            _page: this.page
          }
        };
        const responce = await axios.get('https://jsonplaceholder.typicode.com/posts', config);
        console.log(responce);
        this.posts = responce.data;
      }
      catch (e){
        alert('ошибка');
      }
    }
  }
  , mounted()
  {
    this.getPosts();
  }
})
</script>
