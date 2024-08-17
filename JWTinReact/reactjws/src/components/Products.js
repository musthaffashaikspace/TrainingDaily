import React, { useEffect, useState } from 'react';
import axios from 'axios';

const Products = () => {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const fetchProducts = async () => {
            try {
                const token = localStorage.getItem('token');
                const response = await axios.get('http://localhost:5049/api/ProductsAPI', {
                    headers: {
                        Authorization: `Bearer ${token}`
                    }
                });
                console.log(response.data); // Log the data to inspect it
                setProducts(response.data);
            } catch (error) {
                console.error('Error fetching products', error);
            }
        };
        fetchProducts();
    }, []);

    return (
        <div>
            <h2>Products</h2>
            <ul>
                {products.length > 0 ? (
                    products.map((product) => (
                        <li key={product.productid}>
                            {product.productname} 
                        </li>
                    ))
                ) : (
                    <p>No products available</p>
                )}
            </ul>
        </div>
    );
};

export default Products;
