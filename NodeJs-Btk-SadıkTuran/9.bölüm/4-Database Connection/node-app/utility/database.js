const mongodb = require('mongodb');
const MongoClient = mongodb.MongoClient;

const mongoConnect = (callback) => {
    // MongoClient.connect('mongodb://localhost/node-app')
    MongoClient.connect('mongodb+srv://suleymanaslan:xSnSnEVEKmlB7jm3@cluster0.p8ipqnj.mongodb.net/test?retryWrites=true&w=majority')
        .then(client => {
            console.log('connected');
            callback(client);
        })
        .catch(err => {
            console.log(err);
            throw err;
        })
}


module.exports = mongoConnect;

