import * as yup from 'yup';

export default SignValidationSchema = yup.object().shape({
    fullName: yup.string().required('Adınız soyadınızı girmeniz zorunludur'),
    email: yup.string().email("Lütfen geçerli bir email adresi giriniz").required('Email adresi girmeniz zorunludur'),
    userName: yup.string().required('kullanıcı adı girmeniz zorunludur'),
    password: yup.string().min(8, ({ min }) => `Şifreniz en az ${min} karakter olmalı.`).required("Geçerli bir şifre giriniz"),
    repassword: yup.string().oneOf([yup.ref('password'), null], 'şifreler eşleşmiyor')


});