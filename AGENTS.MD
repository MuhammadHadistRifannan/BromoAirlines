\# AGENTS.md



\# BromoAirlines Development Guidelines



\## Project Overview



BromoAirlines merupakan aplikasi desktop Windows Forms berbasis C# dan .NET yang dikembangkan sebagai project mata kuliah Object Oriented Programming.



Project menggunakan pendekatan Layered Architecture agar kode mudah dipelihara, diuji, dan dikembangkan.



\---



\# Tujuan Agent



Agent bertugas mengimplementasikan setiap fitur secara bertahap berdasarkan PRD.



Agent DILARANG mengimplementasikan fitur di luar urutan yang telah ditentukan.



Setiap implementasi harus selesai secara vertikal hingga dapat dijalankan sebelum berpindah ke fitur berikutnya.



\---



\# Struktur Project



```

Forms

│

├── Splash

│

├── Auth

│

├── Admin

│   ├── Sidebar

│   └── Pages

│

└── User

```



Agent tidak boleh mengubah struktur folder.



\---



\# Dashboard Architecture



DashboardForm terdiri dari



```

DashboardForm

├── SidebarAdmin

└── PanelContent

```



Sidebar hanya dibuat SATU KALI.



Semua halaman Admin dimuat ke PanelContent.



Dilarang membuka Form baru ketika Administrator berpindah menu.



\---



\# Development Order



Agent WAJIB mengikuti urutan berikut.



\## Phase 1



Sidebar Admin



Dashboard Page



\---



\## Phase 2



Master Bandara



\---



\## Phase 3



Master Maskapai



\---



\## Phase 4



Master Jadwal Penerbangan



\---



\## Phase 5



Master Kode Promo



\---



\## Phase 6



Status Penerbangan



\---



\## Phase 7



Transaksi



\---



\## Phase 8



User Management



\---



\## Phase 9



Laporan



Agent tidak boleh melompati phase.



\---



\# Untuk Setiap Feature



Agent harus mengikuti urutan implementasi berikut.



\## STEP 1



Baca PRD Feature.



Jangan menulis kode sebelum seluruh requirement dipahami.



\---



\## STEP 2



Buat UI Form/Page



Yang dibuat hanya tampilan.



Belum ada database.



Belum ada service.



Belum ada event.



\---



\## STEP 3



Tambahkan seluruh komponen UI



Contoh



Label



Textbox



Button



DataGridView



Panel



ComboBox



PictureBox



DateTimePicker



NumericUpDown



FlowLayoutPanel



Gunakan nama kontrol yang konsisten.



Contoh



```

txtNama



txtKode



cmbMaskapai



btnTambah



btnEdit



btnHapus



gridData

```



\---



\## STEP 4



Implement Navigation



Hubungkan Sidebar dengan Page.



Pastikan PanelContent dapat berganti halaman.



\---



\## STEP 5



Buat Model



Model hanya berisi property.



Tidak boleh ada query.



Tidak boleh ada UI.



\---



\## STEP 6



Buat Repository



Repository hanya menangani database.



Contoh



Insert



Update



Delete



Find



GetAll



Search



\---



\## STEP 7



Buat Service



Service berisi seluruh Business Logic.



Contoh



Validation



Business Rules



Calculation



Checking



Repository dipanggil dari Service.



Form tidak boleh memanggil Repository secara langsung.



\---



\## STEP 8



Dependency Injection



Inject Service ke Form.



Form tidak boleh membuat object Repository sendiri.



\---



\## STEP 9



Implement Event



Button Click



Selection Changed



Search



Filter



Double Click



\---



\## STEP 10



Implement Validation



Validation berada di Service.



Contoh



Kode Bandara unik.



Kode Promo unik.



Harga tidak boleh negatif.



Tanggal tidak boleh lewat.



\---



\## STEP 11



Integrasi Database



Pastikan



Insert



Update



Delete



Search



Berjalan.



\---



\## STEP 12



Testing



Pastikan



Tambah



Edit



Hapus



Pencarian



Refresh



Semua berjalan.



\---



\# Layer Responsibility



\## Form



Hanya UI.



Tidak boleh ada SQL.



Tidak boleh ada Business Logic.



\---



\## Service



Validation.



Business Rule.



Calculation.



Workflow.



\---



\## Repository



Database Access.



\---



\## Model



Entity.



\---



\# Coding Rules



Gunakan PascalCase.



Gunakan CamelCase untuk variable.



Gunakan async apabila memungkinkan.



Pisahkan setiap tanggung jawab.



Satu class satu tanggung jawab.



\---



\# SOLID



Agent WAJIB mengikuti



Single Responsibility



Open Closed



Liskov



Interface Segregation



Dependency Inversion



\---



\# Clean Code



Method maksimal 30 baris.



Tidak boleh duplicate code.



Gunakan helper apabila diperlukan.



Gunakan meaningful variable name.



\---



\# Error Handling



Gunakan try catch.



Jangan menampilkan exception asli ke user.



Selalu tampilkan pesan yang ramah.



\---



\# Validation Rules



Semua validasi dilakukan di Service.



Form hanya menampilkan hasil validasi.



\---



\# UI Rules



Gunakan warna yang konsisten.



Sidebar tidak berubah.



Panel Content menjadi tempat seluruh halaman.



Semua CRUD menggunakan DataGridView.



\---



\# Commit Rule



Satu Feature



Satu Commit



Contoh



feat(admin): master bandara



feat(admin): master maskapai



fix(admin): validation bandara



refactor(service): schedule service



\---



\# Done Criteria



Suatu Feature dianggap selesai apabila



UI selesai



Navigation selesai



Repository selesai



Service selesai



Validation selesai



CRUD selesai



Testing berhasil



PRD telah dipenuhi



Baru boleh lanjut ke Feature berikutnya.



