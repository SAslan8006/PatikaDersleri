import {AppRegistry} from 'react-native';

import {App} from './src/app_';

const getFirstComponent = () => {
  return App;
};

AppRegistry.registerComponent('helloreactnative', getFirstComponent);
