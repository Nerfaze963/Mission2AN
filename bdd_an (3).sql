-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 13 avr. 2024 à 13:59
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdd_an`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

DROP TABLE IF EXISTS `bateau`;
CREATE TABLE IF NOT EXISTS `bateau` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NOM` char(255) DEFAULT NULL,
  `LONGUEUR` double(5,2) DEFAULT NULL,
  `LARGEUR` double(5,2) DEFAULT NULL,
  `VITESSE` double(5,2) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `bateau_categorie`
--

DROP TABLE IF EXISTS `bateau_categorie`;
CREATE TABLE IF NOT EXISTS `bateau_categorie` (
  `CATEGORIE_ID` int NOT NULL,
  `BATEAU_ID` int NOT NULL,
  `CAPACITEMAX` bigint DEFAULT NULL,
  PRIMARY KEY (`CATEGORIE_ID`,`BATEAU_ID`),
  KEY `I_FK_BATEAU_CATEGORIE_CATEGORIE` (`CATEGORIE_ID`),
  KEY `I_FK_BATEAU_CATEGORIE_BATEAU` (`BATEAU_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `bateau_equipement`
--

DROP TABLE IF EXISTS `bateau_equipement`;
CREATE TABLE IF NOT EXISTS `bateau_equipement` (
  `EQUIPEMENT_ID` int NOT NULL,
  `BATEAU_ID` int NOT NULL,
  PRIMARY KEY (`EQUIPEMENT_ID`,`BATEAU_ID`),
  KEY `I_FK_BATEAU_EQUIPEMENT_EQUIPEMENT` (`EQUIPEMENT_ID`),
  KEY `I_FK_BATEAU_EQUIPEMENT_BATEAU` (`BATEAU_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `LIBELLE` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NOM` char(255) DEFAULT NULL,
  `PRENOM` char(255) DEFAULT NULL,
  `ADRESSE` char(255) DEFAULT NULL,
  `CP` bigint DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`ID`, `NOM`, `PRENOM`, `ADRESSE`, `CP`) VALUES
(1, 'Gadjadhar', NULL, 'boulevard picpus', 75012),
(2, 'Rondeau', NULL, 'unknown', 94081);

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

DROP TABLE IF EXISTS `equipement`;
CREATE TABLE IF NOT EXISTS `equipement` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

DROP TABLE IF EXISTS `liaison`;
CREATE TABLE IF NOT EXISTS `liaison` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `SECTEUR_ID` char(32) NOT NULL,
  `PORT_DEPART_ID` int NOT NULL,
  `PORT_ARRIVE_ID` int NOT NULL,
  `DUREE` time DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `I_FK_LIAISON_SECTEUR` (`SECTEUR_ID`),
  KEY `I_FK_LIAISON_PORT` (`PORT_DEPART_ID`),
  KEY `I_FK_LIAISON_PORT1` (`PORT_ARRIVE_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID`, `SECTEUR_ID`, `PORT_DEPART_ID`, `PORT_ARRIVE_ID`, `DUREE`) VALUES
(3, '2', 1, 4, '04:00:00'),
(5, '1', 1, 4, '04:00:00'),
(15, '2', 6, 4, '03:00:00'),
(16, '1', 3, 7, '02:00:00'),
(17, '1', 5, 8, '07:00:00'),
(19, '2', 3, 10, '06:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

DROP TABLE IF EXISTS `periode`;
CREATE TABLE IF NOT EXISTS `periode` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

DROP TABLE IF EXISTS `port`;
CREATE TABLE IF NOT EXISTS `port` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NOM` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`ID`, `NOM`) VALUES
(1, 'Palerme'),
(2, 'Ustica'),
(3, 'Stromboli'),
(4, 'Lipari'),
(11, 'Messine'),
(5, 'Trapani'),
(6, 'Milazzo'),
(7, 'Panarea'),
(8, 'Vulcano'),
(9, 'Pantellera'),
(10, 'Favignagna');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `ID` bigint NOT NULL AUTO_INCREMENT,
  `CLIENT_ID` int NOT NULL,
  `TRAVERSEE_ID` bigint NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `I_FK_RESERVATION_CLIENT` (`CLIENT_ID`),
  KEY `I_FK_RESERVATION_TRAVERSEE` (`TRAVERSEE_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `reservation_type`
--

DROP TABLE IF EXISTS `reservation_type`;
CREATE TABLE IF NOT EXISTS `reservation_type` (
  `TYPE_ID` int NOT NULL,
  `RESERVATION_ID` bigint NOT NULL,
  `QUANTITE` int DEFAULT NULL,
  PRIMARY KEY (`TYPE_ID`,`RESERVATION_ID`),
  KEY `I_FK_RESERVATION_TYPE_TYPE` (`TYPE_ID`),
  KEY `I_FK_RESERVATION_TYPE_RESERVATION` (`RESERVATION_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `ID` char(32) NOT NULL,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`ID`, `LIBELLE`) VALUES
('1', 'Palerme'),
('2', 'Messine');

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

DROP TABLE IF EXISTS `tarifer`;
CREATE TABLE IF NOT EXISTS `tarifer` (
  `PERIODE_ID` int NOT NULL,
  `TYPE_ID` int NOT NULL,
  `LIAISON_ID` char(32) NOT NULL,
  `TARIF` decimal(13,2) DEFAULT NULL,
  PRIMARY KEY (`PERIODE_ID`,`TYPE_ID`,`LIAISON_ID`),
  KEY `I_FK_TARIFER_PERIODE` (`PERIODE_ID`),
  KEY `I_FK_TARIFER_TYPE` (`TYPE_ID`),
  KEY `I_FK_TARIFER_LIAISON` (`LIAISON_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

DROP TABLE IF EXISTS `traversee`;
CREATE TABLE IF NOT EXISTS `traversee` (
  `ID` bigint NOT NULL AUTO_INCREMENT,
  `LIAISON_ID` char(32) NOT NULL,
  `BATEAU_ID` int NOT NULL,
  `DATE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `I_FK_TRAVERSEE_LIAISON` (`LIAISON_ID`),
  KEY `I_FK_TRAVERSEE_BATEAU` (`BATEAU_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `CATEGORIE_ID` int NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `I_FK_TYPE_CATEGORIE` (`CATEGORIE_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
