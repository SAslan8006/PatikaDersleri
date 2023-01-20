import React, { useState } from 'react'
import { Formik } from 'formik'
import auth from "@react-native-firebase/auth"
import { View, Text, Image } from 'react-native'
import { showMessage } from 'react-native-flash-message'
import LoginValidation from '../../../validations/LoginValidation'
import styles from "./Login.style"
import Input from '../../../components/Input'
import Button from '../../../components/Button'
const Login = ({ navigation }) => {
    const [loading, setLoading] = useState(false)

    const handleSignUp = () => {
        navigation.navigate("SignPage")
    }

    const handleFormSubmit = async (formValues) => {
        try {
            setLoading(true)
            await auth().signInWithEmailAndPassword(formValues.email, formValues.password)
            showMessage({
                message: "başarılı şekilde giriş yapıldı",
                type: "success",
            });
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
            <View style={styles.image_container}>
                <Image source={require('../../../assets/marvellogo.png')} style={styles.left_logo} />
                <View style={styles.right_logo}>
                    <Image source={require('../../../assets/marvellogo2.png')} style={styles.top_logo} />
                    <Image source={require('../../../assets/marvellogo3.png')} style={styles.bottom_logo} />
                </View>
            </View>
            <Text style={styles.title}>LOGIN</Text>
            <Formik
                initialValues={{ email: '', password: '' }}
                validateOnMount={true}
                onSubmit={handleFormSubmit}
                validationSchema={LoginValidation}
            >
                {({ handleChange, handleSubmit, values, errors, touched, isValid }) => (
                    <View style={styles.input_container}>
                        <Input
                            style={(touched.email && errors.email) ? styles.input_erros : styles.input}
                            placeholder="Username or Email Address"
                            placeholderTextColor="gray"
                            onChangeText={handleChange('email')}
                            value={values.email}
                        />
                        {(touched.email && errors.email) && <Text style={styles.errors}>{errors.email}</Text>}
                        <Input
                            style={(touched.password && errors.password) ? styles.input_erros : styles.input}
                            placeholderTextColor="gray"
                            placeholder="Password"
                            onChangeText={handleChange('password')}
                            value={values.password}
                            isSecure

                        />
                        {(touched.password && errors.password) && <Text style={styles.errors}>{errors.password}</Text>}
                        <Button text="LOGIN" theme="primary" loading={!isValid} onPress={handleSubmit} />
                        <Text style={styles.need_title}>Need help signing in?</Text>
                    </View>
                )}
            </Formik>
            <View style={styles.footer_container}>
                <Button text="CREATE AN" theme="secondary" loading={loading} onPress={handleSignUp} />
            </View>
        </View>
    )
}

export default Login
