<template>
  <div class="book-details">
    <h2>{{ book.title }}</h2>
    <h2>{{ book.author }}</h2>
    <img
      v-if="book.isbn"
      v-bind:src="
        'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'
      "
    />
    <h3>{{ bookReadStatus }}</h3>
  </div>
</template>

<script>
export default {
  name: "book-details",
  props: ["book"],
  computed: {
    bookReadStatus() {
      if (this.book.read) {
        return "I have read this book.";
      } else {
        return "I have not read this book yet.";
      }
    },
  },
};
</script>

<style>
</style>