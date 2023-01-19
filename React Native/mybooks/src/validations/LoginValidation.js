import * as yup from 'yup';

export default LoginValidationSchema = yup.object().shape({
    email: yup.string().email("Lütfen geçerli bir email adresi giriniz").required('Email adresi girmeniz zorunludur'),
    password: yup.string().min(8, ({ min }) => `Şifreniz en az ${min} karakter olmalı.`).required("Geçerli bir şifre giriniz")
});