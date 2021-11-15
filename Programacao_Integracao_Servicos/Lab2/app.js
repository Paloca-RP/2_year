var express = require('express');
var app = express();

app.use(express.urlencoded()); //Parse URL-encoded body (pedidos de formulários)
app.use(express.static(__dirname + '/www'));

    app.get('/', function (req, res) {
        res.sendFile(__dirname + '/www/index.html');
    });

   app.get('/formulario_get', function (req, res) {
    var response = {
    nome:req.query.nome, //com o GET os parâmetros vêm por querystring
    morada:req.query.morada
    };
    console.log(response);
    res.send(JSON.stringify(response));
   });

    app.post('/formulario_post', function (req, res) {
    var response = {
    nome:req.body.nome, //com o POST os parâmetros vêm no body do pedido
    morada:req.body.morada
    };
    console.log(response);
    res.send(JSON.stringify(response));
    });



app.listen(8081, function() {
    console.log("http://localhost:8081")
})


