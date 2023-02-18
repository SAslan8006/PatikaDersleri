-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 31 Ara 2016, 18:46:15
-- Sunucu sürümü: 10.1.13-MariaDB
-- PHP Sürümü: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ders`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kisiler`
--

CREATE TABLE `kisiler` (
  `id` int(11) UNSIGNED NOT NULL,
  `isim` varchar(255) NOT NULL,
  `soyisim` varchar(255) NOT NULL,
  `yas` int(2) NOT NULL,
  `meslek` varchar(255) NOT NULL,
  `sehir` varchar(255) NOT NULL,
  `emailadresi` varchar(255) NOT NULL,
  `websitesiadresi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `kisiler`
--

INSERT INTO `kisiler` (`id`, `isim`, `soyisim`, `yas`, `meslek`, `sehir`, `emailadresi`, `websitesiadresi`) VALUES
(1, 'Volkan', 'Alakent', 36, 'Bilgisayar Yazılımcısı', 'İstanbul', 'info@extraegitim.com', 'http://www.extraegitim.com'),
(2, 'Hakan', 'Alakent', 38, 'Bölge Müdürü', 'İstanbul', 'hakanalakent@extraegitim.com', 'http://www.extraegitim.net'),
(3, 'Ümit', 'Okudan', 38, 'Müşteri Temsilcisi', 'Ankara', '', ''),
(4, 'Onur', 'Tatlı', 34, 'Müdür', 'İzmir', '', '');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kisiler`
--
ALTER TABLE `kisiler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kisiler`
--
ALTER TABLE `kisiler`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
