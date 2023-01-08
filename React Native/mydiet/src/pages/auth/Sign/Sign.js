import React, { useState } from 'react'
import { View, Image } from 'react-native'
import { Formik } from 'formik'
import auth from "@react-native-firebase/auth"
import { showMessage } from "react-native-flash-message";
import Button from '../../../components/Button/Button'
import Input from '../../../components/Input/Input'
import styles from "./Sign.style"
import authErrorMessageParser from '../../../utils/authErrorMessageParser';

const Sign = ({ navigation }) => {
    const [loading, setLoading] = useState(false)
    const handleLogin = () => {
        navigation.goBack()
    }

    const handleFormSubmit = async (formValues) => {
        if (formValues.usermail == "") {
            showMessage({
                message: "boş bırakmayınız",
                type: "danger"
            })
            return
        }
        if (formValues.password == "" && formValues.repassword == "") {
            showMessage({
                message: "boş bırakmayınız",
                type: "danger"
            })
            return
        }
        if (formValues.password !== formValues.repassword) {
            showMessage({
                message: "şifreler uyuşmuyor",
                type: "danger"
            })
            return
        }

        try {
            await auth().createUserWithEmailAndPassword(
                formValues.usermail,
                formValues.password
            )
            showMessage({
                message: "Kullanıcı oluşturuldu",
                type: "success",
            });
            navigation.navigate("LoginPage")
            setLoading(false)
        } catch (error) {
            showMessage({
                message: authErrorMessageParser(error.code),
                type: "info",
            });
            setLoading(false)
        }
    }

    return (
        <View style={styles.container}>
            <View style={styles.logo_container}>
                <Image source={require('../../../assets/alodiyet.png')} style={styles.logo} />
            </View>
            <Formik
                initialValues={{ usermail: '', password: "", repassword: "" }}
                onSubmit={handleFormSubmit}
            >
                {({ handleSubmit, handleChange, values }) => (<View style={styles.form}>
                    <Input placeholder="e-postanızı giriniz.."
                        onType={handleChange("usermail")}
                        value={values.usermail}
                    />
                    <Input placeholder="şifrenizi giriniz.."
                        onType={handleChange("password")}
                        value={values.password}
                        isSecure
                    />
                    <Input placeholder="şifrenizi tekrar giriniz.."
                        onType={handleChange("repassword")}
                        value={values.repassword}
                        isSecure
                    />
                    <Button text="Kayıt Ol" theme="primary" onPress={handleSubmit} loading={loading} />
                    <Button text="Geri" theme="secondary" onPress={handleLogin} />
                </View>)}
            </Formik>



        </View>
    )
}

export default Sign
