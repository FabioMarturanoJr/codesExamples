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

<a href="{{ route('createTask') }}" class="btn btn-dark mt-2 mb-2">Add</a>

<ul class="list-group">
  @foreach ($tasks as $task)
    <li class="list-group-item d-flex justify-content-between align-items-center">
      {{ $task->taskName }}
      <form method="POST" action="{{ route('removeTask', $task->id) }}"
        onsubmit="return confirm('confirm to remove {{ addslashes($task->taskName) }}')">
        @csrf
        @method('DELETE')
        <button class="btn btn-danger btn-sm">
          <i class="fas fa-trash-alt"></i>
        </button>
      </form>
    </li>
  @endforeach
</ul>
@endsection