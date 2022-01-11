import React, {useEffect, useState} from 'react';
import './App.css';

import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';

import {Modal, ModalBody, ModalFooter, ModalHeader} from 'reactstrap';

function App() {
  const URL = 'https://localhost:7206/api/students';
  const [students, setStudents] = useState([]);

  const getStudents = async () => {
    const resp = await axios.get(URL).catch((e) => console.log('Error axios:',e));
    setStudents(resp.data);
    // console.log('Response data:', resp.data);
  };

  useEffect(() => {
    getStudents();
  }, []);

  return (
    <div className="App">
        <header>
          <h3>student registration</h3>
          <button className='btn btn-success'>Add</button>
        </header>
        <table className='table table-bordered'>
          <thead>
            <th>Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Age</th>
            <th>Operation</th>
          </thead>
          <tbody>
            {
              students.map(({id, name, email, age}) => (
                <tr key={id}>
                  <td>{id}</td>
                  <td>{name}</td>
                  <td>{email}</td>
                  <td>{age}</td>
                  <td>
                    <button className='btn btn-primary'>Edit</button>
                    <button className='btn btn-danger'>Dell</button>
                  </td>
                </tr>
              ))
            }
          </tbody>
        </table>
    </div>
  );
}

export default App;
