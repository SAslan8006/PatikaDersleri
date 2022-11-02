import React from 'react';
import {View, Text, Image, TouchableOpacity} from 'react-native';
import styles from './ProductCard.style';

const ProductCard = ({product}) => {
  // render
  return (
    <TouchableOpacity style={styles.container}>
      <Image source={{uri: product.imgURL}} style={styles.image} />
      <View style={styles.infoContainer}>
        <Text style={styles.title}>{product.title}</Text>
        <Text style={styles.price}>{product.price}</Text>
        {!product.inStock ? <Text style={styles.stok}>STOKTA YOK</Text> : ''}
      </View>
    </TouchableOpacity>
  );
};

export default ProductCard;