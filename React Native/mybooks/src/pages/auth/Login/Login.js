import React, { useState } from 'react'
import { View, Text } from 'react-native'
import { Formik } from 'formik';
import auth from "@react-native-firebase/auth"
import styles from "./Login.style"
import Input from '../../../components/Input';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import Button from '../../../components/Button';
import LoginValidation from '../../../validations/LoginValidation';
import { showMessage } from 'react-native-flash-message';
import authErrorMessageParser from '../../../utils/authErrorMessageParser';
const Login = ({ navigation }) => {
    const [loading, setLoading] = useState(false)
    const [showPassword, setShowPassword] = useState(false)

    const handleSignUp = () => {
        navigation.navigate("SignPage")
    }
    const handleFormSubmit = async (formValues) => {
        try {
            setLoading(true)
            await auth().signInWithEmailAndPassword(
                formValues.email,
                formValues.password
            )
            showMessage({
                message: "başarılı şekilde giriş yapıldı",
                type: "success",
            })
            setLoading(false)
        } catch (error) {
            showMessage({
                message: authErrorMessageParser(error.code),
                type: "danger",
            });
            setLoading(false)
        }
    }
    return (
        <View style={styles.container}>
            <Text style={styles.login_title}>Giriş Yap</Text>
            <Formik
                initialValues={{ email: '', password: '' }}
                validateOnMount={true}
                onSubmit={handleFormSubmit}
                validationSchema={LoginValidation}
            >
                {({ handleChange, handleBlur, handleSubmit, values, errors, touched, isValid }) => (
                    <View>
                        <View>
                            <Text style={styles.eposta_title}>E-posta Adresiniz</Text>
                            <Input
                                style={styles.input}
                                placeholder="E-posta"
                                placeholderTextColor="gray"
                                onChangeText={handleChange('email')}
                                onBlur={handleBlur('email')}
                                value={values.email}
                            />
                            {values.email && (<Icon name={!errors.email ? "check" : "close"} size={32} color={!errors.email ? "green" : "red"} style={styles.email_icon} />)}
                        </View>
                        {(touched.email && errors.email) && <Text style={styles.errors}>{errors.email}</Text>}
                        <View>
                            <Text style={styles.password_title}>Şifreniz</Text>
                            <Input
                                style={styles.input}
                                placeholderTextColor="gray"
                                placeholder="MyBooks şifreniz"
                                onChangeText={handleChange('password')}
                                onBlur={handleBlur('password')}
                                value={values.password}
                                isSecure={!showPassword}
                            />
                            {values.password && (<Icon name={showPassword ? "eye-off" : "eye"} size={32} color="black" style={styles.password_icon} onPress={() => setShowPassword(!showPassword)} />)}
                        </View>
                        {(touched.password && errors.password) && <Text style={styles.errors}>{errors.password}</Text>}
                        <Button text="Giriş Yap" theme="primary" onPress={handleSubmit} loading={!isValid} />
                        <Button text="Hesabınız yok mu? Hemen Kaydolun" theme="secondary" onPress={handleSignUp} />
                    </View>
                )}
            </Formik>

        </View>
    )
}

export default Login
