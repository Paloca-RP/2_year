//Nivel 1
/*const express = require("express")
const app = express()

app.use('/rotas', function(req, res, next){ 
    console.log("A request for 'rotas' received at " + Date.now()); 
    next(); 
 }); 
  
 app.get('/rotas', function(req, res){ 
    res.send('teste'); 
 });

app.listen(8081, function() {
    console.log("http://localhost:8081")
})
*/
//Nivel 2
/*var express = require('express'); 
var app = express(); 
 
//Middleware: sempre executado 
app.use(function(req, res, next){ 
   console.log("Start"); 
   next(); //importante para continuar o processamento 
}); 
 
//Rota: apenas executada porque o app.use anterior tem o next() 
app.get('/', function(req, res, next){
    res.send("Middle"); 
   next(); //importante para continuar o processamento 
}); 
 
//Middleware: apenas executada porque o app.get anterior tem o next() 
app.use('/', function(req, res){ 
   console.log('End'); //finaliza por isso não precisa do next() 
}); 
 
app.listen(8081);
*/
//Nivel 3
/*var express = require('express'); 
var app = express(); 
 
var urls = []; 
 
//Middleware: sempre executado 
app.use(function (req, res, next) { 
    if (urls[req.url]) { 
        urls[req.url] += 1; 
    } else { 
        urls[req.url] = 1; 
    } 
 
    console.log(urls.sort()); 
    next(); 
}); 
 
app.get('/', function(req, res, next){ 
   res.send("Root"); 
}); 
 
app.get('/rota/subrota1', function(req, res, next){ 
   res.send("Rota 1"); 
}); 
 
app.get('/rota/subrota2', function(req, res, next){ 
   res.send("Rota 2"); 
}); 

app.listen(8081);*/

//Nivel 4
var express = require('express'); 
var app = express(); 
const fs =  require('fs');
//Middleware: apenas executado para as rotas /rota 
app.use('/rota',function (req, res, next) { 
    fs.appendFileSync("api-requests.txt", Date.now() + ' | ' + req.ip + ' : ' + req.url + "\n"); 
    next(); 
}); 
 
app.get('/', function(req, res, next){ 
   res.send("Root"); 
}); 
 
app.get('/rota/subrota1', function(req, res, next){ 
   res.send("Rota 1"); 
}); 
 
app.get('/rota/subrota2', function(req, res, next){ 
   res.send("Rota 2"); 
}); 
 
app.listen(8081);