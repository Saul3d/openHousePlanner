import React, { Component } from "react";
import axios from 'axios';
import RentalCards from './RentalCards/RentalCards';
import './Rental.scss';

class Rental extends Component{
    state = {
        rentals:[]
    }
    componentDidMount(){
        axios.get('http://localhost:50860/api/rentalProperty')
        .then(response =>{
            this.setState({ rentals: response.data });
            console.log(response);
        })
    }
    render(){
        const rentals = this.state.rentals.map(rental =>{
            return <RentalCards 
                    key = {rental.id}
                    imgUrl={rental.imgUrl}
                    street={rental.street} 
                    city={rental.city}
                    state={rental.state}
                    zip={rental.zip}
                    bedrooms={rental.bedrooms}
                    baths={rental.baths}
                    sqft={rental.sqft}  />
        })
        return(
            <section className="rentals">
                {rentals}
            </section>
        );
    }
}

export default Rental;
