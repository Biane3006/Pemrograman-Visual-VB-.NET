-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 17, 2023 at 04:23 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbApotekSamarinda`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `idAkun` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`idAkun`, `username`, `password`) VALUES
(0, 'Owner', 'Owner'),
(1, 'Syamsir', '12345'),
(2, 'Rhesa Binsar', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tbApoteker`
--

CREATE TABLE `tbApoteker` (
  `kodeApoteker` varchar(50) NOT NULL,
  `namaApoteker` varchar(255) NOT NULL,
  `jenisKelamin` varchar(20) NOT NULL,
  `usiaApoteker` int(10) NOT NULL,
  `nomorTelepon` varchar(15) NOT NULL,
  `alamatApoteker` varchar(255) NOT NULL,
  `idAkun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbApoteker`
--

INSERT INTO `tbApoteker` (`kodeApoteker`, `namaApoteker`, `jenisKelamin`, `usiaApoteker`, `nomorTelepon`, `alamatApoteker`, `idAkun`) VALUES
('APT-001', 'Syamsir', 'Laki-laki', 25, '081234567891', 'Jalan Manunggal', 1),
('APT-002', 'Rhesa Binsar', 'Laki-Laki', 27, '085511223366', 'Jalan Perjuangan Samarinda Sempaja', 2);

--
-- Triggers `tbApoteker`
--
DELIMITER $$
CREATE TRIGGER `Hapus_Akun_Melalui_DELETE_Apoteker` AFTER DELETE ON `tbApoteker` FOR EACH ROW DELETE FROM akun WHERE akun.idAkun = OLD.idAkun
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Tambah_Akun_Melalui_INSERT_Apoteker` AFTER INSERT ON `tbApoteker` FOR EACH ROW INSERT INTO akun SET akun.idAkun = NEW.idAkun,
    akun.username = NEW.namaApoteker, akun.password='12345'
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbDetailPembelian`
--

CREATE TABLE `tbDetailPembelian` (
  `kodePembelian` varchar(50) NOT NULL,
  `kodeObat` varchar(50) NOT NULL,
  `hargaSatuan` int(11) NOT NULL,
  `jumlahObat` int(20) NOT NULL,
  `totalHarga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbDetailPembelian`
--

INSERT INTO `tbDetailPembelian` (`kodePembelian`, `kodeObat`, `hargaSatuan`, `jumlahObat`, `totalHarga`) VALUES
('PMB-001', 'OBT-003', 3000, 10, 30000);

--
-- Triggers `tbDetailPembelian`
--
DELIMITER $$
CREATE TRIGGER `BeliObat_JumlahStokObatBertambah` AFTER INSERT ON `tbDetailPembelian` FOR EACH ROW UPDATE tbObat SET tbObat.jumlahStok = tbObat.jumlahStok + NEW.jumlahObat WHERE tbObat.kodeObat = NEW.kodeObat
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbDetailPenjualan`
--

CREATE TABLE `tbDetailPenjualan` (
  `kodePenjualan` varchar(50) NOT NULL,
  `kodeObat` varchar(50) NOT NULL,
  `hargaSatuan` int(11) NOT NULL,
  `jumlahObat` int(11) NOT NULL,
  `totalHarga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbDetailPenjualan`
--

INSERT INTO `tbDetailPenjualan` (`kodePenjualan`, `kodeObat`, `hargaSatuan`, `jumlahObat`, `totalHarga`) VALUES
('PNJ-001', 'OBT-001', 6000, 8, 48000),
('PNJ-001', 'OBT-003', 4000, 25, 10000),
('PMB-002', 'OBT-001', 6000, 10, 60000),
('PNJ-003', 'OBT-002', 6500, 8, 52000),
('PNJ-004', 'OBT-001', 6000, 7, 42000),
('PMB-004', 'OBT-001', 6000, 5, 30000);

--
-- Triggers `tbDetailPenjualan`
--
DELIMITER $$
CREATE TRIGGER `JualObat_StokObatBerkurang` AFTER INSERT ON `tbDetailPenjualan` FOR EACH ROW UPDATE tbObat SET tbObat.jumlahStok = tbObat.jumlahStok - NEW.jumlahObat WHERE tbObat.kodeObat = NEW.kodeObat
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbObat`
--

CREATE TABLE `tbObat` (
  `kodeObat` varchar(50) NOT NULL,
  `namaObat` varchar(100) NOT NULL,
  `jenisObat` varchar(10) NOT NULL,
  `golonganObat` varchar(10) NOT NULL,
  `hargaJualObat` int(12) NOT NULL,
  `hargaBeliObat` int(12) NOT NULL,
  `jumlahStok` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbObat`
--

INSERT INTO `tbObat` (`kodeObat`, `namaObat`, `jenisObat`, `golonganObat`, `hargaJualObat`, `hargaBeliObat`, `jumlahStok`) VALUES
('OBT-001', 'Bodreks', 'Kaplet', 'Terbatas', 6000, 6000, 5),
('OBT-002', 'Mixagrip', 'Tablet', 'Bebas', 6500, 6500, 50),
('OBT-003', 'Promag', 'Pil', 'Terbatas', 4000, 3000, 55);

-- --------------------------------------------------------

--
-- Table structure for table `tbPelanggan`
--

CREATE TABLE `tbPelanggan` (
  `kodePelanggan` varchar(50) NOT NULL,
  `namaPelanggan` varchar(255) NOT NULL,
  `jenisKelamin` varchar(10) NOT NULL,
  `alamatPelanggan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbPelanggan`
--

INSERT INTO `tbPelanggan` (`kodePelanggan`, `namaPelanggan`, `jenisKelamin`, `alamatPelanggan`) VALUES
('PLG-001', 'Syamsir', 'Laki-Laki', 'Jalan Manunggal Samarinda'),
('PLG-002', 'Muhammad Arif', 'Laki-Laki', 'Jalan Reel Sei Keledang RT.11 No.78 Kelurahan Mesjid');

-- --------------------------------------------------------

--
-- Table structure for table `tbPembelian`
--

CREATE TABLE `tbPembelian` (
  `kodePembelian` varchar(50) NOT NULL,
  `tanggalTransaksi` date NOT NULL,
  `kodeApoteker` varchar(50) NOT NULL,
  `kodeSupplier` varchar(50) NOT NULL,
  `totalPembayaran` int(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbPembelian`
--

INSERT INTO `tbPembelian` (`kodePembelian`, `tanggalTransaksi`, `kodeApoteker`, `kodeSupplier`, `totalPembayaran`) VALUES
('PMB-002', '2023-04-17', 'APT-001', 'SPL-003', 60000),
('PMB-004', '2023-04-17', 'APT-001', 'SPL-002', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `tbPenjualan`
--

CREATE TABLE `tbPenjualan` (
  `kodePenjualan` varchar(50) NOT NULL,
  `tanggalTransaksi` date NOT NULL,
  `kodeApoteker` varchar(50) NOT NULL,
  `kodePelanggan` varchar(50) NOT NULL,
  `totalPembayaran` int(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbPenjualan`
--

INSERT INTO `tbPenjualan` (`kodePenjualan`, `tanggalTransaksi`, `kodeApoteker`, `kodePelanggan`, `totalPembayaran`) VALUES
('PNJ-003', '2023-04-17', 'APT-001', 'PLG-002', 52000),
('PNJ-004', '2023-04-17', 'APT-001', 'PLG-002', 42000);

-- --------------------------------------------------------

--
-- Table structure for table `tbSupplier`
--

CREATE TABLE `tbSupplier` (
  `kodeSupplier` varchar(50) NOT NULL,
  `namaSupplier` varchar(255) NOT NULL,
  `namaPerusahaan` varchar(255) NOT NULL,
  `nomorTelepon` varchar(20) NOT NULL,
  `alamatPerusahaan` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbSupplier`
--

INSERT INTO `tbSupplier` (`kodeSupplier`, `namaSupplier`, `namaPerusahaan`, `nomorTelepon`, `alamatPerusahaan`) VALUES
('SPL-002', 'Filipus Adriel Manik', 'PT. OBAT-OBATAN', '082222222222', 'Jalan Pramuka Sempaja'),
('SPL-003', 'Nur Cahaya', 'PT.Matahari', '089999999', 'Jalan Mangkupalas Samarinda');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`idAkun`);

--
-- Indexes for table `tbApoteker`
--
ALTER TABLE `tbApoteker`
  ADD PRIMARY KEY (`kodeApoteker`),
  ADD UNIQUE KEY `idAkun` (`idAkun`);

--
-- Indexes for table `tbObat`
--
ALTER TABLE `tbObat`
  ADD PRIMARY KEY (`kodeObat`);

--
-- Indexes for table `tbPelanggan`
--
ALTER TABLE `tbPelanggan`
  ADD PRIMARY KEY (`kodePelanggan`);

--
-- Indexes for table `tbPenjualan`
--
ALTER TABLE `tbPenjualan`
  ADD PRIMARY KEY (`kodePenjualan`);

--
-- Indexes for table `tbSupplier`
--
ALTER TABLE `tbSupplier`
  ADD PRIMARY KEY (`kodeSupplier`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `idAkun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbApoteker`
--
ALTER TABLE `tbApoteker`
  MODIFY `idAkun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
