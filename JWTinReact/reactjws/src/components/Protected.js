import React, { Children } from 'react';

import {Navigate} from 'react-router-dom';;

import {jwtDecode} from 'jwt-decode';


const ProtectedRoute=({Children})=>{
 const token=localStorage.getItem('token');
 if(!token)
 {
    return <Navigate to ="/login/"></Navigate>

 }
 try{
    jwtDecode(token);
    return Children;
 }
 catch(err)
 {
    localStorage.removeItem(token);
    return <Navigate to ="/login/"></Navigate>
 }
};
export default ProtectedRoute;