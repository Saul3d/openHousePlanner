import React from 'react';

interface sectionContent{
    title: string,
    text: string,
    image: string
}

export const Section = ({title, text, image}: sectionContent) => {
    return (
        <article className="feature dashboard">
            <section className="copySection">
                <h3>{title}</h3>
                <div className="copy-wrapper">
                    {text}
                </div>
            </section>
            <section className="imgSection">
                <img src={image} title="Property Value Graph" alt=" Property Value Graph" />
            </section>
        </article>
    )
}
