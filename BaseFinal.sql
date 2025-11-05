-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para tablafinal
CREATE DATABASE IF NOT EXISTS `tablafinal` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `tablafinal`;

-- Volcando estructura para tabla tablafinal.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `IdCl` int(11) NOT NULL AUTO_INCREMENT,
  `Cliente` int(11) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Correo` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdCl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tablafinal.clientes: ~0 rows (aproximadamente)

-- Volcando estructura para tabla tablafinal.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `Idpr` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Categoria` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Idpr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tablafinal.productos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla tablafinal.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `IdV` int(11) NOT NULL AUTO_INCREMENT,
  `IdCl` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Total` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdV`),
  KEY `Ashe` (`IdCl`),
  CONSTRAINT `Ashe` FOREIGN KEY (`IdCl`) REFERENCES `clientes` (`IdCl`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tablafinal.ventas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla tablafinal.ventasist
CREATE TABLE IF NOT EXISTS `ventasist` (
  `IdVs` int(11) NOT NULL AUTO_INCREMENT,
  `Idpr` int(11) DEFAULT NULL,
  `idvt` int(11) DEFAULT NULL,
  `PrecioU` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `PrecioT` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdVs`),
  KEY `FK_ventasist_ventas` (`idvt`),
  KEY `FK_ventasist_productos` (`Idpr`),
  CONSTRAINT `FK_ventasist_productos` FOREIGN KEY (`Idpr`) REFERENCES `productos` (`Idpr`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ventasist_ventas` FOREIGN KEY (`idvt`) REFERENCES `ventas` (`IdV`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tablafinal.ventasist: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
