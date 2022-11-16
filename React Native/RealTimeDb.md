# firebase-realtime-db
1. ilk olarak sitesin gidiyoruz : https://rnfirebase.io/database/usage
2. Kurulum için 
3. npm install @react-native-firebase/app        npm install @react-native-firebase/database
4. https://console.firebase.google.com/u/0/project/api-eticaret/database/api-eticaret-default-rtdb/data realtime database içindede 1 database create ediyoruz. 
5. Burada test modeyi seciyoruz şimdlik. 
6. import database from '@react-native-firebase/database'; bunu import ediyoruz ilk olarak .
``` JS
const checkDb=()=>{
       const referance=database().ref('user');
       referance.once('value')
       .then(snapshot => {
         const response=snapshot.val();
         console.log('User data: ', response);
       });
    }
const listenDb=()=>{
    const referance=database().ref('user');
    referance.on('value', snapshot => {
        console.log('User data: ', snapshot.val());
      });
 }
 ****
 
  <Button text="Check Db" onPress={checkDb} loading={loading} />
  <Button text="Listen Db" onPress={listenDb} loading={loading} />

 
```
