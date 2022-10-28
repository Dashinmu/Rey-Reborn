<template>
  <q-page class = "bg-gray-3">
    <div class = "row q-pa-sm bg-primary">
      <q-input  
        v-model = "text" 
        label = "Add note"  
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
        name="check"
        size="100px"
        color="primary"
      />
      <div class="text-h5 text-primary text-center">Задач нет</div>
    </div>
    <div v-else>
      <TaskListVue :notesComp="notes" @removeNote="removeNote"/>
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
          { title: 'WakeUp', done: true }
          , { title: 'GoOut', done: false }
          , { title: 'Smoke', done: false }
          , { title: 'GoBackToBed', done: false }
        ]
        , text: ""
        , cntTask: 0
      }
    }
    , methods: 
    {
      addNote() 
      {
        if (this.text.replace( /\s/g, '') != "")
        {
          this.tasks.push(
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
          title: 'Подтверждение'
          , message: 'Вы уверены, что хотите удалить задачу?'
          , cancel: true
          , persistent: true
        }).onOk(() => {
          this.notes.splice(index, 1);
          this.$q.notify({
            message: 'Задача удалена'
            , caption: 'только что'
            , color: 'secondary'
          })
        })
      
      }
    }
  }
</script>

<style>
  .aboutUs
  {
    text-align: center;
  }
</style>
