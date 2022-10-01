Vue.createApp({
  data() 
  {
    return {
      taskInput: "" //Из архива: содержит строку нота (задачи)
      , needToDoList: [] //Из архива: список нотов на выполнение
      , nextToDoID: 0  //Ключ или же ID нота, уникальная переменная для всех нотов
      , completeToDoList: [] //Из архива: список выполненных нотов
      , placeholderString: "Введите название заметки" //Вывод подсказки в инпуте через переменную
      , TasksToDo: 0 //Переменная для количества нотов на выполнение
      , TasksDone: 0 //Переменная для количества выполненных нотов
      , TasksRemoved: 0 //Переменная для количества удалённых нотов
      , editedNoteID: null //Ключ изменяемого нота, по умолчанию пустой
      , editedNoteTitle: "" //Поле изменяемого нота, по умолчанию пустое
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
            id: this.nextToDoID++, //Постепенное увеличение id нота для уникальности
            title: this.taskInput //Из текущего инпута достаём строку и кидаем в поле нота
          });
        this.taskInput = ""; //Очищения инпута
        this.TasksToDo++; //Подсчёт количества нотов на выполнения (в принципе это длина needToDoList)
      }
    }

    //Метод удаления нота myTask из списка нотов на выполнение, используется индекс (не путать с ключом(ID)!)
    //Индекс указывается автоматически в цикле for в .html файле
    //Индексы при удалении пересчитываются автоматически
    //Пересчёт индексов не вызывает конкретно в этом методе сбои и удаление лишних нотов
    //Из-за пересчёта индексов в будущем будут возникать сбои в других методах
    //Решение сбоев описано где-то ниже
    , removeNoteToDo(index) 
    {
      this.needToDoList.splice(index, 1); //буквально удалить с индекса (нач. позиция) 1 нот
      //Условие, чтобы количество нотов на выполнение не улетело в дыру
      if (this.TasksToDo > 0)
      {
        this.TasksToDo--;
      }
      //Переменная всегда возрастает, ибо учитывается любое удаление
      this.TasksRemoved++;
    }

    ///Метод удаления нота из списка выполненных
    , removeNoteDone(index)
    {
      this.completeToDoList.splice(index, 1);
      //Условие, чтобы количество выполненных нотов не улетело в дыру
      if (this.TasksDone > 0)
      {
        this.TasksDone--;
      }
      this.TasksRemoved++;
    }

    //Метод редактирования нота на выполнение
    //В методе обновляется ключ и поле изменяемого нота.
    , edit_NoteUpdate(note)
    {
      this.editedNoteID = note.id;
      this.editedNoteTitle = note.title;
    }

    //Метод обновление ключа и поля изменяемого нота к значениям по умолчанию
    , edit_NoteRe()
    {
      this.editedNoteID = null;
      this.editedNoteTitle = "";
    }

    //Метод подтверждения изменений в изменяемом ноте
    //Смотрим все ноты в списке нотов needToDoList и ищем совпадение по ID изменяемого нота (который мы обновили в методе editTask)...
    //... при нахождении нужного нота - изменяем его поле и завершаем редактирование
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

    //Метод переброса нота из списка на выполнения в список выполненых
    //Из-за возможности возникновения сбоев по индексу - используем ключ нота
    //Обязательно объявлять новый список УДАЛЯЕМЫХ НОТОВ.
    , change_StatusToDone(index)
    {
      const task_done = this.needToDoList.splice(index , 1); //список удаляемых нотов
      task_done[0].dt = String(new Date().toLocaleString()) //к удаляемому ноту добавляем текущую дату. dt - новый атрибут/ключ списка
      this.completeToDoList.push(task_done[0]); //кидаем нот в другой список
      this.TasksToDo--; //обновление переменных подсчёта количества нотов
      this.TasksDone++;
    }

    //Метод переброса нота из списка выполненых в список на выполнение
    //Построен на основе предыдущего метода
    , change_StatusToDo(index)
    {
      const task_todo = this.completeToDoList.splice(index, 1);
      this.needToDoList.push(task_todo[0]);
      this.TasksDone--;
      this.TasksToDo++;
    }
  },
}
).mount('#app');