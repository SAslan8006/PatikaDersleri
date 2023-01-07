import React from 'react';
import { Text, View, Image, TouchableWithoutFeedback } from 'react-native';
import styles from "./ProductCard.styles"
const ProductCard = ({ product, onSelect }) => {
    return (
        <TouchableWithoutFeedback onPress={onSelect}>
            <View style={styles.container}>
                <Image
                    style={styles.image} source={{ uri: product.image }}
                />
                <View style={styles.body_container}>
                    <Text style={styles.title}>{product.title}</Text>
                    <View style={styles.bottom_info}>
                        <Text style={styles.rate}>{product.rating.rate}</Text>
                        <Text style={styles.price}>{product.price} TL</Text>
                    </View>
                </View>
            </View>
        </TouchableWithoutFeedback>
    );
};


export default ProductCard;