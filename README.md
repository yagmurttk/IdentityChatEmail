# 💌 Identity Email Chat Uygulaması
ASP.NET Core 8.0 MVC ile geliştirilmiş, kullanıcı kimlik doğrulama (Identity) sistemi entegre e-posta mesajlaşma platformu.
## 🎯 Proje Amacı
Bu proje, ASP.NET Core'un Identity altyapısı ile entegre edilmiş, kullanıcıların birbirlerine e-posta formatında mesajlar gönderebildiği bir sistemin temelini oluşturur. Hedef; kullanıcı kayıt, giriş ve profil yönetimi gibi işlemlerle birlikte güvenli, kullanıcı dostu bir mesajlaşma deneyimi sunmak ve bu süreci modern bir arayüzle birleştirmektir.
## ⚙️ Kullanılan Teknolojiler
💎 ASP.NET Core MVC

💎 Entity Framework Core

💎 ASP.NET Core Identity

💾 MS SQL Server

✨ SweetAlert2

🎨 Bootstrap 5
## 🚀 Uygulama Özellikleri
🔐 Kimlik Doğrulama ve Yetkilendirme

✅ Kayıt Ol / Giriş Yap / Oturum Kapat

🔏 Şifreler hashlenerek güvenli şekilde saklanır

🚫 5 kez yanlış girişte geçici olarak erişim kısıtlaması (lockout)

📨 Mesajlaşma Sistemi

✉️ Yeni mesaj oluşturma ve gönderme

📥 Gelen Kutusu (Inbox)

📤 Giden Kutusu (Sent Items)

🗑️ Mesajları çöp kutusuna taşıma

🔍 Arama çubuğu ile mesaj filtreleme

🔄 Dinamik mesaj sayacı (sidebar’da görünür)

👤 Profil Yönetimi

📇 Ad, Soyad, Kullanıcı Adı, E-posta ve Profil Fotoğrafı

🔁 Bilgileri güncelleme imkânı

📊 Alınan ve gönderilen mesajların sayısı gösterilir

🎨 Kullanıcı Arayüzü

🌐 Responsive tasarım (mobil uyumlu)

✅ İşlem sonrası SweetAlert2 ile görsel bildirimler

🧩 Temiz, sade ve modern tasarım

## 📝 Kayıt Sayfası
• Kullanıcı bilgileri alınarak güvenli şekilde veritabanına kaydedilir.

• Parola kuralları Validator ile denetlenir.

![KAYIT OL](https://github.com/user-attachments/assets/01c46d3d-ae07-4e62-b3dc-31b4f0d73144)
## 🔐 Giriş Sayfası
• Kimlik doğrulama işlemi gerçekleştirilir.

• Yanlış girişlerde güvenlik için geçici kilitleme uygulanır.

![LOGİN](https://github.com/user-attachments/assets/c8bda8bd-4c1d-4c5e-ba1d-9b09d727791e)
## 👤 Profilim Sayfası
• Kullanıcının temel bilgileri ve mesaj istatistikleri görüntülenir.

• Bilgiler güncellenebilir.

![PROFİLİM](https://github.com/user-attachments/assets/0f5252d2-9aae-46aa-9a5a-bf93263b9c4f)
## 📬 Gelen & Giden Kutusu
• Kullanıcı, tüm mesaj geçmişini görüntüleyebilir.

• Arama, sıralama ve filtreleme desteği.

• Mesajlar çöp kutusuna gönderilebilir.

![GELEN MESAJLAR](https://github.com/user-attachments/assets/7355502d-560b-45cc-8c23-dd4651f7a058)

![GİDEN MESAJLAR](https://github.com/user-attachments/assets/b3ac5061-d9f4-4d18-bf39-da7a2e370de9)
## 📨 Yeni Mesaj
• Alıcının e-posta adresi, konu ve içerik girilerek mesaj gönderilir.

• Başarılı gönderim sonrası görsel bildirim sağlanır.

![YENİ MESAJ OLUŞTUR](https://github.com/user-attachments/assets/d05290cd-e078-440c-87a2-dcdcf8df3af4)

![SWALL](https://github.com/user-attachments/assets/07914c71-7f31-4088-995b-3c104c123d80)

![ÇÖP KUTUSU](https://github.com/user-attachments/assets/7e2700e3-d6cd-4e29-ba5f-6bc34f67625e)

## 🧪 Geliştirici Notu
• Bu uygulama, ASP.NET Core MVC ve Identity yapısını öğrenmek ve pratik etmek isteyen geliştiriciler için örnek bir proje niteliğindedir. Gerçek dünya uygulamaları için temel alınabilir ve üzerine geliştirilebilir.














