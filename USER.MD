# USER.md

# BromoAirlines User Module Development Guide

## Overview

Dokumen ini menjadi panduan implementasi seluruh fitur User pada project BromoAirlines.

Agent WAJIB mengikuti urutan implementasi yang telah ditentukan.

Setiap phase harus selesai terlebih dahulu sebelum melanjutkan ke phase berikutnya.

Agent DILARANG mengimplementasikan fitur di luar phase yang sedang dikerjakan.

---

# User Architecture

```text
Forms
│
└── User
    │
    ├── Sidebar
    │     └── SidebarUser
    │
    └── Pages
```

Dashboard User menggunakan satu Sidebar dan satu Panel Content.

Semua halaman User dimuat ke Panel Content.

Tidak boleh membuka Form baru ketika berpindah menu.

---

# Dashboard User

```text
DashboardUserForm
│
├── SidebarUser
│
└── PanelContent
```

---

# Sidebar Menu

* Home
* Cari Penerbangan
* Tiket Saya
* Riwayat
* Profil
* Logout

---

# Development Phase

Agent WAJIB mengikuti urutan berikut.

---

# Phase 1

## Sidebar User dan Dashboard Page

Tujuan

* Membuat Sidebar User
* Membuat Dashboard User
* Navigation
* Active Menu
* Panel Content
* Sidebar hanya dibuat satu kali
* Semua halaman User dimuat ke Panel Content
* Tidak membuka Form baru ketika berpindah menu

Belum ada database.

Belum ada service.

Belum ada business logic.

UI Phase 1 wajib dibuat melalui Windows Forms Designer atau file `.Designer.cs`.

File `.cs` hanya berisi event navigation dan logic ringan.

---

# Phase 2

## Home Page

Menampilkan

* Banner
* Promo
* Shortcut Cari Penerbangan

Belum ada CRUD.

---

# Phase 3

## Search Flight

Membuat UI pencarian.

Field

* Bandara Asal
* Bandara Tujuan
* Tanggal Berangkat
* Jumlah Penumpang

Output

Daftar Jadwal.

---

# Phase 4

## Flight Detail

Menampilkan

* Maskapai
* Bandara
* Jadwal
* Harga
* Kursi Tersedia

Button

Booking

---

# Phase 5

## Booking

Membuat Booking.

Field

* Jadwal
* Jumlah Penumpang
* Promo

Belum melakukan pembayaran.

---

# Phase 6

## Passenger

Input seluruh data penumpang.

Field

* Nama Lengkap
* Nomor Identitas
* Jenis Kelamin
* Tanggal Lahir
* Kewarganegaraan

Jumlah form mengikuti jumlah penumpang.

---

# Phase 7

## Payment

Menampilkan

* Harga
* Pajak
* Promo
* Total Bayar

Simulasi pembayaran.

---

# Phase 8

## My Ticket

Menampilkan

* Nomor Booking
* Jadwal
* Status
* Detail Tiket

---

# Phase 9

## History

Menampilkan seluruh transaksi User.

Filter

* Tanggal
* Status

---

# Phase 10

## Profile

Menampilkan

* Nama
* Username
* Email

Edit Profile.

Ganti Password.

---

# Standard Implementation

Setiap Feature WAJIB mengikuti urutan berikut.

---

## STEP 1

Baca PRD Feature.

---

## STEP 2

Buat UI.

Belum ada Event.

Belum ada Database.

UI dibuat menggunakan Windows Forms Designer atau `.Designer.cs`, bukan seluruhnya dibuat by code di constructor.

---

## STEP 3

Tambahkan seluruh Control.

Contoh

Label

Textbox

Button

ComboBox

DatePicker

DataGridView

Panel

PictureBox

---

## STEP 4

Hubungkan Navigation.

Sidebar → Panel Content.

---

## STEP 5

Buat Model.

Model hanya berisi Property.

---

## STEP 6

Buat Repository.

Repository hanya menangani database.

---

## STEP 7

Buat Service.

Seluruh Business Logic berada pada Service.

---

## STEP 8

Dependency Injection.

Inject Service ke Form.

Form tidak boleh membuat object Repository sendiri.

---

## STEP 9

Implement Event.

Button

Search

Save

Cancel

Booking

---

## STEP 10

Implement Validation.

Validation dilakukan di Service.

---

## STEP 11

Integrasi Database.

Hubungkan Repository melalui Service.

Search

CRUD dan workflow feature berjalan sesuai kebutuhan phase.

---

## STEP 12

Testing.

Pastikan seluruh flow berjalan.

---

# Layer Responsibility

## Form

Hanya UI.

Tidak boleh SQL.

Tidak boleh Business Logic.

---

## Service

Validation.

Workflow.

Business Rule.

Calculation.

---

## Repository

CRUD Database.

---

## Model

Entity.

---

# Coding Rules

Gunakan PascalCase.

Gunakan CamelCase.

Gunakan nama Control yang konsisten.

Contoh

txtNama

cmbBandara

btnBooking

gridFlight

lblHarga

---

# Validation Rules

Validation dilakukan pada Service.

Contoh

Bandara Asal ≠ Bandara Tujuan.

Tanggal tidak boleh kurang dari hari ini.

Jumlah Penumpang minimal 1.

Promo harus masih aktif.

Kursi harus tersedia.

---

# Business Rules

User harus Login.

Booking hanya untuk Jadwal Aktif.

Pembayaran maksimal sesuai ketentuan sistem.

Status Tiket mengikuti Status Pembayaran.

---

# Error Handling

Seluruh Exception ditangani.

Tidak menampilkan Stack Trace.

Tampilkan pesan yang mudah dipahami User.

---

# UI Rules

Gunakan Sidebar yang konsisten.

Gunakan Panel Content.

Tidak membuka Form baru.

Gunakan DataGridView untuk daftar data.

Gunakan warna dan komponen UI yang konsisten.

Gunakan Windows Forms Designer atau `.Designer.cs` untuk layout agar element bisa digeser melalui designer.

File `.cs` hanya untuk event, navigation, dan pemanggilan service.

---

# Commit Rules

Satu Feature

Satu Commit.

Contoh

feat(user): search flight

feat(user): booking ticket

feat(user): passenger page

feat(user): payment

feat(user): history

---

# Done Criteria

Suatu Feature dianggap selesai apabila

* UI selesai
* Navigation selesai
* Model selesai
* Repository selesai
* Service selesai
* Validation selesai
* Database selesai
* Testing berhasil
* PRD telah dipenuhi

Baru boleh melanjutkan ke phase berikutnya.

---

# Final Flow User

Login

↓

Dashboard User

↓

Home

↓

Cari Penerbangan

↓

Detail Penerbangan

↓

Booking

↓

Input Data Penumpang

↓

Pembayaran

↓

Tiket Saya

↓

Riwayat

↓

Logout
