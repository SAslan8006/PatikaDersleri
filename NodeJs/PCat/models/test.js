const mongoose = require('mongoose');
const Schema = mongoose.Schema;

//connectDb
mongoose.set('strictQuery', false);
mongoose.connect('mongodb://127.0.0.1:27017/pcat-test-db');

//Creat Schema
const PhotoSchema = new Schema({
  title: String,
  description: String,
});

const Photo = mongoose.model('Photo', PhotoSchema);

//create a photo
// Photo.create({
//   title: 'Photo Title 2',
//   description: 'Photo description 2 lorem ipsum',
// });

//read a photo
// Photo.find({}, (err, data) => {
//   console.log(data);
// });

//update photo
// const id = '63cfee081ebcf0eb20c1c87f';
// Photo.findByIdAndUpdate(
//   id,
//   {
//     title: 'Photo Title 111 updated',
//     description: 'Photo description 111 updated',
//   },
//   {
//     new: true, //Veri güncellemesi bu callback fonsiyonu tetiklenmelidir
//   },
//   (err, data) => {
//     console.log(data);
//   }
// );

//delete a photo
const id = '63cfee081ebcf0eb20c1c87f';

Photo.findByIdAndDelete(id, (err, data) => {
  console.log('Photo is removed..');
});
