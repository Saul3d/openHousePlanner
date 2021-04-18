import React, { useState, useEffect, useCallback }from 'react'
import { iRental } from '../../model/iRental';
import { DataGrid, GridRowsProp, GridColDef } from '@material-ui/data-grid';
import { getAllRentals, getRentalById, deleteRental, editRental, addNewRental} from '../../helpers/data/RentalRequest';
import { RestoreOutlined } from '@material-ui/icons';
import { idText } from 'typescript';
    
    export const Rental = () => {
        const [rentals, setRentals]= useState([] as any);
       

        const fetchRentalHandler = useCallback(
           async () => {
            const ren = await getAllRentals();
            setRentals(ren);
            },
            [],
        )

        useEffect(() => {
            fetchRentalHandler();
        }, [fetchRentalHandler]);

        console.log(rentals);

        let rows: GridRowsProp = [];
         
         const columns: GridColDef[] = [
           { field: 'col1', headerName: 'street', width : 150 },
           { field: 'col2', headerName: 'city', width: 150 },
           { field: 'col3', headerName: 'state', width : 150 },
           { field: 'col4', headerName: 'baths', width : 150 },
           { field: 'col5', headerName: 'bedrooms', width: 150 },
           { field: 'col6', headerName: 'hasTenants', width : 150 },
           { field: 'col7', headerName: 'isActive', width : 150 },
           { field: 'col8', headerName: 'sqft', width: 150 },
           { field: 'col9', headerName: 'zip', width : 150 },
           { field: 'col10', headerName: 'imgUrl', width: 150 },
         ];

        if(rentals !== undefined && rentals.length > 0) {
            rows = rentals.map((rental: iRental) => {
                return {
                    id:rental.id,
                    col1: rental.street,
                    col2: rental.city,
                    col3: rental.state,
                    col4: rental.baths,
                    col5: rental.bedrooms,
                    col6: rental.hasTenants,
                    col7: rental.isActive,
                    col8: rental.sqft,
                    col9: rental.zip,
                    col10: rental.imgUrl,
                }
            })
        }


        return (
            <div>
                <h1>Rentals</h1>
                <div style={{ height: '100%', width: '100%' }}>
                    <DataGrid rows={rows} columns={columns} />
                </div>
            </div>
        )
    }

