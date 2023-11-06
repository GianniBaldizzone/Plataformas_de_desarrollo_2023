-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `mydb` ;

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `categoria`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `categoria` ;

CREATE TABLE IF NOT EXISTS `categoria` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `esta_activo` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `subcategoria`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `subcategoria` ;

CREATE TABLE IF NOT EXISTS `subcategoria` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `categoria_id` INT NOT NULL,
  `esta_activo` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_subcategoria_categoria`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `categoria` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `producto` ;

CREATE TABLE IF NOT EXISTS `producto` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `descripción` VARCHAR(45) NULL,
  `precio` FLOAT NULL,
  `codigo` VARCHAR(45) NULL,
  `img` VARCHAR(45) NULL,
  `proovedor` VARCHAR(45) NULL,
  `subcategoria_id` INT NOT NULL,
  `categoria_id` INT NOT NULL,
  `talle` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_producto_subcategoria1`
    FOREIGN KEY (`subcategoria_id`)
    REFERENCES `subcategoria` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_categoria1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `categoria` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cliente` ;

CREATE TABLE IF NOT EXISTS `cliente` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `mail` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `direccion` VARCHAR(45) NULL,
  `dni` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `usuario` ;

CREATE TABLE IF NOT EXISTS `usuario` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `mail` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `direccion` VARCHAR(45) NULL,
  `dni` VARCHAR(45) NULL,
  `contraseña` VARCHAR(45) NULL,
  `rol` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `venta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `venta` ;

CREATE TABLE IF NOT EXISTS `venta` (
  `id` INT NOT NULL,
  `precio_total` FLOAT NULL,
  `fecha` DATE NULL,
  `metodo_de_pago` VARCHAR(45) NULL,
  `descuento` DOUBLE NULL,
  `cliente_id` INT NOT NULL,
  `usuario_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_venta_cliente1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `cliente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_venta_usuario1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `detalle_venta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `detalle_venta` ;

CREATE TABLE IF NOT EXISTS `detalle_venta` (
  `cantidad` INT NULL,
  `venta_id` INT NOT NULL,
  `producto_id` INT NOT NULL,
  CONSTRAINT `fk_detalle_venta_venta1`
    FOREIGN KEY (`venta_id`)
    REFERENCES `venta` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_venta_producto1`
    FOREIGN KEY (`producto_id`)
    REFERENCES `producto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `categoria`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `categoria` (`id`, `nombre`, `esta_activo`) VALUES (1, 'Peluches', 'Activa');

COMMIT;


-- -----------------------------------------------------
-- Data for table `subcategoria`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `subcategoria` (`id`, `nombre`, `categoria_id`, `esta_activo`) VALUES (1, 'Chiquitos', 1, 'Activa');

COMMIT;


-- -----------------------------------------------------
-- Data for table `producto`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `producto` (`id`, `nombre`, `descripción`, `precio`, `codigo`, `img`, `proovedor`, `subcategoria_id`, `categoria_id`, `talle`) VALUES (1, 'Muñeco generico', 'es un muñeco generico', 10000, '2345234567', 'imagen.jpg', 'Bandai', 1, 1, 'No tiene');

COMMIT;


-- -----------------------------------------------------
-- Data for table `usuario`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `usuario` (`id`, `nombre`, `apellido`, `mail`, `telefono`, `direccion`, `dni`, `contraseña`, `rol`) VALUES (1, 'Gianni', 'Baldizzone', 'gianni@gmail.com', '1145678907', 'Acoyte 420', '44891361', 'gianni123', 1);
INSERT INTO `usuario` (`id`, `nombre`, `apellido`, `mail`, `telefono`, `direccion`, `dni`, `contraseña`, `rol`) VALUES (2, 'Victoria', 'Troiano', 'vic@gmail.com', '1123456789', 'Billinghurst 234', '44567432', 'vic345', 2);

COMMIT;

