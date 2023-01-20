import React from 'react'
import { View, Text, SectionList, FlatList } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import Config from 'react-native-config'
import useFetch from '../../../hooks/useFetch'
import styles from "./ComicsDetail.style"
import ComicDetailCard from '../../../components/ComicDetailCard'
import ComicDetailCardHeader from '../../../components/ComicDetailCard/ComicDetailCardHeader/ComicDetailCardHeader'
const ComicsDetail = ({ navigation, route }) => {
  const { id } = route.params

  const { data, loading } = useFetch(`${Config.API_URL}/comics/${id}`)
  const { data: dataCharacters } = useFetch(`${Config.API_URL}/comics/${id}/characters`);
  const { data: dataStories } = useFetch(`${Config.API_URL}/comics/${id}/stories`);

  const sections = [
    {
      title: 'Comics',
      data: data,
      horizontal: false
    },
    {
      title: 'Characters',
      data: dataCharacters,
    },
    {
      title: 'Stories',
      data: dataStories,
    },
  ];

  const handleBack = () => {
    navigation.goBack()
  }
  const handleAllShow = (data, name) => {
    navigation.navigate("ShowAllItemPage", { data, name })
  }
  return (
    <View style={styles.container}>
      <View style={styles.container_header}>
        <Icon name="arrow-back-ios" size={25} style={styles.icon} onPress={handleBack} />
        <Text style={styles.header}>{data[0]?.title}</Text>
      </View>

      <SectionList
        stickySectionHeadersEnabled={false}
        sections={sections}
        renderSectionHeader={({ section }) => (
          <>

            {
              section.title !== 'Comics' ?
                <View style={styles.sectionHeader_container}>
                  <Text style={styles.sectionHeader}>{section.title}</Text>
                  <Text style={styles.seeAll_button} onPress={() => handleAllShow(section.data, data[0]?.title)}>See All</Text>
                </View>
                : null
            }
            <FlatList
              data={section.data}
              horizontal
              renderItem={({ item }) =>
                section.title !== 'Comics' && (
                  <ComicDetailCard item={item} />)
              }
            />
          </>
        )}
        renderItem={({ item, section }) => {
          if (!section.horizontal && section.title === 'Comics') {
            return <ComicDetailCardHeader item={item} />
          }
          return null
        }}

      />
    </View>
  )
}

export default ComicsDetail
