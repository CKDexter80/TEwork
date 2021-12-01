<template>
  <div>
    <h1>
      {{card.title}}
    </h1>
    <p>
      {{card.description}}
    </p>
    <comments-list v-bind:comments="this.card.comments" />
  </div>
</template>

<script>
import boardsService from '../services/BoardService';
import commentsList from '../components/CommentsList';
export default {
  name: "card-detail",
  components: {
    commentsList
  },
  data(){
    return {
      card: {
        title: '',
        description: '',
        comments: []
      }
    }
  },
  created(){
    const boardId = this.$route.params.boardID;
    const cardId = this.$route.params.cardID;
    boardsService.getCard(boardId, cardId).then(
      response => {
        
        this.card = response;
      }
    )
    
  }
};
</script>
