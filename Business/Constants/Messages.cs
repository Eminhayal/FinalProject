using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        // static newlemez statiktir

        public static string ProductAdded = " Ürün Eklendi ";
        public static string ProductNameInvalid = " Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountError = "Bir kategoryde en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = " Kategori limiti aşılmıştır";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = " Kayıt olundu";
        public static string UserNotFound = " Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = " Kulllanıcı mevcut";
        public static string AccessTokenCreated = " Token oluşturuldu.";
    }
}
