<template>
  <div>
    <section class="vh-15">
      <div class="container py-1 h-40">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-md-8 col-lg-6 col-xl-4">
            <div class="card shadow-0 border">
              <div class="card-body p-4">
                <h5>Weather:</h5>
                <p class="mb-2">
                  Current temperature:
                  <strong>{{ weatherData.current.temp_c }}°C</strong>
                </p>
                <p>
                  Feels like:
                  <strong>{{ weatherData.current.feelslike_c }}°C</strong>
                </p>
                <img v-bind:src="weatherData.current.condition.icon" />
                <p>
                  Conditions: <strong>{{ weatherData.current.condition.text }}.</strong> 
                  Winds at <strong>{{ weatherData.current.wind_kph }}kph.</strong> 
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  props: {
    weatherData: Object,
  },
};
</script>
