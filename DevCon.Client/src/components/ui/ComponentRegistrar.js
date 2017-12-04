import Message from './Message'
import MessageList from './MessageList'
import ResultsPanel from './ResultsPanel'
import SideNav from './SideNav'
import StdRow from './StdRow'
import StdCol from './StdCol'
import StdForm from './StdForm'
import StdTrans from './StdTrans'
import StdListItem from './StdListItem'
import TitledCard from './TitledCard'
import Toast from './Toast'

class Registrar {
  registerAll(vue) {
    vue.component(Message.name, Message)
    vue.component(MessageList.name, MessageList)
    vue.component(ResultsPanel.name, ResultsPanel)
    vue.component(SideNav.name, SideNav)
    vue.component(StdRow.name, StdRow)
    vue.component(StdCol.name, StdCol)
    vue.component(StdForm.name, StdForm)
    vue.component(StdTrans.name, StdTrans)
    vue.component(StdListItem.name, StdListItem)
    vue.component(TitledCard.name, TitledCard)
    vue.component(Toast.name, Toast)
  }
}

const _registrar = new Registrar()

export default _registrar
