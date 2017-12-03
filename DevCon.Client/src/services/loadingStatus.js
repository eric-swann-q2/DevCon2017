import {
  Loading,
  QSpinnerCircles
} from 'quasar'

const loaderProps = {
  spinner: QSpinnerCircles,
  spinnerSize: 80, // in pixels
  spinnerColor: 'primary',
  delay: 100
}

class LoadingStatus {
  show() {
    Loading.show(loaderProps)
  }
  hide() {
    Loading.hide()
  }
}

const loader = new LoadingStatus()

export default loader
