import { Keyboard } from 'react-native';

let tmp1, tmp2;

export const dismissKeyboard = () => {
  Keyboard.dismiss();
  //console.log('>>> Keyboard.dismiss <<<<');
};

export const keyboardListener = (opened, closed) => {
  keyboardListenerClear();

  tmp1 = Keyboard.addListener('keyboardDidShow', d => {
    opened(d.endCoordinates);
    //console.log('>>> keyboardDidShow <<<<');
  });

  tmp2 = Keyboard.addListener('keyboardDidHide', () => {
    closed();
    //console.log('>>> keyboardDidHide <<<<');
  });

  //console.log('>>> keyboardListener <<<<', tmp1, tmp2);
};

export const keyboardListenerClear = () => {
  try {
    if (tmp1?.remove) {
      tmp1.remove();
    }
    if (tmp2?.remove) {
      tmp2.remove();
    }
  } catch (e) {
    console.log('KEYBOARD : FIX ME', e);
  }
};
