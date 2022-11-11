import React, {useState}  from "react";
import { SafeAreaView,View,FlatList,Text,StyleSheet } from "react-native";

import { SearchBar,SongCard } from "../components";
import music_data from '../images/music-data.json';

function Shop({route}){
    const [list,setList]=useState(music_data);
    const renderSong= ({item})=> <SongCard song={item} />;
    const renderSeperator= ()=> <View style={styles.seperator} />;
    //veriler texte girildiğinde listedeki veriler eşletirilip ona göre verilerin filtrelenmesi sağlanmış bu değişiklikler ise küçük buyük harf etkisi kaldırılmıştır.
    const handleSearch=text =>{
      const filteredList=music_data.filter(song=>{
        const searchedText=text.toLowerCase();
        const currentTitle=song.title.toLowerCase();
  
        return currentTitle.indexOf(searchedText)>-1;
      });
      setList(filteredList);
    };
    const {user}=route.params;
    return(
        <SafeAreaView style={styles.container}>
            <View style={styles.user}>
                <Text> {user.Name} {user.Surname} Hoş Geldiniz...</Text>
            </View>
            <View>
                <SearchBar onSearch={handleSearch} />
                <FlatList 
                keyExtractor={item => item.id}
                data={list}
                renderItem={renderSong}
                ItemSeparatorComponent={renderSeperator}          
                />
            </View>
        </SafeAreaView>
    );
}
const styles = StyleSheet.create({
    container: {
      paddingHorizontal: 2,
      backgroundColor: 'white',
      borderRadius: 16,
      padding: 4,
      shadowColor: 'red',
      shadowOffset: {
        width: 0,
        height: 2,
      },
      shadowOpacity: 1,
      shadowRadius: 4,
      elevation: 8,
    },
    seperator:{
      borderWidth:1,
      borderColor:'red',
    },
    user:{
      justifyContent: 'center',
      borderRadius: 12,
      padding: 8,
      alignItems: 'flex-start',
      marginTop: 16,
      backgroundColor: 'pink',
    }
  
  });
export default Shop;