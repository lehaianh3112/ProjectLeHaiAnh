-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 26, 2020 lúc 02:19 PM
-- Phiên bản máy phục vụ: 10.4.13-MariaDB
-- Phiên bản PHP: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `tk_sv`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sv`
--

CREATE TABLE `sv` (
  `MaSV` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL,
  `Hoten` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL,
  `GioiTinh` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL,
  `NamSinh` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL,
  `QueQuan` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL,
  `MaLop` varchar(50) COLLATE utf8_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `sv`
--

INSERT INTO `sv` (`MaSV`, `Hoten`, `GioiTinh`, `NamSinh`, `QueQuan`, `MaLop`) VALUES
('12321321', 'Lê Hải Anh', 'Nam', '31/12/2000', 'Thường Tín', 'PM2'),
('2222222222222222', 'Nguyễn Anh Dũng', 'Nam', '10/7/2000', 'Thường Tín', 'PM2'),
('323123', 'Vũ Văn Thiết', 'Nam', '13/6/2000', 'Hải Dương', 'PM2'),
('213213123', 'Nguyễn Thị Ly', 'Nữ', '2000', 'Tô Hiệu', 'PM2'),
('231232', 'Lê Thị Cẩm Ly', 'Nữ', '2000', 'Thường Tín', 'PM2'),
('2313213', 'Lê Mạnh Quang', 'Nam', '2000', 'Thường Tín', 'PM1'),
('123124242412412', 'Lê Thanh Thùy', 'Nữ', '2000', 'Thường Tín', 'PM1'),
('421442141421', 'Nguyễn Thị Huyền Trang', 'Nữ', '2000', 'Hải Phòng', 'PM1'),
('54535454', 'Lê Đức Trung', 'Nam', '2000', 'Hà Nội', 'PM1'),
('3123213213', 'Tạ Đức Long', 'Nam', '2000', 'Thường Tín', 'PM1'),
('45435443435', 'Nguyễn văn Bằng', 'Nam', '2000', 'Hà Nội', 'PM2');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
