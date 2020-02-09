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

        const chartTypeName= this.props.chartType;
        
        return(
            <div className="chart">
                {<Bar
                    data={this.state.chartData}
                    options={{
                        maintainAspectRatio:false,
                        responsive: true
                    }}
                    options={{ 
                        maintainAspectRatio: false,
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
                />}
            </div>
        )
    }
}

export default Charts