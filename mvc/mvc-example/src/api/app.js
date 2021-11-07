const express = require('express');
const bodyParser = require('body-parser');
const path = require('path');

const authorController = require('../controllers/authorController');

const app = express();
app.use(bodyParser.urlencoded({ extended: true }));

app.set('view engine', 'ejs');

app.set('views', path.join(__dirname,'..', 'views'));

app.get('/authors', authorController.listAuthors);
app.get('/authors/new', authorController.newAuthor);
app.get('/authors/:id', authorController.showAuthor);
app.post('/authors', authorController.createAuthor);

module.exports = { app };
