import { useEffect, useState } from 'react';

export const useMeals = () => {
    const [isLoading, setIsLoading] = useState(true);
    const [meals, setMeals] = useState([]);

    const loadMeals = async () => {
        const response = await fetch('/meals');
        const meals = await response.json();
        setMeals(meals);
        setIsLoading(false);
    }

    useEffect(() => {
        loadMeals();
    }, [])

    return { isLoading, meals, setMeals};
}