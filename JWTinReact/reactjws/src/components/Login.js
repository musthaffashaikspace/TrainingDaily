import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios';
const Login = () => {
 const [username, setUsername] = useState('');
 const [password, setPassword] = useState('');
 const [error, setError] = useState('');
 const navigate = useNavigate();
 const handleLogin = async (e) => {
    e.preventDefault();
    try {
        const response = await axios.post('http://localhost:5049/api/Logins/authenticate', 
            { username, password },
            { headers: { 'Content-Type': 'application/json' } }
        );
        
        const token = response.data; // Directly assign the token
        
        if (token) {
            localStorage.setItem('token', token);
            navigate('/products');
        } else {
            setError('Token not found in response');
        }
    } catch (error) {
        console.error(error.response?.data); // Log error response from the server
        setError('Invalid username or password');
    }
};

  
 return (
 <div>
 <h2>Login</h2>
 {error && <p style={{ color: 'red' }}>{error}</p>}
 <form onSubmit={handleLogin}>
 <div>
 <label>Username</label>
 <input
 type="text"
 value={username}
 onChange={(e) => setUsername(e.target.value)} // e is event , here it represents OnChange event , target is the textbox 
 />
 </div>
 <div>
 <label>Password</label>
 <input
 type="password"
 value={password}
 onChange={(e) => setPassword(e.target.value)} 
 />
 </div>
 <button type="submit">Login</button>
 </form>
 </div>
 );
};
export default Login;