module.exports = (io) => io.on('connection', (socket) => {
  // envia apenas para quem conectou
  socket.emit('serverMessage', 'Olá, seja bem vindo ao nosso chat público! Use essa página para conversar a vontade.');
  // envia para todos menos para ele mesmo
  // socket.broadcast.emit('serverMessage', `chatSocket:Iiiiiirraaaa! ${socket.id} acabou de se conectar :D`);

  socket.on('clientMessage', (message) => {
    console.log(`Mensagem ${message}`);
    // envia para todos
    io.emit('serverMessage', message);
  });

  // socket.on('disconnect', () => {
  //   socket.broadcast.emit('serverMessage', `chatSocket:  Xiii! ${socket.id} acabou de se desconectar! :(`);
  // });
});