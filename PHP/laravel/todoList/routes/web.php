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

Route::get('/todoList', 'TodoController@index');

Route::get('/todoList/create', 'TodoController@createTask');
Route::post('/todoList/create', 'TodoController@storeTask');
