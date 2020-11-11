-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 11, 2020 lúc 05:46 PM
-- Phiên bản máy phục vụ: 10.4.14-MariaDB
-- Phiên bản PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `project`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `binhluan`
--

CREATE TABLE `binhluan` (
  `id` int(11) NOT NULL,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `comment` text COLLATE utf8_unicode_ci NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cauhoi`
--

CREATE TABLE `cauhoi` (
  `id` int(11) NOT NULL,
  `title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `question` text COLLATE utf8_unicode_ci NOT NULL,
  `likes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `cauhoi`
--

INSERT INTO `cauhoi` (`id`, `title`, `question`, `likes`) VALUES
(8, 'Máy tính', 'alo', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `likes`
--

CREATE TABLE `likes` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `cauhoi_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `likes`
--

INSERT INTO `likes` (`id`, `user_id`, `cauhoi_id`) VALUES
(1, 1, 5),
(2, 1, 6),
(3, 1, 7),
(4, 1, 8);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `create_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `user`
--

INSERT INTO `user` (`id`, `username`, `email`, `password`, `create_at`) VALUES
(18, '1851161833', 'haianhle3112@gmail.com', '$2y$10$vsZc8CCDRuu/XwOVToZYE.v29W0/AnucDr1zNJS6Vwmh5f.oM4p52', '2020-10-27 14:02:51'),
(20, 'trung', 'lehaianh2000k@gmail.com', '$2y$10$3xSJzMGkouBXB2xdum0gPewKBRhGEYMr9ZNIp9MGQ35QBnTHSo786', '2020-10-27 14:05:58'),
(22, 'le_hai_anh123', 'lehaianh999@gmail.com', '$2y$10$B.G.LwQlGx4xVkV1w8gq4ehJ4UpiakulDaiAJhzuIoPDtMVv0ZISO', '2020-10-27 14:19:52'),
(23, 'haianh3112', '1851161833@e.tlu.edu.vn', '$2y$10$ReiGbGMP0xfk6rOzB7DK3Oh4xy5vdJHUbxAnG8jXTVEXxe78B9iEm', '2020-10-27 14:21:33'),
(25, 'haianh3', 'lehaianh999@yahoo.com', '$2y$10$/E1AzwAp66q6QCZnscXCBunUC/vfk.mGOumrjLfkl/w/OTDlQb8DG', '2020-11-02 04:09:03'),
(29, '1', 'haianhle3@gmail.com', '$2y$10$KaXJGBxwgiuXJ.EUMdywFO0f9Dhp13DK1uqndvA5KLjCOOJoGFDIC', '2020-11-03 03:04:45'),
(31, 'haianh3112222', 'lehaianh@yahoo.com', '$2y$10$jxTrtCEfop0WUZVYsBG5guBva.XEybktJT6e.oN/kbzMrBE6b3keW', '2020-11-06 11:30:50'),
(34, '1851161833', 'dungrio05@gmail.com', '$2y$10$UrsohGZbQL009rdYNFeeUep7RdoizyviNUQSeZOpFmeQPl84ILBX2', '2020-11-07 07:48:51'),
(35, 'haianhle32', 'haianhle32@gmail.com', '$2y$10$lBvSHipAwISyK/w.Ks5cpeHEJkLC95WyBVW1Z.0q49BnPj.HbrYkK', '2020-11-10 09:02:06'),
(36, 'haianh32', 'haianhle332@gmail.com', '$2y$10$Q52JGcV51GKUApDVI.t28.Zih0F0hBjhthFOQQUDm3gjeSkuTdzPa', '2020-11-10 09:16:19'),
(37, 'Hải Anh', 'haianhle3333@gmail.com', '$2y$10$OgbBzvRb2I3esOZgBADsmOMetH68XbMvGG6Hngz7iElTmHrTbqy.K', '2020-11-10 09:30:50');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `binhluan`
--
ALTER TABLE `binhluan`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `cauhoi`
--
ALTER TABLE `cauhoi`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `likes`
--
ALTER TABLE `likes`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `binhluan`
--
ALTER TABLE `binhluan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT cho bảng `cauhoi`
--
ALTER TABLE `cauhoi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT cho bảng `likes`
--
ALTER TABLE `likes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
