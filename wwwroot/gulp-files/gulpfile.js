const gulp = require('gulp');
const cleanCSS = require('gulp-clean-css');
const concat = require('gulp-concat');
const uglify = require('gulp-uglify')

function css_admin() {
  return gulp.src([
    '../lib/bootstrap/dist/css/bootstrap.min.css',
    '../font-awesome/css/all.min.css',
    '../css/admin.css',
])
  .pipe(cleanCSS())
  .pipe(concat('admin.bundle.css'))
  .pipe(gulp.dest('../minification'));
}

function css_client() {
  return gulp.src([
    '../css/site.css',
    '../css/custom-editor.css',
    '../css/additional.css',
])
  .pipe(cleanCSS())
  .pipe(concat('client.bundle.css'))
  .pipe(gulp.dest('../minification'));
}

function js_client_before() {
  return gulp.src([
    '../lib/jquery/dist/jquery.min.js',
    '../js/site.js',
  ])
    .pipe(uglify())
    .pipe(concat('js_client_before.bundle.js'))
    .pipe(gulp.dest('../minification'))
}

function js_client_after() {
  return gulp.src([
    '../js/owl.carousel.js',
    '../js/easyResponsiveTabs.js',
    '../js/jquery.magnific-popup.min.js',
    '../js/jquery.waypoints.min.js',
    '../js/jquery.countup.js',
    '../js/ui.js',
  ])
    .pipe(uglify())
    .pipe(concat('js_client_after.bundle.js'))
    .pipe(gulp.dest('../minification'))
}

function admin_js() {
  return gulp.src([
      '../lib/vue/vue.js',
      '../js/admin.js',
      '../lib/jquery/dist/jquery.min.js',
      '../lib/jquery-validation/dist/jquery.validate.min.js',
      '../lib/jquery-validation/dist/additional-methods.min.js',
      '../lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js',
      '../lib/bootstrap/dist/js/bootstrap.bundle.min.js'
    ])
      .pipe(uglify())
      .pipe(concat('admin.bundle.js'))
      .pipe(gulp.dest('../minification'))
}

exports.default = gulp.parallel(css_admin, admin_js, css_client, js_client_before, js_client_after)