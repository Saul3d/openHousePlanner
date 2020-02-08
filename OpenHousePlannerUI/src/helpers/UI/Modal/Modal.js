import React from 'react';

import RentalRequest from '../../data/RentalRequest';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPen } from '@fortawesome/free-solid-svg-icons';
import RentalForm from '../RentalForm/RentalForm'
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';

class RentalFromModal extends React.Component {

  constructor(props) {
    super(props);

    this.state = {
      modal: props.initialModalState
    };
  }
    
    saveChanges = (rentalInfo) =>{
      RentalRequest.editRental(rentalInfo, rentalInfo.id).then(() => {
        this.props.getRentals();
        this.toggle();
      }).catch((error) => {
        console.error("Error Updating rental information: ", error);
      });
    }
    
    toggle = () => (
        this.setState({
        modal: !this.state.modal
        }
    ));


  render() {
    return (
      <div>
        <button className="edit" onClick={this.toggle}><FontAwesomeIcon icon={faPen} className="icon"  /></button>
        <Modal isOpen={this.state.modal} toggle={this.toggle} className={this.props.className}>
          <ModalHeader toggle={this.toggle}>Modal title</ModalHeader>
          <ModalBody>
              <RentalForm rentalInfo={this.props.rentalInfo} saveChanges={this.saveChanges}/>
          </ModalBody>
          <ModalFooter>
            <Button color="secondary" onClick={this.toggle}>Cancel</Button>
          </ModalFooter>
        </Modal>
      </div>
    );
  }
}

export default RentalFromModal;
