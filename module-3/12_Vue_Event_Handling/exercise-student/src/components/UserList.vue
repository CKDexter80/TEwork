<template>
  <div class="container">
    <table id="tblUsers">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
          <th>Email Address</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>
            <input
              type="checkbox"
              id="selectAll"
              v-model="isAllChecked"
              v-on:click="checkAllBoxes"
            />
          </td>
          <td>
            <input
              type="text"
              id="firstNameFilter"
              v-model="filter.firstName"
            />
          </td>
          <td>
            <input type="text" id="lastNameFilter" v-model="filter.lastName" />
          </td>
          <td>
            <input type="text" id="usernameFilter" v-model="filter.username" />
          </td>
          <td>
            <input type="text" id="emailFilter" v-model="filter.emailAddress" />
          </td>
          <td>
            <select id="statusFilter" v-model="filter.status">
              <option value>Show All</option>
              <option value="Active">Active</option>
              <option value="Disabled">Disabled</option>
            </select>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr
          v-for="user in filteredList"
          v-bind:key="user.id"
          v-bind:class="{ disabled: user.status === 'Disabled' }"
        >
          <td>
            <input
              type="checkbox"
              v-bind:id="user.id"
              v-bind:value="user.id"
              v-model="selectedUserIDs"
              v-on:change="checkABox"
            />
          </td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.username }}</td>
          <td>{{ user.emailAddress }}</td>
          <td>{{ user.status }}</td>
          <td>
            <!-- This is sweaty, I know.  I'll refactor at a later time -->
            <button
              class="btnEnableDisable"
              v-bind:id="user.id"
              v-bind:value="user.id"
              v-on:click="flipStatus(user.id)"
              v-if="user.status === 'Active'"
            >
              Disable
            </button>
            <button
              class="btnEnableDisable"
              v-bind:id="user.id"
              v-bind:value="user.id"
              v-on:click="flipStatus(user.id)"
              v-if="user.status === 'Disabled'"
            >
              Enable
            </button>
          </td>
        </tr>
      </tbody>
    </table>

    <div class="all-actions">
      <button :disabled="actionButtonDisabled" v-on:click="enableSelectedUsers">
        Enable Users
      </button>
      <button
        :disabled="actionButtonDisabled"
        v-on:click="disableSelectedUsers"
      >
        Disable Users
      </button>
      <button :disabled="actionButtonDisabled" v-on:click="deleteSelectedUsers">
        Delete Users
      </button>
    </div>

    <button v-on:click.prevent="showForm = true">Add New User</button>

    <form
      id="frmAddNewUser"
      v-show="showForm === true"
      v-on:submit.prevent="saveUser"
    >
      <div class="field">
        <label for="firstName">First Name:</label>
        <input type="text" name="firstName" v-model="newUser.firstName" />
      </div>
      <div class="field">
        <label for="lastName">Last Name:</label>
        <input type="text" name="lastName" v-model="newUser.lastName" />
      </div>
      <div class="field">
        <label for="username">Username:</label>
        <input type="text" name="username" v-model="newUser.username" />
      </div>
      <div class="field">
        <label for="emailAddress">Email Address:</label>
        <input type="text" name="emailAddress" v-model="newUser.emailAddress" />
      </div>
      <button type="submit" class="btn save">Save User</button>
    </form>
  </div>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      showForm: false,
      selectedUserIDs: [],
      isAllChecked: false,
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "",
      },
      newUser: {
        id: null,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active",
      },
      users: [
        {
          id: 1,
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active",
        },
        {
          id: 2,
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active",
        },
        {
          id: 3,
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled",
        },
        {
          id: 4,
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active",
        },
        {
          id: 5,
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active",
        },
        {
          id: 6,
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled",
        },
      ],
    };
  },
  methods: {
    saveUser() {
      this.newUser.id = this.users[this.users.length - 1].id + 1;
      this.users.push(this.newUser);
      this.newUser = {
        id: null,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active",
      };
      this.showForm = false;
    },

    flipStatus(userId) {
      const userToFlip = this.findUser(userId);
      console.log(userToFlip);
      if (userToFlip.status === "Active") {
        userToFlip.status = "Disabled";
      } else if (userToFlip.status === "Disabled") {
        userToFlip.status = "Active";
      }
    },
    checkAllBoxes() {
      this.isAllChecked = !this.isAllChecked;
      this.selectedUserIDs = [];

      if (this.isAllChecked) {
        this.users.forEach((user) => {
          this.selectedUserIDs.push(user.id);
        });
      }
    },
    enableSelectedUsers() {
      this.selectedUserIDs.forEach(
        (id) => (this.findUser(id).status = "Active")
      );
    },
    disableSelectedUsers() {
      this.selectedUserIDs.forEach(
        (id) => (this.findUser(id).status = "Disabled")
      );
    },
    deleteSelectedUsers() {
      this.selectedUserIDs.forEach((id) =>
        this.users.splice(
          this.users.findIndex((user) => user.id === id),
          1
        )
      );
      this.selectedUserIDs = [];    
    },
    findUser(userId) {
      return this.users.find((user) => user.id == userId);
    },
    checkABox() {
      if (this.selectedUserIDs.length === this.users.length) {
        this.isAllChecked = true;
      } else {
        this.isAllChecked = false;
      }
    },
  },
  computed: {
    filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter(
          (user) => user.status === this.filter.status
        );
      }
      return filteredUsers;
    },
    actionButtonDisabled() {
      return this.selectedUserIDs.length === 0;
    },
  },
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  margin-bottom: 20px;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}

form {
  margin: 20px;
  width: 350px;
}
.field {
  padding: 10px 0px;
}
label {
  width: 140px;
  display: inline-block;
}
button {
  margin-right: 5px;
}
.all-actions {
  margin-bottom: 40px;
}
.btn.save {
  margin: 20px;
  float: right;
}
</style>
