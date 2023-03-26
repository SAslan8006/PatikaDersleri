import { ButtonX } from "../ui-common"
import React from "react";

export const StepListItem = ({ stepItem }) => {
    return (
        <div className="list-item">
            {stepItem ? 
        <>
            <p>{stepItem}</p>
            <div className="right-action">
                <ButtonX onClick={() => console.log("test")} />
            </div>
        </>   
        : 
        <h3>No step found</h3>
        }
        </div>
    )
};
