# Flat List kullanımı
```JS
 <FlatList style={{ flex: 1, alignContent: 'center', }}
                    data={todoList}
                    itemSeparatorComponent={ItemSeparatorComponent}
                    renderItem={RenderItem}
                    keyExtractor={(item, index) => index.toString()}
 />
          
```
1. data: kullanıcının elinde bulunduğu veri listesidir. 
2. itemSeparatorComponent: Verilerin arasına koyulacak boşluk yada ----- gibi şekillerin render edilmesini sağlayan bir alandır.
3. renderItem: Reder edilecek itemdeki verinin nasıl görşelleşeceğinin ve listeleceğini burada ayarlanmaktadır.
4. keyExtractor={(item, index) => index.toString()} burada flat liste key verilmesinin sağlayan bir yapıdır. her zaman bu şekilde kullanılabilir ama listelemede karşımıza çıkan verinin bir keye sahip olması şarttır. 
