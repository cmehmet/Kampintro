using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarDetails = "Araçların detayları listelendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        //------------------------------------------------
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandListed = "Marka listelendi.";
        //------------------------------------------------
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string CarImagesListed = "Araba resimleri listelendi.";
        public static string CarImageLimitExceeded = "Bu araç için resim limiti doldu.";
        public static string CarImageUploaded = "Araba resmi başarıyla eklendi.";
        public static string NoCarImage = "Belirttiğiniz araç için herhangi bir resim bulunamadı.";
        public static string CarImageUpdated = "Araba resmi başarıyla güncellendi.";
        public static string CarImageDeleted = "Araba resmi başarıyla silindi.";

    }
}
