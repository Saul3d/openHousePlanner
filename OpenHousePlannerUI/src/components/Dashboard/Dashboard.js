import React from 'react';
import { Responsive, WidthProvider } from 'react-grid-layout';
import Charts from './Chart/Charts';

// import GridLayout from 'react-grid-layout';
import 'react-grid-layout/css/styles.css';
import 'react-resizable/css/styles.css';
import './Dashboard.scss';

const ResponsiveGridLayout = WidthProvider(Responsive);
class Dashboard extends React.Component{
  constructor(props){
    super(props);
    this.state ={
      chartData:{}
    }
  }

  componentWillMount(){
    this.getChartData();
  }

  getChartData(){
    //API Call Goes Here
    this.setState({
      chartData:{
        labels:['Boston', 'Worcester', 'Springfield', 'Lowell', 'Cambridge', 'New Bedford'],
        datasets:[
            {
                label:'Population',
                data:[617594, 181045, 153060,106519, 105162,95072],
                backgroundColor:[
                    'rgba(255, 99, 132, .6',
                    'rgba(54, 162, 235, .6',
                    'rgba(255, 206, 86, .6',
                    'rgba(75, 192, 192, .6',
                    'rgba(153, 102, 255, .6',
                    'rgba(255, 159, 64, .6',
                ]
            }
        ]
    }
    })
  }

  static defaultProps={
    autoSize:  true
  }

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
        cols={{lg: 12, md: 10, sm: 6, xs: 4, xxs: 2}}
      >
        <div key="1"><Charts chartData={this.state.chartData} chartType="Bar" location="Massachussetts"/></div>
        <div key="2"><Charts chartData={this.state.chartData} chartType="Line"  /></div>
        <div key="3"><Charts chartData={this.state.chartData} chartType="Pie"  /></div>
      </ResponsiveGridLayout>
    )
    }
}

export default Dashboard;