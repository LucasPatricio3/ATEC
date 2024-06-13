// app.js
const express = require("express");
const app = express();

app.get("/", (req, res) => {
  res.send("<h1>Hello turma 1223! Este é um exemplo de um servidor nodejs que se encontra a correr num container!</h1>");
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server running on port: ${PORT}`);
});
