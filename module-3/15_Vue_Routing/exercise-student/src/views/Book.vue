<template>
  <div>
      <book-details v-bind:book="findBook" />
  </div>
</template>

<script>
import BookDetails from '@/components/BookDetails'

export default {
  components: { BookDetails },
    name: 'book',
    computed: {
      findBook(){
        const readingList = this.$store.state.books;
        return readingList.find(
          b => b.isbn == this.$route.params.isbn
        )
      }
    }
    
}
</script>

<style>

</style>