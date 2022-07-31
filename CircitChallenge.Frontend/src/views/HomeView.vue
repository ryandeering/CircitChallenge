<template>
  <nav class="navbar navbar-light bg-light static-top">
    <div class="container">
      <a class="navbar-brand" href="#!">Circit Challenge - Ryan Deering</a>
    </div>
  </nav>

  <section class="vh-10">
    <div class="container py-5 h-20">
      <div class="row d-flex justify-content-center align-items-center h-30">
        <div class="col-md-4 col-lg-6 col-xl-4">
          <VueMultiselect v-model="selected" :options="cities" :allow-empty="false" deselect-label="Can't remove this value">
          </VueMultiselect>
        </div>
      </div>
    </div>
  </section>

  <div v-if="weatherData">
    <h4 class="mb-1 sfw-normal">
      {{ weatherData.location.name }}, {{ weatherData.location.country }}
    </h4>
    <WeatherCard :weatherData="weatherData" />
  </div>

  <div v-if="astronomyData">
    <AstronomyCard :astronomyData="astronomyData" />
  </div>

    <div v-if="timezoneData">
    <TimezoneCard :timezoneData="timezoneData" />
  </div>

</template>

<script>
import WeatherCard from "../components/WeatherCard.vue";
import AstronomyCard from "../components/AstronomyCard.vue";
import TimezoneCard from "../components/TimezoneCard.vue";
import VueMultiselect from "vue-multiselect";
import axios from "axios";
export default {
  props: {
    title: String,
  },
  components: {
    WeatherCard,
    AstronomyCard,
    TimezoneCard,
    VueMultiselect
  },
  data() {
    return {
      cities: ["Dublin", "Tokyo", "Berlin"],
      selected: "Dublin",
      weatherData: {},
      astronomyData: {},
      timezoneData: {}
    };
  },
  created() {
    this.getData(this.selected);
  },
  methods: {
    async getData(cityName) {
      this.timezoneData = null;
      this.astronomyData = null;
      this.weatherData = null;

      this.getWeather(cityName);
      this.getAstronomy(cityName);
      this.getTimezone(cityName);

    },
      async getWeather(cityName) {
      this.weatherData = null;
      const res = await axios.get(
        `https://localhost:7094/api/currentweather?city=${cityName}`
      );
      this.weatherData = res.data;
    },
      async getAstronomy(cityName) {
      this.astronomyData = null;
      const res = await axios.get(
        `https://localhost:7094/api/astronomy?city=${cityName}`
      );
      this.astronomyData = res.data;
    },
    async getTimezone(cityName) {
      this.timezoneData = null;
      const res = await axios.get(
        `https://localhost:7094/api/timezone?city=${cityName}`
      );
      this.timezoneData = res.data;
    },

  },
  watch: {
    selected(newSelected) {
      this.getData(newSelected);
      this.$forceUpdate();
    },
  },
};
</script>

<style src="vue-multiselect/dist/vue-multiselect.css"></style>
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
