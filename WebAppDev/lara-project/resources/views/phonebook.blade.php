@extends('layout')

@section('content')

<h1 class="mb-4">{{ $header }}</h1>
    <form class="d-flex mb-4" role="search" method="GET" action="{{route('search');}}">
        <input class="form-control me-2" type="search" placeholder="Имя" aria-label="Search" name="s1" value="{{$s1}}">
        <input class="form-control me-2" type="search" placeholder="Почта" aria-label="Search" name="email" value="{{$email}}">
        <button class="btn btn-outline-success" type="submit">Поиск</button>
      </form>
@if(count($users))
<table class="table table-hover table-striped">
    <thead>
        <tr>
        <th scope="col">№</th>
        <th scope="col">#</th>
        <th scope="col">Имя</th>
        <th scope="col">Почта</th>
        <th scope="col">Телефон</th>
        <th scope="col">Обновлён</th>
        <th scope="col">Удалить</th>
        </tr>
    </thead>
    <tbody>
        @foreach($users as $num => $user)
        <tr>
            <td>{{++$num + ($users->currentPage() - 1) * 10 }}</td>
            <td>{{$user->id}}</td>
            <td>{{$user->name}}</td>
            <td>{{$user->email}}</td>
            <td>{{$user->phone}}</td>
            <td>{{$user->updated_at}}</td>
            <td><a href="{{route('removephone')}}?id={{$user->id}}">Удалить</a></td>
        </tr>
        @endforeach
    </tbody>
</table>
@else
<h2 class="mb-4">Пользователей нет</h2>
@endif
{{$users->appends(['s1' => request()->s1])->appends(['email' => request()->email])->links()}}
@endsection