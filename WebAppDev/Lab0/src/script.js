const btnsOpenModel = document.querySelectorAll('.js-modal-open'); //кнопки открытия
const btnCloseModel = document.querySelectorAll('.modal__close'); //кнопки крестики
const modal = document.querySelectorAll('.modal');

//Открытие нужной модалки
btnsOpenModel.forEach((element) => {
    element.addEventListener("click", function() {
        element_attribute = element.getAttribute('data-open');
        let modalid = document.querySelector(element_attribute);
        modalid.classList.add("active");
    }) 
})

//Закрытие модалок через крестик
btnCloseModel.forEach((button) => {
    button.addEventListener("click", function() {
        modal.forEach((element) => {
            element.classList.remove("active");
        })
    })
})

//const overModal = document.querySelectorAll('.modal__wrapper');
//Закрытие через фон
modal.forEach((space) => {
    space.addEventListener("click", function(event) {
        var target = event.target;
        if(target.classList.contains("modal")) space.classList.remove("active");
    })
})


//Список постов
fetch('https://jsonplaceholder.typicode.com/posts')
  .then(response => response.json())
  .then(json => console.log(json))
//Комментарии к 3 посту
fetch('https://jsonplaceholder.typicode.com/posts/3/comments')
  .then(response => response.json())
  .then(json => console.log(json))
//Посты пользователя 2
fetch('https://jsonplaceholder.typicode.com/posts?userId=2')
  .then(response => response.json())
  .then(json => console.log(json))
//Альбомы пользователя 2
fetch('https://jsonplaceholder.typicode.com/albums?userId=2')
  .then(response => response.json())
  .then(json => console.log(json))
