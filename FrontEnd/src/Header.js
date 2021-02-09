
function Header() {
    return (
        <div className="header">
            <form className="row">
                <input className="form-control col-4 offset-3" type="search" placeholder="Ara" aria-label="Search"/>
                <button className="btn btn-outline-success col-2" type="submit">Arama</button>
            </form>
        </div>
    );
  }
  
  export default Header;