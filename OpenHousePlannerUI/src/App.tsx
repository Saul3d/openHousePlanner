import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';

import { Dashboard } from './app/Dashboard/Dashboard';
import { LandingPage } from './app/Home/LandingPage';
import { Rental } from './app/Rental/Rental';

import './App.scss';



function App() {
  return (
    <React.Fragment>
      <Router>

    <Switch>
      <Route path="/dashboard" component={Dashboard} />
      <Route path="/rentals" component={Rental} />
      <Route exact path="/" component={LandingPage} />
    </Switch>
      </Router>
  </React.Fragment>
);
}

export default App;
