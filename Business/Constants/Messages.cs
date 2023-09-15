using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Car Messages
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarDeleted = "Araç Silme işlemi başarılı";
        public static string CarUpdated = "Araç Güncelleme işlemi başarılı";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Lütfen farklı bir renk giriniz.";

        //BrandMessages
        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Lütfen farklı bir marka giriniz.";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";

        //RentalMessages
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = "Araç Zaten Teslim Alınmış.";
    }
}
