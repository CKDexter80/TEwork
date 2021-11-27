<template>
<div>
    <form class="new-book-form" action="#">
        <h2>Add New Book</h2>
        <div>
        <label for="title">Add title: </label>
        <input class="title-input" type="text" id="title" name="title" v-model="newBook.title">
        </div>
        <div>
        <label for="author">Add author: </label>
        <input class="author-input" type="text" id="author" name="author" v-model="newBook.author">
        </div>

        <div>
        <label for="isbn">Add ISBN: </label>
        <input class="isbn-input" type="text" id="isbn" name="isbn" v-model="newBook.isbn">
        </div>
        <div>
            <input type="submit" value="Submit" v-on:click.prevent="addToList()">
        </div>
    </form>
</div>
</template>

<script>
export default {
    name: "new-book-form",
    data(){
        return {
            newBook:{
                title:"",
                author:"",
                isbn: "",
                read:false
            },
        }
    },
    methods: {
        addToList(){
            
            this.$store.commit('ADD_BOOK', this.newBook);
            //console.log("poo")
        }
    }

}
</script>

<style>
.new-book-form{
    
    
}
</style>