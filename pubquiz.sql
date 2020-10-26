-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 08 sep 2020 om 11:08
-- Serverversie: 10.3.15-MariaDB
-- PHP-versie: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pubquiz`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `awnser`
--

CREATE TABLE `awnser` (
  `awnser_id` int(11) NOT NULL,
  `question_id` int(11) NOT NULL,
  `awnser` text NOT NULL,
  `trueFalse` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `awnser`
--

INSERT INTO `awnser` (`awnser_id`, `question_id`, `awnser`, `trueFalse`) VALUES
(1, 1, '1915', 1),
(2, 1, '1918', 0),
(3, 1, '1925', 0),
(4, 1, '1953', 0),
(6, 3, 'Overijssel', 0),
(11, 5, 'Koeien', 0),
(12, 5, 'Vogels', 0),
(16, 3, 'Utrecht', 0),
(21, 3, 'Gelderland', 1),
(23, 3, 'Zeeland', 0),
(29, 5, 'Kippen', 1),
(30, 7, 'Lekker', 0),
(31, 7, 'Heel lekker', 0),
(32, 7, 'Super lekker', 1),
(33, 7, 'vies', 0),
(34, 5, 'Varkens', 0),
(36, 11, '12.000', 0),
(37, 11, '14.000', 1),
(38, 11, '16.000', 0),
(39, 11, '20.000', 0),
(40, 12, '1', 0),
(41, 12, '2', 0),
(42, 12, '3', 1),
(43, 12, '4', 0),
(44, 13, 'Tussen de 120 en 140', 0),
(45, 13, 'Tussen de 140 en 160', 0),
(46, 13, 'Tussen de 160 en 180', 0),
(47, 13, 'Tussen de 180 en 200', 1),
(48, 14, '1852', 1),
(49, 14, '1856', 0),
(50, 14, '1872', 0),
(51, 14, 'Kasteel de schaffelaar bestaat helemaal niet', 0),
(52, 15, '63', 0),
(53, 15, '78', 0),
(54, 15, '85', 0),
(55, 15, '94', 1),
(56, 16, '5', 0),
(57, 16, '7', 0),
(58, 16, '9', 0),
(59, 16, '10', 1),
(60, 17, 'Asje van Dijk', 1),
(61, 17, 'Jos Houben', 0),
(62, 17, 'Lucas Bolsius', 0),
(63, 17, 'Rene Verhulst', 0),
(64, 18, 'Geen', 0),
(65, 18, '1', 0),
(66, 18, '2', 1),
(68, 18, '3', 0),
(73, 19, 'Grand Prestige', 1),
(74, 19, 'Hefstbok', 0),
(75, 19, 'Karakter', 0),
(76, 19, 'Tripel', 0),
(77, 20, 'Venlo', 0),
(78, 20, 'Eindhoven', 0),
(79, 20, 'Deurne', 0),
(80, 20, 'Arcen', 1),
(81, 21, '6 liter', 0),
(82, 21, '7,2 liter', 1),
(83, 21, '7,92 liter', 0),
(84, 21, '8,4 liter', 0),
(85, 22, '1', 0),
(86, 22, '2', 0),
(87, 22, '4', 1),
(88, 22, '7', 0),
(89, 23, '6', 0),
(90, 23, '8', 0),
(91, 23, '10', 0),
(92, 23, '12', 1),
(93, 24, 'gelijk als je het koopt', 0),
(94, 24, '3 jaar laten rijpen', 0),
(95, 24, '6 jaar laten rijpen', 1),
(96, 24, '8 jaar laten rijpen', 0),
(97, 25, 'Sinds zomer 2018', 0),
(98, 25, 'Sinds begin 2019', 0),
(99, 25, 'Sinds eind 2019', 1),
(100, 25, 'Hertog Jan heeft geen alcoholvrij bier', 0),
(101, 26, 'paraplu', 0),
(102, 26, 'herenfiets', 0),
(103, 26, 'agenda', 1),
(104, 26, 'creditkaardhouder', 0),
(105, 27, '2', 1),
(106, 27, '4', 0),
(107, 27, '6', 0),
(108, 27, 'geen', 0),
(109, 28, 'roofvogel', 0),
(110, 28, 'uil', 1),
(111, 28, 'duif', 0),
(112, 28, 'zwaluw', 0),
(114, 29, '8', 0),
(115, 29, '10', 1),
(116, 29, '12', 0),
(117, 29, '14', 0),
(118, 30, 'laatste zondag van september', 0),
(119, 30, '28 september', 0),
(120, 30, '4 oktober', 1),
(121, 30, '9 oktober', 0),
(122, 31, 'Duitse herder', 0),
(123, 31, 'bloedhond', 1),
(124, 31, 'Mechelse herder', 0),
(125, 31, 'Grayhound', 0),
(126, 32, 'Canarische Eilanden', 1),
(127, 32, 'Brazilie', 0),
(128, 32, 'Australie', 0),
(129, 32, 'Panama', 0),
(130, 33, 'Grijs', 1),
(131, 33, 'Zwart', 0),
(132, 33, 'Wit-grijs', 0),
(133, 33, 'Donkerblauw', 0),
(134, 34, '28', 0),
(135, 34, '30', 0),
(136, 34, '32', 1),
(137, 34, '34', 0),
(138, 35, 'kever', 1),
(139, 35, 'wespen', 0),
(140, 35, 'mieren', 0),
(141, 35, 'schaap', 0),
(142, 36, 'Nederland', 0),
(143, 36, 'Australie', 1),
(144, 36, 'Zuid-Afrika', 0),
(145, 36, 'USA', 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `question`
--

CREATE TABLE `question` (
  `question_id` int(11) NOT NULL,
  `question` text NOT NULL,
  `quiz_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `question`
