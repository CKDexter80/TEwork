import Vue from 'vue'
import VueRouter from 'vue-router'


import Products from '@/views/Products'
import ProductDetail from '@/views/ProductDetail'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    component: Products, //component-view
    name: 'products'
  },
  {
    path: '/product/:id',
    component: ProductDetail,
    name: 'product-detail'
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
