<template>
  <div>
    <section class="vh-5">
      <div class="container py-1 h-40">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-md-8 col-lg-6 col-xl-4">
            <div class="card shadow-0 border">
              <div class="card-body p-4">
                <h5>Astronomy:</h5>
                <p class="mb-2">
                  Sunrise Time 🌅:
                  <strong>{{ astronomyData.astronomy.astro.sunrise }}</strong>
                </p>
                <p class="mb-2">
                  Sunset Time 🌇:
                  <strong>{{ astronomyData.astronomy.astro.sunset }}</strong>
                </p>
                <p class="mb-2">
                  Moon Phase 🌝:
                  <strong>{{ astronomyData.astronomy.astro.moon_phase }}</strong>
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
    astronomyData: Object,
  },
};
</script>
