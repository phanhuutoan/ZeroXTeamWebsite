const gulp = require('gulp');
const cleanCSS = require('gulp-clean-css');
const concat = require('gulp-concat');
 
gulp.task('minify-css',() => {
  return gulp.src([
      '../lib/bootstrap/dist/css/bootstrap.min.css',
      '../font-awesome/css/all.min.css',
      '../css/admin.css'
  ])
    .pipe(cleanCSS())
    .pipe(concat('admin.bundle.css'))
    .pipe(gulp.dest('../minification'));
});