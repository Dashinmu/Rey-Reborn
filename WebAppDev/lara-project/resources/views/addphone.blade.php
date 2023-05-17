@extends('layout')

@section('content')
<h1 class="mb-5">{{$header}}</h1>
<div class="row">
    <div class="col-md-6">
        @if($errors->any())
            <div class = 'alert alert-danger'>
                <ul>
                    @foreach($errors->all() as $error)
                        <li>{{$error}}</li>
                    @endforeach
                </ul>
            </div>
        @endif
        @if(session('message'))
            <div class = "alert alert-success">
                {{session('message')}}
            </div>
        @endif
        <form class="d-flex mb-4 flex-column align-items-start" role="search" method="post" action="{{route('addphone')}}">
            @csrf
            <input class="form-control me-2 mb-3" value="{{ old('name') }}" type="text" name="name" placeholder="Имя" >
            <input class="form-control me-2 mb-3" value="{{ old('email') }}" type="email" name="email" placeholder="Почта">
            <input class="form-control me-2 mb-3" value="{{ old('phone') }}" type="text" name="phone" placeholder="Телефон">
            <button class="btn btn-outline-success" type="submit">Добавить</button>
        </form>
    </div>
</div>
@endsection