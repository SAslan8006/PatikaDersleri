## ScrollView Kullanımında Style
Scrolview kullanırken style de  alignItems:'center' özelliğini kullanmak isterseniz.. aşağdıka kodu kullanabilirsiniz.Bunun hatasını aşağıdaki kodlarla cozebilirsiniz. style yerine contentContainerStyle kullanarak çözebiliriz
```JS
 <ScrollView contentContainerStyle = {{flex: 1, alignItems:'center', width: '100%'}}>
                <TouchableOpacity
                  onPress = {() => navigation.navigate('FilexBox')}
                  style = {{
                      flex: 1,
                      margin: 20,
                      width: '95%',
                      height: 50,
                      alignItems: 'center',
                      backgroundColor: '#f00',
                      justifyContent: 'center',
                      borderRadius: 30
                  }}>
                     <Text>Flex Box</Text>
                </TouchableOpacity>
            </ScrollView>
```
