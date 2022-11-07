export const arrayLoop = (array = [], func = () => null, fromIndex = 0) => {
  for (let i = fromIndex; i < array.length; i++) {
    func(array[i], i);
  }
};

export const stringLoop = (str, func = () => null, fromIndex = 0) => {
  arrayLoop(str.split(''), func);
};

export const arrayFind = (array, arg) => {
  let result;

  if (typeof arg === 'function') {
    arrayLoop(array, (item, index) => arg(item, index) && (result = { item, index }));
  } else if (typeof arg === 'object') {
  } else if (Array.isArray(arg)) {
  } else {
    arrayLoop(array, (item, index) => item === arg && (result = { item, index }));
  }

  return result;
};

export const arrayFilter = (array, func) => {
  const result = [];
  arrayLoop(array, (item, index) => func(item, index) && result.push(item));
  return result;
};

export const arrayCount = (array, arg) => {
  let count = 0;

  if (typeof arg === 'function') {
    arrayLoop(array, (item, index) => {
      if (arg(item, index)) {
        //result.push({ item, index });
        count++;
      }
    });
  } else if (typeof arg === 'object') {
  } else if (Array.isArray(arg)) {
  } else {
    arrayLoop(array, (item, index) => {
      if (item === arg) {
        count++;
      }
    });
  }

  return count;
};

export const create2dArray = (w, h, val) => {
  const arr = [];
  for (let i = 0; i < h; i++) {
    arr[i] = [];

    for (let j = 0; j < w; j++) {
      arr[i][j] = val;
    }
  }

  return arr;
};

export const emailValidation = input => {
  let reg = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w\w+)+$/;
  return reg.test(input);
};

export const setToHappen = (fn, date) => {
  return setTimeout(fn, date - Date.now());
};

export const checkString = d => typeof d === 'string' && (d || '').length > 0;
