import React, { useState } from 'react'
import { View, Image } from 'react-native'
import auth from "@react-native-firebase/auth"
import { Formik } from 'formik'
import authErrorMessageParser from '../../../utils/authErrorMessageParser'
import { showMessage } from "react-native-flash-message";
import Button from '../../../components/Button/Button'
import Input from '../../../components/Input/Input'
import styles from "./Login.style"


const Login = ({ navigation }) => {
    const [loading, setLoading] = useState(false)
    const handleSignUp = () => {
        navigation.navigate("SignPage")
    }

    const handleFormSubmit = async (formValues) => {

        try {
            setLoading(true)
            await auth().signInWithEmailAndPassword(
                formValues.usermail,
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
            <View style={styles.logo_container}>
                <Image source={require('../../../assets/codeTalks.png')} style={styles.logo} />
            </View>
            <Formik
                initialValues={{ usermail: '', password: "" }}
                onSubmit={handleFormSubmit}
            >
                {({ handleSubmit, values, handleChange }) => (<View style={styles.form}>
                    <Input placeholder="e-postanızı giriniz.."
                        onType={handleChange("usermail")}
                        value={values.usermail}
                    />
                    <Input placeholder="şifrenizi giriniz.."
                        onType={handleChange("password")}
                        value={values.password}
                        isSecure
                    />
                    <Button text="Giriş Yap" theme="primary" onPress={handleSubmit} loading={loading} />
                    <Button text="Kayıt Ol" theme="secondary" onPress={handleSignUp} />
                </View>)}

            </Formik>



        </View >
    )
}

export default Login
