const app = {
    data() 
    {
        return{
            cnt: 0
            , name_h: "Счётчик: "
            , listTitle: "Список заметок"
            , placeholderString: "Введите название заметки"
            , inputValue: ""
            , calcTitle: "Какулятор"
            , placeholderString1: "Введите число"
            , inputValue1: 0
            , inputValue2: 0
            , resultValue: 0
            , notes: [ "Note 1" ]
        }
    },
    
    methods:
    {
        method_add() 
        { 
            if (this.cnt < 10) this.cnt++ 
            else alert("Enough! Counter is max.")
        }
        , method_sub() 
        { 
            if (this.cnt > 0) this.cnt-- 
            else alert("Enough! Counter is min.")
        }
        , method_inputChange(event)
        {
            this.inputValue = event.target.value;
        }
        , method_inputChange1(event)
        {
            this.inputValue1 = event.target.value;
            this.resultValue = Number(this.inputValue1) + Number(this.inputValue2);
        }
        , method_inputChange2(event)
        {
            this.inputValue2 = event.target.value;
            this.resultValue = Number(this.inputValue1) + Number(this.inputValue2);
        }
        , method_result()
        {
            let num = Number(this.inputValue1) + Number(this.inputValue2);
            this.resultValue = num;
        }
        , method_addNewNote()
        {
            if (this.inputValue != '')
            {
                this.notes.push(this.inputValue);
                this.inputValue = "";
            }           
        }
        , method_removeLastNote()
        {
            this.notes.pop();
        }
        , method_inputKey(event)
        {
            if (event.key == 'Enter') 
            {
                this.method_addNewNote();
            }
        }
        , method_inputKey1(event)
        {
            if (event.shiftKey == true && event.key == '+')
            {
                this.method_addNewNote();
                event.preventDefault();
            }
        }
        , method_removeNote(idx)
        {
            this.notes.splice(idx, 1);
        }
        , useless_method_toUpperCase(item)
        {
            return item.toUpperCase();
        }
        , doubleCount()
        {
            console.log('doubleCount');
            return this.notes.length * 2;
        },
        
    },

    computed:
    {
        doubleCountCompoted()
        {
            console.log('doubleCountCompoted');
            return this.notes.length * 2;
        }
    },

    watch:
    {
        inputValue(value)
        {
            console.log('VALUE CHANGED!!', value)
            if (value.length > 30) this.inputValue = '';
            if (value.slice(-1) == '@') this.inputValue = '';
        }
    }
}

Vue.createApp(app).mount("#app");