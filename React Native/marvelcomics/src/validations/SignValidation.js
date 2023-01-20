import * as yup from 'yup';

export default SignValidationSchema = yup.object().shape({
    firstName: yup.string().required('Please enter your first name'),
    lastName: yup.string().required('Please enter your last name'),
    email: yup.string().email("Please enter your email address").required('Email address is required'),
    password: yup.string().min(6, ({ min }) => `Enter at least ${min} characters.`).required("Password is required"),


});
