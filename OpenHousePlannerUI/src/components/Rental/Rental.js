import React, { Component } from "react";

import RentalCards from './RentalCards/RentalCards';
import RentalRequest from '../../helpers/data/RentalRequest';

import './Rental.scss';

class Rental extends Component{
    state = {
        rentals:[]
    }

    getRentals = () => {
        RentalRequest.getAllRentals().then(data => 
          this.setState({ rentals: data }))
        }

    componentDidMount(){
        this.getRentals();
    }

    render(){
        const rentals = this.state.rentals.map(rental =>{
            return <RentalCards 
                    key={rental.id}
                    rentalInfo={rental}
                    imgUrl={rental.imgUrl}
                    street={rental.street} 
                    city={rental.city}
                    state={rental.state}
                    zip={rental.zip}
                    bedrooms={rental.bedrooms}
                    baths={rental.baths}
                    sqft={rental.sqft}
                    hasTenants={rental.hasTenants}
                    getRentals={this.getRentals}
                    update = {this.updateRental}  
                    saveChanges = {this.saveChanges}
                />
             })
        return(
            <section className="rentals">
                {rentals}
            </section>
        );
    }
}

export default Rental;
