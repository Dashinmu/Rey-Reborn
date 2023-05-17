<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>{{ $header }}</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
 
</head>
<body>
    <header>
 
    <nav class="navbar navbar-expand-lg navbar navbar-dark bg-dark">
  <div class="container">
    <a class="navbar-brand" href="#">Мой сайт</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('home');}}">Домой</a>
        </li>
      
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('phonebook');}}">Телефонный справочник</a>
        </li>

        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('addphonebook');}}">Добавить</a>
        </li>

        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('tasks');}}">Задания</a>
        </li>

        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('about');}}">О нас</a>
        </li>
        
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="{{route('contacts');}}">Контакты</a>
        </li>

        <!-- <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li> -->
      </ul>
   
    </div>
  </div>
</nav>
    </header>
    <div class="container pt-5">
        @yield('content')
    </div>
 
</body>
</html>
