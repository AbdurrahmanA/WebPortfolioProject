# Admin Panelli Portfolyo Sitesi

Bu proje  Admin ve Yazar panellerine, Kullanıcı Arayüzüne sahip dinamik bir web sitesidir. ASP.NET Core ve diğer modern teknolojiler kullanılarak geliştirilmiştir.

## Proje Detayları

### Kullanıcı Arayüzü
Bu bölüm hakkımda, yetenekler ve projeler gibi kişisel bilgilerimin görüntülendiği bir arayüzdür. Mesaj gönderebilmeniz ve bilgilerime ulaşabilmeniz için iletişim alanı da bulunmaktadır.

### Admin Paneli
Kullanıcı Arayüzü içerisindeki alanları yönetmek için oluşturulmuştur. Eğitim, yetenekler, projeler gibi alanlar üzerinde CRUD (Create, Read, Update, Delete) işlemleri yapılabilmektedir.

### Yazar Paneli
Sisteme kaydolan kullanıcıların mesajlaşma, duyuru takibi, profil düzenleme gibi işlemleri gerçekleştirebildiği paneldir.

## Projenin İçeriği

- **ASP.NET Core:** Platform bağımsız, performans odaklı ve modern web uygulamaları geliştirmek için kullanılan bir framework. ASP.NET Core’un MVC yapısı kullanılarak, kullanıcı ve admin panelleri arasında sorunsuz bir geçiş sağlanmaktadır.
- **MVC (Model-View-Controller):** Projede MVC mimarisi kullanılarak iş mantığı (Model), arayüz (View) ve kontrol işlemleri (Controller) birbirinden ayrılmıştır. Bu yapı, uygulamanın hem geliştirme sürecini kolaylaştırmış hem de kodun daha düzenli ve bakımı kolay bir hale gelmesini sağlamıştır.
  
- **Entity Framework Core:** Nesne-ilişkisel haritalama (ORM) aracı olarak kullanıldı. Veritabanı işlemleri daha basit ve yönetilebilir hale getirildi.

- **N-Tier Architecture:** Uygulamanın işlevselliğini farklı katmanlar halinde ayırarak geliştirme ve bakımını kolaylaştıran bir yapı sunar. Bu projede EntityLayer, DataAccesLayer, BusinessLayer, PresentationLayer katmanlarına ayrılarak uygulamanın modülerliği artırılmıştır.

- **Identity:** ASP.NET Core Identity, kullanıcının kimliğini doğrulamak ve kullanıcılara belirli izinler tanımlamak için kullanıldı. Projede, kullanıcı kaydı, giriş ve rol bazlı erişim kontrolü işlemleri Identity üzerinden gerçekleştirilmiştir.

- **Fluent Validation:** Uygulamada kullanıcı girdilerini doğrulamak için kullanıldı. Bu kütüphane, giriş verilerinin kurallara uygun olup olmadığını kontrol ederek uygulamanın güvenli ve hatasız çalışmasını sağlar.

- **Repository Design Pattern:** Veri erişimini soyutlayarak, veritabanı işlemlerinin iş mantığından ayrılmasını sağlar. Projede, veritabanı işlemlerini daha temiz ve yönetilebilir hale getirmek amacıyla kullanıldı.

- **Rolleme (Role-based Access Control):** Kullanıcılara roller tanımlanarak, bu roller doğrultusunda yetkilendirme işlemleri yapılmıştır. Projede admin, yazar ve kullanıcı rolleri tanımlanarak, bu roller üzerinden erişim yetkileri belirlenmiştir.
- **MsSQL:** Veritabanı yönetim sistemi olarak kullanıldı.


---
**Kullanıcı Arayüzü**

![Giriş1](https://github.com/user-attachments/assets/733f8704-91f7-4937-8f8d-009d0643b0d4)
![Hakkımda2](https://github.com/user-attachments/assets/65ee2027-c678-4972-97e4-9961e9409dba)
![Yetenekler3](https://github.com/user-attachments/assets/cdedbce0-3b49-4170-8f82-5407d61668da)
![Teknolojiler4](https://github.com/user-attachments/assets/19154736-9a70-4429-98f5-6ef3cc88ef7f)
![Projeler5](https://github.com/user-attachments/assets/0d5d7445-323f-471b-8717-c1b3219db6c6)
![İletişim6](https://github.com/user-attachments/assets/d1ba0534-b9e3-41c9-becc-a0763903c49b)
---
**Admin Paneli**

![AdminPanel7](https://github.com/user-attachments/assets/1a54ef1c-56b1-4aba-8b77-cbb13381e9fb)
---
**Yazar Paneli**

![YazarPanel8](https://github.com/user-attachments/assets/32e1c401-b260-4b7b-8c01-81145e07f76d)
