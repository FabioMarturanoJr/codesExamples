@extends('layout')

@section('title')
tasks
@endsection

@section('content')
@if(!empty($mesage))
<div class="alert alert-success">
  {{ $mesage }}
</div>
@endif

<a href="/todoList/create" class="btn btn-dark mt-2 mb-2">Add</a>

<ul class="list-group">
  @foreach ($tasks as $task)
    <li class="list-group-item">{{ $task->taskName }}</li>
  @endforeach
</ul>
@endsection