import React, { useState } from 'react'
import { View, Text } from 'react-native'
import FormButton from '../../../components/FormButton/FormButton'
import Input from '../../../components/Input'
import { signIn } from '../../../utils/auth'
import styles from "./SignIn.style"
const SignIn = ({ navigation }) => {
    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')

    const handleOnSubmit = () => {
        if (email != '' && password != '') {
            signIn(email, password)
        }
    }
    return (
        <View style={styles.container}>
            <Text style={styles.title}>Sign In</Text>
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
            <FormButton
                labelText="Submit"
                theme="primary"
                handleOnPress={handleOnSubmit}
                style={{ width: "100%" }}
            />
            <View style={styles.footer_container}>
                <Text>Don't have an account?</Text>
                <Text style={styles.text_right} onPress={() => navigation.navigate("SignUpScreen")}>Create account</Text>
            </View>
        </View>
    )
}

export default SignIn
