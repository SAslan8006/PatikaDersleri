import { useEffect, useState } from 'react';
import axios from 'axios';
const useFetch = (url, type = null) => {
    const [data, setData] = useState([]);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        fetchData();
    }, [url]);

    const fetchData = async () => {
        try {
            setLoading(true);
            const { data: responseData } = await axios.get(url);
            if (type === null) {
                setData(responseData);
            } else {
                setData(responseData[type]);
            }
        } catch (err) {
            setError(err.message);
        } finally {
            setLoading(false);
        }
    };

    return { data, error, loading };
};

export default useFetch;