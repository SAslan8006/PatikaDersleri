import * as yup from 'yup';

export default LoginValidationSchema = yup.object().shape({
    email: yup.string().email("Please enter your email address").required('Email address is required'),
    password: yup.string().min(6, ({ min }) => `Enter at least ${min} characters.`).required("Password is required")
});