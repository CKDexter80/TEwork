<template>
    <div class="main">
        <input v-model="text" type="text" name="" id="">
        <p>{{text}}</p>
        <h2>
            {{name}} 
        </h2>
        <p>
            Average Rating: {{averageRating}}
        </p>
        <div 
            v-for="review in reviews" 
            v-bind:key="review.reviewer"
            v-bind:class="{favorited: review.favorited}"
            class="review"
        > 
            <h4>
            {{review.reviewer}}
            </h4>
            <div class="rating">
                <img
                v-for="n in review.rating" 
                v-bind:key="n"
                src="../assets/star.png" 
                alt=""
                >          
            </div>
            <h3>
                {{review.title}}
            </h3>
            <p>
                {{review.review}}
            </p>
            <p>
                <input v-model="review.favorited" type="checkbox" name="" id="">
            </p>
        </div>
    </div>
</template>

<script>
export default {
    name: 'product-review',
    data() {
        return {
            text: '',
            name : 'Cigar Parties For Reasonably Intelligent People',
            description : 'How to host the perfect Cigar Party',
            reviews : [
                {
                    reviewer: 'Joe',
                    title: 'Too Long Din Read',
                    rating: 2,
                    review: 'Watch the movie instead',
                    favorited: false
                },
                {
                    reviewer: 'Joe Seph',
                    title: 'Wow',
                    rating: 5,
                    review: 'Read it all',
                    favorited: false
                }
            ]
        }
    },
    computed: {
        test(){
            return this.reviews.length;
        },
        averageRating(){
            //must use `this`
            //must return something
            const sum = this.reviews.reduce(
                (currentSum, review) =>{
                    return currentSum + review.rating
                },0
                )
            return sum / this.reviews.length;
        }
    }
}
</script>

<style scoped>
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

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review.favorited {
  background-color: lightyellow;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}
.favorited {
    background-color: yellow;
}
</style>