## DevSettings Kullanımı
***
DevSettings modülü, geliştirme aşamasındaki geliştiricilere ayarlarını özelleştirmeye yönelik yöntemler sunarmaktadır.
### Reference
### Methods
#### addMenuItem()
```JS
static addMenuItem(title, handler)
```
Geliştirici menüsüne özel menü öğesi ekler.
##### Parameters:
| VALUE | DESCRIPTION | 
|--------:|----------------------------|
|title(Required)| string|   
| handler(Required) |function |     
##### Example:
```JS
DevSettings.addMenuItem('Show Secret Dev Screen', () => {
  Alert.alert('Showing secret dev screen!');
  //Menüye tıklandığında alert olarak karşımıza cıkacak mesaj ('Showing secret dev screen!')
});
//Bir butona bu özelliği bağladığımızda "d" ile açılan developer menuye "Show Secret Dev Screen" adı altında bir menu ekler. 
```
#### reload()
```JS
static reload()
```
Uygulamayı yeniden yükler. Doğrudan veya kullanıcı etkileşimi ile çağrılabilir.
##### Example:
```JS
<Button title="Reload" onPress={() => DevSettings.reload()} />
// Developer menudeki gibi uygulamayı yeniden yükler.
```
##### Example Image:
![Alt Text](https://user-images.githubusercontent.com/2677334/62000297-71624680-b0a1-11e9-8403-bc95c4747f0c.gif)
