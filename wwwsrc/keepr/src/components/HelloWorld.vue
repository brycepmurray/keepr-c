<template>
  <div class="app">
    <navbar></navbar>
  </div>
</template>

<script>
    export default {
        name: 'HelloWorld',
        data() {
            return {}
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .app {
        margin: 0px;
    }
    
    .hello {
        margin: 0px;
    }
    
    h1,
    h2 {
        font-weight: normal;
        margin: 0px;
        padding: 10px;
    }
    
    ul {
        list-style-type: none;
        padding: 0;
    }
    
    li {
        display: inline-block;
        margin: 0 10px;
    }
    
    a {
        color: #42b983;
    }
</style>