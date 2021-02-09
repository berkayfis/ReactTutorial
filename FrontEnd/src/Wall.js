import React, { useEffect, useState } from "react"
import NewPost from "./NewPost"
import Feed from "./Feed"

function Wall() {
    const [feeds, setFeeds] = useState([]);
    const [isError, setIsError] = useState(false);

    useEffect(() => {
        fetch("https://localhost:44373/api/post/posts")
          .then(res => res.json())
          .then(
            (result) => {
                console.log(result);
                setFeeds(result);
            },
            // Note: it's important to handle errors here
            // instead of a catch() block so that we don't swallow
            // exceptions from actual bugs in components.
            (error) => {
                setIsError(true)
            }
          )
      }, [])

    return (
        <div className="wall col-6">
            <NewPost/>
            {isError 
            ?<div className="alert alert-primary" role="alert">Postlar alınırken bir hata ile karşılaşıldı.</div>
            :feeds.map( (item, i) => <Feed key={i} content={item.content}/> )
            }
        </div>
    );
  }
  
  export default Wall;