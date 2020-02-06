import React from 'react';

import Rental from './components/Rental/Rental';
import Dashboard from './components/Dashboard/Dashboard';
import Header from './components/LandingPage/LandingPageHeader/LandingPageHeader';
import Footer from './components/LandingPage/LandingPageFooter/LandingPageFooter';
import LandingPage from './components/LandingPage/LandingPage';

import './App.scss';

function App() {
  return (
    <React.Fragment>
      {/* <Header />
      <LandingPage />
      <Footer /> 
      <Dashboard />*/}
      <Rental />
    </React.Fragment>
  );
}

export default App;
