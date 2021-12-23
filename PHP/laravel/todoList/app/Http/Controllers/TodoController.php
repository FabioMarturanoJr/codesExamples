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
        $req->validate([
            'taskName' => 'required|min:79'
        ]);

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
