<?php

use Illuminate\Support\Facades\Route;
// use App\Http\Controllers\MainController;
use App\Http\Controllers;
use Resources\Views;
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/


Route::get('/home', function () {
    $header = 'Домашняя страница';
    return view('home', compact('header'));
})->name('home');

Route::get('/phonebook', 'App\Http\Controllers\MainController@index')->name('phonebook');

Route::get('/search', 'App\Http\Controllers\MainController@search')->name('search');

Route::get('/about', function () {
    $header = 'О нас';
    return view('about', compact('header'));
})->name('about');

Route::get('/contacts', function () {
    $header = 'Контакты';
    return view('contacts', compact('header'));
})->name('contacts');

Route::get('/tasks', function () {
    $header = 'Задания';
    return view('tasks', compact('header'));
})->name('tasks');

Route::get('/addphonebook', function() {
    $header = 'Добавить телефон';
    return view('addphone', compact('header'));
})->name('addphonebook');

Route::post('/addphonebook', 'App\Http\Controllers\MainController@addphone')->name('addphone');

Route::get('/removephonebook', 'App\Http\Controllers\MainController@removephone')->name('removephone');