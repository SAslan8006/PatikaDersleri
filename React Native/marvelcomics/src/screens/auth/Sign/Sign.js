import React, { useState } from 'react'
import { Formik } from 'formik'
import { View, Text, Image } from 'react-native'
import auth from "@react-native-firebase/auth"
import { showMessage } from 'react-native-flash-message'
import SignValidation from '../../../validations/SignValidation'
import authErrorMessageParser from '../../../utils/authErrorMessageParser';
import styles from "./Sign.style"
import Input from '../../../components/Input'
import Button from '../../../components/Button'
import CheckBox from '@react-native-community/checkbox';

const Sign = ({ navigation }) => {
    const [loading, setLoading] = useState(false)
    const [toggleCheckBox, setToggleCheckBox] = useState(false)
    const handleLogin = () => {
        navigation.goBack()
    }

    const handleFormSubmit = async (formValues) => {
        console.log(formValues)
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


    return (

        <View style={styles.container}>
            <View style={styles.image_container}>
                <Image source={require('../../../assets/marvellogo.png')} style={styles.left_logo} />
                <View style={styles.right_logo}>
                    <Image source={require('../../../assets/marvellogo2.png')} style={styles.top_logo} />
                    <Image source={require('../../../assets/marvellogo3.png')} style={styles.bottom_logo} />
                </View>
            </View>
            <Text style={styles.title}>CREATE YOUR ACCOUNT</Text>
            <Formik
                initialValues={{ firstName: '', email: '', lastName: '', password: '' }}
                validateOnMount={true}
                onSubmit={handleFormSubmit}
                validationSchema={SignValidation}
            >
                {({ handleChange, handleBlur, handleSubmit, values, errors, touched, isValid }) => (
                    <View style={styles.input_container}>
                        <Input
                            style={(touched.firstName && errors.firstName) ? styles.input_erros : styles.input}
                            placeholder="First Name"
                            placeholderTextColor="gray"
                            onChangeText={handleChange('firstName')}
                            value={values.firstName}
                            onBlur={handleBlur('firstName')}
                        />
                        {(touched.firstName && errors.firstName) && <Text style={styles.errors}>{errors.firstName}</Text>}
                        <Input
                            style={(touched.lastName && errors.lastName) ? styles.input_erros : styles.input}
                            placeholderTextColor="gray"
                            placeholder="Last Name"
                            onChangeText={handleChange('lastName')}
                            value={values.lastName}
                            onBlur={handleBlur('lastName')}
                        />
                        {(touched.lastName && errors.lastName) && <Text style={styles.errors}>{errors.lastName}</Text>}
                        <Input
                            style={(touched.email && errors.email) ? styles.input_erros : styles.input}
                            placeholderTextColor="gray"
                            placeholder="Email Address"
                            onChangeText={handleChange('email')}
                            value={values.email}
                            onBlur={handleBlur('email')}
                        />
                        {(touched.email && errors.email) && <Text style={styles.errors}>{errors.email}</Text>}
                        <Input
                            style={(touched.password && errors.password) ? styles.input_erros : styles.input}
                            placeholderTextColor="gray"
                            placeholder="Password"
                            onChangeText={handleChange('password')}
                            onBlur={handleBlur('password')}
                            value={values.password}
                            isSecure={!toggleCheckBox}
                        />
                        {(touched.password && errors.password) && <Text style={styles.errors}>{errors.password}</Text>}
                        <View style={styles.show_container}>
                            <CheckBox
                                disabled={false}
                                value={toggleCheckBox}
                                onValueChange={(newValue) => setToggleCheckBox(newValue)}
                            />
                            <Text>Show password</Text>
                        </View>

                        <Button text="CREATE ACCOUNT" theme="primary" loading={!isValid} onPress={handleSubmit} />
                        <View style={styles.footer_container}>
                            <Text style={styles.already_text}>Already have an account?</Text>
                            <Button text="Login" theme="tertiary" loading={loading} onPress={handleLogin} />
                        </View>
                    </View>
                )}
            </Formik>

        </View>

    )
}

export default Sign
