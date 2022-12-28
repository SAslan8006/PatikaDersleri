# Döngüler
1. let numLis=[]; şekliden ifade edilir
2. let ogrenci={id:5,adi:'mehmet',basari:true};
3. let ogrenciList= [{id:1,adi:'mehmet',basari:true},{id:2,adi:'Ayşe',basari:true},{id:3,adi:'yusuf',basari:true}] 
![image](https://user-images.githubusercontent.com/109723263/209791956-3285724b-9923-4734-b355-e1410a0b0ccf.png)
4.  foreach yerine map de kullanılmaktadı
![image](https://user-images.githubusercontent.com/109723263/209792185-ab38d8dd-d7bf-4a16-998d-930934275fcc.png)
5. Örnek : Aşağıdaki şekildedir.
```JS 
{numList.map((num,index)=>(
    <Text style={styles.textStyle} key={index.toString()}> {num} </Text> 
))}
``` 
![image](https://user-images.githubusercontent.com/109723263/209794312-d26caefd-ce82-40c7-a085-c3f05c8a750c.png)
