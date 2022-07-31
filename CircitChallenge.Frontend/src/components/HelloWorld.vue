<template>
    <div class="post">
        <div v-if="loading === 'true'" class="loading">
            Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
        </div>
        <div v-else class="content">
            <h3>{{post.region}}</h3>
        </div>
		
		<div class="alert alert-primary" role="alert">
		A simple primary alert—check it out!
		</div>
    </div>
</template>

<script lang="js">
    import { defineComponent } from 'vue';
    import axios from "axios";

    export default defineComponent({
        data() {
            return {
                loading: false,
                post: null
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            this.fetchData();
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            async fetchData() {
                this.loading = true;
                this.post = null;
                const res = await axios.get('https://localhost:7094/api/timezone?city=Dublin');
                this.post = res.data.location;
            }
        },
    });
</script>