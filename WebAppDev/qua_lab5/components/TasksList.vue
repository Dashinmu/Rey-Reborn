<template>
  <div >
    <div v-if = "this.notesComp.filter( (todo) => {return todo.done == false} ).length > 0">
        <h5 class = "aboutUs">Нужно выполнить</h5>
        <q-list 
          class = "bg-white" 
          separator 
          bordered
          v-for = "note in notesComp" :key = "note.id"
        >    
          <q-item
            v-if = "note.done == false" 
            class = "done bg-blue-1" 
            tag = "label" 
            v-ripple 
            clickable  
            @click = "note.done = !note.done"
          >
            <q-item-section avatar>
              <q-checkbox class = "no-pointer-events" v-model = "note.done" />
            </q-item-section>
            <q-item-section>
              {{note.title}}      
            </q-item-section>
          </q-item>     
        </q-list>
    </div>
    <div 
      v-if = "this.notesComp.filter( (todo) => {return todo.done === true} ).length > 0"
    >
      <h5 class = "aboutUs">Уже выполнены</h5>
      <q-list 
        class = "bg-white" 
        separator 
        bordered
        v-for = "(note, index) in notesComp" :key="note.id"
      >      
        <q-item  
          v-if = "note.done == true" 
          class = "done bg-blue-1" 
          tag = "label" 
          v-ripple 
          clickable
          @click = "note.done = !note.done"
        >
          <q-item-section avatar>
            <q-checkbox class = "no-pointer-events" v-model="note.done" />
          </q-item-section>
          <q-item-section>
            {{note.title}}      
          </q-item-section>
          <q-item-section side>
            <q-btn 
              v-if = "note.done" 
              dense 
              flat 
              round 
              color = "primary" 
              icon = "delete" 
              @click.stop = "removeNote(index)"
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
      notesComp: 
      {
          type: Array
      }
    }
    , methods:
    {
      removeNote(index)
      {
          this.$emit('removeNote', index);
      }
    }
  }
</script>

<style scoped>
</style>