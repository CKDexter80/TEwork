//https://localhost:44315/student

import axios from 'axios';

export default {

  getAllStudents() {
    return axios.get('/student')
  },
}
