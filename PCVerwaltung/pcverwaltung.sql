-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 25. Nov 2022 um 10:17
-- Server-Version: 10.4.18-MariaDB
-- PHP-Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `pcverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `computer`
--

CREATE TABLE `computer` (
  `id` int(16) NOT NULL,
  `cpu_id` int(16) NOT NULL,
  `mainboard_id` int(16) NOT NULL,
  `ssd_id` int(16) NOT NULL,
  `monitor_id` int(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `cpu`
--

CREATE TABLE `cpu` (
  `idcpu` int(11) NOT NULL,
  `producer` varchar(45) DEFAULT NULL,
  `model` varchar(45) DEFAULT NULL,
  `frequence` double DEFAULT NULL,
  `price` double DEFAULT NULL,
  `cores` int(11) DEFAULT NULL,
  `cooling efficiency` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `cpu`
--

INSERT INTO `cpu` (`idcpu`, `producer`, `model`, `frequence`, `price`, `cores`, `cooling efficiency`) VALUES
(21, 'dwadwa', 'daw', 2.2, 123.12, 6, 75);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `finanzierung`
--

CREATE TABLE `finanzierung` (
  `id` int(11) NOT NULL,
  `runtime` int(11) NOT NULL,
  `rate` float NOT NULL,
  `finalcost` float NOT NULL,
  `kunden_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunden`
--

CREATE TABLE `kunden` (
  `id` int(11) NOT NULL,
  `fullname` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mainboard`
--

CREATE TABLE `mainboard` (
  `idmainboard` int(11) NOT NULL,
  `producer` varchar(45) DEFAULT NULL,
  `model` varchar(45) DEFAULT NULL,
  `architecture` varchar(45) DEFAULT NULL,
  `price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `monitor`
--

CREATE TABLE `monitor` (
  `idmonitor` int(11) NOT NULL,
  `producer` varchar(45) DEFAULT NULL,
  `model` varchar(45) DEFAULT NULL,
  `resolution` varchar(45) DEFAULT NULL,
  `price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `rechnungen`
--

CREATE TABLE `rechnungen` (
  `id` int(11) NOT NULL,
  `product` varchar(255) NOT NULL,
  `price` int(100) NOT NULL,
  `kunden_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ssd`
--

CREATE TABLE `ssd` (
  `idssd` int(11) NOT NULL,
  `producer` varchar(45) DEFAULT NULL,
  `model` varchar(45) DEFAULT NULL,
  `storage (GB)` double DEFAULT NULL,
  `price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `username` varchar(255) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `user`
--

INSERT INTO `user` (`username`, `fullname`, `password`, `role`) VALUES
('danascully', 'Dana Scully', '123', 'Sachbearbeitung'),
('foxmulder', 'Fox Mulder', '123', 'Hardwarespezialist'),
('johnbuyman', 'John Buyman', '123', 'Einkauf');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `computer`
--
ALTER TABLE `computer`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cpu_id` (`cpu_id`),
  ADD KEY `mainboard_id` (`mainboard_id`),
  ADD KEY `monitor_id` (`monitor_id`),
  ADD KEY `ssd_id` (`ssd_id`);

--
-- Indizes für die Tabelle `cpu`
--
ALTER TABLE `cpu`
  ADD PRIMARY KEY (`idcpu`);

--
-- Indizes für die Tabelle `finanzierung`
--
ALTER TABLE `finanzierung`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kunden_id` (`kunden_id`);

--
-- Indizes für die Tabelle `kunden`
--
ALTER TABLE `kunden`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `mainboard`
--
ALTER TABLE `mainboard`
  ADD PRIMARY KEY (`idmainboard`);

--
-- Indizes für die Tabelle `monitor`
--
ALTER TABLE `monitor`
  ADD PRIMARY KEY (`idmonitor`);

--
-- Indizes für die Tabelle `rechnungen`
--
ALTER TABLE `rechnungen`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kunden_id` (`kunden_id`);

--
-- Indizes für die Tabelle `ssd`
--
ALTER TABLE `ssd`
  ADD PRIMARY KEY (`idssd`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `computer`
--
ALTER TABLE `computer`
  MODIFY `id` int(16) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `cpu`
--
ALTER TABLE `cpu`
  MODIFY `idcpu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT für Tabelle `finanzierung`
--
ALTER TABLE `finanzierung`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `kunden`
--
ALTER TABLE `kunden`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `mainboard`
--
ALTER TABLE `mainboard`
  MODIFY `idmainboard` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT für Tabelle `monitor`
--
ALTER TABLE `monitor`
  MODIFY `idmonitor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT für Tabelle `rechnungen`
--
ALTER TABLE `rechnungen`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `ssd`
--
ALTER TABLE `ssd`
  MODIFY `idssd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `computer`
--
ALTER TABLE `computer`
  ADD CONSTRAINT `computer_ibfk_1` FOREIGN KEY (`cpu_id`) REFERENCES `cpu` (`idcpu`),
  ADD CONSTRAINT `computer_ibfk_2` FOREIGN KEY (`mainboard_id`) REFERENCES `mainboard` (`idmainboard`),
  ADD CONSTRAINT `computer_ibfk_3` FOREIGN KEY (`monitor_id`) REFERENCES `monitor` (`idmonitor`),
  ADD CONSTRAINT `computer_ibfk_4` FOREIGN KEY (`ssd_id`) REFERENCES `ssd` (`idssd`);

--
-- Constraints der Tabelle `finanzierung`
--
ALTER TABLE `finanzierung`
  ADD CONSTRAINT `finanzierung_ibfk_1` FOREIGN KEY (`kunden_id`) REFERENCES `kunden` (`id`);

--
-- Constraints der Tabelle `rechnungen`
--
ALTER TABLE `rechnungen`
  ADD CONSTRAINT `rechnungen_ibfk_1` FOREIGN KEY (`kunden_id`) REFERENCES `kunden` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
