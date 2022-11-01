import React from 'react';
import {  StyleSheet,  SafeAreaView,} from 'react-native';
import Card from './components/Card';

const App = () => {
  return (
    <SafeAreaView style={styles.container}>
      <Card title="Eddard Stark" text="Winter is coming"/>
      <Card title="Arif Isık" text="Winter is coming" />
      <Card title="Pamuk" text="Ben Hediye paketi istiyorum!" />
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#e0e0e0',
    margin: 10,
    padding: 3,
    flex: 1,
    borderRadius: 8,
    marginHorizontal: 16,
  },
});

export default App;
