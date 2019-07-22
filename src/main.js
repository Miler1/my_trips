// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import * as VueGoogleMaps from 'vue2-google-maps'
import 'bootstrap-css-only/css/bootstrap.min.css'
import 'mdbvue/build/css/mdb.css'
import StarRating from 'vue-star-rating'

Vue.use(VueGoogleMaps, {
  load: {
    libraries: 'places'
  }
})

Vue.component('star-rating', StarRating);

Vue.component('my-modal', {
  template: 
      `<template>
      <mdb-card cascade class="cascading-admin-card mb-5" @click.native="modal = true" :show="modal">
        <mdb-card-body class="d-sm-flex justify-content-between">
          <mdb-row>
          <mdb-col xl="3" md="4" class="mb-r">
            <i class="fas fa-map-marker-alt"> </i> {{cities.city.name}}, {{cities.country}}
          </mdb-col>
          <mdb-col xl="3" md="4" class="mb-r">
            <i class="far fa-calendar-alt"></i> {{cities.date}}
          </mdb-col>
          <mdb-col xl="3" md="4" class="mb-r">
            <i class="far fa-user"></i> {{cities.guest}} Guest
          </mdb-col>                       
          <mdb-col xl="3" md="6" class="mb-r">
            <i class="fas fa-crown"></i> {{cities.class}}
          </mdb-col>
          <mdb-col xl="3" md="6" class="mb-r">
            <i class="far fa-money-bill-alt"> </i> {{cities.price}}
          </mdb-col>
           </mdb-row>
        </mdb-card-body>
      </mdb-card>
    </template>`
})

Vue.config.productionTip = false

/* eslint-disable no-new */

new Vue({
  el: '#app',
  showLoginModal:false,
  router,
  components: { App },
  template: '<App/>'
})
