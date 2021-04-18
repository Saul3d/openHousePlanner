import React from 'react'

import { Section } from './Section';
import { Header } from './Header/Header';
import { Footer } from './Footer/Footer';

import propertyGraph from '../../assets/images/PropertyValueGraph-v2.png';
import calendarImage from '../../assets/images/calendar.png';

import './LandingPage.scss';

export const LandingPage = () => {
    return (
        <React.Fragment>
            <Header />
        <main>
            <Section 
                title="Dashboard" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={propertyGraph} 
            />
            <Section 
                title="Calendar" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={calendarImage} 
            />
            <Section 
                title="Payments" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={propertyGraph} 
            />
            <Section 
                title="Expenses" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={propertyGraph} 
            />
            <Section 
                title="Leases" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={propertyGraph} 
            />
            <Section 
                title="Rentals" 
                text = {`Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla. &lt;br/&gt; Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.`}
                image={propertyGraph} 
            />

        </main>
        <Footer/>
        </React.Fragment>
    )
}
