import React, { Component } from 'react';
import { Bar, Line, Pie } from 'react-chartjs-2';

import './Chart.scss';

class Charts extends Component {
    constructor(props){
        super(props);
        this.state = {
            chartData:props.chartData
        }
    }

    static defaultProps = {
        displayTitle:true,
        displayLegend:true,
        LegendPosition:'right',
        location:'City'
    }

    render(){

        const ChartTypeName= this.props.chartType;
        let myChart;
        switch(ChartTypeName){
            case 'Bar':
                myChart = <Bar
                data={this.state.chartData}
                options={{
                    maintainAspectRatio:false,
                    responsive: true,
                    title:{
                        display:true,
                        text:`Largest Cities in ${this.props.location}`,
                        fontSize:25
                    },
                    legend:{
                        display:true,
                        position: 'top'
                    }
                }}/>;
            break;
            
            case 'Line':
                myChart = <Line
                data={this.state.chartData}
                options={{
                    maintainAspectRatio:false,
                    responsive: true,
                    title:{
                        display:true,
                        text:`Largest Cities in ${this.props.location}`,
                        fontSize:25
                    },
                    legend:{
                        display:true,
                        position: 'top'
                    }
                }}/>;
            break; 

            case 'Pie':
                myChart = <Pie
                data={this.state.chartData}
                options={{
                    maintainAspectRatio:false,
                    responsive: true,
                    title:{
                        display:true,
                        text:`Largest Cities in ${this.props.location}`,
                        fontSize:25
                    },
                    legend:{
                        display:true,
                        position: 'top'
                    }
                }}/>;
            break;                    
        }
        
        return(
            <div className="chart">
                {myChart}
                {/* {<Bar
                    data={this.state.chartData}
                    options={{
                        maintainAspectRatio:false,
                        responsive: true,
                        title:{
                            display:true,
                            text:`Largest Cities in ${this.props.location}`,
                            fontSize:25
                        },
                        legend:{
                            display:true,
                            position: 'top'
                        }
                    }} 
                />} */}
            </div> 
        )
    }
}

export default Charts