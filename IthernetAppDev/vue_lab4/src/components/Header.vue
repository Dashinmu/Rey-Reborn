<template>
    <div class="header">
        <div class="container header__container">
            <div class="logo">Список задач</div>
            <div class="wrapper">
                <div class="form">
                    <input 
                        type="text" 
                        :placeholder = "placeholderString"
                        @keypress.enter = "addTask"
                        v-model = "note.title" 
                    >    
                    <button class="btn" @click = "createNote">Добавить</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data()
        {
            return {
                placeholderString: "Введите название заметки"
                , note:
                {
                    id: '',
                    title: '',
                }
            }
        },
        methods:
        {
            createNote()
            {
                if (this.note.title.replace( /\s/g, '') != '')
                {
                    this.note.id = Date.now();
                    this.$emit('create', this.note);
                    this.note = { id: "", title: ""};
                }
            }
        }
    }
</script>

<style>

</style>