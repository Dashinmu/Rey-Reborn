<template>
    <div class="q-pa-md">
        <q-list bordered padding v-if="this.notes.length>0">
        <q-item tag="label" v-ripple v-for="note in notes" :key="note.id">
            <q-item-section top avatar>
            <q-avatar>
                {{note.id}}
            </q-avatar>
            </q-item-section>

            <q-item-section>
                <q-item-label>{{note.title}}</q-item-label>
            </q-item-section>

            <q-item-section side top>
            <q-checkbox v-model="note.completed"/>
            </q-item-section>
        </q-item>
        </q-list>
    </div>
</template>
  
  
<script>
    import axios from 'axios'
    export default
    {
      data () 
      {
        return {
          notes:[],
        }
      }

        , methods : 
        {
            async getPosts()
            {
                try 
                {
                const config = 
                {
                    params: 
                    {
                    _limit: 10,
                    }
                }
                const response = await axios.get('https://jsonplaceholder.typicode.com/todos', config);
                console.log(response);
                this.notes = response.data;
                }
                catch (e)
                {
                alert('Ошибка');
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
  