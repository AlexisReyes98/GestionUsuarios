CREATE DATABASE gestion_usuarios;

USE gestion_usuarios;

CREATE TABLE usuarios(
	id int not null auto_increment,
    nombre varchar(80) not null,
    apellido varchar(80) not null,
    fecha_nacimiento datetime null,
    primary key (id)
);

DROP TABLE usuarios;

ALTER TABLE usuarios ADD COLUMN telefono varchar(50) NULL;
ALTER TABLE usuarios MODIFY COLUMN telefono varchar(30) NULL;

INSERT INTO usuarios(nombre,apellido,fecha_nacimiento,telefono) VALUES('Alexis','Reyes','1998-05-29','12345');
SELECT *FROM usuarios;
UPDATE usuarios SET fecha_nacimiento = '1998-05-29 18:00:00' WHERE id=1;
DELETE FROM usuarios WHERE id=1;

SELECT COUNT(*) AS 'Cantidad' FROM usuarios WHERE apellido='Reyes' AND nombre='Alexis';

SELECT *FROM usuarios WHERE nombre LIKE 'Ale%';

CREATE TABLE publicaciones(
	id int not null auto_increment,
    autor_id int not null,
    titulo varchar(150) not null,
    texto text not null,
    primary key (id),
    foreign key (autor_id) references usuarios(id)
);

CREATE TABLE clientes(
	id int not null auto_increment,
    nombre varchar(60) not null,
    apellido varchar(60) not null,
    telefono varchar(40) null,
    credit_card varchar(40) null,
    primary key (id)
);
SELECT *FROM clientes;
INSERT INTO clientes(id,nombre,apellido,telefono,credit_card) VALUES(NULL,'Alexis','Reyes','5555','12345');
DELETE FROM clientes WHERE clientes.id = 2;
