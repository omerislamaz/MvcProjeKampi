# MVC Proje Kampı


### Description / Tanımlama

Mevcutta var olan Sözlük sitesi tasarımlarından farklı bir örneklendirme ile oluşturulan projede; 4 ayrı ekran bulunmaktadır. Bu ekranlardan 2'si ayrı ayrı giriş yapılabilen Yazar ve Admin panelidir.

1 nci ekran Vitrin Sayfası, 
Tasarımı normal bir web sitesi olarak değerlendirilen bu ekranda, projede kullanılan geliştirme bileşenleri ile birlikte projede nelerin yapıldığı ve ekran görselleri ile birlikte kullanıcılara sunum yapmaktadır.

2 nci ekran olan Sözlük sayfasında, 
Yazarların, herhangi bir konu üzerinden oluşturabilecekleri Başlıkları ve bu başlıklara hem kendilerinin hem de farklı yazarların yazmış oldukları yorumlar listelenmektedir.

3 ncü ekran Yazar Paneli'dir.
Bu ekranda Sisteme Authenticate olan yazar öncelikli olarak Kendi profilini düzenleyebiliyor. Sonrasında Başlık oluşturma, düzenleme ve oluşturduğu Başlığı Aktif ya da Pasife alma gibi eylemleri ile birlikte; bu başlıklara yorum yazabilmektedir. Ayrıca Sisteme Authenticate 
olan yazarın farklı Başlıklar altında yazmış olduğu tüm yazı ve yorumları da listenebilmektedir. Bu panzelde yazara sistemi daha etkin kullanıp sistem yöneticileri ile iletişim halinde olabilmeleri için de Mesaj sayfası oluşturulmuştur. Mesaj sayfasında
* Yazar'dan -> Yazar'a  
* Yazar'dan -> Admin'e
* Admin'den -> Yazar'a 
* Admin'den -> Admin'e olacak şekilde birbirlerine mesaj gönderimide sunuldu.

4ncü ekran ise Admin Paneli.
Admin Panelinde proje üzerindeki tüm Yetkilendirmeler kontrol edilebilmektedir.Sisteme Authenticate olan Admin, oluşturulan Başlıkların kategorileri ve Başlıkları tamamiyle listeleyip düzenlenebilir veya Aktif ya da Pasife alınacak şekilde düzenleme sağlayabilir. 
Panelde var olan Yazarlar sayfasından, Sistemde kayıtlı olan yazarların profillerinde düzenlemede bulunabilir. Sistem içerisinde ki kayıtlı olan Başlıkların tamamını Rapor halinde Excel, Pdf olarak dışa aktarabilir. Yazar panelinde de olduğu gibi kayıtlı kullanıcılar
ile mesajlaşarak iletişim kurabilmektedir.

 

### Tecnologies / Kullanılan Teknolojiler

Geliştirme Yaklaşımı olarak;

* MVC Mimarisi üzerinden şekillenerek,
* N Tier Architecture (Çok Katmanlı Mimari) ile birlikte 4 temel katman kullanıldı.
  
   * Business Layer ( İş Katmanı )
   * Data Access Layer ( Veri Katmanı )
   * Entity Layer ( Varlık Katmanı )
   * Presentation Layer ( Sunum Katmanı )

 * SOLID yazılım prensipleri göz önünde bulundurularak

    * Projenin sürdürülebilirliği,
    * Anlaşılır olmasını,
    * ve kod tekrarının önüne geçilmesi hedeflendi.
  
 * Projede ortak olarak ihtiyaç duyulan CRUD işlemleri için tek bir yerden kullanımını sağlayan

    * Generic Repository tasarımı kullanıldı.
  
Veri Tabanı olarak;

* MS Sql kullanıldı.

Veri Tabanı yönetimi;

* Entity Framework Code First yapısı ile sağlandı.
* Tablolar arasında Bir'e Çok ilişki sağlandı.

Proje içerisinde;
* Fluent Validation (Doğrulama Kuralları) kullanılarak, kullanıcı tarafından herhangi bir yanlış veri girişi engeli sağlandı.
* DropDownList (Açılır Liste) kullanılarak veritabanında ki kayıtlı veriyi kullanıcıya seçtirme olanağı sunuldu.

Tasarım olarak;

* Html,
* Bootstrap,
* Css,
* JavaScript,
* Alert Message,
* SweetAlert,
* ve IFrame ile site üzerine Harita bilgisi eklendi.

### Screenshots / Ekran Görüntüleri

 * Vitrin Ekranları
   
1-
  ![Vitrin-AnaSayfa](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/c932544e-70a7-4c88-9777-c413a9079238)
  
2-    
 ![Vitrin-2](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/35048eb2-1ae9-4d2a-b596-11e1213fb66f)
 
3- 
![Vitrin-3](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/2a870e8e-cd94-4ea6-aca8-0bc68a4b7f2e)

4-
![Vitrin-4](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/9d34661e-a800-4ea9-a5c3-1907e27a926e)

5-
![Vitrin-5](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/00925060-2461-4360-8b84-356890e27248)

6-
![Vitrin-6](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/e7617f58-dc8d-4791-81c3-5abd9673c184)





 * Sözlük Ekranı

![Sözlük-1](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/0023e6b6-58a4-4033-9fe2-ef30ff8e05fe)


 * Yazar Panel Ekranı

1-
![1](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/16147d2d-82b2-4643-97d3-87501f2e4ff6)

2-
![2](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/6e7e999a-78e7-402f-8046-442b17517d1e)

3-
![3](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/e1957de4-c6c6-4350-9f55-96c26318a399)

4-
![4](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/1afc11fd-6718-4ab9-bc6b-037a2dd95980)

5-
![yazar-2](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/6b7a231a-15ab-4b26-8dd6-b4f55c9e70cc)


 * Admin Panel Ekranı

1-
![6](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/b30a2f17-7b1d-4342-a237-72a9efb93ee0)

2-
![Admin-Başlıklar](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/4bc8dfde-131d-4946-a060-8c7e8dc6c4f7)

3-
![8](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/9209c6b4-bf9f-48d9-a968-7b3c79574453)

4-
![9](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/32f6d92a-c6d9-4aba-ad8c-60e8bcb479f0)

5-
![Admin-Raporlar](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/c81fc3cc-64c2-4009-b075-6c7f460874e0)

6-
![Admin-Yetkilendirme](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/850eee7d-e364-428f-9305-ea94fcb7552c)

7-
![Admin-SweetAlert](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/16d162f9-a73e-466e-80a9-1e603084e48e)


 * Veri Tabanı İlişki / Diagram Ekranı

![vtilişki](https://github.com/omerislamaz/MvcProjeKampi/assets/139688216/50e14609-0083-4fd4-99ac-93ebc2a46a34)


