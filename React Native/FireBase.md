# Firebase Tanıtımı ve Kurulumu
1. https://console.firebase.google.com/u/0/?utm_source=firebase.google.com&utm_medium=referral buradan hesap oluştur firebase için 
2. porje oluşturduktan sonra https://console.firebase.google.com/u/0/project/api-eticaret/overview bu ekrana gelinmektedir.
3. bu yapı ile realtime database ve authentication yapısını yapımıza entegre olmasını sağlamak için bu yapıyı kullanacağız.
4. https://rnfirebase.io/ react native firebase yapısını oluşturmak için siteye giriyoruz..
5. npm install --save @react-native-firebase/app  bunu kuruyoruz
6. https://console.firebase.google.com/u/0/project/api-eticaret/overview android tarafına geliyoruz burdan 
7. https://console.firebase.google.com/u/0/project/api-eticaret/overview işlemleri yap 
8. Gelen uygulama adını gerekli yere yaz ve sonra goole-services.json dosyasını app içine koyunuz.
9. /android/build.gradle buraya git classpath 'com.google.gms:google-services:4.3.14' bunu ekle bulidlscript --- dependisin altına
10. /android/app/build.gradle file 2 satıra apply plugin: 'com.google.gms.google-services' ekle


# Firebase-auth-modulu

1. https://rnfirebase.io/auth/usage buradaki auth kısmına geliyoruz.
2. npm i @react-native-firebase/auth paketini kuruyoruz.
3. https://console.firebase.google.com/u/0/project/api-eticaret/authentication/providers  altındaki Email/Password alanını Enable yapıp save yapınız..
```JS
       const signUp = () => {
        auth().createUserWithEmailAndPassword(
            'jane.doe@example.com',
            'SuperSecretPassword',
        )
       .then(res=>console.log(res))
       .catch(err=>console.log(err))
    }
    const signIn = () => {
        auth().signInWithEmailAndPassword(
            'jane.doe@example.com',
            'SuperSecretPassword',
        )
       .then(res=>console.log(res))
       .catch(err=>console.log(err))
    }
    const singOut=()=>{
        auth().signOut()
          .then(res=>console.log(res))
          .catch(err=>console.log(err))
    }
    const checkOut=()=>{
        const user= auth().currentUser;
        console.log(user);
    }
    
    
    ****
       <Button text="Hesap Oluştur" onPress={signUp} loading={loading} />
       <Button text="Gmail" onPress={signIn} loading={loading} />
```