--

INSERT INTO `question` (`question_id`, `question`, `quiz_id`) VALUES
(1, 'In welk jaar is Hertog Jan opgericht?', 7),
(3, 'In welke provincie ligt Barneveld?', 1),
(5, 'Waar staat Barneveld bekend om?', 1),
(6, 'Hoeveel liter bier drinken Nederlanders per jaar per pesoon?', 2),
(8, 'Hoe oud is grolsch?', 10),
(9, 'Hoe lekker is bier?', 2),
(11, 'Hoeveel auto\'s zijn er geregistreerd in Barneveld(plaats)?', 1),
(12, 'Hoeveel treinstations heeft Barneveld?', 1),
(13, 'Hoeveel eieren kan een goede Barnevelder (Barneveldse kippenras) per jaar leggen?', 1),
(14, 'In welk jaar werd de eerste steen van kasteel de Schaffelaar gelegd?', 1),
(15, 'Hoeveel hectare grond heeft het schaffelaarse bos in Barneveld?', 1),
(16, 'Hoeveel supermarkten heeft de plaats Barneveld?', 1),
(17, 'Hoe heet de burgermeester van Barneveld?', 1),
(18, 'Hoeveel voetbalclubs heeft Barneveld?', 1),
(19, 'Welk bier van Hertog Jan is het zwaarst?', 7),
(20, 'Waar kun je de brouwerij van Hertog Jan bezoeken?', 7),
(21, 'Hoeveel liter bier zit er in een krat Hertog Jan?', 7),
(22, 'Hoeveel mensen hebben Hertog Jan opgericht?', 7),
(23, 'Hoeveel soorten bier heeft Hertog Jan momenteel in zijn assortiment?', 7),
(24, 'Na hoeveel jaar rijpen is de smaak van de Grand Prestige het beste?', 7),
(25, 'Sinds wanneer verkoopt Hertog Jan alcoholvrij bier?', 7),
(26, 'Wat verkoopt Hertog Jan NIET in hun webshop?', 7),
(27, 'Hoeveel vleugels heeft een mug?', 13),
(28, 'Wat voor soort vogel is de Amerikaanse oehoe?', 13),
(29, 'hoeveel poten heeft een kreeft?', 13),
(30, 'Wanneer is het dierendag?', 13),
(31, 'Welk soort hond wordt vaak gebruik bij opsporen van mensen?', 13),
(32, 'Waar komt de kanarie oorspronkelijk vandaag?', 13),
(33, 'Welke kleur heeft de zwarte neushoorn?', 13),
(34, 'Hoeveel tanden en kiezen heeft een schaap?', 13),
(35, 'Wat voor een soort dier is de wespenbok?', 13),
(36, 'Waar komt de grasparkiet in het wild voor?', 13);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quizname`
--

CREATE TABLE `quizname` (
  `quiz_id` int(11) NOT NULL,
  `quizName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `quizname`
--

INSERT INTO `quizname` (`quiz_id`, `quizName`) VALUES
(1, 'Barneveld\r\n'),
(7, 'Hertog Jan'),
(13, 'Dieren');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `awnser`
--
ALTER TABLE `awnser`
  ADD PRIMARY KEY (`awnser_id`);

--
-- Indexen voor tabel `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`question_id`);

--
-- Indexen voor tabel `quizname`
--
ALTER TABLE `quizname`
  ADD PRIMARY KEY (`quiz_id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `awnser`
--
ALTER TABLE `awnser`
  MODIFY `awnser_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=146;

--
-- AUTO_INCREMENT voor een tabel `question`
--
ALTER TABLE `question`
  MODIFY `question_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT voor een tabel `quizname`
--
ALTER TABLE `quizname`
  MODIFY `quiz_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
