<template>
    <div class="q-pa-md">
      <q-list v-for="post in posts" bordered separator padding>
       <q-item>
        <q-item-section top avatar>
          <q-avatar>
            {{post.id}}
          </q-avatar>
        </q-item-section>
  
        <q-item-section>
          <q-item-label>{{post.name}}</q-item-label>
          <q-item-label>{{post.username}}</q-item-label>
        </q-item-section>
  
        <q-item-section side top>
            user {{post.email}}
        </q-item-section>
       </q-item>
      </q-list>
    </div>
  </template>
  
<script>
    import axios from 'axios';
    export default
    {
        data(){
        return {
            posts:[]
        }
        }
        , methods : 
        {
            async getPosts(){
                try 
                {
                    const config = 
                    {
                        params: 
                        {
                        _limit: 10,
                        }
                    }
                    const responce = await axios.get('https://jsonplaceholder.typicode.com/users/', config);
                    console.log(responce);
                    this.posts = responce.data;
                }
                catch (e)
                {
                    alert('ошибка');
                }
            }
        }
        , mounted()
        {
            this.getPosts();
        }
    }
</script>

<style>

</style>