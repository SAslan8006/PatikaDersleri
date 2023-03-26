import bodyParser from 'body-parser';
import { db } from './db/index.js';
import express from 'express';
import { routes } from './routes/index.js';

const app = express();

app.use(bodyParser.json());

routes.forEach(route => {
    app[route.method](route.path, route.handler);
});

const start = async () => {
    await db.connect('mongodb+srv://test:test@courseshop.tzvot.mongodb.net/Youtube-MERN?retryWrites=true&w=majority');
    app.listen(8080,() => {
        console.log('Server is listening on port 8080');
    });
}

start();