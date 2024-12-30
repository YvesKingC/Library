create table Admin(
	AdminID int auto_increment primary key,
    Nama varchar(255) not null,
    Pass varchar(255) not null
);

Create table Anggota(
	AnggotaID int auto_increment primary key,
    Nama Varchar(255) Not null,
	Alamat Text,
    NoTelp Varchar(15),
    Email Varchar(255)
);

create table Genre(
	GenreID int auto_increment primary key,
    Genre varchar(50) not null unique
);
create table Katalog(
	KatalogID INT auto_increment primary key,
    GenreID int(50),
    Judul varchar(255) not null,
    Penulis varchar(100),
    Penerbit varchar(100),
    StokBuku int default 0,
    foreign key (GenreID) References Genre(GenreID)
);

create table Peminjaman(
	PeminjamanID int auto_increment primary key,
    AnggotaID int not null,
    TglPinjam Date not null,
    BatasPengembalian Date not null,
    TglKembali date not null,
    foreign key (AnggotaID) References Anggota(AnggotaID) On Delete cascade
);

create table DetailPeminjaman(
	DetailID INT AUTO_INCREMENT PRIMARY KEY,
    PeminjamanID INT NOT NULL,
    KatalogID INT NOT NULL,
    Jumlah INT NOT NULL,
    FOREIGN KEY (PeminjamanID) REFERENCES Peminjaman(PeminjamanID) ON DELETE CASCADE,
    FOREIGN KEY (KatalogID) REFERENCES Katalog(KatalogID) ON DELETE CASCADE
);