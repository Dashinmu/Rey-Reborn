<template>
  <q-page class = "bg-gray-3">
    <div class = "row q-pa-sm bg-primary">
      <q-input  
        v-model = "text" 
        :label = "placeHolderString"  
        @keypress.enter = "addNote"
        filled bg-color = "white" 
        class = "col" 
        square
      >
        <template v-slot:append>
          <q-btn 
            @click = "addNote" 
            round 
            dense 
            flat 
            icon = "add" 
          />
        </template>
      </q-input>
    </div>
    <div 
      v-if = "notes.length == 0" 
      class = "no-tasks absolute-center"
    >
      <q-icon
        name = "today"
        size = "100px"
        color = "primary"
      />
      <div class="text-h5 text-primary text-center">Задач нет</div>
    </div>
    <div v-else>
      <TaskListVue :notesCompKS="notes" @removeNote="removeNote"/>
    </div>   
  </q-page>
</template>

<script>
  import TaskListVue from '../components/TasksList.vue';

  export default
  {
    components: 
    {
      TaskListVue
    }
    , data () 
    {
      return{
        notes: 
        [
          { title: 'Wake up', done: true }
          , { title: 'Go out', done: false }
          , { title: 'Frozen', done: false }
          , { title: 'Go back to bed', done: false }
        ]
        , text: ""
        , placeHolderString: "Введите задачу"
      }
    }
    , methods: 
    {
      addNote() 
      {
        if (this.text.replace( /\s/g, '') != "")
        {
          this.notes.push(
            {
              id: Date.now()
              , title: this.text
              , done: false
            }); 
        }
        this.text = "";
      }

      , removeNote(index) 
      {
        this.$q.dialog({
          dark: true
          , title: 'Подтверждение'
          , message: 'Вы уверены, что хотите удалить задачу?'
          , cancel: true
          , persistent: true
        }).onOk(() => {
          this.notes.splice(index, 1);
          this.$q.notify({
            message: 'Задача удалена'
          })
        })
      
      }
    }
  }
</script>

<style>
</style>
