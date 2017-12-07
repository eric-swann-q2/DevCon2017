import SideNav from './SideNav'
import StdTrans from './StdTrans'
import TitledCard from './TitledCard'
import Toast from './Toast'

class Registrar {
  registerAll(vue) {
    vue.component(SideNav.name, SideNav)
    vue.component(StdTrans.name, StdTrans)
    vue.component(TitledCard.name, TitledCard)
    vue.component(Toast.name, Toast)
  }
}

const _registrar = new Registrar()

export default _registrar
