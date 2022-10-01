Vue.createApp({
  data() 
  {
    return {
      taskInput: "" //Из архива: содержит строку нота (задачи)
      , needToDoList: [] //Из архива: список нотов на выполнение
      , nextToDoId: 0  //Ключ или же ID нота, уникальная переменная для всех нотов
      , completeToDoList: [] //Из архива: список выполненных нотов
      , placeholderString: "Введите название заметки" //Вывод подсказки в инпуте через переменную
      , countTaskToDo: 0 //Переменная для количества нотов на выполнение
      , countTaskDone: 0 //Переменная для количества выполненных нотов
      , countTaskDeleted: 0 //Переменная для количества удалённых нотов
      , editedTaskId: null //Ключ изменяемого нота, по умолчанию пустой
      , editedTaskTitle: "" //Поле изменяемого нота, по умолчанию пустое
    };
  },
  methods: 
  {
    //Метод добавления нота myTask в список нотов на выолнение needToDoList[]
    addTask() 
    {
      //replace используется для удаления всех пробелов в строке, чтобы нот не был "пустым"
      if (this.taskInput.replace( /\s/g, '') != '')
      {
        //В список нотов needToDoList в конец закидываем нот с указанием id и tittle
        this.needToDoList.push(
          {
            id: this.nextToDoId++, //Постепенное увеличение id нота для уникальности
            title: this.taskInput //Из текущего инпута достаём строку и кидаем в поле нота
          });
        this.taskInput = ""; //Очищения инпута
        this.countTaskToDo++; //Подсчёт количества нотов на выполнения (в принципе это длина needToDoList)
      }
    }

    //Метод удаления нота myTask из любого списка нотов, используется индекс (не путать с ключом(ID)!)
    //Индекс указывается автоматически в цикле for в .html файле
    //Индексы при удалении пересчитываются автоматически
    //Пересчёт индексов не вызывает конкретно в этом методе сбои и удаление лишних нотов
    //Из-за пересчёта индексов в будущем будут возникать сбои в других методах
    //Решение сбоев описано где-то ниже
    , removeTask(index) 
    {
      this.needToDoList.splice(index, 1); //буквально удалить с индекса (нач. позиция) 1 нот
      this.completeToDoList.splice(index, 1);
      //Условие, чтобы количество нотов на выполнение не улетело в дыру
      if (this.countTaskToDo > 0)
      {
        this.countTaskToDo--;
      }
      //Условие, чтобы количество выполненных нотов не улетело в дыру
      if (this.countTaskDone > 0)
      {
        this.countTaskDone--;
      }
      //Переменная всегда возрастает, ибо учитывается любое удаление
      this.countTaskDeleted++;
    }

    //Метод редактирования нота на выполнение
    //В методе обновляется ключ и поле изменяемого нота.
    , editTask(task)
    {
      this.editedTaskId = task.id;
      this.editedTaskTitle = task.title;
    }
    , editTaskStop()
    {
      this.editedTaskId = null;
      this.editedTaskTitle = "";
    }
    , editTaskEnd()
    {
      this.needToDoList.forEach(element => {
        if (element.id == this.editedTaskId)
        {
          element.title = this.editedTaskTitle;
          this.editTaskStop();
        }
      });
    }
    , changeStatusTask_Done(idx)
    {
      const task_done = this.needToDoList.splice(idx , 1);
      task_done[0].dt = String(new Date().toLocaleString())
      this.completeToDoList.push(task_done[0]);
      this.countTaskToDo--;
      this.countTaskDone++;
    }
    , changeStatusTask_ToDo(idx)
    {
      const task_todo = this.completeToDoList.splice(idx, 1);
      this.needToDoList.push(task_todo[0]);
      this.countTaskDone--;
      this.countTaskToDo++;
    }
  },
}
).mount('#app');