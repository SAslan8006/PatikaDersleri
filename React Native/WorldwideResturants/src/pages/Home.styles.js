import {StyleSheet, Dimensions} from 'react-native';

const {height, width} = Dimensions.get('window');

export default StyleSheet.create({
  container: {
    flex: 1,
  },
  map: {
    ...StyleSheet.absoluteFillObject,
  },
  searchBox: {
    position: 'absolute',
    marginTop: 20,
    flexDirection: 'row',
    backgroundColor: '#fff',
    width: '90%',
    alignSelf: 'center',
    borderRadius: 5,
    padding: 5,
    shadowColor: '#ccc',
    shadowOffset: {width: 0, height: 3},
    shadowOpacity: 0.5,
    shadowRadius: 5,
    elevation: 10,
    justifyContent: 'center',
    alignItems: 'center',
  },
  chipsScrollView: {
    position: 'absolute',
    top: 70,
    paddingHorizontal: 10,
  },
  chipItem: {
    flexDirection: 'row',
    backgroundColor: '#fff',
    borderRadius: 20,
    padding: 8,
    paddingHorizontal: 20,
    marginHorizontal: 10,
    height: 35,
  },
  scrollView: {
    position: 'absolute',
    bottom: 0,
    margin: 20,
  },
  card: {
    margin: 10,
    height: height / 3.5,
    width: width * 0.6,
    backgroundColor: 'white',
    borderWidth: 1,
    borderRadius: 6,
  },
  starStyle: {
    width: 100,
    height: 20,
  },
  starContainer: {flexDirection: 'row', margin: 5},
  resturantImage: {
    height: height / 4 - 120,
    width: '100%',
    padding: 0,
    borderRadius: 6,
  },
  name: {
    fontWeight: '700',
    fontSize: 16,
    marginStart: 5,
    height: 20,
  },
  ranking: {fontStyle: 'italic', marginStart: 5},
  hourHeader: {fontWeight: '600'},
  hourContainer: {flexDirection: 'row', padding: 5},
  openNow: {marginStart: 5, fontStyle: 'italic'},
  hourDay: {marginStart: 5, fontWeight: '600'},
});
