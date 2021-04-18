import logo from '../../../assets/images/openhouseplannerLogo.svg';
import MenuIcon from './Nav/Nav';

import './Header.scss';

export const Header = () => {

    return (
        <header className="lpcontainer">
            <article className="register">
                <div>
                    <img src={logo} alt="OpenHousePlanner" className="logo"/>
                    <h3>OPENHOUSEPLANNER</h3>
                </div>
                <p>
                Sint sit ea adipisicing velit elit et culpa irure mollit dolore. Velit mollit nostrud ullamco aute nostrud Lorem eiusmod laboris in ea anim. Anim do do ea in magna sit ad. Excepteur aliqua quis voluptate deserunt minim sit laboris Lorem.. 
                </p>
            </article>
            <MenuIcon></MenuIcon>
        </header>
    )
}
