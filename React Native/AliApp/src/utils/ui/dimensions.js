import {Dimensions} from 'react-native';
import {getStatusBarHeight} from './getStatusBarHeight';

export const window = Dimensions.get('window');
export const screen = Dimensions.get('screen');

export const w = window.width;
export const h = window.height;

export const W = d => (w * d) / 100;
export const H = d => (h * d) / 100;

export const sbh = getStatusBarHeight();
export const sbhi = getStatusBarHeight(true);
