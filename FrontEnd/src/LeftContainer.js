import Menu from './Menu'
import Profile from './Profile'

function LeftContainer() {
    return (
        <div className="left-menu col-3">
            <Menu/> 
            <Profile/>
        </div>
    );
  }
  
  export default LeftContainer;