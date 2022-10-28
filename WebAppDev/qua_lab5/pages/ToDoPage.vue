<template>
  <q-page class = "bg-gray-3">
    <div class = "row q-pa-sm bg-primary">
      <q-input  
        v-model = "text" 
        label = "Add task"  
        @keypress.enter = "addTask"
        filled bg-color = "white" 
        class = "col" 
        square
      >
        <template v-slot:append>
          <q-btn 
            @click = "addTask" 
            round 
            dense 
            flat 
            icon = "add" 
          />
        </template>
      </q-input>
    </div>
    <div 
      v-if = "tasks.length == 0" 
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
      <TaskListVue :tasksComp="tasks" @deleteNote="delTask"/>
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
        tasks: 
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
      addTask() 
      {
        if (this.text.replace( /\s/g, '') != "")
        {
          this.tasks.push(
            {
              id: Date.now(),
              title: this.text,
              done: false,
            }); 
        }
        this.text = "";
      }

      , delTask(index) 
      {
        this.$q.dialog({
          title: 'Подтверждение',
          message: 'Вы уверены, что хотите удалить задачу?',
          cancel: true,
          persistent: true
        }).onOk(() => {
          this.tasks.splice(index, 1);
          this.$q.notify({
            message: 'Задача удалена',
            caption: 'только что',
            color: 'secondary'
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
