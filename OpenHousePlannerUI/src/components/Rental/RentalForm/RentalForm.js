import React from 'react';
import { Form, FormGroup, Label, Input, Button } from 'reactstrap';

class RentalForm extends React.Component {
  state = {
    rentalInfo: {}
  }

  saveRentalInfo = () => {
    this.props.saveChanges(this.state.rentalInfo);
  };

  onRentalChange = (e) => {
    const newValue = e.target.value;
    let updateRentalInfo = {...this.state.rentalInfo};
    updateRentalInfo[e.target.id] = newValue;
    this.setState({rentalInfo: updateRentalInfo});
    
  };

  componentDidMount(){
    this.setState({rentalInfo: this.props.rentalInfo});
  }
  
  render() {
    const rentalInfo = {...this.state.rentalInfo};
    return (
      <React.Fragment>
      <Form>
          <FormGroup>
          <Label for="imgUrl">Image</Label>
          <Input type="input" name="image" id="imgUrl" onChange={this.onRentalChange} defaultValue={rentalInfo.imgUrl} placeholder="with a placeholder"/>
        </FormGroup>
        <FormGroup>
          <Label for="street">Street</Label>
          <Input type="input" name="street" id="street" onChange={this.onRentalChange} defaultValue={rentalInfo.street} placeholder="with a placeholder" />
        </FormGroup>
        <FormGroup>
          <Label for="city">City</Label>
          <Input type="input" name="city" id="city" onChange={this.onRentalChange} defaultValue={rentalInfo.city} placeholder="with a placeholder" />
        </FormGroup>
        <FormGroup>
          <Label for="street">State</Label>
          <Input type="input" name="state" id="state" onChange={this.onRentalChange} defaultValue={rentalInfo.state} placeholder="with a placeholder" />
        </FormGroup>
        <FormGroup>
          <Label for="zip">zip</Label>
          <Input type="input" name="zip" id="zip" onChange={this.onRentalChange} defaultValue={rentalInfo.zip} placeholder="with a placeholder" />
        </FormGroup>
        <FormGroup>
          <Label for="bedrooms">Bedrooms</Label>
          <Input type="select" name="bedrooms" id="bedrooms" >
            <option>1</option>
            <option>2</option>
            <option>3</option>
            <option>4</option>
            <option>5</option>
          </Input>
        </FormGroup>
        <FormGroup>
          <Label for="baths">Baths</Label>
          <Input type="select" name="baths" id="bath" >
            <option>1</option>
            <option>2</option>
            <option>3</option>
            <option>4</option>
            <option>5</option>
          </Input>
        </FormGroup>
        <FormGroup>
          <Label for="sqft">Sqft</Label>
          <Input type="input" name="sqft" id="sqft" placeholder="with a placeholder" onChange={this.onRentalChange} defaultValue={rentalInfo.sqft}/>
        </FormGroup>
        <FormGroup check>
          <Label check>
            <Input type="checkbox" name="hasTenant" id="hasTenant" onChange={this.onRentalChange} defaultValue={rentalInfo.hasTenant} />
            Has Tenant
          </Label>
        </FormGroup>
        <Button color="primary" onClick={this.saveRentalInfo}>Save</Button>

      </Form>
      </React.Fragment>
    );
    }
}

export default RentalForm;