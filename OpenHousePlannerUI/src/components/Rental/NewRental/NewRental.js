import React, { Component } from 'react';
import DefaultModal from '../../../helpers/UI/DefaultModal/DefaultModal';

class NewRental extends Component{
    render(){
        return(
            <React.Fragment>
                <DefaultModal defaultModalClassName={"addRental"} getRentals={this.props.getRentals}/>
            </React.Fragment>
        )
    }
}
export default NewRental;