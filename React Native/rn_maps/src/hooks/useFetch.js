import { useState, useCallback, useEffect } from "react";
import axios from "axios";
export default function useFetch(url) {
    const [data, setData] = useState(null);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(true);

    const fetchData = useCallback(async () => {
        try {
            const { data: response } = await axios.get(url)
            setData(response)
            setLoading(false)
        } catch (err) {
            setError(err)
            setLoading(false)
        }
    }, [url])


    useEffect(() => {
        fetchData()
    }, [fetchData])

    return { data, loading, error }
}