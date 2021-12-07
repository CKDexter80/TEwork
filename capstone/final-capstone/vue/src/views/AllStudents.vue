<template>
  
    <main>  
        <h1>ALL STUDENTS</h1>
        <div v-for="student in students" v-bind:key="student.quote">  
            <h1>
                {{ student.firstName}} {{ student.lastName}}
            </h1>
            <p>
                {{ student.quote}}
            </p>
        </div>

    </main>

</template>

<script>

import student from '../services/Student.js'

export default {
    name:'all-students',
    data(){
        return{
            students: []
        }
    },
    created(){
       // this.students = student.getAllStudents();
       student.getAllStudents().then(
           response => {
               this.students = response.data;
           }
       )
    }

}
</script>

<style>

</style>