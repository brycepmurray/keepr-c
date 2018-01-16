<template>
    <div id="no" class="container-fluid">
      <div id="app">
        <navbar></navbar>
        
        <router-view></router-view>
      </div>
    </div>
  </template>

<script>
    import Error from './components/Error'
    import Navbar from './components/Navbar'
    export default {
        name: 'app',
        components: {
            Error,
            Navbar,
        },
        methods: {},
        mounted() {
            this.$store.dispatch('authenticate')
        }
    }
</script>

<style>
    #app {
        font-family: 'Montserrat', cursive;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        background-image: url('http://www.terravivos.com/images/genome/vault.jpg');
        min-height: 100vh;
        background-size: cover;
    }
    
    #no {
        padding-left: 0px;
        padding-right: 0px;
    }
    
    button {
        float: right
    }
</style>