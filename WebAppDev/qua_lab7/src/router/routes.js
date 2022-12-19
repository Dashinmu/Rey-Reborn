
const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: '', component: () => import('src/pages/PostsPage.vue') },
      { path: '/comments', component: () => import('src/pages/CommentsPage.vue') },
      { path: '/album', component: () => import('src/pages/AlbumPage.vue') },
      { path: '/photos', component: () => import('src/pages/PhotosPage.vue') },
      { path: '/tasks', component: () => import('src/pages/ListTasks.vue') },
      { path: '/users', component: () => import('src/pages/UsersPage.vue') }
    ]
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue')
  }
]

export default routes
