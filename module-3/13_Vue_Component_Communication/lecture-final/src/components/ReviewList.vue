<template>
  <div class="reviews">
    <review-display
      v-for="reviewFromLoop in filteredReviews"
      v-bind:key="reviewFromLoop.title"
      v-bind:review="reviewFromLoop"
    />
  </div>
</template>

<script>
import ReviewDisplay from "./ReviewDisplay";

export default {
  name: "review-list",
  components: {
    ReviewDisplay
  },
  computed: {
    filteredReviews() {
      const reviewsFilter = this.$store.state.filter;
      const reviews = this.$store.state.reviews;
      const filteredReviews = reviews.filter(
          (review) => {
            //filter so method boolean exp
            //if true - add object to be returned
          return ((reviewsFilter === 0) || (reviewsFilter === review.rating));
        }
      );
      return filteredReviews;
    }
  }
};
</script>

<style>
div.main {
  margin: 1rem 0;
}
div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.well-display div.well {
  cursor: pointer;
}
</style>
