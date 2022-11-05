import React from "react";
import { View, StyleSheet, Button, Alert } from "react-native";

const showAlert = () =>
  Alert.alert(
    "Alert Başlığı", //Alert başlığı yazılmalısı gereklidir.
    "My Alert Msg", //Alert mesajı
    [
      {//Button konsepti olarak positive(Pozitif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
        text: "Cancel",
        onPress: () => Alert.alert("Cancel Pressed"),
        style: "cancel", ///3 Stil vardır: default,cancel ve destructive
      },
    ],
    {
      cancelable: true, //alert kutusunun dışına dokunularak kapatılabilmek için true yapılmaktadır
      onDismiss: () => //cancelable callback fonksiyorundur. İsteğe bağlı kullanımdır.
        Alert.alert(
          "This alert was dismissed by tapping outside of the alert dialog."
        ),
    }
  );

const App = () => (
  <View style={styles.container}>
    <Button title="Show alert" onPress={showAlert} />
  </View>
);

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center"
  }
});

export default App;