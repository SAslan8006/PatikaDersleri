import React from 'react';
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 
import { Share, View, Button } from 'react-native';

const ShareExample = () => {
  const onShare = async () => {
    try {
      const result = await Share.share({
        message:
        //share komutundaki penceredeki yazacak mesaj buraya yazılmaktadır.
          'React Native | A framework for building native apps using React',
      });
      if (result.action === Share.sharedAction) {
        if (result.activityType) { //Aktivite burada kontrol ediliyor if döngüsüyle
          // aktivite türüyle paylaşım  result.activityType
        } else {
          // paylaşım
        }
      } else if (result.action === Share.dismissedAction) {
        // dismissed
      }
    } catch (error) {
      alert(error.message);
    }
  };
  return (
    <View style={{ marginTop: 50 }}>
    {/* Eklenen butona onShare fonsiyonu eklenerek share api si eklenmiştir. */}
      <Button onPress={onShare} title="Share" />
    </View>
  );
};

export default ShareExample;