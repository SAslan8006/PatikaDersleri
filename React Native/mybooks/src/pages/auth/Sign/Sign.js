import React, { useState } from 'react'
import { View, Text } from 'react-native'
import { Formik } from 'formik';
import auth from "@react-native-firebase/auth"
import database from "@react-native-firebase/database"
import styles from "./Sign.style"
import Input from '../../../components/Input';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import Button from '../../../components/Button';
import { showMessage } from 'react-native-flash-message';
import SignValidation from '../../../validations/SignValidation';
import authErrorMessageParser from '../../../utils/authErrorMessageParser';
const Sign = ({ navigation }) => {
    const [loading, setLoading] = useState(false)
    const [showPassword, setShowPassword] = useState(false)
    const [showRepassword, setShowrepassword] = useState(false)

    const handleLogin = () => {
        navigation.goBack()
    }
    const handleFormSubmit = async (formValues) => {

        try {
            setLoading(true)
            await auth().createUserWithEmailAndPassword(
                formValues.email,
                formValues.password,

            )
            showMessage({
                message: "Kullanıcı oluşturuldu",
                type: "success",
            });
            navigation.navigate("LoginPage")
            setLoading(false)
        } catch (error) {
            console.log(error)
            showMessage({
                message: authErrorMessageParser(error.code),
                type: "info",
            });
            setLoading(false)
        }
    }

    const handleCreateUser = (formValues) => {
        handleFormSubmit(formValues)
        const userObject = {
            fullName: formValues.fullName,
            email: formValues.email,
            userName: formValues.userName,
            profileImage: "",
            backgroundProfileImage: "",
            date: new Date().toISOString(),

        }
        database().ref('users/').push(userObject)
    }
    return (
        <View style={styles.container}>
            <Formik
                initialValues={{ fullName: '', email: '', userName: '', password: '', repassword: '' }}
                validateOnMount={true}
                onSubmit={handleCreateUser}
                validationSchema={SignValidation}
            >
                {({ handleChange, handleBlur, handleSubmit, values, errors, touched, isValid }) => (
                    <View>
                        <View>
                            <Text style={styles.sign_title}>Adınız ve soyadınız</Text>
                            <Input
                                style={styles.input}
                                placeholderTextColor="gray"
                                onChangeText={handleChange('fullName')}
                                onBlur={handleBlur('fullName')}
                                value={values.fullName}
                            />
                            {values.fullName && (<Icon name={!errors.fullName ? "check" : "close"} size={32} color={!errors.fullName ? "green" : "red"} style={styles.input_icon} />)}
                        </View>
                        {(touched.fullName && errors.fullName) && <Text style={styles.errors}>{errors.fullName}</Text>}
                        <View>
                            <Text style={styles.sign_title}>E-posta Adresiniz</Text>
                            <Input
                                style={styles.input}
                                placeholder="E-posta"
                                placeholderTextColor="gray"
                                onChangeText={handleChange('email')}
                                onBlur={handleBlur('email')}
                                value={values.email}
                            />
                            {values.email && (<Icon name={!errors.email ? "check" : "close"} size={32} color={!errors.email ? "green" : "red"} style={styles.input_icon} />)}
                        </View>
                        {(touched.email && errors.email) && <Text style={styles.errors}>{errors.email}</Text>}
                        <View>
                            <Text style={styles.sign_title}>Kullanıcı adınız</Text>
                            <Input
                                style={styles.input}
                                placeholderTextColor="gray"
                                onChangeText={handleChange('userName')}
                                onBlur={handleBlur('userName')}
                                value={values.userName}
                            />
                            {values.userName && (<Icon name={!errors.userName ? "check" : "close"} size={32} color={!errors.userName ? "green" : "red"} style={styles.input_icon} />)}
                        </View>
                        {(touched.userName && errors.userName) && <Text style={styles.errors}>{errors.userName}</Text>}

                        <View>
                            <Text style={styles.sign_title}>Şifreniz</Text>
                            <Input
                                style={styles.input}
                                placeholderTextColor="gray"
                                placeholder="Yeni MyBooks şifreniz"
                                onChangeText={handleChange('password')}
                                onBlur={handleBlur('password')}
                                value={values.password}
                                isSecure={!showPassword}
                            />
                            {values.password && (<Icon name={showPassword ? "eye-off" : "eye"} size={32} color="black" style={styles.password_icon} onPress={() => setShowPassword(!showPassword)} />)}
                        </View>
                        {(touched.password && errors.password) && <Text style={styles.errors}>{errors.password}</Text>}
                        <View>
                            <Text style={styles.sign_title}>Şifreniz (Tekrar)</Text>
                            <Input
                                style={styles.input}
                                placeholderTextColor="gray"
                                placeholder="Şifrenizi tekrar girin"
                                onChangeText={handleChange('repassword')}
                                onBlur={handleBlur('repassword')}
                                value={values.repassword}
                                isSecure={!showRepassword}
                            />
                            {values.repassword && (<Icon name={showRepassword ? "eye-off" : "eye"} size={32} color="black" style={styles.password_icon} onPress={() => setShowrepassword(!showRepassword)} />)}
                        </View>
                        {(touched.repassword && errors.repassword) && <Text style={styles.errors}>{errors.repassword}</Text>}
                        <Button text="Kaydol" theme="primary" onPress={handleSubmit} loading={!isValid} />
                        <Button text="Hesabınız var mı? Giriş Yapın" theme="secondary" onPress={handleLogin} />
                    </View>
                )}
            </Formik>

        </View>
    )
}

export default Sign

