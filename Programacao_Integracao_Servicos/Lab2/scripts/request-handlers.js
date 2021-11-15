const mysql = require("mysql")
const conexao = require("./connection.json")

function openConnectionDB(option){
    let conn = mysql.createConnection(option)
    conn.connect()
    return conn
}