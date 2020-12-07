﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_028.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjamanNavigation { get; set; }
        [Required(ErrorMessage = "Tanggal peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        [Required(ErrorMessage = "Kendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "Customer tidak boleh kosong")]
        public int? IdCustomer { get; set; }
        [Required(ErrorMessage = "Jaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int? Biaya { get; set; }

        public Costumer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}