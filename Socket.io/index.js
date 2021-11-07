const express = require('express');
const app = express();
const http = require('http').createServer(app);

const PORT = 3001;

const io = require('socket.io')(http, {
  cors: {
    origin: `http://localhost:${PORT}`, // url aceita pelo cors
    methods: ['GET', 'POST'], // Métodos aceitos pela url
  }
});

app.use(express.static(__dirname + '/public'));

// require('./sockets/ping')(io);
// require('./sockets/chat')(io);
require('./sockets/rooms')(io);

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/index.html')
});

http.listen(PORT, () => {
  console.log(`Servidor  ouvindo na porta ${PORT}`);
});
