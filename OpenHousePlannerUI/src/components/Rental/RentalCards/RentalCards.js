import React from "react";

import './RentalCards.scss';

const RentalCards = (props) => (
    <article className="RentalCards">
        <img src={props.imgUrl} alt="House" className="cardImage"/>
        <div className="wrapper">
            <div className="Address">
                <div className="street">{props.street}</div>
                <span className="city">{props.city},</span>
                <span className="state">{props.state}</span>
                <span className="Zip">{props.zip}</span>
            </div>
            <div className="Info">
                <span className="bedrooms"><strong>{props.bedrooms}</strong> bds</span>|
                <span className="baths"><strong>{props.baths}</strong> ba</span>|
                <span className="sqft"><strong>{props.sqft}</strong> sqft</span>
            </div>
        </div>
    </article>
)
export default RentalCards;
