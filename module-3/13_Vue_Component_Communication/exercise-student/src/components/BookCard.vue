<template>
  <div class="card" v-bind:class="{read: this.book.read === true}">
    <h2 class="book-title">{{book.title}}</h2>
    <!-- Please leave <img> commented out until directed to remove open and close comment tags in the README.-->
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <h3 class="book-author">{{book.author}}</h3>

    <button class="mark-read" v-if="!this.book.read" v-on:click="flipReadStatus()">Mark Read</button>
    <button class="mark-unread" v-else v-on:click="flipReadStatus()">Mark Unread</button>

  </div>
</template>
<script>
export default {
    name: 'book-card',
    props: ['book'],
    methods: {
        flipReadStatus(){
            this.$store.commit('MARK_READ', this.book );
        }
    },
    
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>