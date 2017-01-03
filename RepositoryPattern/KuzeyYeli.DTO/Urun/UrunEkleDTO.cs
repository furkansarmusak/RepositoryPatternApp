using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.DTO.Urun
{
    public class UrunEkleDTO
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public short Stok { get; set; }
        public int KategoriId { get; set; }
        public int TedarikciId { get; set; }
    }
}
