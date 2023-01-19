import React from 'react'
import { View, Text } from 'react-native'
import styles from "./BookInfo.style"
const BookInfo = ({ book }) => {
   
    return (
        <View style={styles.container}>
            <Text style={styles.container_title}>Hakkında</Text>
            <View style={styles.container_info}>
                <Text style={styles.info_title}>Adı: </Text>
                <Text style={styles.info_value}>{book.title}</Text>
            </View>
            <View style={styles.container_info}>
                <Text style={styles.info_title}>Yazar:  </Text>
                <Text style={styles.info_value}>{book.authors}</Text>
            </View>
            <View style={styles.container_info}>
                <Text style={styles.info_title}>Sayfa:  </Text>
                <Text style={styles.info_value}>{book.pageCount}</Text>
            </View>
            <View style={styles.container_info}>
                <Text style={styles.info_title}>Tür:  </Text>
                <Text style={styles.info_value}>{book.categories}</Text>
            </View>
            <View style={styles.container_info}>
                <Text style={styles.info_title}>Basım Tarihi:  </Text>
                <Text style={styles.info_value}>{book.publishedDate}</Text>
            </View>
            <View style={styles.container_info}>
                <Text style={styles.info_value}>-{book.subtitle}</Text>
            </View>
            <View style={styles.desc_container}>
                <Text style={styles.description}>{book.description}</Text>
            </View>
        </View>
    )
}

export default BookInfo
