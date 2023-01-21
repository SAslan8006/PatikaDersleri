import { View,  ScrollView,  Text,  StatusBar,  Image,  TextInput,  TouchableOpacity,} from 'react-native';
import React, {useEffect, useState, useRef} from 'react';
import MapView, {Marker, PROVIDER_GOOGLE} from 'react-native-maps';
import styles from './Home.styles';
import Ionicons from 'react-native-vector-icons/dist/Ionicons';
import Star from 'react-native-star-view';
import data from '../../data.json';

export default function Home() {
  const [search, setSearch] = useState('');
  const [filteredDataSource, setFilteredDataSource] = useState(data);
  const [masterDataSource, setMasterDataSource] = useState(data);

  function time_convert(num) {
    var hours = Math.floor(num / 60);
    var minutes = num % 60;
    return hours + ':' + minutes;
  }

  let category = data[0].cuisine.map(item => item.name);
  category.push('Hepsi');
  category.reverse();

  const mapRef = useRef();

  const handleMarkerSelect = item => {
    mapRef.current.animateToRegion({
      latitude: Number(item.latitude),
      longitude: Number(item.longitude),
      latitudeDelta: 0.015,
      longitudeDelta: 0.0121,
    });
  };

  const handleMapView = item => {
    mapRef.current.animateToRegion({
      latitude: Number(item.latitude),
      longitude: Number(item.longitude),
      latitudeDelta: 0.015,
      longitudeDelta: 0.0121,
    });
  };

  const searchFilterFunction = text => {
    if (text) {
      const newData = masterDataSource.filter(function (item) {
        const itemData = item.name ? item.name.toUpperCase() : ''.toUpperCase();
        const textData = text.toUpperCase();
        return itemData.indexOf(textData) > -1;
      });
      setFilteredDataSource(newData);
      setSearch(text);
    } else {
      setFilteredDataSource(masterDataSource);
      setSearch(text);
    }
  };

  return (
    <View style={styles.container}>
      <StatusBar backgroundColor="#c50e29" barStyle="dark-content" />
      <MapView
        provider={PROVIDER_GOOGLE}
        style={styles.map}
        region={{
          latitude: -6.923141,
          longitude: 107.62387,
          latitudeDelta: 0.015,
          longitudeDelta: 0.0121,
        }}
        ref={mapRef}>
        {data.map((item, index) => (
          <Marker
            key={index}
            coordinate={{
              latitude: Number(item.latitude),
              longitude: Number(item.longitude),
            }}
            title={item.name}
            description={item.address_obj.street1}
            image={require('../asset/markerIcon2.png')}
            onPress={() => handleMarkerSelect(item)}
          />
        ))}
      </MapView>
      <View style={styles.searchBox}>
        <TextInput
          placeholder="Restoran Ara"
          placeholderTextColor="#000"
          autoCapitalize="none"
          style={{flex: 1, padding: 0}}
          onChangeText={text => searchFilterFunction(text)}
          value={search}
        />
        <Ionicons name="ios-search" size={20} />
      </View>
      <ScrollView
        horizontal
        scrollEventThrottle={1}
        showsHorizontalScrollIndicator={false}
        height={50}
        style={styles.chipsScrollView}>
        {category.map((item, index) => (
          <TouchableOpacity style={styles.chipItem} key={index}>
            <Text>{item}</Text>
          </TouchableOpacity>
        ))}
      </ScrollView>

      <ScrollView
        horizontal
        scrollEventThrottle={1}
        showsHorizontalScrollIndicator={false}
        style={styles.scrollView}
        snapToAlignment="center">
        {filteredDataSource.map((item, index) => (
          <View style={styles.card} key={index}>
            <TouchableOpacity onPress={() => handleMapView(item)}>
              <Image
                source={{uri: item.photo.images.small.url}}
                style={styles.resturantImage}
              />
              <Text style={styles.name}>{item.name}</Text>
              <View style={styles.starContainer}>
                <Star
                  score={parseFloat(item.raw_ranking)}
                  style={styles.starStyle}
                />
                <Text style={styles.ranking}>
                  {parseFloat(item.raw_ranking).toFixed(2)}
                </Text>
              </View>
              <Text style={styles.openNow}>{item.open_now_text}</Text>
              <View style={styles.hourContainer}>
                <Text style={styles.hourHeader}>Çalışma Saatleri </Text>
                <Text>
                  {item.hours
                    ? time_convert(item.hours.week_ranges[0][0].open_time)
                    : 'boş'}
                  -
                  {item.hours
                    ? time_convert(item.hours.week_ranges[0][0].close_time)
                    : 'boş'}
                </Text>
                <Text style={styles.hourDay}>
                  {item.hours ? item.hours.week_ranges.length : 'boş'} Gün
                </Text>
              </View>
              <Text style={styles.hourDay}>{item.phone}</Text>
            </TouchableOpacity>
          </View>
        ))}
      </ScrollView>
    </View>
  );
}
