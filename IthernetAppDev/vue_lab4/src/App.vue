<template>
<!-- <div class="header">
    <div class="container header__container">
    <div class="logo">Список задач</div>
    <div class="wrapper">
        <div class="form">
            <input 
                type="text" 
                :placeholder = "placeholderString"
                @keypress.enter = "addTask"
                v-model = "taskInput" 
            >    
            <button class="btn" @click = "addTask">Добавить</button>
        </div>
    </div>
    </div>
</div> -->

<div>
    <Header @create='addTask'/>
</div>

<div class="container">
    <div class="wrapper">
<!--         <div class="wrapper__list">
            <h2>
                <span>Нужно сделать</span>
                <span class="task-num">{{ TasksToDo }}</span>
            </h2>

            <ul class="task-list" v-if = "needToDoList != 0">
                <li v-for = "(note, index) in needToDoList" :key="note.id">
                    <div>
                        <input 
                            type="checkbox" 
                            @change = "change_StatusToDone(index)"
                        />
                        <input 
                            type = "text"
                            v-model = "editedNoteTitle"
                            v-if = "editedNoteID == note.id"
                        >
                        <span v-else>{{note.title}}</span>
                    </div>
                    <div>
                        <button  
                            class = "btn btn_mr" 
                            v-if = "editedNoteID == note.id"
                            @click = "edit_NoteAccept"
                            >
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check2" viewBox="0 0 16 16">
                            <path d="M13.854 3.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3.5-3.5a.5.5 0 1 1 .708-.708L6.5 10.293l6.646-6.647a.5.5 0 0 1 .708 0z"/>
                            </svg>
                        </button>
                        <button  
                            class = "btn btn_yellow btn_icon" 
                            v-else
                            @click = "edit_NoteUpdate(note)"
                            >
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil" viewBox="0 0 16 16">
                            <path d="M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5 13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"/>
                            </svg>                  
                        </button>
                        <button class="btn btn_red btn_icon" @click = "removeNoteToDo(index)">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
                            <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                            <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                            </svg>
                        </button>
                    </div>
                </li>
            </ul>
            <div v-else>Задач нет</div>
            <div v-if = "needToDoList.length > 10">Может уже пора делать задачи, а не только ставить?</div>
        </div> -->

        <ListToDo :notes = 'needToDoList' @remove = 'removeNote'/>

        <!-- <div class="wrapper__list">
            <h2>
                <span>Уже сделаны</span>
                <span class="task-num">{{ TasksDone }}</span>
            </h2>

            <ul class="task-list complete-list" v-if = "completeToDoList != 0">
                <li v-for = "(note, index) in completeToDoList" :key="note.id">
                    <div>
                        <input 
                            type="checkbox" checked 
                            @change = "change_StatusToDo(index)"
                        >
                        <span>{{note.title}} {{note.dt}}</span>
                    </div>
                    <button class="btn btn_red btn_icon" @click = "removeNoteDone(index)">
                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
                        <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                        <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                        </svg>                
                    </button>
                </li>
            </ul>
            <div v-else>Задач нет</div>
        </div> -->

        <CompleteList :notes = 'completeToDoList' @remove = 'removeNoteDone'/>

        <p><b>Всего:</b> назначено {{ TasksToDo }}, сделано {{ TasksDone }}, удалено {{ TasksRemoved }}</p>
    </div>
</div>
</template>

<script>
    import Header from '@/components/Header.vue';
    import ListToDo from '@/components/ListToDo.vue';
    import CompleteList from '@/components/CompleteList.vue';

    export default 
    {
        components:
        {
            Header
            , ListToDo
            , CompleteList
        },
        data() 
        {
            return {
                taskInput: ""
                , needToDoList: []
                , nextToDoID: 0
                , completeToDoList: []
                , placeholderString: "Введите название заметки"
                , TasksToDo: 0
                , TasksDone: 0
                , TasksRemoved: 0
                , editedNoteID: null
                , editedNoteTitle: ""
            };
        },
        methods: 
        {
            addTask(note) 
            {
                this.needToDoList.push(note);
            }
            , removeNote(index) 
            {
                this.needToDoList.splice(index, 1);
                this.TasksRemoved++;
            }
            , removeNoteDone(index)
            {
                this.completeToDoList.splice(index, 1);
                this.TasksRemoved++;
            }
            , edit_NoteUpdate(note)
            {
            this.editedNoteID = note.id;
            this.editedNoteTitle = note.title;
            }
            , edit_NoteRe()
            {
            this.editedNoteID = null;
            this.editedNoteTitle = "";
            }
            , edit_NoteAccept()
            {
            this.needToDoList.forEach(note => {
                if (note.id == this.editedNoteID)
                {
                note.title = this.editedNoteTitle;
                this.edit_NoteRe();
                }
            });
            }
            , change_Status(index, flag)
            {
                if (flag == 'false')
                {
                    const task_done = this.needToDoList.splice(index , 1);
                    task_done[0].dt = String(new Date().toLocaleString())
                    this.completeToDoList.push(task_done[0]);
                } else
                {
                    const task_todo = this.completeToDoList.splice(index, 1);
                    this.needToDoList.push(task_todo[0]);
                }
            }
        }
    }
</script>

<style>

</style>