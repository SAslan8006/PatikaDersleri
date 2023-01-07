import axios from "axios";
import React, { useEffect, useState } from "react"

const useFetch = (url) => {
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [data, setData] = useState([]);

    const fetchData = async () => {
        try {
            const { data: responseData } = await axios.get(url)
            setData(responseData)
            setLoading(false)
        } catch (err) {
            setError(err.message)
            console.log(err.message)
            setLoading(false)
        }
    }

    useEffect(() => {
        fetchData()
    }, [url])

    return { loading, error, data }
}

export default useFetch;