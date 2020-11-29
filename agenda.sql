drop database agenda;
create database agenda;
use agenda;

CREATE TABLE `profesional` (
  `id_profesional` int(15) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(15) DEFAULT NULL,
  `apellido` varchar(15) DEFAULT NULL,
  `documento_identidad` varchar(32) DEFAULT NULL,
  `documento_tipo` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_profesional`)
);

CREATE TABLE `visitante` (
  `id_visitante` int(15) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(15) DEFAULT NULL,
  `apellido` varchar(15) DEFAULT NULL,
  `documento_identidad` varchar(32) DEFAULT NULL,
  `documento_tipo` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_visitante`)
);

CREATE TABLE `telefono_profesional` (
  `id_profesional` int(15) NOT NULL AUTO_INCREMENT,
  `telefono` varchar(15) DEFAULT NULL,
  `tipo` varchar(15) DEFAULT NULL,
  FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`)ON DELETE CASCADE ON UPDATE CASCADE 
);

CREATE TABLE `telefono_visitante` (
  `id_visitante` int(15) NOT NULL AUTO_INCREMENT,
  `telefono` varchar(15) DEFAULT NULL,
  `tipo` varchar(15) DEFAULT NULL,
 FOREIGN KEY (`id_visitante`) REFERENCES `visitante` (`id_visitante`)ON DELETE CASCADE ON UPDATE CASCADE 
);

CREATE TABLE `dias` (
  `id_dias` int(15) NOT NULL,
  `dias` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_dias`)
);
CREATE TABLE `estado` (
  `id_estado` int(15) NOT NULL,
  `estado` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_estado`)
);

CREATE TABLE `disponibilidad` (
  `id_profesional` int(15) NOT NULL AUTO_INCREMENT,
  `id_dias` int(15) NOT NULL,
  `hora_inicio` varchar(15) DEFAULT NULL,
  `hora_fin` varchar(15) DEFAULT NULL,
  FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`)ON DELETE CASCADE,
  FOREIGN KEY (`id_dias`) REFERENCES `dias` (`id_dias`)ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE `generar` (
  `id_generar` int(11) NOT NULL AUTO_INCREMENT,
  `id_profesional` int(11) NOT NULL,
  `id_visitante` int(11) NOT NULL,
  `id_dias` int(15) NOT NULL,
  `hora` varchar(12) DEFAULT NULL,
  `fecha` varchar(12) DEFAULT NULL,
  `motivo` varchar(64) DEFAULT NULL,
   `id_estado` int(12) NOT NULL,
  `created_at` datetime DEFAULT NULL,
  PRIMARY KEY (`id_generar`),
  KEY `id_profesional` (`id_profesional`),
  KEY `id_visitante` (`id_visitante`),
  FOREIGN KEY (`id_dias`) REFERENCES `dias` (`id_dias`)ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`id_estado`) REFERENCES `estado` (`id_estado`)ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`)ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`id_visitante`) REFERENCES `visitante` (`id_visitante`)ON DELETE CASCADE ON UPDATE CASCADE
); 

insert into dias values(0,'Domingo');
insert into dias values(1,'Lunes');
insert into dias values(2,'Martes');
insert into dias values(3,'Miercoles');
insert into dias values(4,'Jueves');
insert into dias values(5,'Viernes');
insert into dias values(6,'Sabado');

insert into estado values(1,'Confirmada');
insert into estado values(2,'Realizada');
insert into estado values(3,'Pospuesta');
insert into estado values(4,'Cancelada')


