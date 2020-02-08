import axios from 'axios';

const baseUrl = 'http://localhost:50860/api';

const getAllRentals = () => new Promise((resolve, reject) => {
    axios.get(`${baseUrl}/rentalproperty`)
    .then(res => resolve(res.data))
    .catch(err => reject(err));
});

const deleteRental = (id, isActive) => axios.delete(`${baseUrl}/rentalproperty?id=${id}&isActive=${isActive}`);

const editRental = (UpdatedRental, id) => axios.put(`${baseUrl}/rentalproperty/${id}`, UpdatedRental);

const addNewRental = (newRental) => axios.post(`${baseUrl}/rentalproperty`, newRental);

const getRentalById = id => axios.get(`${baseUrl}/rentalproperty/${id}`);

export default { 
    getAllRentals, 
    deleteRental, 
    editRental,
    addNewRental,
    getRentalById
};
