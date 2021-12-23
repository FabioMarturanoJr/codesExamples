<?php

namespace App\Http\Controllers;

use App\Task;
use Illuminate\Http\Request;
use App\Http\Requests\taskFormRequest;

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

    public function storeTask(taskFormRequest $req)
    {
        $taskName = $req->taskName;
        $task = Task::create(compact('taskName'));

        $mesage = "Task id {$task->id} created: {$taskName}";        
        $req->session()->flash('mesage', $mesage);

        return redirect()->route('listTask');
    }
    
    public function removeTask(Request $req)
    {
        Task::destroy($req->id);
        
        $mesage = "Task successfully deleted";
        
        $req->session()->flash('mesage', $mesage);

        return redirect()->route('listTask');
    }
}
