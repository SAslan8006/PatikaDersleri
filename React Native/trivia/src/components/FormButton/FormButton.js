import React from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import { COLORS } from '../../constants/theme'

const FormButton = ({ labelText, handleOnPress, style, isPrimary = true, ...more }) => {
    return (
        <TouchableOpacity
            style={{
                paddingVertical: 10,
                backgroundColor: isPrimary ? COLORS.primary : COLORS.white,
                borderWidth: 1,
                borderColor: COLORS.primary,
                borderRadius: 5,
                ...style,
            }}
            onPress={handleOnPress}
            activeOpacity={0.9}
            {...more}
        >
            <Text style={{
                textAlign: "center",
                fontSize: 18,
                color: isPrimary ? COLORS.white : COLORS.primary,
            }}>{labelText}</Text>
        </TouchableOpacity>
    )
}

export default FormButton
