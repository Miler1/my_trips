<template>
  <section id="dashboard">
    <div class="card">
      <div class="card-header btn-info">
        <div class="mb-sm-5 pt-5 text-center"> 
          <h1> my trips </h1> 
        </div>
      </div>
      <ul class="list-group list-group-flush">
        <div v-for="(cities, index) in cities" :key="index" @click="updateSelected(index)">
          <div v-if="selectedPlace == index">
            <li class="list-group-item">
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
            </li>
          </div><div v-else class="mb-sm-0 pt-0 text-center"> Choose a trip </div>
          <li class="list-group-item">
            <mdb-card cascade class="cascading-admin-card mb-4" :key="index" >
              <mdb-card-body class="d-sm-flex justify-content-between">
                <div><img style="position:relative;" :src="(cities.thumb)" class="img-fluid z-depth-1-half" alt=""></div>
                <mdb-col xl="3" md="10" class="mb-r">
                  <div><star-rating :show-rating="false" :star-size="15" :read-only="true" :inline="false" :rating="(cities.stars)" :max-rating="5"></star-rating></div>
                  <div>{{cities.hotelName}}</div>
                  <div class="text-black-50">{{cities.location}}, {{cities.city.name}}</div>
                  <div class="text-sm-right text-info">{{cities.price.toFixed(2).replace(".", ",")}}€</div>
                </mdb-col>
              </mdb-card-body>
            </mdb-card>
          </li>
        </div>
      </ul>
    </div>
  </section>
</template>

<script>
import { mdbRow, mdbCol, mdbBtn, mdbCard, mdbCardBody, mdbCardHeader, mdbCardText, mdbIcon, mdbTbl, mdbBarChart, mdbPieChart, mdbLineChart, mdbRadarChart, mdbDoughnutChart, mdbListGroup, mdbListGroupItem, mdbBadge, mdbModal, mdbModalHeader, mdbModalTitle, mdbModalBody, mdbModalFooter } from 'mdbvue'

export default {
  mounted() {
    fetch("https://localhost:44335/Trips/City/132")
      .then(response =>response.json())
      .then((data) => {
        this.cities = data;
        console.log(data);
      })
  },
  methods: {
     /**
    * update state to maintain selected item
    * and toggle view
    */
    updateSelected (selectedItem) {
        this.selectedPlace = selectedItem;
        this.showPlaces = true;
        console.log('this.selected'+this.selectedPlace);
        console.log('this.showPlaces'+this.showPlaces);
     }
   },
  name: 'Dashboard',
  components: {
    mdbRow,
    mdbCol,
    mdbBtn,
    mdbCard,
    mdbCardBody,
    mdbCardHeader,
    mdbCardText,
    mdbIcon,
    mdbTbl,
    mdbBarChart,
    mdbPieChart,
    mdbLineChart,
    mdbRadarChart,
    mdbDoughnutChart,
    mdbListGroup,
    mdbListGroupItem,
    mdbBadge,
    mdbModal,
    mdbModalHeader,
    mdbModalTitle,
    mdbModalBody,
    mdbModalFooter
  },
  data () {
    return {
      showFrameModalTop: false,
      showFrameModalBottom: false,
      showSideModalTopRight: false,
      showSideModalTopLeft: false,
      showSideModalBottomRight: false,
      showSideModalBottomLeft: false,
      showCentralModalSmall: false,
      showCentralModalMedium: false,
      showCentralModalLarge: false,
      showCentralModalFluid: false,
      showFluidModalRight: false,
      showFluidModalLeft: false,
      showFluidModalTop: false,
      showFluidModalBottom: false,
      modal: false,
      isHidden: false,
      cities: [],
      selectedPlace: {},
      showPlaces: false
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.cascading-admin-card {
  margin: 20px 0;
}
.cascading-admin-card .admin-up {
  margin-left: 4%;
  margin-right: 4%;
  margin-top: -20px;
}
.cascading-admin-card .admin-up .fas,
.cascading-admin-card .admin-up .far {
  box-shadow: 0 2px 9px 0 rgba(0, 0, 0, 0.2), 0 2px 13px 0 rgba(0, 0, 0, 0.19);
  padding: 1.7rem;
  font-size: 2rem;
  color: #fff;
  text-align: left;
  margin-right: 1rem;
  border-radius: 3px;
}
.cascading-admin-card .admin-up .data {
  float: right;
  margin-top: 2rem;
  text-align: right;
}
.admin-up .data p {
  color: #999999;
  font-size: 12px;
}
.classic-admin-card .card-body {
  color: #fff;
  margin-bottom: 0;
  padding: 0.9rem;
}
.classic-admin-card .card-body p {
  font-size: 13px;
  opacity: 0.7;
  margin-bottom: 0;
}
.classic-admin-card .card-body h4 {
  margin-top: 10px;
}
</style>
