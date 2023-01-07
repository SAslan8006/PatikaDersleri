import React, { useRef, useState } from 'react'
import { View } from 'react-native'
import Config from 'react-native-config';
import MapView from 'react-native-maps';
import InfoCard from './components/InfoCard/InfoCard';
import Loading from './components/Loading';
import UserMarker from './components/marker/UserMarker';
import useFetch from './hooks/useFetch';

const App = () => {
  const mapRef = useRef()
  const [user, setUser] = useState()
  const [infoModalVisibility, setInfoModalVisibility] = useState(false);
  const { data, loading, error } = useFetch(Config.API_URL)

  const renderUserMarker = () => {
    return data.map(({ id, avatar, first_name, last_name, username, address: { coordinates } }) => {
      return (
        <UserMarker
          key={id}
          coordinates={{
            latitude: coordinates.lat,
            longitude: coordinates.lng
          }}
          userImageURL={avatar}
          onSelect={() => handleMarkerSelect(coordinates, { first_name, last_name, username })}
        />
      )
    })
  }
  const handleMarkerSelect = (coor, selectedUser) => {
    setUser(selectedUser)

    handleModalVisibility();
    mapRef.current.animateToRegion({
      latitude: coor.lat,
      longitude: coor.lng,
      latitudeDelta: 8,
      longitudeDelta: 8,
    })
  }

  const handleModalVisibility = () => {
    setInfoModalVisibility(!infoModalVisibility)
  }

  return (
    <View style={{ flex: 1 }}>
      <MapView ref={mapRef} style={{ flex: 1 }}>
        {data && renderUserMarker()}
      </MapView>
      {loading && <Loading />}
      {user && (<InfoCard visibile={infoModalVisibility} onClose={handleModalVisibility} user={user} />)}
    </View>
  )
}

export default App
