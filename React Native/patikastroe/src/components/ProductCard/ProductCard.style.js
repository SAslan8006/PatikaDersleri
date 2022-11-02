import {StyleSheet, Dimensions} from 'react-native';

export default StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#ededed',
    borderRadius: 10,
    margin: 5,
    padding: 10,
  },
  image: {
    width: '100%',
    height: Dimensions.get('window').height / 5,
    resizeMode: 'contain',
    backgroundColor: 'white',
    borderRadius: 5,
  },
  infoContainer: {
    flex: 1,
    //backgroundColor: 'red',
  },
  title: {
    color: 'black',
    fontSize: 20,
    fontWeight: 'bold',
  },
  price: {
    color: '#979797',
    fontSize: 16,
    fontWeight: 'bold',
    alignItems: 'flex-end',
  },
  stok: {
    color: 'red',
    fontSize: 16,
    fontWeight: 'bold',
  },
});