-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2024 at 06:30 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gym`
--

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

CREATE TABLE `equipment` (
  `id` int(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `cost` int(100) NOT NULL,
  `ddate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`id`, `name`, `cost`, `ddate`) VALUES
(1, 'eee', 333, '2024-04-03'),
(2, 'rr', 44, '2024-04-04');

-- --------------------------------------------------------

--
-- Table structure for table `fees`
--

CREATE TABLE `fees` (
  `id` int(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `amount` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fees`
--

INSERT INTO `fees` (`id`, `name`, `amount`) VALUES
(4, 'r', 4);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `phone` int(50) NOT NULL,
  `gender` bit(50) NOT NULL,
  `age` date NOT NULL,
  `gymtime` varchar(100) NOT NULL,
  `joindate` date NOT NULL,
  `city` varchar(50) NOT NULL,
  `membership` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`id`, `fname`, `lname`, `phone`, `gender`, `age`, `gymtime`, `joindate`, `city`, `membership`) VALUES
(1, 'ss', 'ss', 0, b'00010001100110010101101101011000010110110001100101', '0000-00-00', '5.00 - 6.00 P.M', '0000-00-00', 's', '1 Month'),
(2, 'd', 'd', 0, b'00000000000000000001001101011000010110110001100101', '0000-00-00', '6.00 - 7.00 P.M', '2024-04-15', 'd', '4 Month'),
(3, 'd', 'd', 0, b'00000000000000000001001101011000010110110001100101', '0000-00-00', '6.00 - 7.00 P.M', '2024-04-15', 'd', '4 Month'),
(4, 'e', 'e', 0, b'00010001100110010101101101011000010110110001100101', '2024-04-19', '6.00 - 7.00 P.M', '2024-04-12', 'e', '2 Month'),
(5, 'pp', 'jj', 0, b'00010001100110010101101101011000010110110001100101', '2024-04-18', '6.00 - 7.00 A.M', '2024-04-16', 'oo', '3 Month'),
(6, 'l,l', 'pp', 0, b'00010001100110010101101101011000010110110001100101', '2024-04-03', '6.00 - 7.00 P.M', '2024-04-18', 'kko', '3 Month'),
(7, 'sss', 'ww', 88, b'00000000000000000001001101011000010110110001100101', '2024-04-03', '6.00 - 7.00 A.M', '2024-04-02', 'ww', '2 Month');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `id` int(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` int(100) NOT NULL,
  `gender` bit(5) NOT NULL,
  `jdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `name`, `phone`, `gender`, `jdate`) VALUES
(1, 'ff', 0, b'11111', '2024-04-04'),
(2, 'ff', 0, b'11111', '2024-04-09'),
(3, 'gg', 667, b'11111', '2024-04-03'),
(4, 'dee', 0, b'11111', '2024-04-02');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `fees`
--
ALTER TABLE `fees`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `equipment`
--
ALTER TABLE `equipment`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
