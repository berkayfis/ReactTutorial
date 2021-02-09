import React, { useEffect, useState } from "react"

function NewPost() {
    const [postContent, setPostContent] = useState(null);

    function submitNewPost(event) {
        event.preventDefault();
        const data = { Content : postContent};
            
        fetch('https://localhost:44373/api/post/create', {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify(data),
        }).then(function(data) { 
            console.log("Response : ",data);
            if(data.ok){
                setPostContent(null);
                alert("Postunuz başarıyla gönderildi!");                
            }  
         })
    }

    function handlePostContent(event) {
        setPostContent(event.target.value);
        console.log("On change : ",postContent);
    }

    return (
        <div className="newPost">
            <form onSubmit={submitNewPost}>
                <div className="mb-3">                    
                    <textarea className="form-control" id="newPostTextField" placeholder="Neler oluyor?" rows="3" onChange={handlePostContent} value={postContent}></textarea>
                </div>
                <div className="text-right">
                    <button type="submit" className="btn btn-primary">Tweetle!</button>
                </div>
            </form> 
        </div>
    );
  }
  
  export default NewPost;