import React, { useState } from 'react'
import { View, Text, Alert } from 'react-native'
import FormButton from '../../../components/FormButton/FormButton'
import Input from '../../../components/Input'
import { signUp } from '../../../utils/auth'
import styles from "./SignUp.style"
const SignUp = ({ navigation }) => {
    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')
    const [confirmpassword, setConfirmPassword] = useState('')

    const handleOnSubmit = () => {
        if (email != '' && password != '' && confirmpassword != '') {
            if (password == confirmpassword) {
                signUp(email, password)
            } else {
                Alert.alert('password did not match')
            }
        }
    }
    return (
        <View style={styles.container}>
            <Text style={styles.title}>Sign Up</Text>
            <Input
                labelText="Email"
                placeHolderText="Enter your email"
                onChangeText={value => setEmail(value)}
                value={email}
                keyboardType={"email-address"}
            />
            <Input
                labelText="Password"
                placeHolderText="Enter your password"
                onChangeText={value => setPassword(value)}
                value={password}
                secureTextEntry={true}
            />
            <Input
                labelText="Confirm Password"
                placeHolderText="Enter your password again"
                onChangeText={value => setConfirmPassword(value)}
                value={confirmpassword}
                secureTextEntry={true}
            />

            <FormButton
                labelText="Sign up"
                theme="primary"
                handleOnPress={handleOnSubmit}
                style={{ width: "100%" }}
            />
            <View style={styles.footer_container}>
                <Text>Already have an account?</Text>
                <Text style={styles.text_right} onPress={() => navigation.navigate("SignInScreen")}>Sign in</Text>
            </View>
        </View>
    )
}

export default SignUp
