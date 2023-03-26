import React from 'react';

export const ButtonX = ({onClick}) => (
    <div className="button-x">
        <span className="the-x" onClick={onClick}>
            X
        </span>
    </div>
);