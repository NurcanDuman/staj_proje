-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 30 Tem 2021, 07:51:06
-- Sunucu sürümü: 10.4.20-MariaDB
-- PHP Sürümü: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `cesme`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ayna_tas_malzeme`
--

CREATE TABLE `ayna_tas_malzeme` (
  `ayna_tas_malzeme_id` int(11) NOT NULL,
  `malzeme` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bulundugu_alan`
--

CREATE TABLE `bulundugu_alan` (
  `bulundugu_alan_id` int(11) NOT NULL,
  `alan` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cati_kaplama_m.`
--

CREATE TABLE `cati_kaplama_m.` (
  `cati_kaplama_id` int(11) NOT NULL,
  `kaplama` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cati_ortusu`
--

CREATE TABLE `cati_ortusu` (
  `cati_ortu_id` int(11) NOT NULL,
  `ortu` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cephe_orgu_m.`
--

CREATE TABLE `cephe_orgu_m.` (
  `cephe_orgu_malzeme_id` int(11) NOT NULL,
  `malzeme` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cesme`
--

CREATE TABLE `cesme` (
  `id` int(11) NOT NULL,
  `lat` int(11) NOT NULL,
  `lon` int(11) NOT NULL,
  `ad` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `bilgi_aciklama` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `mimarin_adi` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `stil_id` int(11) DEFAULT NULL,
  `mimari_tip_id` int(11) DEFAULT NULL,
  `yaptiran` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `hazne_sayisi` int(11) DEFAULT NULL,
  `hazne_yapim_malzeme_id` int(11) DEFAULT NULL,
  `hazne_cati_tipi_id` int(11) DEFAULT NULL,
  `hazne_cati_malzeme_id` int(11) DEFAULT NULL,
  `cesmenin_durumu_id` int(11) DEFAULT NULL,
  `sebeke_suyu` tinyint(1) DEFAULT NULL,
  `kaynak_suyu` tinyint(1) DEFAULT NULL,
  `kaynak_suyu_membagi` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `cephe_orgu_malzeme_id` int(11) DEFAULT NULL,
  `cati_kaplama_id` int(11) DEFAULT NULL,
  `cati_ortu_id` int(11) DEFAULT NULL,
  `sacak_durum_id` int(11) DEFAULT NULL,
  `sacak_ozellik_id` int(11) DEFAULT NULL,
  `bulundugu_alan_id` int(11) DEFAULT NULL,
  `konumu_id` int(11) DEFAULT NULL,
  `cephe_sayisi` int(11) DEFAULT NULL,
  `alinlik` tinyint(1) DEFAULT NULL,
  `silme` tinyint(1) DEFAULT NULL,
  `masrapalik_id` int(11) DEFAULT NULL,
  `lule_sayisi` int(11) DEFAULT NULL,
  `yalak_durumu` tinyint(1) DEFAULT NULL,
  `yalak_malzeme_id` int(11) DEFAULT NULL,
  `testilik` tinyint(1) DEFAULT NULL,
  `tugra` tinyint(1) DEFAULT NULL,
  `tugra_kime_ait` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `kemer` tinyint(1) DEFAULT NULL,
  `kemer_tip_id` int(11) DEFAULT NULL,
  `musluk` tinyint(1) DEFAULT NULL,
  `musluk_sayi` int(11) DEFAULT NULL,
  `ayna_tasi` tinyint(1) DEFAULT NULL,
  `ayna_tasi_sayisi` int(11) DEFAULT NULL,
  `ayna_tasi-malzeme_id` int(11) DEFAULT NULL,
  `cesmecik` tinyint(1) DEFAULT NULL,
  `cesmecik_sayi` int(11) DEFAULT NULL,
  `kitabe_sayi` int(11) DEFAULT NULL,
  `kitabe_malzeme_id` int(11) DEFAULT NULL,
  `kitabe_tercume` varchar(250) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `diger_bilgiler` varchar(250) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `resim` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `fiziki_durum`
--

CREATE TABLE `fiziki_durum` (
  `fiziki_durum_id` int(11) NOT NULL,
  `durum` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hazne_cati_m.`
--

CREATE TABLE `hazne_cati_m.` (
  `hazne_cati_malzeme_id` int(11) NOT NULL,
  `malz` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hazne_cati_tipi`
--

CREATE TABLE `hazne_cati_tipi` (
  `hazne_cati_tip_id` int(11) NOT NULL,
  `cati_tip` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hazne_yapi_m.`
--

CREATE TABLE `hazne_yapi_m.` (
  `hazne_yapi_malzeme_id` int(11) NOT NULL,
  `malzeme` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kemer_tip`
--

CREATE TABLE `kemer_tip` (
  `kemer_tip_id` int(11) NOT NULL,
  `tip` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kitabe_malzeme`
--

CREATE TABLE `kitabe_malzeme` (
  `kitabe_malzeme_id` int(11) NOT NULL,
  `malzeme` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `konum`
--

CREATE TABLE `konum` (
  `konum_id` int(11) NOT NULL,
  `konum` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `masrapalik`
--

CREATE TABLE `masrapalik` (
  `masrapalik_id` int(11) NOT NULL,
  `masrapalik` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `mimari_tipi`
--

CREATE TABLE `mimari_tipi` (
  `mimari_tip_id` int(11) NOT NULL,
  `tip` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sacak_durum`
--

CREATE TABLE `sacak_durum` (
  `sacak_durum_id` int(11) NOT NULL,
  `durum` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sacak_ozellik`
--

CREATE TABLE `sacak_ozellik` (
  `sacak_ozellik_id` int(11) NOT NULL,
  `ozellik` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `stil`
--

CREATE TABLE `stil` (
  `stil_id` int(11) NOT NULL,
  `stil` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yalak_malzeme`
--

CREATE TABLE `yalak_malzeme` (
  `yalak_malzeme_id` int(11) NOT NULL,
  `malzeme` varchar(50) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `ayna_tas_malzeme`
--
ALTER TABLE `ayna_tas_malzeme`
  ADD PRIMARY KEY (`ayna_tas_malzeme_id`);

--
-- Tablo için indeksler `bulundugu_alan`
--
ALTER TABLE `bulundugu_alan`
  ADD PRIMARY KEY (`bulundugu_alan_id`);

--
-- Tablo için indeksler `cati_kaplama_m.`
--
ALTER TABLE `cati_kaplama_m.`
  ADD PRIMARY KEY (`cati_kaplama_id`);

--
-- Tablo için indeksler `cati_ortusu`
--
ALTER TABLE `cati_ortusu`
  ADD PRIMARY KEY (`cati_ortu_id`);

--
-- Tablo için indeksler `cephe_orgu_m.`
--
ALTER TABLE `cephe_orgu_m.`
  ADD PRIMARY KEY (`cephe_orgu_malzeme_id`);

--
-- Tablo için indeksler `cesme`
--
ALTER TABLE `cesme`
  ADD PRIMARY KEY (`id`),
  ADD KEY `stil_id` (`stil_id`),
  ADD KEY `mimari_tip_id` (`mimari_tip_id`,`hazne_yapim_malzeme_id`,`hazne_cati_tipi_id`,`hazne_cati_malzeme_id`,`cesmenin_durumu_id`,`cephe_orgu_malzeme_id`,`cati_kaplama_id`,`cati_ortu_id`,`sacak_durum_id`,`sacak_ozellik_id`,`bulundugu_alan_id`,`konumu_id`,`masrapalik_id`,`yalak_malzeme_id`,`kemer_tip_id`,`ayna_tasi-malzeme_id`,`kitabe_malzeme_id`),
  ADD KEY `cati_kaplama_id` (`cati_kaplama_id`),
  ADD KEY `cesmenin_durumu_id` (`cesmenin_durumu_id`),
  ADD KEY `sacak_ozellik_id` (`sacak_ozellik_id`),
  ADD KEY `hazne_cati_tipi_id` (`hazne_cati_tipi_id`),
  ADD KEY `hazne_yapim_malzeme_id` (`hazne_yapim_malzeme_id`),
  ADD KEY `kitabe_malzeme_id` (`kitabe_malzeme_id`),
  ADD KEY `hazne_cati_malzeme_id` (`hazne_cati_malzeme_id`),
  ADD KEY `konumu_id` (`konumu_id`),
  ADD KEY `sacak_durum_id` (`sacak_durum_id`),
  ADD KEY `yalak_malzeme_id` (`yalak_malzeme_id`),
  ADD KEY `kemer_tip_id` (`kemer_tip_id`),
  ADD KEY `cati_ortu_id` (`cati_ortu_id`),
  ADD KEY `masrapalik_id` (`masrapalik_id`),
  ADD KEY `cephe_orgu_malzeme_id` (`cephe_orgu_malzeme_id`),
  ADD KEY `bulundugu_alan_id` (`bulundugu_alan_id`),
  ADD KEY `ayna_tasi-malzeme_id` (`ayna_tasi-malzeme_id`),
  ADD KEY `mimari_tip_id_2` (`mimari_tip_id`);

--
-- Tablo için indeksler `fiziki_durum`
--
ALTER TABLE `fiziki_durum`
  ADD PRIMARY KEY (`fiziki_durum_id`);

--
-- Tablo için indeksler `hazne_cati_m.`
--
ALTER TABLE `hazne_cati_m.`
  ADD PRIMARY KEY (`hazne_cati_malzeme_id`);

--
-- Tablo için indeksler `hazne_cati_tipi`
--
ALTER TABLE `hazne_cati_tipi`
  ADD PRIMARY KEY (`hazne_cati_tip_id`);

--
-- Tablo için indeksler `hazne_yapi_m.`
--
ALTER TABLE `hazne_yapi_m.`
  ADD PRIMARY KEY (`hazne_yapi_malzeme_id`);

--
-- Tablo için indeksler `kemer_tip`
--
ALTER TABLE `kemer_tip`
  ADD PRIMARY KEY (`kemer_tip_id`);

--
-- Tablo için indeksler `kitabe_malzeme`
--
ALTER TABLE `kitabe_malzeme`
  ADD PRIMARY KEY (`kitabe_malzeme_id`);

--
-- Tablo için indeksler `konum`
--
ALTER TABLE `konum`
  ADD PRIMARY KEY (`konum_id`);

--
-- Tablo için indeksler `masrapalik`
--
ALTER TABLE `masrapalik`
  ADD PRIMARY KEY (`masrapalik_id`);

--
-- Tablo için indeksler `mimari_tipi`
--
ALTER TABLE `mimari_tipi`
  ADD PRIMARY KEY (`mimari_tip_id`);

--
-- Tablo için indeksler `sacak_durum`
--
ALTER TABLE `sacak_durum`
  ADD PRIMARY KEY (`sacak_durum_id`);

--
-- Tablo için indeksler `sacak_ozellik`
--
ALTER TABLE `sacak_ozellik`
  ADD PRIMARY KEY (`sacak_ozellik_id`);

--
-- Tablo için indeksler `stil`
--
ALTER TABLE `stil`
  ADD PRIMARY KEY (`stil_id`);

--
-- Tablo için indeksler `yalak_malzeme`
--
ALTER TABLE `yalak_malzeme`
  ADD PRIMARY KEY (`yalak_malzeme_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `ayna_tas_malzeme`
--
ALTER TABLE `ayna_tas_malzeme`
  MODIFY `ayna_tas_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `bulundugu_alan`
--
ALTER TABLE `bulundugu_alan`
  MODIFY `bulundugu_alan_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `cati_kaplama_m.`
--
ALTER TABLE `cati_kaplama_m.`
  MODIFY `cati_kaplama_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `cati_ortusu`
--
ALTER TABLE `cati_ortusu`
  MODIFY `cati_ortu_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `cephe_orgu_m.`
--
ALTER TABLE `cephe_orgu_m.`
  MODIFY `cephe_orgu_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `cesme`
--
ALTER TABLE `cesme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `fiziki_durum`
--
ALTER TABLE `fiziki_durum`
  MODIFY `fiziki_durum_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hazne_cati_m.`
--
ALTER TABLE `hazne_cati_m.`
  MODIFY `hazne_cati_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hazne_cati_tipi`
--
ALTER TABLE `hazne_cati_tipi`
  MODIFY `hazne_cati_tip_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hazne_yapi_m.`
--
ALTER TABLE `hazne_yapi_m.`
  MODIFY `hazne_yapi_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `kemer_tip`
--
ALTER TABLE `kemer_tip`
  MODIFY `kemer_tip_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `kitabe_malzeme`
--
ALTER TABLE `kitabe_malzeme`
  MODIFY `kitabe_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `konum`
--
ALTER TABLE `konum`
  MODIFY `konum_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `masrapalik`
--
ALTER TABLE `masrapalik`
  MODIFY `masrapalik_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `mimari_tipi`
--
ALTER TABLE `mimari_tipi`
  MODIFY `mimari_tip_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `sacak_durum`
--
ALTER TABLE `sacak_durum`
  MODIFY `sacak_durum_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `sacak_ozellik`
--
ALTER TABLE `sacak_ozellik`
  MODIFY `sacak_ozellik_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `stil`
--
ALTER TABLE `stil`
  MODIFY `stil_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `yalak_malzeme`
--
ALTER TABLE `yalak_malzeme`
  MODIFY `yalak_malzeme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `cesme`
--
ALTER TABLE `cesme`
  ADD CONSTRAINT `cesme_ibfk_1` FOREIGN KEY (`stil_id`) REFERENCES `stil` (`stil_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_10` FOREIGN KEY (`sacak_durum_id`) REFERENCES `sacak_durum` (`sacak_durum_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_11` FOREIGN KEY (`yalak_malzeme_id`) REFERENCES `yalak_malzeme` (`yalak_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_12` FOREIGN KEY (`kemer_tip_id`) REFERENCES `kemer_tip` (`kemer_tip_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_13` FOREIGN KEY (`cati_ortu_id`) REFERENCES `cati_ortusu` (`cati_ortu_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_14` FOREIGN KEY (`masrapalik_id`) REFERENCES `masrapalik` (`masrapalik_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_15` FOREIGN KEY (`mimari_tip_id`) REFERENCES `mimari_tipi` (`mimari_tip_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_16` FOREIGN KEY (`cephe_orgu_malzeme_id`) REFERENCES `cephe_orgu_m.` (`cephe_orgu_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_17` FOREIGN KEY (`bulundugu_alan_id`) REFERENCES `bulundugu_alan` (`bulundugu_alan_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_18` FOREIGN KEY (`ayna_tasi-malzeme_id`) REFERENCES `ayna_tas_malzeme` (`ayna_tas_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_2` FOREIGN KEY (`cati_kaplama_id`) REFERENCES `cati_kaplama_m.` (`cati_kaplama_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_3` FOREIGN KEY (`cesmenin_durumu_id`) REFERENCES `fiziki_durum` (`fiziki_durum_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_4` FOREIGN KEY (`sacak_ozellik_id`) REFERENCES `sacak_ozellik` (`sacak_ozellik_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_5` FOREIGN KEY (`hazne_cati_tipi_id`) REFERENCES `hazne_cati_tipi` (`hazne_cati_tip_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_6` FOREIGN KEY (`hazne_yapim_malzeme_id`) REFERENCES `hazne_yapi_m.` (`hazne_yapi_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_7` FOREIGN KEY (`kitabe_malzeme_id`) REFERENCES `kitabe_malzeme` (`kitabe_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_8` FOREIGN KEY (`hazne_cati_malzeme_id`) REFERENCES `hazne_cati_m.` (`hazne_cati_malzeme_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cesme_ibfk_9` FOREIGN KEY (`konumu_id`) REFERENCES `konum` (`konum_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
