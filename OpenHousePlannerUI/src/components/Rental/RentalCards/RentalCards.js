import React, { Component } from "react";

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPen } from '@fortawesome/free-solid-svg-icons'
import { faTrashAlt } from '@fortawesome/free-solid-svg-icons'
import { faExternalLinkAlt } from '@fortawesome/free-solid-svg-icons'
import './RentalCards.scss';

class RentalCards extends Component {
    state = {
        props:[]
    }

    editRentalCardHandler = () => {
        console.log('Edit Rental!');
    };

    deleteRentalCardHandler = () => {
        console.log('Delete Rental!');
    };

    goToLeaseHandler = () => {
        console.log('Go to Lease');
    }

    render(){
        return(
            <article className="RentalCards" >
                <section className="icon-section">
                    <div className="button-wrapper">
                        <button className="edit" onClick={this.editRentalCardHandler}><FontAwesomeIcon icon={faPen} className="icon"  /></button>
                        <button className="delete"onClick={this.deleteRentalCardHandler}><FontAwesomeIcon icon={faTrashAlt} className="icon" /></button>
                        <button className="delete" onClick={this.goToLeaseHandler}><FontAwesomeIcon icon={faExternalLinkAlt} className="icon" /></button>                    </div>
                </section>
                <img src={this.props.imgUrl} alt="House" className="cardImage"/>
                <div className="wrapper">
                    <div className="Address">
                        <div className="street">{this.props.street}</div>
                        <span className="city">{this.props.city},</span>
                        <span className="state">{this.props.state}</span>
                        <span className="Zip">{this.props.zip}</span>
                    </div>
                    <div className="Info">
                        <span className="bedrooms"><strong>{this.props.bedrooms}</strong> bds</span>|
                        <span className="baths"><strong>{this.props.baths}</strong> ba</span>|
                        <span className="sqft"><strong>{this.props.sqft}</strong> sqft</span>
                    </div>
                </div>
            </article>

        )
    }
}

export default RentalCards;
