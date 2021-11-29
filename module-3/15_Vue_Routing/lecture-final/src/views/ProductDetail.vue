<template>
  <div id="app" class="main">
    <!--router-link to="/">Back To Product List</router-link-->
    <router-link v-bind:to="{name: 'products'}">
      Go Back
    </router-link>
    <h1>Product Reviews for {{ product.name }}</h1>
    <p class="description">
      {{ product.description }}
    </p>
    <div class="well-display">
      <average-summary />
      <star-summary rating = "1" />
      <star-summary rating = "2" />
      <star-summary rating = "3" />
      <star-summary rating = "4" />
      <star-summary rating = "5" />
    </div>

    <review-list />
  </div>
</template>

<script>

import AverageSummary from "../components/AverageSummary.vue";
import StarSummary from "../components/StarSummary.vue";
import ReviewList from "../components/ReviewList.vue";


export default {
    name: 'product-detail',
      components: {
    AverageSummary,
    StarSummary,
    ReviewList

  },
    created(){
      //console.log('created');
      this.$store.commit('SET_ACTIVE_PRODUCT', this.$route.params.id);
    },
    computed: {
      product(){
      const allProducts = this.$store.state.products;
      const currentProductId = this.$store.state.activeProduct;
      return allProducts.filter(
          (p) =>{
              return p.id == currentProductId;
            }
        )
      }
    }
}
</script>

<style>

</style>