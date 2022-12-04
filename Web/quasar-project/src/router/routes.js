
const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: '', component: () => import('pages/IndexPage.vue') },
      { path: '/RandomGameList', component: () => import('src/pages/RandomGameList.vue') },
      { path: '/GameList', component: () => import('src/pages/GameList.vue') },
      { path: '/GameList/:id', component: () => import('pages/GameInfo.vue') },
      { path: '/GameInfo', component: () => import('pages/GameInfo.vue') }
    ],
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue')
  }
]

export default routes
