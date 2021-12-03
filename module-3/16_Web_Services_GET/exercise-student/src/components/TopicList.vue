<template>
  <div class="topic-list">
    <router-link v-for="topic in topics" v-bind:key="topic.id" :to="{ name: 'Messages', params: {id: topic.id} }">
    <div class="topic">
      {{ topic.title }}
    </div>
    </router-link>>
  </div>
</template>

<script>
import TopicsService from "@/services/TopicsService";
export default {
  name: "topic-list",
  created() {
    TopicsService.getTopics().then((response) => {
      this.topics = response.data;
    });
  },
  data() {
    return {
      topics: [],
    };
  },
};
</script>

<style>
.topic-list {
  padding: 20px 20px;
  margin: 0 auto;
  max-width: 600px;
}
.topic {
  font-size: 24px;
  border-bottom: 1px solid #f2f2f2;
  padding: 10px 20px;
}
.topic:last-child {
  border: 0px;
}
</style>