import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

import Login from './components/Login';
import Products from './components/Products';
import ProtectedRoute  from './components/Protected';
function App() {
 return (
 <Router>
 <div>
 <Routes>
 <Route path="" element={<Login />} />
 <Route path="/products" element={<ProtectedRoute><Products /></ProtectedRoute>} />
 </Routes>
 </div>
 </Router>
 );
}
export default App;