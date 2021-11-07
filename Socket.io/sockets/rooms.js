module.exports = (io) => io.on('connection', (socket) => {
  let userName = '';
  let Room = '';

  socket.on('joinRoom', ({ username, room }) => {
    console.log(`${username} se conectou na sala ${room}!`);
    userName = username;
    Room = room;

    socket.join(room);

    socket.emit('serverMessage', `Bem vindo ${username} a sala sobre ${room}`);

    socket.broadcast.to(room).emit('serverMessage', `${username} acabou de entrar na sala`);

    socket.on('roomClientMessage', ({ message, room }) => {
      io.to(room)
      .emit('serverMessage', `${username}: ${message}`);
    });
  });

  socket.on('disconnect', () => {
    console.log(`${userName} se desconectou na sala ${Room}!`);
    socket.broadcast.to(Room).emit('serverMessage', `${userName} acabou de sair na sala`);
  });
});
