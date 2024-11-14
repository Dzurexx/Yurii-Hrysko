-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 08, 2023 at 10:09 AM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mobilebank`
--

-- --------------------------------------------------------

--
-- Table structure for table `bank_card`
--

CREATE TABLE `bank_card` (
  `id_bank_card` int(11) NOT NULL,
  `bank_card_type` varchar(50) NOT NULL,
  `bank_card_number` varchar(16) NOT NULL,
  `bank_cvv_code` varchar(3) NOT NULL,
  `bank_card_balance` int(11) NOT NULL,
  `bank_cark_currency` varchar(10) NOT NULL,
  `bank_card_paymentSystem` varchar(50) NOT NULL,
  `bank_card_date` date NOT NULL,
  `bank_card_pin` int(11) NOT NULL,
  `id_client` int(11) DEFAULT NULL,
  `id_credit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `id_client` int(1) NOT NULL,
  `client_last_name` varchar(50) NOT NULL,
  `client_first_name` varchar(50) NOT NULL,
  `client_middle_name` varchar(3) NOT NULL,
  `client_gender` varchar(256) NOT NULL,
  `client_email` varchar(50) NOT NULL,
  `client_phone_number` char(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `clientpersonalaccount`
--

CREATE TABLE `clientpersonalaccount` (
  `id_personal_account` int(11) NOT NULL,
  `personal_account` varchar(10) NOT NULL,
  `id_service` int(11) NOT NULL,
  `id_client` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `clientservices`
--

CREATE TABLE `clientservices` (
  `id_service` int(11) NOT NULL,
  `serviceName` varchar(100) NOT NULL,
  `serviceBalance` int(11) NOT NULL,
  `serviceType` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id_transaction` int(11) NOT NULL,
  `transaction_type` varchar(50) NOT NULL,
  `transaction_destination` varchar(200) NOT NULL,
  `transaction_date` date NOT NULL,
  `transaction_number` char(50) NOT NULL,
  `transaction_value` int(11) NOT NULL,
  `id_bank_card` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bank_card`
--
ALTER TABLE `bank_card`
  ADD PRIMARY KEY (`id_bank_card`),
  ADD UNIQUE KEY `id_credit` (`id_credit`),
  ADD KEY `id_client` (`id_client`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id_client`);

--
-- Indexes for table `clientpersonalaccount`
--
ALTER TABLE `clientpersonalaccount`
  ADD PRIMARY KEY (`id_personal_account`),
  ADD UNIQUE KEY `id_service` (`id_service`);

--
-- Indexes for table `clientservices`
--
ALTER TABLE `clientservices`
  ADD PRIMARY KEY (`id_service`);

--
-- Indexes for table `credits`
--
ALTER TABLE `credits`
  ADD PRIMARY KEY (`id_credit`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id_transaction`),
  ADD UNIQUE KEY `id_bank_card` (`id_bank_card`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `id_client` int(1) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bank_card`
--
ALTER TABLE `bank_card`
  ADD CONSTRAINT `bank_card_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `client` (`id_client`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `bank_card_ibfk_2` FOREIGN KEY (`id_bank_card`) REFERENCES `transaction` (`id_bank_card`),
  ADD CONSTRAINT `bank_card_ibfk_3` FOREIGN KEY (`id_credit`) REFERENCES `credits` (`id_credit`);

--
-- Constraints for table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `clientpersonalaccount` (`id_personal_account`);

--
-- Constraints for table `clientservices`
--
ALTER TABLE `clientservices`
  ADD CONSTRAINT `clientservices_ibfk_1` FOREIGN KEY (`id_service`) REFERENCES `clientpersonalaccount` (`id_service`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
