<template>
  <main>
    <div class="content">
      {{ name }}
      <br />
      {{ $store.state.content }}
      <br />
      {{ stateText }}
      
      <form>
        <div class="mb-3">
          <label for="exampleInputEmail1" class="form-label"
            >Text 1</label
          >
          <input
            type="text"
            class="form-control"
            id="exampleInputEmail1"
            aria-describedby="emailHelp"
            v-model="textBox"
          />
          <div id="emailHelp" class="form-text">
            We'll never share your email with anyone else.
          </div>
        </div>
        <button v-on:click="handleClick" type="button" class="btn btn-primary">
          Primary
        </button>
      </form>
    </div>
  </main>
</template>

<script>
export default {
  name: "main-content",
  data() {
    return {
      name: "Main Content",
      textBox: ""
    };
  },
  computed: {
    stateText() {
      return this.$store.state.content + "123";
    },
  },
  methods: {
    handleClick() {
      console.log("clicked");
    },
  },
};
</script>

<style>
</style>