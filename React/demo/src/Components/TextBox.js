import React, { useState } from "react";

const Text=()=> {

    const [state,setstate]= useState("Text here");

    return (
        <div>
            Text Box:<input type="text" value={state} onChange={(event)=>setstate(event.target.value)}/>
           <br/>
           <br/>
            {event.target.value}
        </div>
    );
}

export default Text;