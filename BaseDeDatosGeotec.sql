--GO
--CREATE DATABASE GEOTEC


CREATE TABLE Color 
(
	Id INT  NOT NULL,
	Nombre varchar(100) NOT NULL,
	Descripcion varchar(500) NULL,
	CONSTRAINT PK_Id PRIMARY KEY( Id )
)

INSERT INTO Color
VALUES
(1,'ROJO','ROJO'),
(2,'AMARILLO','AMARILLO'),
(3,'VERDE','VERDE'),
(4,'AZUL','AZUL'),
(5,'GRIS','GRIS'),
(6,'NEGRO','NEGRO'),
(7,'BLANCO','BLANCO')

CREATE TABLE Marca
(
	Id int NOT NULL,
	Nombre varchar(100) NOT NULL,
	Descripcion varchar(500) NULL,
	CONSTRAINT PK_Id PRIMARY KEY( Id )
)

INSERT INTO Marca
VALUES
(1,'Nike',''),
(2,'Adidas',''),
(3,'Puma',''),
(4,'Topper','')

CREATE TABLE Talle
(
	Id INT NOT NULL,
	Nombre varchar(100) NOT NULL,
	Descripcion varchar(500) NULL,
	CONSTRAINT PK_Id PRIMARY KEY( Id )
)

INSERT INTO Talle
VALUES
(1,'S','Small'),
(2,'M','Medium'),
(3,'L','Large'),
(4,'XL','Extra Large')

CREATE TABLE Producto
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nombre varchar(100) NOT NULL,
	Descripcion varchar(500) NULL,
	Imagen varchar(max) NULL,
	Precio money NOT NULL,
	Marca_Id int FOREIGN KEY REFERENCES Marca(Id),
	Color_Id int FOREIGN KEY REFERENCES Color(Id),
	Talle_Id int FOREIGN KEY REFERENCES Talle(Id)
)

--DELETE FROM Color
--DELETE FROM Talle
--DELETE FROM Marca
--DELETE FROM Producto
--SELECT * FROM Color
--SELECT * FROM Talle
--SELECT * FROM Marca
INSERT INTO Producto
VALUES
('Remera','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s',
'https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_1536,h_1536/global/845895/06/fnd/ARG/fmt/png',200.50, 3,5,2),

('Remera','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s',
'https://ferreira.vteximg.com.br/arquivos/ids/331470-588-588/ni_aj7565010.jpg?v=637139552244370000',300, 1,6,1),

('Remera','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s',
'https://assets.adidas.com/images/w_600,f_auto,q_auto/c0b5234b4053469285dea83500d56eda_9366/Remera_3_Tiras_Blanco_CW1203_01_laydown.jpg',300, 2,7,3)




