<template>
  <header>
    <div class="content">
      {{ childText }}
    </div>
  </header>
</template>

<script>
export default {
  name: "the-header",
  props: ["childText"],
};
</script>

<style scoped>
</style>