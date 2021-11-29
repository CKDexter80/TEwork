<template>
  <div>
    <reading-list />
    <nav>
      <router-link v-bind:to="{name: 'new-book'}">Add Book to Reading List</router-link>
    </nav>
  </div>
</template>

<script>
import ReadingList from "@/components/ReadingList";


export default {
  name: "my-books",
  components: {
    ReadingList,
    
  },
};
</script>

<style>
</style>