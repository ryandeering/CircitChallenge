<template>
    <nav class="navbar navbar-light bg-light static-top">
        <div class="container">
            <a class="navbar-brand" href="#!">Circit Challenge</a>
        </div>
    </nav>
    
    <div v-if="cityData">
        <h1>HELLO!</h1>
        <WeatherCard :weatherData="cityData" />
    </div>

</template>

<script>
    import WeatherCard from '../components/WeatherCard.vue'
    import axios from "axios";

    export default {
        props: {
            title: String
        },
        components: {
            WeatherCard
        },
        data() {
            return {
                cities: ["Dublin", "Tokyo", "Berlin"],
                cityData: {}
            }
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            this.getData("Dublin");
        },
        methods: {

            async getData(cityName){
                this.cityData = null;
                this.getTimezone(cityName);
            },
            async getTimezone(cityName) {
                this.loading = true;
                this.cityData = null;
                const res = await axios.get(`https://localhost:7094/api/timezone?city=${cityName}`);
                this.cityData = res.data;
            }
        }
    };
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
