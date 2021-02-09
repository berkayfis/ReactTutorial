import profileImage from "./profile_small.jpg"
import React, { useEffect, useState } from "react"

function Profile(props) {
    const [userInfo, setUserInfo] = useState([]);
    const [isError, setIsError] = useState(false);

    useEffect(() => {
        fetch("https://localhost:44373/api/user/current")
          .then(res => res.json())
          .then(
            (result) => {
                console.log(result);
                setUserInfo(result);
            },
            (error) => {
                setIsError(true)
            }
          )
      }, [])

    return (
            <div className="small-profile row align-bottom">
                <img className={props.isWall ? "col-2" :"col-4"} src={profileImage}></img>                
                {props.isWall 
                ?
                <div className="col-8"> 
                    <span className="row">{userInfo.firstName} {userInfo.lastName} <small> {userInfo.userName}</small></span>
                </div>                      
                : 
                <div className="col-8"> 
                    <span className="row">{userInfo.firstName} {userInfo.lastName}</span>
                    <span className="row"><small>{userInfo.userName}</small></span>
                </div>            
                }  
            </div>
    );
  }
  
  export default Profile;