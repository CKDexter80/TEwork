<template>
  <main>
    <div class="loading" v-if="isLoading">
      <img src="../assets/ping_pong_loader.gif" />
    </div>
    <div v-else>
      <router-link
       v-bind:to="{ name: 'Board', params: { id: $route.params.boardID } }"
      >
      Get Back</router-link>
      <h1>
        {{ card.title }}
      </h1>
      <p>
        {{ card.description }}
      </p>
      <comments-list v-bind:comments="card.comments" />
    </div>
  </main>
</template>

<script>
import boardsService from "../services/BoardService";
import CommentsList from "../components/CommentsList";

export default {
  name: "card-detail",
  components: {
    CommentsList,
  },
  data() {
    return {
      card: {
        title: "not loaded yet",
        description: "",
        comments: [],
      },
      isLoading: true,
    };
  },
  created() {
    const boardId = this.$route.params.boardID;
    const cardId = this.$route.params.cardID;

    boardsService.getCard(boardId, cardId).then((response) => {
      this.card = response;
      this.isLoading = false;
    });
  },
};
</script>
