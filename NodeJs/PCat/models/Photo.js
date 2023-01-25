const mongoose = require('mongoose');
const Schema = mongoose.Schema;

//Creat Schema
const PhotoSchema = new Schema({
  title: String,
  decription: String,
  image: String,
  dateCreated: {
    type: Date,
    default: Date.now,
  },
});

const Photo = mongoose.model('Photo', PhotoSchema);

module.exports = Photo;
