# React Navigation Kurulumu 
1. npm install @react-navigation/native kurunuz
2. npm install react-native-screens react-native-safe-area-context kurunuz.
3. MainActivity.javaiçinde bulunan dosyayı düzenleyin android/app/src/main/java/<your package name>/MainActivity.java. MainActivitySınıfın gövdesine aşağıdaki kodu ekleyin :

```JS
  import android.os.Bundle;
  ... //Gövde alanına
  @Override
protected void onCreate(Bundle savedInstanceState) {
  super.onCreate(null);
}  
```

4. npm install @react-navigation/stack
5. npm install react-native-gesture-handler 
6. npm install @react-native-masked-view/masked-view

# React Drawer Kurulumu
  
1. npm install @react-navigation/drawer
2. npm install react-native-gesture-handler react-native-reanimated
 babel config e pulings ayarı ekleyiniz. 
  
# React Bottom Tabs Kurulumu
1. npm install @react-navigation/bottom-tabs
