
"use client";
import { useEffect, useState } from "react";

export default function Hotels(){
  const [data,setData]=useState([]);
  const [nombre,setNombre]=useState("");

  const load=()=>fetch("http://localhost:8080/api/hotels").then(r=>r.json()).then(setData);
  useEffect(load,[]);

  const create=async()=>{
    await fetch("http://localhost:8080/api/hotels",{
      method:"POST",
      headers:{"Content-Type":"application/json"},
      body:JSON.stringify({nombre})
    });
    load();
  }

  return (
    <div>
      <h1>Hoteles</h1>
      <input onChange={e=>setNombre(e.target.value)} />
      <button onClick={create}>Crear</button>
      <ul>{data.map(x=><li key={x.id}>{x.nombre}</li>)}</ul>
    </div>
  )
}
