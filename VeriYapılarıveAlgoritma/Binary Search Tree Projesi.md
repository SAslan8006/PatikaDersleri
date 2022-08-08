Proje 3
[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.

* ilk değer olan **7**, root seçilir.
* 1. **5**     
   5<7 => 5 7'den küçük olduğu için ; 7'nin soluna
* 2. **1**     
   1<7, 1<5; 5 in alt sol dalı olur; 5'in soluna
* 3. **8**     
   8>7; 7 den büyük olduğu için sagına dal olur ; 7'nin sağına 
* 4. **3**     
   3<7, 3<5, 3>1; 1'in sağına
* 5. **6**     
   6<7, 6>5; 5'in sağına
* 6. **0**     
   0<7, 0<5, 0<1; 1'in soluna
* 7. **9**     
   9>7, 9>8; 8in sağına
* 8. **4**     
   4<7, 4<5, 4>1, 4>3; 3'ün sağına
* 9. **2**     
   2<7, 2<5, 2>1, 2<3; 3'ün soluna yazılır.

                  7
                /  \
               5    8
              / \    \
             1   6    9
            / \
           0   3
              / \
             2   4 