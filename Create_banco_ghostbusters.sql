 CREATE DATABASE GHOSTBUSTERS_3
 
 USE GHOSTBUSTERS_3
 
 CREATE TABLE PERFIL
 (
	COD_PERFIL INT IDENTITY (1,1) PRIMARY KEY,
	NOME VARCHAR(150) NOT NULL
 )
 
 CREATE TABLE IMAGEM
 (
	COD_IMAGEM INT IDENTITY(1,1)PRIMARY KEY,
	NOME VARCHAR(150) NOT NULL,
	BASE_DATA VARCHAR(MAX) NOT NULL,
 )
 
 CREATE TABLE USUARIO
 (
	COD_USUARIO INT IDENTITY (1,1) PRIMARY KEY,
	NOME VARCHAR(250) NOT NULL,
	EMAIL VARCHAR(250) NOT NULL UNIQUE,
	SENHA VARCHAR(20) NOT NULL,
	COD_PERFIL INT NOT NULL,
	COD_IMAGEM INT, 
	FOREIGN KEY (COD_PERFIL)
		REFERENCES PERFIL(COD_PERFIL),
	FOREIGN KEY (COD_IMAGEM)
		REFERENCES IMAGEM(COD_IMAGEM)	
 )

CREATE TABLE _STATUS
(
	COD_STATUS INT IDENTITY(1,1) PRIMARY KEY,
	NOME VARCHAR(250) NOT NULL,
	COD_PERFIL INT,
	FOREIGN KEY (COD_PERFIL)
		REFERENCES PERFIL(COD_PERFIL)
)



CREATE TABLE CATEGORIA
(
	COD_CATEGORIA INT IDENTITY(1,1) PRIMARY KEY,
	NOME VARCHAR(150) 	
)

--ALTER TABLE CHAMADO DROP COLUMN COD_ANEXO -- INT DEFAULT NULL
--ALTER TABLE CHAMADO ADD FOREIGN KEY (COD_ANEXO) REFERENCES ANEXO(COD_ANEXO)

--ALTER TABLE Chamado ALTER COLUMN DATA_CHAMADA_FINALIZADA add DEFAULT ('1900-01-01T00:00:00.000')

CREATE TABLE CHAMADO
(
	COD_CHAMADO INT IDENTITY (1,1) PRIMARY KEY,
	TITULO VARCHAR(250) NOT NULL,
	DESCRICAO VARCHAR(1000) NOT NULL,
	DATA_CHAMADO DATETIME NOT NULL DEFAULT GETDATE(),
	DATA_CHAMADA_FINALIZADA DATETIME DEFAULT  ('1900-01-01T00:00:00.000'),
	COD_STATUS INT NOT NULL,
	COD_CATEGORIA INT NOT NULL, 
	COD_OWNER INT NOT NULL,
	COD_TECH INT DEFAULT NULL,
	--COD_ANEXO INT,
	--COD_PERFIL INT NOT NULL,
	--FOREIGN KEY (COD_PERFIL)
		--REFERENCES PERFIL(COD_PERFIL),
	FOREIGN KEY (COD_STATUS)
		REFERENCES _STATUS(COD_STATUS),
	FOREIGN KEY (COD_CATEGORIA)
		REFERENCES CATEGORIA(COD_CATEGORIA),
	FOREIGN KEY (COD_OWNER)
		REFERENCES USUARIO(COD_USUARIO),
	FOREIGN KEY (COD_TECH)
		REFERENCES USUARIO(COD_USUARIO),
	--FOREIGN KEY (COD_ANEXO)
		--REFERENCES ANEXO(COD_ANEXO)
)

CREATE TABLE ANEXO
(
	COD_ANEXO INT IDENTITY(1,1) PRIMARY KEY,
	NOME VARCHAR(150)NOT NULL,
	BASE_64 VARCHAR(MAX) NOT NULL,
	EXTENSAO VARCHAR(150) NOT NULL,
	COD_CHAMADO INT NOT NULL,
	FOREIGN KEY (COD_CHAMADO)
		REFERENCES CHAMADO(COD_CHAMADO)
)
INSERT INTO PERFIL(NOME)
	VALUES
		('Admin'),
		('Usuario'),
		('Técnico')
	
INSERT INTO USUARIO(NOME, EMAIL, SENHA, COD_PERFIL, COD_IMAGEM)
	VALUES
		('AdiminEasy', 'adm', 'adm', 1,1),
		('TechEasy', 'tech', 'tech', 3,1),
		('UserEasy', 'user', 'user', 2,1)

	--	('Adimin','adimin@hotmail.com','adimin',1),
	--	('Ghostbursters','Ghostbursters@hotmail.com','ghostbursters',1),
	--	('Pedro hb', 'pedro@live.com', '123456', 2)

SELECT * FROM PERFIL
SELECT * FROM IMAGEM
SELECT * FROM USUARIO
SELECT * FROM CATEGORIA
SELECT * FROM _STATUS
SELECT * FROM ANEXO
SELECT * FROM CHAMADO

INSERT INTO CATEGORIA(NOME)
	VALUES 
		('Geral'),
		('Servidor'),
		('Internet/Firewall'),
		('Acesso'),
		('Banco de dados'),
		('Hardware'),
		('Nao faco ideia so vem arrumar')

INSERT INTO _STATUS(NOME)
	VALUES 
		('Aguardando Atendimento'),
		('Passado para o Técnico '),
		('Pronto')


--DROP TABLE CHAMADO 
--DROP TABLE ANEXO

UPDATE USUARIO
	SET COD_PERFIL = 2
	WHERE COD_USUARIO = 9
	