CREATE SCHEMA IF NOT EXISTS lab5;
USE lab5;
##create tables
CREATE TABLE SIZE (ID INT NOT NULL AUTO_INCREMENT, SIZE VARCHAR(255), PRIMARY 
KEY (ID));
create table PET (ID INT NOT NULL AUTO_INCREMENT, NOME VARCHAR(255) NULL, 
BIRTH_DATE DATE NULL, FK_SIZE_ID INT NULL , PRIMARY KEY (ID), FOREIGN KEY 
(FK_SIZE_ID) REFERENCES SIZE(ID) );
create table USER (ID INT NOT NULL AUTO_INCREMENT, NOME VARCHAR(255) NULL, 
BIRTH_DATE DATETIME NULL, PRIMARY KEY (ID) );
CREATE TABLE USER_PET (ID INT NOT NULL AUTO_INCREMENT , FK_USER_ID int NOT NULL, 
FK_PET_ID INT NOT NULL ,PRIMARY KEY (ID), FOREIGN KEY (FK_USER_ID) REFERENCES 
USER(ID) ON DELETE CASCADE, FOREIGN KEY (FK_PET_ID) REFERENCES PET(ID) ON DELETE CASCADE);
##inserts
INSERT INTO size( ID, SIZE ) VALUES (1, 'Grande');
INSERT INTO size( ID, SIZE ) VALUES (2, 'Médio');
INSERT INTO size( ID, SIZE ) VALUES (3, 'Pequeno');
INSERT INTO pet( ID, NOME, BIRTH_DATE, FK_SIZE_ID) VALUES (1, 'Nero','2012-12-02','1');
INSERT INTO pet( ID, NOME, BIRTH_DATE, FK_SIZE_ID) VALUES (2, 'Boneca','2014-08-12','3');
INSERT INTO user(ID, NOME, BIRTH_DATE) VALUES (1,'António','2000-04-24');
INSERT INTO user(ID, NOME, BIRTH_DATE) VALUES (2,'Maria','2002-10-14');
INSERT INTO user_pet(FK_USER_ID, FK_PET_ID) VALUES (1,1);
INSERT INTO user_pet(FK_USER_ID, FK_PET_ID) VALUES (1,2);
INSERT INTO user_pet(FK_USER_ID, FK_PET_ID) VALUES (2,2);


SELECT * FROM USER;
SELECT * FROM PET;
SELECT * FROM USER_PET;

SELECT Nome.PET FROM PET;

SELECT USER.ID AS "ID Dono", USER.NOME AS "Dono", PET.ID AS "ID Pet", PET.NOME AS "Pet", PET.SIZE AS "Tamanho", PET.BIRTH_DATE AS "Nascimento Pet" FROM USER_PET
	INNER JOIN (SELECT PET.ID, Nome, Birth_DATE, SIZE.SIZE FROM PET
		INNER JOIN (SELECT id, SIZE FROM SIZE) AS SIZE ON PET.FK_SIZE_ID = SIZE.ID) AS PET ON PET.ID = USER_PET.FK_PET_ID
	INNER JOIN (SELECT USER.ID, USER.NOME FROM USER) AS USER ON USER.ID = USER_PET.FK_USER_ID
WHERE USER.ID = 1;