import React, { useEffect, useState } from 'react';
import axios from 'axios';
import Config from "react-native-config";
const useFetch = (url) => {
    const [loading, setLoading] = useState(true)
    const [error, setError] = useState(null)
    const [data, setData] = useState([])

console.log(url)
    const fetchData = async () => {
        try {
            const { data: { data: response } } = await axios.get(url, {
                params: {
                    apikey: Config.PUBLIC_KEY,
                    hash: Config.HASH,
                    ts: Config.TS,
                },
                headers: {
                    'Content-Type': 'application/json',
                },
            })
            setData(response.results)
            setLoading(false);
        } catch (err) {
            setError(err.message);
            setLoading(false);
        }
    }
    useEffect(() => {
        fetchData();
    }, [url]);

    return { error, loading, data }
}
export default useFetch;