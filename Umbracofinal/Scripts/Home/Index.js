import Vue from 'vue'
import HomeComponent from './home.vue'
import SubmisssionComponent from './submission.vue'
import AboutComponent from './about.vue'

new Vue({
    el:"#app",
        component: {
        HomeComponent,
        SubmisssionComponent,
        AboutComponent
    }
})