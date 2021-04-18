import { useState } from 'react';
import { Link } from 'react-router-dom';

import Button from '@material-ui/core/Button';
import Menu from '@material-ui/core/Menu';
import MenuItem from '@material-ui/core/MenuItem';
import MenuIcon from '@material-ui/icons/Menu';


const Nav = () => {
    const [anchorEl, setAnchorEl] = useState(null);

    const handleClick = (event:any) => {
        setAnchorEl(event.currentTarget);
    };

    const handleClose = () => {
        setAnchorEl(null);
    };

    return (
        <>
            <Button aria-controls="simple-menu" aria-haspopup="true" onClick={handleClick}>
                <MenuIcon></MenuIcon> 
            </Button>
            <Menu
                id="simple-menu"
                anchorEl={anchorEl}
                keepMounted
                open={Boolean(anchorEl)}
                onClose={handleClose}
            >
                <MenuItem onClick={handleClose}> <Link to="/"> Home</Link></MenuItem>
                <MenuItem onClick={handleClose}> <Link to="/dashboard"> Dashboard</Link></MenuItem>
                <MenuItem onClick={handleClose}> <Link to="/rentals"> Rentals</Link></MenuItem>
            </Menu>
      </>
    )
}

export default Nav;