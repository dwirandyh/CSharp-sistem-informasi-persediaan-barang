/*
SQLyog Ultimate v10.42 
MySQL - 5.6.21-log : Database - jotun
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `barang` */

DROP TABLE IF EXISTS `barang`;

CREATE TABLE `barang` (
  `kd_barang` char(7) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `no_batch` varchar(40) DEFAULT NULL,
  `tipe` varchar(30) DEFAULT NULL,
  `ukuran` float(4,2) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `barang` */

insert  into `barang`(`kd_barang`,`nama`,`no_batch`,`tipe`,`ukuran`,`harga`,`stok`) values ('BRG0001','JOTA TC GLOSS BASE 3','','Gallon',6.50,60000,8),('BRG0002','JOTA TC GLOSS BASE 3','','PAIL',18.00,60000,32),('BRG0004','Jota A','1234','Gallon',4.00,130000,-6);

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `kd_customer` char(7) NOT NULL,
  `nama` varchar(40) DEFAULT NULL,
  `alamat` text,
  `no_telepon` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `status` varchar(18) DEFAULT NULL,
  `diskon` float(4,2) DEFAULT NULL,
  PRIMARY KEY (`kd_customer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `customer` */

insert  into `customer`(`kd_customer`,`nama`,`alamat`,`no_telepon`,`email`,`status`,`diskon`) values ('CST0001','dqw','ewq','0898321','dqw','Langganan',10.00),('CST0002','ewq','eqw','ewq','wq','Bukan Langganan',0.00),('CST0003','Eko Hendro','Bandar Lampung','08908989','eko@yahoo.co.id','Langgaan',10.00);

/*Table structure for table `detail_invoice` */

DROP TABLE IF EXISTS `detail_invoice`;

CREATE TABLE `detail_invoice` (
  `kd_detail_invoice` int(11) NOT NULL AUTO_INCREMENT,
  `no_invoice` char(20) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `liter` float(4,2) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_invoice`),
  KEY `no_invoice` (`no_invoice`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `detail_invoice_ibfk_1` FOREIGN KEY (`no_invoice`) REFERENCES `invoice` (`no_invoice`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_invoice_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

/*Data for the table `detail_invoice` */

insert  into `detail_invoice`(`kd_detail_invoice`,`no_invoice`,`kd_barang`,`qty`,`liter`,`harga`,`total`) values (25,'IN20151113-0001','BRG0001',2,13.00,60000,780000),(26,'IN20151113-0001','BRG0004',3,12.00,130000,1560000),(27,'IN20151113-0002','BRG0001',2,13.00,60000,780000),(28,'IN20151113-0002','BRG0002',2,36.00,60000,2160000),(29,'IN20151113-0003','BRG0001',1,6.00,60000,390000),(30,'IN20151113-0003','BRG0001',2,13.00,60000,780000);

/*Table structure for table `detail_penerimaan` */

DROP TABLE IF EXISTS `detail_penerimaan`;

CREATE TABLE `detail_penerimaan` (
  `kd_detail_penerimaan` int(11) NOT NULL AUTO_INCREMENT,
  `no_penerimaan` varchar(30) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `ukuran` float(4,2) DEFAULT NULL,
  `total` float(11,2) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_penerimaan`),
  KEY `no_penerimaan` (`no_penerimaan`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `detail_penerimaan_ibfk_1` FOREIGN KEY (`no_penerimaan`) REFERENCES `penerimaan` (`no_penerimaan`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_penerimaan_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `detail_penerimaan` */

insert  into `detail_penerimaan`(`kd_detail_penerimaan`,`no_penerimaan`,`kd_barang`,`qty`,`ukuran`,`total`) values (5,'ewq','BRG0001',1,6.50,0.00),(6,'ewq','BRG0002',2,18.00,0.00),(7,'125','BRG0001',1,6.50,0.00),(8,'125','BRG0002',2,18.00,0.00),(9,'1241253','BRG0001',2,6.50,13.00),(10,'1241253','BRG0002',3,18.00,54.00),(11,'524','BRG0002',3,18.00,54.00),(12,'524','BRG0004',4,4.00,16.00);

/*Table structure for table `detail_po` */

DROP TABLE IF EXISTS `detail_po`;

CREATE TABLE `detail_po` (
  `kd_detail_po` int(11) NOT NULL AUTO_INCREMENT,
  `no_po` varchar(30) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `liter` float(4,2) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_po`),
  KEY `no_po` (`no_po`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `detail_po_ibfk_1` FOREIGN KEY (`no_po`) REFERENCES `po` (`no_po`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_po_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `detail_po` */

insert  into `detail_po`(`kd_detail_po`,`no_po`,`kd_barang`,`qty`,`liter`,`harga`,`total`) values (1,'1241','BRG0001',3,20.00,60000,1170000),(4,'2425','BRG0001',2,13.00,60000,780000),(5,'2425','BRG0002',2,36.00,60000,2160000),(12,'44444','BRG0001',2,13.00,60000,780000),(13,'44444','BRG0004',3,12.00,130000,1560000),(14,'542412','BRG0001',1,6.00,60000,390000),(15,'542412','BRG0001',2,13.00,60000,780000);

/*Table structure for table `detail_po_pusat` */

DROP TABLE IF EXISTS `detail_po_pusat`;

CREATE TABLE `detail_po_pusat` (
  `kd_detail_po_pusat` int(11) NOT NULL AUTO_INCREMENT,
  `no_po` char(20) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `liter` float(4,2) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_po_pusat`),
  KEY `kd_barang` (`kd_barang`),
  KEY `no_po` (`no_po`),
  CONSTRAINT `detail_po_pusat_ibfk_1` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_po_pusat_ibfk_2` FOREIGN KEY (`no_po`) REFERENCES `po_pusat` (`no_po`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `detail_po_pusat` */

insert  into `detail_po_pusat`(`kd_detail_po_pusat`,`no_po`,`kd_barang`,`qty`,`liter`,`harga`,`total`) values (9,'PO20151113-0001','BRG0001',2,13.00,60000,780000),(10,'PO20151113-0001','BRG0004',1,20.00,130000,2600000),(11,'PO20151113-0002','BRG0001',1,6.00,60000,390000),(12,'PO20151113-0002','BRG0004',5,20.00,130000,2600000);

/*Table structure for table `detail_surat_jalan` */

DROP TABLE IF EXISTS `detail_surat_jalan`;

CREATE TABLE `detail_surat_jalan` (
  `kd_detail_surat_jalan` int(11) NOT NULL AUTO_INCREMENT,
  `no_surat_jalan` char(20) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `ukuran` float(4,2) DEFAULT NULL,
  `total_ukuran` float(4,2) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_surat_jalan`),
  KEY `no_surat_jalan` (`no_surat_jalan`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `detail_surat_jalan_ibfk_1` FOREIGN KEY (`no_surat_jalan`) REFERENCES `surat_jalan` (`no_surat_jalan`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_surat_jalan_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

/*Data for the table `detail_surat_jalan` */

insert  into `detail_surat_jalan`(`kd_detail_surat_jalan`,`no_surat_jalan`,`kd_barang`,`qty`,`ukuran`,`total_ukuran`) values (2,'SJ20151109-0001','BRG0001',2,6.50,13.00),(3,'SJ20151109-0001','BRG0002',2,18.00,36.00),(4,'SJ20151110-0002','BRG0001',2,6.50,13.00),(5,'SJ20151110-0002','BRG0002',2,18.00,36.00),(6,'SJ20151110-0003','BRG0001',2,6.50,13.00),(7,'SJ20151110-0003','BRG0002',2,18.00,36.00),(8,'SJ20151110-0004','BRG0001',2,6.50,13.00),(9,'SJ20151110-0004','BRG0002',2,18.00,36.00),(10,'SJ20151110-0005','BRG0001',2,6.50,13.00),(11,'SJ20151110-0005','BRG0002',2,18.00,36.00),(12,'SJ20151110-0006','BRG0001',3,6.50,20.00),(13,'SJ20151110-0007','BRG0001',2,6.50,13.00),(14,'SJ20151110-0007','BRG0002',2,18.00,36.00),(15,'SJ20151113-0008','BRG0001',2,6.50,13.00),(16,'SJ20151113-0008','BRG0002',2,18.00,36.00),(17,'SJ20151113-0009','BRG0001',2,6.50,13.00),(18,'SJ20151113-0009','BRG0004',3,4.00,12.00),(19,'SJ20151113-0010','BRG0001',1,6.50,6.00),(20,'SJ20151113-0010','BRG0001',2,6.50,13.00);

/*Table structure for table `invoice` */

DROP TABLE IF EXISTS `invoice`;

CREATE TABLE `invoice` (
  `no_invoice` char(20) NOT NULL,
  `tgl` datetime DEFAULT NULL,
  `no_surat_jalan` char(20) DEFAULT NULL,
  `kd_customer` char(7) DEFAULT NULL,
  `total_liter` float(4,2) DEFAULT NULL,
  `diskon` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `total_bayar` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_invoice`),
  KEY `kd_customer` (`kd_customer`),
  KEY `no_sj` (`no_surat_jalan`),
  CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`kd_customer`) REFERENCES `customer` (`kd_customer`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`no_surat_jalan`) REFERENCES `surat_jalan` (`no_surat_jalan`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `invoice` */

insert  into `invoice`(`no_invoice`,`tgl`,`no_surat_jalan`,`kd_customer`,`total_liter`,`diskon`,`total`,`total_bayar`) values ('IN20151113-0001','2015-11-13 15:52:39','SJ20151113-0009','CST0001',25.00,0,2340000,2106000),('IN20151113-0002','2015-11-13 15:54:46','SJ20151109-0001','CST0001',49.00,294000,2940000,2646000),('IN20151113-0003','2015-11-13 16:57:30','SJ20151113-0010','CST0003',19.00,117000,1170000,1053000);

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `kd_karyawan` char(7) NOT NULL,
  `nama` varchar(40) DEFAULT NULL,
  `no_telepon` varchar(20) DEFAULT NULL,
  `alamat` text,
  `email` varchar(50) DEFAULT NULL,
  `hak_akses` varchar(20) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `karyawan` */

insert  into `karyawan`(`kd_karyawan`,`nama`,`no_telepon`,`alamat`,`email`,`hak_akses`,`username`,`password`) values ('KRY0001','Dwi Randy Herdinanto','088989','Alamat','email@yahoo.com','Gudang','root','root'),('KRY0002','Eko Hendro Wicaksono','0898989','Bandar Lampugn','email@yahoo.com','Pimpinan','eko','eko'),('KRY0003','Rizki','08989','Bandar Lmapung','riz@agdasg.com','Gudang','rizki','rizki');

/*Table structure for table `penerimaan` */

DROP TABLE IF EXISTS `penerimaan`;

CREATE TABLE `penerimaan` (
  `no_penerimaan` varchar(30) NOT NULL,
  `date` date DEFAULT NULL,
  `order_date` date DEFAULT NULL,
  `delivery_date` date DEFAULT NULL,
  `incoterm` varchar(30) DEFAULT NULL,
  `order_number` int(11) DEFAULT NULL,
  `ship_from` varchar(20) DEFAULT NULL,
  `haulier` varchar(40) DEFAULT NULL,
  `vat_reg` varchar(40) DEFAULT NULL,
  `ship_to` varchar(20) DEFAULT NULL,
  `total_liter` float(11,2) DEFAULT NULL,
  `total_qty` float(11,2) DEFAULT NULL,
  PRIMARY KEY (`no_penerimaan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `penerimaan` */

insert  into `penerimaan`(`no_penerimaan`,`date`,`order_date`,`delivery_date`,`incoterm`,`order_number`,`ship_from`,`haulier`,`vat_reg`,`ship_to`,`total_liter`,`total_qty`) values ('1241253','2015-11-13','2015-11-13','2015-11-13','incoterm',1234,'-','SHL-',NULL,'-',67.00,5.00),('125','2015-11-10','2015-11-10','2015-11-10','incoterm',12,'ship','company',NULL,'ship_to',42.50,3.00),('524','2015-11-13','2015-11-13','2015-11-13','-',4232,'-','-',NULL,'-',70.00,7.00),('ewq','2015-11-10','2015-11-10','2015-11-10','',24232,'','',NULL,'',42.50,3.00);

/*Table structure for table `po` */

DROP TABLE IF EXISTS `po`;

CREATE TABLE `po` (
  `no_po` varchar(30) NOT NULL,
  `kd_customer` char(7) DEFAULT NULL,
  `tgl` date DEFAULT NULL,
  `term` varchar(30) DEFAULT NULL,
  `project` varchar(40) DEFAULT NULL,
  `sub_total` int(11) DEFAULT NULL,
  `ppn` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_po`),
  KEY `kd_customer` (`kd_customer`),
  CONSTRAINT `po_ibfk_1` FOREIGN KEY (`kd_customer`) REFERENCES `customer` (`kd_customer`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `po` */

insert  into `po`(`no_po`,`kd_customer`,`tgl`,`term`,`project`,`sub_total`,`ppn`,`total`) values ('1241','CST0002','2015-11-05','term','project',1170000,117000,1287000),('2425','CST0001','2015-11-05','term','project',2940000,294000,3234000),('44444','CST0001','2015-11-13','-','-',2340000,234000,2574000),('542412','CST0003','2015-11-13','','',1170000,117000,1287000);

/*Table structure for table `po_pusat` */

DROP TABLE IF EXISTS `po_pusat`;

CREATE TABLE `po_pusat` (
  `no_po` char(20) NOT NULL,
  `tgl` datetime DEFAULT NULL,
  `project` varchar(40) DEFAULT NULL,
  `term` varchar(30) DEFAULT NULL,
  `sub_total` int(11) DEFAULT NULL,
  `ppn` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_po`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `po_pusat` */

insert  into `po_pusat`(`no_po`,`tgl`,`project`,`term`,`sub_total`,`ppn`,`total`) values ('PO20151113-0001','2015-11-13 21:53:05','60 day','-',3380000,338000,3718000),('PO20151113-0002','2015-11-13 21:56:28','60 day','term',2990000,299000,3289000);

/*Table structure for table `surat_jalan` */

DROP TABLE IF EXISTS `surat_jalan`;

CREATE TABLE `surat_jalan` (
  `no_surat_jalan` char(20) NOT NULL,
  `no_po` varchar(30) DEFAULT NULL,
  `kd_customer` char(7) DEFAULT NULL,
  `tgl` datetime DEFAULT NULL,
  `total_ukuran` float(4,2) DEFAULT NULL,
  `po_pr` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`no_surat_jalan`),
  KEY `no_po` (`no_po`),
  KEY `kd_customer` (`kd_customer`),
  CONSTRAINT `surat_jalan_ibfk_2` FOREIGN KEY (`no_po`) REFERENCES `po` (`no_po`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `surat_jalan_ibfk_3` FOREIGN KEY (`kd_customer`) REFERENCES `customer` (`kd_customer`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `surat_jalan` */

insert  into `surat_jalan`(`no_surat_jalan`,`no_po`,`kd_customer`,`tgl`,`total_ukuran`,`po_pr`) values ('SJ20151109-0001','2425','CST0001','2015-11-09 17:37:34',49.00,''),('SJ20151110-0002','2425','CST0001','2015-11-10 08:17:02',49.00,''),('SJ20151110-0003','2425','CST0001','2015-11-10 08:20:08',49.00,'no pr edit'),('SJ20151110-0004','2425','CST0001','2015-11-10 08:21:58',49.00,'po pr edit'),('SJ20151110-0005','2425','CST0001','2015-11-10 08:49:15',49.00,'po pr'),('SJ20151110-0006','1241','CST0002','2015-11-10 14:42:52',20.00,'po pr'),('SJ20151110-0007','2425','CST0001','2015-11-10 17:14:54',49.00,''),('SJ20151113-0008','2425','CST0001','2015-11-13 07:50:26',49.00,'12'),('SJ20151113-0009','44444','CST0001','2015-11-13 13:52:51',25.00,'-'),('SJ20151113-0010','542412','CST0003','2015-11-13 16:56:58',19.00,'');

/* Trigger structure for table `detail_invoice` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `detail_invoice_ai` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `detail_invoice_ai` AFTER INSERT ON `detail_invoice` FOR EACH ROW BEGIN
	update barang set barang.`stok` = barang.stok - new.qty where barang.`kd_barang`=new.kd_barang;
    END */$$


DELIMITER ;

/* Trigger structure for table `detail_penerimaan` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `detail_penerimaan_ai` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `detail_penerimaan_ai` AFTER INSERT ON `detail_penerimaan` FOR EACH ROW BEGIN
	update barang set barang.`stok`=barang.`stok` + new.qty where barang.`kd_barang`=new.kd_barang;
    END */$$


DELIMITER ;

/* Procedure structure for procedure `penomoran` */

/*!50003 DROP PROCEDURE IF EXISTS  `penomoran` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `penomoran`(IN kode VARCHAR(5), IN tabel VARCHAR(20), IN pk VARCHAR(20))
BEGIN
	SET @no_urut = '';
	SET @query = CONCAT_WS('','select right(',pk,',4) as penomoran into @no_urut from ',tabel,' where left(',pk,',3)="',kode,'" order by ',pk,' desc limit 0,1');
	
	PREPARE stmt FROM @query;
	EXECUTE stmt;
	DEALLOCATE PREPARE stmt;
	IF @no_urut IS NULL THEN
		SET @no_urut = CONCAT(kode,'0001');
	ELSE
		SET @no_urut = CONCAT(kode, RIGHT(CONCAT('0000', @no_urut + 1), 4));
	END IF;
	SELECT @no_urut;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `penomoran_transaksi` */

/*!50003 DROP PROCEDURE IF EXISTS  `penomoran_transaksi` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `penomoran_transaksi`(IN kode VARCHAR(4), tabel VARCHAR(20), pk VARCHAR(20))
BEGIN
	SET @no_urut = '';
	SET @hitung = '';
	SET @jumlah = LENGTH(kode);
	SET @query = CONCAT_WS('','select right(',pk,',4) as penomoran into @no_urut from ',tabel,' where left(',pk,',',@jumlah,')="',kode,'" order by ',pk,' desc limit 0,1');
	
	PREPARE stmt FROM @query;
	EXECUTE stmt;
	DEALLOCATE PREPARE stmt;
	IF @no_urut IS NULL THEN
		SET @no_urut = CONCAT(kode,DATE_FORMAT(NOW(),'%Y%m%d'),"-0001");
	ELSE 
		SET @hitung = CONCAT("0000",@no_urut + 1);
		SET @no_urut = CONCAT(kode,DATE_FORMAT(NOW(),'%Y%m%d'),'-',RIGHT(@hitung,4));
	END IF;
	SELECT @no_urut;
END */$$
DELIMITER ;

/*Table structure for table `view_barang` */

DROP TABLE IF EXISTS `view_barang`;

/*!50001 DROP VIEW IF EXISTS `view_barang` */;
/*!50001 DROP TABLE IF EXISTS `view_barang` */;

/*!50001 CREATE TABLE  `view_barang`(
 `kd_barang` char(7) ,
 `nama` varchar(50) ,
 `no_batch` varchar(40) ,
 `tipe` varchar(30) ,
 `ukuran` float(4,2) ,
 `harga` int(11) ,
 `stok` int(11) ,
 `terjual` decimal(32,0) 
)*/;

/*View structure for view view_barang */

/*!50001 DROP TABLE IF EXISTS `view_barang` */;
/*!50001 DROP VIEW IF EXISTS `view_barang` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_barang` AS select `barang`.`kd_barang` AS `kd_barang`,`barang`.`nama` AS `nama`,`barang`.`no_batch` AS `no_batch`,`barang`.`tipe` AS `tipe`,`barang`.`ukuran` AS `ukuran`,`barang`.`harga` AS `harga`,`barang`.`stok` AS `stok`,sum(`detail_invoice`.`qty`) AS `terjual` from (`barang` join `detail_invoice` on((`barang`.`kd_barang` = `detail_invoice`.`kd_barang`))) group by `barang`.`kd_barang` */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
