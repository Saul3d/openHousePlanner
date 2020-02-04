import React from 'react';

import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import LandingPage from './components/LandingPage/LandingPage';

import './App.css';

function App() {
  return (
    <React.Fragment>
      <Header />
      <LandingPage />
      <Footer />
    </React.Fragment>
  );
}

export default App;
