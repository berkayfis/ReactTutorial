import Profile from './Profile'

function Feed(props) {
    return (
            <div className="feed card">
                <Profile isWall="true"/>
                <div className="postContent row">
                    <span className="offset-2">{props.content}</span>
                </div>
            </div>
    );
  }
  
  export default Feed;