using KuzeyYeli.DTO;
using KuzeyYeli.DTO.Urun;
using KuzeyYeli.ORM.Models;
using KuzeyYeli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Service
{
    public class UrunServis
    {
        UrunRepository repository = new UrunRepository();

        public IList<UrunListeleDTO> Listele()
        {
            return repository.Listele().Select(
                x => new UrunListeleDTO
                {
                    UrunAdi = x.UrunAdi,
                    Fiyat = x.Fiyat,
                    Stok = x.Stok,
                    UrunID = x.UrunID,
                    EnAzYenidenSatisMikatari = x.EnAzYenidenSatisMikatari,
                    BirimdekiMiktar = x.BirimdekiMiktar,
                    KategoriID = x.KategoriID,
                    TedarikciID = x.TedarikciID,
                    YeniSatis = x.YeniSatis,
                    Sonlandi = x.Sonlandi
                }
                ).ToList();
        }
        public void Ekle(UrunEkleDTO ent)
        {
            Urunler urunler = new Urunler { 
            
            UrunAdi=ent.UrunAdi,
            Fiyat =ent.Fiyat,
            Stok =ent.Stok,
            KategoriID = ent.KategoriId,
            TedarikciID =ent.TedarikciId
            
            };
            repository.Ekle(urunler);
        }

    }
}
