@extends('layout')

@section('title')
Add New Task
@endsection

@section('content')
@if ($errors->any())
  <div class="alert alert-danger">
    <ul>
      @foreach ($errors->all() as $error)
        <li>{{ $error }} ;)</li>
      @endforeach
    </ul>
  </div>
@endif
<form method="post">
  @csrf
  <div class="form-group mb-3">
    <label for="taskName" class="form-label">Task Name</label>
    <input type="text" name="taskName" id="taskName" class="form-control">
  </div>
  <button class="btn btn-primary">Save</button>
</form>
@endsection