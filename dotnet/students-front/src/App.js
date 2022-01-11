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
          <h3>Fabio Marturano</h3>
          <button className='bnt btn-success'>Add Student</button>
        </header>
        <table className='table table-bordered'>
          <thead>
            <tr>Id</tr>
            <tr>Name</tr>
            <tr>Email</tr>
            <tr>Age</tr>
            <tr>Operation</tr>
          </thead>
          <tbody>
            {
              students.map(({id, name, email, age}) => (
                <tr key={id}>
                  <td>{id}</td>
                  <td>{name}</td>
                  <td>{email}</td>
                  <td>{age}</td>
                </tr>
              ))
            }
          </tbody>
        </table>
    </div>
  );
}

export default App;
