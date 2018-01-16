<div>
    <ul>
        <div class="col-xs-5">
            <li>
                <a class="home" href="#">Home</a>
            </li>
            <li>
                <a href="#cookbook">Cookbook</a>
            </li>
            <li>
                <a href="#shopping">Shopping List</a>
            </li>



        </div>
        <div class="col-xs-4 text-left">

            <li>
                <h3 v-if="user.name">Welcome, {{user.name}}</h3>
                <h3 v-if="!user.name">Welcome, traveler</h3>
            </li>
        </div>

        <li v-if="user.name" class="logout pull-right">
            <a v-if="user.name" @click="logout">Log Out</a>
        </li>
        <li v-if="!user.name" class="logout">
            <a href="#login">Log In</a>
        </li>
    </ul>

</div>
</template>



<script>
    const swal = require('sweetalert2')
    export default {
        name: 'navbar',
        data() {
            return {}
        },
        computed: {
            user() {
                return this.$store.state.user
            }
        },
        methods: {
            logout() {
                swal({
                    title: 'Are you sure?',
                    type: 'warning',
                    showCancelButton: true,
                    cancelButtonColor: '#d33',
                    confirmButtonColor: '#3085d6',
                    cancelButtonText: "No, I'm not sure",
                    confirmButtonText: "Yes, I'm sure",
                    cancelButtonClass: 'btn btn-danger',
                    confirmButtonClass: 'btn btn-success',
                    buttonsStyling: false,
                    reverseButtons: true
                }).then((result) => {
                    if (result.value) {
                        swal(
                            "",
                            "You've been logged out.",
                            'success'
                        )
                        this.$store.dispatch('logout')
                    } else if (result.dismiss === 'cancel') {
                        return
                    }
                })
            },
            login() {
                this.$store.dispatch('authenticate')
            }
        },
        components: {}
    }
</script>


<style scoped>
    ul {
        list-style-type: none;
        display: flex;
        justify-content: space-between;
        margin: 0;
        padding: 0;
        overflow: hidden;
        background-color: #333;
    }
    
    li {
        float: left;
    }
    
    li a {
        display: block;
        color: white;
        text-align: center;
        padding: 14px 16px;
        font-family: 'Montserrat', cursive;
    }
    
    h3 {
        color: white;
        display: block;
        text-align: center;
        font-family: 'Montserrat', cursive;
        margin-top: 9px
    }
    
    .logout {
        right: 0px;
        cursor: pointer;
    }
    
    .logout:hover {
        color: red;
    }
    
    li a:hover {
        background-color: #111;
    }
</style>