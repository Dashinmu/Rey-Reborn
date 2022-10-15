<template>
    <div class="wrapper__list">
        <h2>
            <span>{{Title}}</span>
            <span class="task-num">{{ notes.length }}</span>
        </h2>
        <ul :class = "{
            'task-list': true,
            'complete-list' : flag == true
        }" v-if = "notes != 0">
        <Notes v-for = "(note, index) in notes" :key="note.id" :index = "index" :note = "note" :flag = "flag" :NoteID = "NoteID" @check = "check" @remove = "remove" @edit = "edit" @edit_accept = "edit_accept"/>
        </ul>
        <div v-else>Задач нет</div>
        <div v-if = "notes.length > 10 && flag == false"> Может уже пора делать задачи, а не только ставить? </div>
    </div>
</template>

<script>
    import Notes from '@/components/Notes.vue';
    export default {
        components:
        {
            Notes
        }
        , props:
        {
            notes:
            {
                type: Array
            }
            , Title:
            {
                type: String
            }
            , flag:
            {
                type: Boolean
            }
            , NoteID:
            {
                type: Number
            }
        },
        methods:
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
            }
            , edit_accept(string)
            {
                this.$emit('edit_accept', string);
            }
        }
    }
</script>

<style>

</style>