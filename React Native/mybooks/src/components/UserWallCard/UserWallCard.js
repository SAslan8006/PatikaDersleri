import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import { formatDistance, parseISO } from 'date-fns'
import { tr } from "date-fns/locale"
import styles from "./UserWallCard.style"
import Button from '../Button'

const UserWallCard = ({ wall, handleFavoriCount, handlesendComment }) => {

    const formattedDate = formatDistance(parseISO(wall.book.date), new Date(), {
        addSuffix: true,
        locale: tr,
    })


    return (
        <View style={styles.container}>
            <View style={styles.userinfo_contianer}>
                <Image source={{ uri: wall.book.profileImage }} style={styles.image} />
                <View style={styles.user_container_title}>
                    <View style={styles.user_title}>
                        <Text style={styles.fullName}>{wall.book.fullName}</Text>
                        <Text style={styles.username}>@{wall.book.userName}</Text>

                    </View>

                    <Text style={styles.desc}>{wall?.book?.isWillRead ? "bir kitabı okumayı düşünüyor" : wall?.book?.isRead ? "bir kitap okudu" : wall?.book?.isReading && "bir kitabı okumaya başladı"}</Text>
                    <Text style={styles.date}>{formattedDate}</Text>
                </View>
            </View>
            <View style={styles.container_book}>
                {
                    wall?.book?.imageLinks ? <Image source={{ uri: wall?.book.imageLinks.thumbnail }} style={styles.image_book} />
                        :
                        <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                }
                <View style={styles.info_title}>
                    <Text style={styles.title}>{`${wall?.book.title.length > 29 ? wall?.book.title.slice(0, 29) + '...' : wall?.book.title} `}</Text>
                    <Text style={styles.authors}>{`${wall?.book.authors.length > 2 ? wall?.book.authors.slice(0, 2) + '...' : wall?.book.authors}`}</Text>
                    <Button text={wall?.book?.isWillRead ? "Okuyacağım" : wall?.book?.isRead ? "Okudum" : wall?.book?.isReading && "Okuyorum"} theme="wallread" />
                </View>
            </View>
            <View style={styles.button_container}>
                {wall?.book?.isFavori ? <Text style={styles.button_favori_title}>{`${wall?.book?.favoriCount} beğeni`}</Text> : null}
                <View style={styles.button_container_button}>
                    <Button text="" theme="wallfavori" iconName={wall?.book?.isFavori ? "cards-heart" : "cards-heart-outline"} color={wall?.book?.isFavori ? "#d50000" : null} onPress={() => handleFavoriCount(wall)} />
                    <Button text="" theme="wallcommon" iconName="comment-outline" onPress={() => handlesendComment(wall)} />
                </View>
                {
                    wall.book.isReading ?
                        wall.book.comment ? <Text style={styles.button_favori_title}>{`${wall.book.commentCount} yorumun tümünü gör`}</Text> : null
                        :
                        wall.book.isRead ?
                            wall.book.comment ? <Text style={styles.button_favori_title}>{`${wall.book.commentCount} yorumun tümünü gör`}</Text> : null
                            :
                            wall.book.isWillRead ?
                                wall.book.comment ? <Text style={styles.button_favori_title}>{`${wall.book.commentCount} yorumun tümünü gör`}</Text> : null
                                :
                                null
                }
            </View>
        </View>
    )
}

export default UserWallCard
