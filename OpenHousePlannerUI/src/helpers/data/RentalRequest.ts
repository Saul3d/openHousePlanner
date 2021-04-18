import { iRental } from '../../model/iRental';

// interface iRentalData {
//     ():Promise<iRental[]>
// }

const baseUrl = 'http://localhost:50860/api';

export const  getAllRentals = async () => {
    const response = await fetch(`${baseUrl}/rentalproperty`);
    const data:iRental[] = await response.json();
    return data
    // const test = data.map((rental:iRental) => {
    //     return {
    //         Street: rental.street,
    //         City: rental.city,
    //         State: rental.state,
    //         Zip: rental.zip,
    //         Bedrooms: rental.bedrooms,
    //         Baths: rental.baths,
    //         Sqft: rental.sqft,
    //         HasTenants: rental.hasTenants,
    //         IsActive: rental.isActive,
    //         imgUrl: rental.imgUrl
    //     };
    // }); 
}

//  export const getAllRentals: iRentalData = () => fetch(`${baseUrl}/rentalproperty`)
//     .then(response => response.json())
//     .then(data => data)
//     .catch(err => console.log(err));

export const getRentalById = (id: number) => {
    return fetch(`${baseUrl}/rentalproperty/${id}`)
    .then(response => response.json())
    .then(data => data)
    .catch(err => console.log(err));
};
 
export const deleteRental = (id: number, isActive: boolean) => {
    return fetch(`${baseUrl}/rentalproperty?id=${id}&isActive=${isActive}`, {
        method:"DELETE"
    })
    .then(response => response.json())
    .then(data => data)
    .catch(err => console.log(err));
}

export const editRental = (id: number, UpdateRental:iRental) => {
    return fetch(`${baseUrl}/rentalproperty?id=${id}`, {
        method:"PUT",
        headers: {'content-type': 'application/json'},
        body: JSON.stringify({UpdateRental})
    })
    .then(response => response.json())
    .then(data => data)
    .catch(err => console.log(err));
}

export const addNewRental = (newRental:iRental) => {
    return fetch(`${baseUrl}/rentalproperty, ${newRental}`, {
        method:"POST"
    })
    .then(response => response.json())
    .then(data => data)
    .catch(err => console.log(err));
}

// const deleteRental = (id: number, isA ctive: boolean) => axios.delete(`${baseUrl}/rentalproperty?id=${id}&isActive=${isActive}`);

// const editRental = (UpdatedRental, id) => axios.put(`${baseUrl}/rentalproperty/${id}`, UpdatedRental);

// const addNewRental = (newRental) => axios.post(`${baseUrl}/rentalproperty`, newRental);

// const getRentalById = id => axios.get(`${baseUrl}/rentalproperty/${id}`);


