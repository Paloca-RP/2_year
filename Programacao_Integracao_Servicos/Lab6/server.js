let express = require("express");
let app = express();
let mysql = require("mysql");

const PORT = process.env.PORT || 8081;
app.listen(PORT, console.log("Listening on http://localhost:" + PORT));

const db = mysql.createConnection(require("./scripts/dbConn.json"));
db.connect((err) => {
    if(err) throw err;
    console.log('Connected to Database')
});

app.use(express.json());
app.use(express.urlencoded({extended: false}));

app.get("/api/aluno", (req, res) => {
    let query = mysql.format("SELECT * FROM USER");
    db.query(query, (err, rows) => {
        if(err)
            throw err;  
        res.send(rows);
    });
});
app.get("/api/aluno/:id", (req, res) => {
    let query = mysql.format("SELECT * FROM USER WHERE ID = ?", [req.params.id]);
    db.query(query, (err, rows) => {
        if(err)
            throw err;
        res.send(rows);
    });
});
app.post("/api/aluno", (req, res) => {
    let query = mysql.format("INSERT INTO USER (Nome, Birth_Date) VALUES (?, ?)", [req.body.nome, new Date(req.body.birthdate)]);
    db.query(query, (err, rows) => {
        if(err)
            throw err;
        res.send(rows);
    });
});
app.put("/api/aluno", (req, res) => {
    let query = mysql.format("UPDATE USER SET Nome = ?, Birth_Date = ? WHERE ID = ?", [req.body.nome, new Date(req.body.birthdate), req.body.id]);
    db.query(query, (err, rows) => {
        if(err)
            throw err;
        res.send(rows);
    });
});
app.delete("/api/aluno", (req, res) => {
    let query = mysql.format("DELETE FROM USER WHERE ID > 0");
    db.query(query, (err, rows) => {
        if(err)
            throw err;
        res.send(rows);
    });
});
app.get("/api/alunopet/:alunoid", (req, res) => {
    let query = mysql.format("SELECT USER.ID AS 'ID Dono', USER.NOME AS 'Dono', PET.ID AS 'ID Pet', PET.NOME AS 'Pet', PET.SIZE AS 'Tamanho', PET.BIRTH_DATE AS 'Nascimento Pet' FROM USER_PET INNER JOIN (SELECT PET.ID, Nome, Birth_DATE, SIZE.SIZE FROM PET INNER JOIN (SELECT id, SIZE FROM SIZE) AS SIZE ON PET.FK_SIZE_ID = SIZE.ID) AS PET ON PET.ID = USER_PET.FK_PET_ID INNER JOIN (SELECT USER.ID, USER.NOME FROM USER) AS USER ON USER.ID = USER_PET.FK_USER_ID WHERE USER.ID = ?", [req.params.alunoid]);
    db.query(query, (err, rows) => {
        if(err)
            throw err;
        res.send(rows);
    });
});