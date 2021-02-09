
function Menu() {
    return (
            <div className="menu list-group" id="list-tab" role="tablist">
                <a className="list-group-item list-group-item-action active" id="list-home-list" data-bs-toggle="list" href="#" role="tab" aria-controls="home">Home</a>
                <a className="list-group-item list-group-item-action" id="list-messages-list" data-bs-toggle="list" href="#" role="tab" aria-controls="messages">Messages</a>
                <a className="list-group-item list-group-item-action" id="list-settings-list" data-bs-toggle="list" href="#" role="tab" aria-controls="settings">Settings</a>
            </div>
    );
  }
  
  export default Menu;