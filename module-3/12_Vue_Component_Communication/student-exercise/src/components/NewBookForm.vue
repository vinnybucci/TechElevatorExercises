<template>
  <div>
    <a
      id="show-form-button"
      href="#"
      v-if="showForm === false"
      v-on:click.prevent="showForm = true"
    >Show Form</a>
    <a
      id="hide-form-button"
      href="#"
      v-if="showForm === true"
      v-on:click.prevent="showForm = false"
    >Hide Form</a>

    <form v-on:submit.prevent="addNewBook" v-if="showForm === true">
      <div class="new-book-form">
        <label for="title-input">Title:</label>
        <input id="title-input" type="text" v-model="newBook.title" />
      </div>
      <div class="new-book-form">
        <label for="author-input">Author:</label>
        <input id="author-input" type="text" v-model="newBook.author" />
      </div>
      <div class="new-book-form">
        <label for="isbn-input">ISBN:</label>
        <input id="isbn-input" type="text" v-model="newBook.isbn" />
      </div>
      <input type="submit" value="Save" />
      <input type="button" value="Cancel" v-on:click.prevent="resetForm" />
    </form>
  </div>
</template>

<script>
export default {
  name: "add-book",
  data() {
    return {
      showForm: false,
      newBook: {
        read: false,
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_BOOK", this.newBook)
      this.resetForm();
    },
    resetForm() {
      this.showForm = false;
      this.newBook = {};
    },
  },
};
</script>

