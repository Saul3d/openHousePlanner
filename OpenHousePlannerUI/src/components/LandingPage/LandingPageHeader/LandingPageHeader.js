import React from 'react';

import logo from '../../../assets/image/openhouseplannerLogo.svg';
import './LandingPageHeader.scss';

class Header extends React.Component {
    render() {
        return (
            <header className="container">
                <article className="register">
                    <div>
                        <img src={logo} alt="OpenHousePlanner" className="logo"/>
                        <h3>OPENHOUSEPLANNER</h3>
                    </div>
                    <p>
                       Sint sit ea adipisicing velit elit et culpa irure mollit dolore. Velit mollit nostrud ullamco aute nostrud Lorem eiusmod laboris in ea anim. Anim do do ea in magna sit ad. Excepteur aliqua quis voluptate deserunt minim sit laboris Lorem.. 
                    </p>
                    <button className="registerbtn">Register</button>
                </article>
                <nav>
                    {/* <img src="../../assets/images/OpenHousePlanner-logo.svg" title="OpenHousePlanner" alt="OpenHousePlanner Logo"></img>/ */}
                    <ul>
                        <a href="http://www.marvel.com"><li>Login</li></a>
                    </ul>
                </nav>
            </header>
        )
    }
}

export default Header;