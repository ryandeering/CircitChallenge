<template>
  <div>
    <section class="vh-15">
      <div class="container py-1 h-40">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-md-8 col-lg-6 col-xl-4">
            <div class="card shadow-0 border">
              <div class="card-body p-4">
                <h5>Timezone:</h5>
                <p class="mb-2">
                  TZ Database ID 🗺️:
                  <strong>{{ timezoneData.location.tz_id }}</strong>
                </p>
                <p>
                  Local Time 🕑:
                  <strong>{{ timezoneData.location.localtime }}</strong>
                </p>
                <p>
                  Local Unix Time Epoch 🤓:
                  <strong>{{ timezoneData.location.localtime_epoch }}</strong>
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
    timezoneData: Object,
  },
};
</script>
