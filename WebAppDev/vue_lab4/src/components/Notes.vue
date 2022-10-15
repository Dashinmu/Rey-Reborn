<template>
    <!-- ToDo -->
    <li>
        <div v-if = "flag == false">
            <input 
                type="checkbox"
                @change = "check(index, false)"
            />
            <input 
                type = "text"
                v-model = "note_title"
                v-if = "NoteID == note.id"
            >
            <span v-else>{{note.title}}</span>
        </div>
        <div v-if = "flag == true">
            <input 
                type="checkbox" checked 
                @change = "check(index, true)"
            >
            <span>{{note.title}} {{note.dt}}</span>
        </div>
        <div>
            <button  
                class = "btn btn_mr" 
                v-if = "NoteID == note.id && flag == false"
                @click = "edit_accept()"
                >
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check2" viewBox="0 0 16 16">
                <path d="M13.854 3.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3.5-3.5a.5.5 0 1 1 .708-.708L6.5 10.293l6.646-6.647a.5.5 0 0 1 .708 0z"/>
                </svg>
            </button>
            <button  
                class = "btn btn_yellow btn_icon" 
                v-else-if = "flag == false"
                @click = "edit(note)"
                >
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil" viewBox="0 0 16 16">
                <path d="M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5 13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"/>
                </svg>                  
            </button>
            <button class="btn btn_red btn_icon" @click = "remove(index)">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
                <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                </svg>
            </button>
        </div>
    </li>
    <!-- Done -->
<!--     <li v-for = "(note, index) in notes" :key="note.id" v-if = "flag == true">
        
        <button class="btn btn_red btn_icon" @click = "remove(index)">
            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
            <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
            <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
            </svg>                
        </button>
    </li> -->

</template>

<script>
    export default 
    {
        props:
        {
            notes:
            {
                type: Array
            }
            , flag:
            {
                type: Boolean
            }
            , NoteID:
            {
                type: Number
            }
            , index:
            {
                type: Number
            }
            , note:
            {
                type: Object
            }
        }
        , methods:
        {
            check(index, flag)
            {
                this.$emit('check', index, flag);
            }
            , remove(index)
            {
                this.$emit('remove', index);
            }
            , edit(note)
            {
                this.$emit('edit', note);
                this.note_title = note.title;
            }
            , edit_accept()
            {
                this.$emit('edit_accept', this.note_title);
            }
        }
    }
</script>

<style lang="scss" scoped>

</style>