import './App.css';
import Header from './Header';
import Wall from './Wall'
import LeftContainer from './LeftContainer'
import RightContainer from './RightContainer'

function App() {
  return (
    <div className="App container">
      <Header/>
      <div className="row align-items-start">
        <LeftContainer/>
        <Wall/>
        <RightContainer/>
      </div>
    </div>
  );
}

export default App;
