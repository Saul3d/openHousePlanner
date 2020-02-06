import React from 'react';

import Header from './LandingPageHeader/LandingPageHeader';
import Footer from './LandingPageFooter/LandingPageFooter';
import propertyGraph from '../../assets/image/PropertyValueGraph-v2.png';
import calendarImage from '../../assets/image/calendar.png';
import './LandingPage.scss'

function LandingPage() {
    return(
        <React.Fragment>
        <Header />
        <main>
            <article className="feature dashboard">
                
                <section className="copySection">
                    <h3>Dashboard</h3>
                    <div className="copy-wrapper">
                        <p>Ut sunt do laborum sint ex anim irure id veniam irure esse dolore commodo ut. Tempor sint exercitation amet do velit laboris est. Aliquip ipsum eiusmod duis reprehenderit eiusmod irure mollit minim nisi. Dolor irure esse voluptate Lorem sit minim sunt non ea anim deserunt in proident nulla.</p>

                        <p>Id mollit ea sint minim ex cillum ipsum mollit cillum officia nisi duis eu ullamco. Magna id nisi reprehenderit elit laborum consequat ipsum esse do ullamco laborum ullamco. Velit qui ullamco aliquip incididunt commodo esse elit amet. Consequat proident labore quis incididunt do laborum consequat exercitation. Nisi aute commodo voluptate mollit sunt quis commodo cillum.</p>
                    </div>
                </section>
                <section className="imgSection">
                    <img src={propertyGraph} title="Property Value Graph" alt=" Property Value Graph" />
                </section>
            </article>
            <article className="feature calendar">
                <section className="imgSection">
                <img src={calendarImage} title="Calendar" alt=" Calendar" />
                </section>
                <section className="copySection">
                    <h3>Calendar</h3>
                    <div className="copy-wrapper">
                        <p>Qui officia labore ex occaecat non eiusmod tempor. Amet pariatur incididunt incididunt veniam et aliquip. Ex non exercitation labore officia est in id cillum. Aliqua laborum irure fugiat aliquip excepteur adipisicing sint. Exercitation cupidatat consectetur ad ipsum.</p>

                        <p>Dolor duis exercitation mollit non exercitation do velit do anim ad. Officia ea excepteur tempor fugiat anim nostrud laborum ullamco deserunt. Nisi dolor ullamco laboris sit ea eiusmod ullamco qui reprehenderit veniam cillum. In duis Lorem ipsum irure culpa.</p>
                    </div>
                </section>
            </article>
            <article className="feature payments">
                <section className="copySection">
                <h3>Payments</h3>
                    <div className="copy-wrapper">
                        <p>Qui Lorem ea elit excepteur sint ad qui deserunt laboris non incididunt deserunt. Id voluptate do elit exercitation. Pariatur pariatur ad quis laboris anim ut minim veniam. Est proident voluptate dolor consequat dolore incididunt id. </p>

                        <p> Consectetur et reprehenderit ipsum elit cillum commodo esse laborum laborum consequat. Id ipsum occaecat eu occaecat enim occaecat. Tempor minim cillum do eu. Esse nulla deserunt ex et in velit fugiat. Eiusmod velit ad sint dolor occaecat esse tempor. Et commodo qui esse nostrud.</p>
                        </div>
                </section>
                <section className="imgSection">

                </section>
            </article>
            <article className="feature expenses">
                <section className="imgSection">

                </section>
                <section className="copySection">
                    <h3>Expenses</h3>
                    <div className="copy-wrapper">
                        <p>Ex magna Lorem proident consequat occaecat ex ut reprehenderit incididunt ut Lorem Lorem. Minim dolor reprehenderit fugiat irure irure et anim exercitation deserunt officia minim voluptate aute. Ad in ipsum cupidatat amet est nostrud consequat occaecat ipsum irure cupidatat aliquip laboris. Nisi occaecat cillum aute nostrud reprehenderit eu consequat ea consectetur Lorem. </p>

                        <p>Proident dolore excepteur proident fugiat sit ut eu qui quis proident. Nisi pariatur aliqua sit magna sint. Aliqua deserunt do adipisicing cillum occaecat est et adipisicing sunt eiusmod ex. Tempor nostrud occaecat cillum cupidatat velit elit occaecat amet veniam.</p>
                        </div>
                </section>
            </article>
            <article className="feature leases">
                <section className="copySection">
                    <h3>Leases</h3>
                    <div className="copy-wrapper">
                        <p>Incididunt irure veniam sit duis consequat laboris fugiat aute cillum irure sint amet commodo. Velit et enim nostrud consequat laboris proident. Reprehenderit commodo quis reprehenderit ad sunt commodo adipisicing veniam laboris eiusmod id.</p>

                        <p>Velit sit reprehenderit laborum nostrud dolor labore ullamco do magna ipsum minim. Proident nostrud labore sit fugiat mollit adipisicing et ad dolore et excepteur. Ad aliquip enim excepteur nostrud minim ex exercitation magna ut esse enim. Sit sunt cillum officia culpa Lorem minim. Sunt aute dolor sit cupidatat laborum labore.</p>
                        </div>
                </section>
                <section className="imgSection">

                </section>
            </article>
            <article className="feature rentals">
                <section className="imgSection">

                </section>
                <section className="copySection">
                    <h3>Rentals</h3>
                    <div className="copy-wrapper">
                        <p>Aliquip Lorem ex ullamco ullamco aute ullamco non fugiat magna aliqua minim Lorem cillum. Proident proident non anim aute proident consectetur aute. Anim qui officia veniam quis nostrud occaecat. Non exercitation ut cillum anim. Eiusmod culpa Lorem incididunt mollit consectetur mollit exercitation. Ad aute laborum adipisicing nulla consectetur qui enim excepteur cupidatat.</p>

                        <p>Nostrud magna eu pariatur minim pariatur exercitation non exercitation incididunt est enim nisi. Sint voluptate eiusmod cupidatat consectetur fugiat. Magna incididunt officia elit sit ipsum quis labore dolore aliquip. Excepteur qui consectetur cillum do enim sit pariatur. Fugiat Lorem excepteur mollit aute laboris dolore aute quis aute enim aliquip dolor. Exercitation nostrud mollit duis nisi fugiat tempor labore cillum. Qui eu dolor veniam in laboris culpa incididunt do tempor.</p>
                        </div>
                </section>
            </article>       
        </main>
        <Footer />
        </React.Fragment>
    );
}

export default LandingPage;
