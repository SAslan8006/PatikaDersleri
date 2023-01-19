import React, { useContext } from 'react'
import { View, Text, TouchableOpacity, Alert, Image } from 'react-native'
import database from "@react-native-firebase/database"
import { launchImageLibrary } from 'react-native-image-picker';
import { addYears, formatWithOptions } from 'date-fns/fp'
import { tr } from 'date-fns/locale'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import styles from "./UserProfileInfoCard.style"
import { UserInfoContext } from '../../../context/UserInfoContext';
import ReadingCard from '../ReadingCard';

const UserProfileInfoCard = ({ userInfo, handleSelectedBook }) => {

    const { backgroundProfileImageChange, profileImageChange, setBackgroundProfileImage, setProfileImage } = useContext(UserInfoContext)

    const [{ backgroundProfileImage, profileImage, fullName, userName, date }] = userInfo

    const formatedDate = [new Date(date)]
    const dateToString = formatWithOptions({ locale: tr }, 'd MMMM yyyy')
    const formattedDates = formatedDate.map(dateToString)


    const handleImage = (item) => {
        Alert.alert(
            `${item} fotoğrafını değiştir`,
            "Fotoğraf",
            [
                {
                    text: "Kamera ile çek",
                    onPress: () => pickImageFromCamera(item),
                    style: "default",
                },
                {
                    text: "Galeriden seç",
                    onPress: () => pickImageFromGalery(item),
                    style: "default",
                },

            ],
            {
                cancelable: true,

            }
        );


    }

    const pickImageFromCamera = (item) => {
        Alert.alert("tasarlanmadı", "lütfen galerinizden bir fotoğraf seçiniz")
        /*    const options = {
            mediaType: 'photo',
            saveToPhotos:false,
            cameraType:"front",
            quality:1
        }
        
        const result = await launchImageLibrary(options);
        if (result?.assets) {
            console.log(result.assets)
        } */
    }
    const pickImageFromGalery = async (item) => {
        const options = {
            mediaType: 'photo'
        }
        if (item == "Kapak") {
            const result = await launchImageLibrary(options);
            if (result?.assets) {
                //setBackgroundProfileImage(result.assets[0].uri)
                const [{ id }] = userInfo

                database()
                    .ref(`users/${id}/`)
                    .update({ backgroundProfileImage: result.assets[0].uri })
                return
            }
        }
        if (item == "Profil") {
            const result = await launchImageLibrary(options);
            if (result?.assets) {
                //setProfileImage(result.assets[0].uri)
                const [{ id }] = userInfo

                database()
                    .ref(`users/${id}/`)
                    .update({ profileImage: result.assets[0].uri })
                return
            }
        }



    }


    return (
        <View>
            <TouchableOpacity onPress={() => handleImage("Kapak")} style={styles.coverImage}>
                {
                    backgroundProfileImage != "" ?
                        <Image source={{ uri: backgroundProfileImage !== "" ? backgroundProfileImage : backgroundProfileImageChange }}
                            style={styles.backgroundImage}
                            resizeMode={'cover'} />
                        :
                        <Icon name="camera-outline" size={40} color="grey" />
                }
            </TouchableOpacity>

            <TouchableOpacity onPress={() => handleImage("Profil")} style={styles.profileImage}>
                {
                    profileImage != "" ?
                        <Image source={{ uri: profileImage !== "" ? profileImage : profileImageChange }}
                            style={styles.profileImage_value}
                            resizeMode={'contain'}
                        />
                        :
                        <Icon name="camera-outline" size={40} color="grey" />
                }
            </TouchableOpacity>
            <View style={styles.info_container}>
                <Text style={styles.fullname}>{fullName}</Text>
                <Text style={styles.username}>{`@${userName}`}</Text>
                <Text style={styles.date}>{formattedDates} tarihinde katıldı</Text>
                <Text style={styles.now_reading_title}>Şu anda okuduğu kitap</Text>
                <ReadingCard userInfo={userInfo} handleSelectedBook={handleSelectedBook} />
            </View>

        </View>
    )
}

export default UserProfileInfoCard
