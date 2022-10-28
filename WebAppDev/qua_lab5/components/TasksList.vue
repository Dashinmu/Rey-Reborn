<template>
  <div >
    <div v-if = "this.tasksComp.filter( (todo) => {return todo.done == false} ).length > 0">
        <h5 class="aboutUs">Нужно выполнить</h5>
        <q-list 
          class="bg-white" 
          separator 
          bordered
          v-for = "task in tasksComp" :key = "task.id"
        >    
          <q-item
            v-if = "task.done == false" 
            class="done bg-blue-1" 
            tag="label" 
            v-ripple 
            clickable  
            @click = "task.done = !task.done"
          >
            <q-item-section avatar>
              <q-checkbox class = "no-pointer-events" v-model = "task.done" />
            </q-item-section>
            <q-item-section>
              {{task.title}}      
            </q-item-section>
          </q-item>     
        </q-list>
    </div>
    <div 
      v-if = "this.tasksComp.filter( (todo) => {return todo.done === true} ).length > 0"
    >
      <h5 class = "aboutUs">Уже выполнены</h5>
      <q-list 
        class = "bg-white" 
        separator 
        bordered
        v-for = "(task, index) in tasksComp" :key="task.id"
      >      
        <q-item  
          v-if = "task.done == true" 
          class = "done bg-blue-1" 
          tag = "label" 
          v-ripple 
          clickable
          @click = "task.done = task.done"
        >
          <q-item-section avatar>
            <q-checkbox class="no-pointer-events" v-model="task.done" />
          </q-item-section>
          <q-item-section>
            {{task.title}}      
          </q-item-section>
          <q-item-section side>
            <q-btn 
              v-if = "task.done" 
              dense 
              flat 
              round 
              color = "primary" 
              icon = "delete" 
              @click.stop = "deleteNote(index)"
            />
          </q-item-section>
        </q-item>
      </q-list>
    </div>
  </div>
</template>
    
<script>
  export default 
  {
    data ()
    {
      return{
        cntDone: 0
        , cntNotDone: 3
      }
    }
    , props: 
    {
      tasksComp: 
      {
          type: Array
      }
    }
    , methods:
    {
      deleteNote (index)
      {
          this.$emit('deleteNote', index);
      }
    }
  }
</script>

<style scoped>
</style>