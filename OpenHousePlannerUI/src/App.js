import React from 'react';
import { Route, Switch } from 'react-router-dom';

import Rental from './components/Rental/Rental';
import Dashboard from './components/Dashboard/Dashboard';
import LandingPage from './components/LandingPage/LandingPage';

import './App.scss';

function App() {
  return (
    <React.Fragment>
      <Switch>
        <Route path="/dashboard" component={Dashboard} />
        <Route path="/rentalproperty" component={Rental} />
        <Route exact path="/" component={LandingPage} />
      </Switch>
    </React.Fragment>
  );
}

export default App;
