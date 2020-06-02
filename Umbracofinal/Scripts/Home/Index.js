import Vue from 'vue'
import HomeComponent from './home.vue'
import loginComponent from './login.vue'
import AboutComponent from './about.vue'
import TestComponent from './test.vue'


new Vue({
    el:"#app",
        component: {
        HomeComponent,
        LoginComponent,
        AboutComponent,
        TestComponent
    }
})