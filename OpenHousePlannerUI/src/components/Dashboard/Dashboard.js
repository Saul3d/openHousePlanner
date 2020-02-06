import React from 'react';
import { Responsive, WidthProvider } from 'react-grid-layout';


// import GridLayout from 'react-grid-layout';
import 'react-grid-layout/css/styles.css';
import 'react-resizable/css/styles.css';
import './Dashboard.scss';

const ResponsiveGridLayout = WidthProvider(Responsive);
class Dashboard extends React.Component{
  render() {
    // {lg: layout1, md: layout2, ...}
    //const layouts = getLayoutsFromSomewhere();
    const layouts ={ 
      lg:[{i: 'a', x: 0, y: 0, w: 1, h: 1, static: true},
      {i: 'b', x: 1, y: 0, w: 3, h: 2, minW: 2, maxW: 4},
      {i: 'c', x: 4, y: 0, w: 1, h: 2}
      ]};
    return (
      <ResponsiveGridLayout className="layout" layouts={layouts}
        breakpoints={{lg: 1200, md: 996, sm: 768, xs: 480, xxs: 0}}
        cols={{lg: 12, md: 10, sm: 6, xs: 4, xxs: 2}}>
        <div key="1">1</div>
        <div key="2">2</div>
        <div key="3">3</div>
      </ResponsiveGridLayout>
    )
    }
}

export default Dashboard;