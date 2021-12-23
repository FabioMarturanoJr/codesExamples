<?php

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

// Route::get('/', function () {
//     return view('welcome');
// });

Route::get('/todoList', 'TodoController@index')->name('listTask');
Route::get('/todoList/create', 'TodoController@createTask')->name('createTask');
Route::post('/todoList/create', 'TodoController@storeTask')->name('createTask');
Route::delete('/todoList/{id}', 'TodoController@removeTask')->name('removeTask');
