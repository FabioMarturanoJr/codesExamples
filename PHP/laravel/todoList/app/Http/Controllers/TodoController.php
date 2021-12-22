<?php

namespace App\Http\Controllers;

use App\Task;
use Illuminate\Http\Request;
use PHPUnit\Framework\Test;

class TodoController extends Controller
{
    public function index(Request $req) {
        // get infos req
        // echo $req->url() . ' ';
        // echo $req->query('gata') . ' ';
        // echo var_dump($req->query());
        // $tasks = Task::all();

        $mesage = $req->session()->get('mesage');

        $tasks = Task::query()->orderBy('taskName')->get();
        
        return view('todo.index', compact('tasks', 'mesage'));
    }

    public function createTask()
    {
        return view('todo.createTask');
    }

    public function storeTask(Request $req)
    {
        $taskName = $req->taskName;

        $task = Task::create(compact('taskName'));

        $mesage = "Task id {$task->id} created: {$task->taskName}";
        
        $req->session()->flash('mesage', $mesage);

        return redirect('/todoList');
    }
}
