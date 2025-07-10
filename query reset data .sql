-- Pastikan Anda menggunakan database yang benar
USE CourtCraftDB;
GO

-- Hapus data dari tabel-tabel dalam urutan yang benar untuk menghindari error relasi

-- 1. Hapus detail dari setiap booking
DELETE FROM BookingDetails;
GO

-- 2. Hapus data pembayaran
DELETE FROM Payments;
GO

-- 3. Hapus data booking utama
DELETE FROM Bookings;
GO

-- 4. Hapus data pelanggan (opsional, jika Anda ingin semua pelanggan hilang)
DELETE FROM Customers;
GO

-- 5. Terakhir, hapus semua slot waktu yang sudah di-generate
DELETE FROM TimeSlots;
GO

-- Konfirmasi bahwa data sudah kosong (opsional)
PRINT 'Semua data jadwal dan booking telah berhasil direset.';