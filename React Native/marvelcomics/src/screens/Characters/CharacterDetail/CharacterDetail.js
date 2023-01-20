import React from 'react'
import { View, Text, SectionList, FlatList, Image } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import Config from 'react-native-config'
import useFetch from '../../../hooks/useFetch'
import styles from "./CharacterDetail.style"
import CharacterDetailCard from '../../../components/CharacterDetailCard'
import CharDetailCardHeader from '../../../components/CharacterDetailCard/CharDetailCardHeader/CharDetailCardHeader'
const CharacterDetail = ({ navigation, route }) => {

  const { id } = route.params

  const { data, loading } = useFetch(`${Config.API_URL}/characters/${id}`)
  const { data: dataComics } = useFetch(`${Config.API_URL}/characters/${id}/comics`);
  const { data: dataEvents } = useFetch(`${Config.API_URL}/characters/${id}/events`);
  const { data: dataSeries } = useFetch(`${Config.API_URL}/characters/${id}/series`);
  const { data: dataStories } = useFetch(`${Config.API_URL}/characters/${id}/stories`);

  const sections = [
    {
      title: 'Character',
      data: data,
      horizontal: false
    },
    {
      title: 'Comics',
      data: dataComics,
    },
    {
      title: 'Series',
      data: dataSeries,
    },
    {
      title: 'Stories',
      data: dataStories,
    },
    {
      title: 'Events',
      data: dataEvents,
    },
  ];

  const handleBack = () => {
    navigation.goBack()
  }
  const handleAllShow = (data, name, title) => {
    navigation.navigate("ShowAllItemPage", { data, name, title })
  }
  return (
    <View style={styles.container}>
      <View style={styles.container_header}>
        <Icon name="arrow-back-ios" size={25} style={styles.icon} onPress={handleBack} />
        <Text style={styles.header}>{data[0]?.name}</Text>
      </View>

      <SectionList
        stickySectionHeadersEnabled={false}
        sections={sections}
        renderSectionHeader={({ section }) => (
          <>

            {
              section.title !== 'Character' ?
                <View style={styles.sectionHeader_container}>
                  <Text style={styles.sectionHeader}>{section.title}</Text>
                  <Text style={styles.seeAll_button} onPress={() => handleAllShow(section.data, data[0]?.name, section.title)}>See All</Text>
                </View>
                : null
            }
            <FlatList
              data={section.data}
              horizontal
              renderItem={({ item }) =>
                section.title !== 'Character' && (
                  <CharacterDetailCard item={item} />)
              }
            />
          </>
        )}
        renderItem={({ item, section }) => {
          if (!section.horizontal && section.title === 'Character') {
            return <CharDetailCardHeader item={item} />
          }
          return null
        }}

      />
    </View>
  )
}

export default CharacterDetail
