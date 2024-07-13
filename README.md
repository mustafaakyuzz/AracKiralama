## Projenin Veri Tabanı
### Müşteri Tablosu ve Veri Tipleri

![resim1](https://github.com/user-attachments/assets/1726ef8b-7318-4bd4-8c96-9db3acdadbde)

Müşteri tablosunda sadece MusteriId adlı sütundaki veriler bilgisayar tarafından 1’den 
başlayarak birer artışla otomatik olarak atanıyor. Geriye kalan diğer verilerde ise uygunluk 
durumuna göre karakter sayısı atadık örneğin TC Kimlik numarası için 11 karakterli veri tipi 
atadık.

### Araba Tablosu Veri Tipleri

![resim3](https://github.com/user-attachments/assets/c7685a48-7b34-42b9-8b6e-f134a2a69453)

Müşteri tablosunda olduğu gibi araç tablosunda da ArabaId adlı sütunun değerlerini 
bilgisayarımız otomatik olarak birer artırarak otomatik olarak atayacaktır. MusteriUygunluk ve 
ArabaUygunluk adlı sütunların veri tiplerinin bit olması sebebi ise ya ‘1’ değerine yada ‘0’ 
değerine sahip olacaklarındandır. Yani ya ‘True’ yada ‘False’ olacaklardır.

### Talep Tablosu Veri Tipleri

![resim4](https://github.com/user-attachments/assets/6b254688-db9c-4d68-98ca-3817efc258d7)

### Talep Tablosu Veriler

![resim5](https://github.com/user-attachments/assets/6861a566-938f-4aff-bb90-6b2528f208ee)


### Bağlı Tablolarla Oluşturulan Diyagram

![resim6](https://github.com/user-attachments/assets/9359e2d2-7a26-48a8-90ba-6e45a1a00749)

Şekilde görüldüğü gibi talep ve kira tablosunda bulunan müşteri ID ve araba ID bilgileri 
ilgili tablolardaki ID bilgileri ile birbirleri arasında bağlantı kurulmuştur.


## Proje Arayüz-Model Ekran Görüntüleri ve Açıklamaları
### Ana Sayfa

![resim7](https://github.com/user-attachments/assets/443c38f0-4d05-4887-bb8c-bb53d00d3c02)

Projemizde yönetici olarak uygulamayı açtığımızda karşımıza gelen ana sayfa yukarıdaki 
gibidir. Bu ana sayfada 8 adet açabileceğimiz menü vardır. Bu menüler Müşteri Ekle, Araba 
Ekle, Talep Listesi, Yönetici Ekle, Müşteri İşlemleri, Arabaları Görüntüle, Kira Takip, Yönetici 
İşlemleri’dir. Ana sayfadaki ikonlarımızın hepsini aynı tarzda tasarladık ve eşit ölçeklendirdik. 
Bu sayede göze hoş gelen bir ana sayfa ortaya çıkardık ve kullanan yöneticinin bu menüde 
kolaylıkla hareket edebilmesini sağladık.

### Araç İşlemleri Ekranı

![resim8](https://github.com/user-attachments/assets/7a55cd4e-0903-49ef-80fd-ea71f4432f40)

Şekilde görseli olan araç işlemleri menüsünde yönetici, veritabanında kayıtlı olan araçları 
ve ID, marka, model, renk, plaka ve üretim yılı gibi özellikleri görebilir. Bu özelliklerde 
herhangi bir düzenleme yapması gerektiğinde aracı seçip gerekli düzeltmeyi yaptıktan sonra 
araç bilgisini güncelleyebilir veya artık olmayan bir aracı sistemden silebilir.

### Müşteri İşlemleri Ekranı

![resim9](https://github.com/user-attachments/assets/a934b976-70b9-4c4e-99ec-f67bf4a00efb)

Şekilde görseli olan müşteri işlemleri menüsünde yönetici, veritabanında kayıtlı olan 
müşterileri ve ID, kullanıcı adı, şifre, ad, soyad, mail, TC kimlik numarası, cinsiyet ve telefon 
gibi özellikleri görebilir. Bu özelliklerde herhangi bir düzenleme yapması gerektiğinde aracı 
seçip gerekli düzeltmeyi yaptıktan sonra araç bilgisini güncelleyebilir veya herhangi bir 
kullanıcıyı sistemden silebilir. Görselin sol üstünde gözüken “label13” ise program çalışırken 
gözükmemektedir. Görevi cinsiyet özelliğindeki seçili radibuttonu labelda tutmaktır. 
Veritabanına eklenirken labelda yazılan değer esas alınır.

### Talep Görüntüleme Ekranı

![resim11](https://github.com/user-attachments/assets/4ba47d29-9d96-46cf-90ce-d3dfdaa3db70)

Şekilde görseli olan talep görüntüleme ekranında yönetici, herhangi bir müşterinin talep 
ettiği aracı, müşteriyi, aracın kiralanılmak istediği ve teslim edilmek istediği tarihleri görebilir. 
Buradaki müşteriler tablosu müşterinin ID’si sayesinde diğer özelliklerine ulaşmamızı 
sağlarken arabalar tablosu da arabanın ID’si sayesinde diğer özelliklerine ulaşmamızı sağlar. 
Yönetici bu ekranda talebi Kabul veya reddeder. Talebi kabul edilen araç uygunluğunu yitirir.

### Müşteri Ekranı

![resim12](https://github.com/user-attachments/assets/45d0e40c-c60a-401c-976d-2edb35052b7f)

Şekilde görseli olan müşteri ekranında müşteri, sistemde olan ve özellikleri gözüken 
araçlardan talep etmek istediği aracı seçip teslim almak ve geri teslim etmek istediği tarihleri 
seçebilir. Müşteri bu menüde aracın özellikleriyle ilgili bir değişiklik yapamaz sadece tarihleri 
değiştirebilir. Müşteri kullanıcı adı ve şifresiyle giriş yaptıktan sonra bu ekrana eriştiği için sol 
üst köşede kendi kulanıcı adını ve ad-soyad bilgisini görebilir.

### Bu Projede Beni Zorlayan Kısım
#### Formlar Arası Veri Taşıma

Projemizde müşteri kullanıcı adını ve şifresini girdikten sonra açılan Müşteri Ekranı 
Formunda müşteriye kendi ad soyad ve kullanıcı adı bilgisini göstermek amacıyla iki form 
arasında veri taşımam gerekiyordu. Bunu sağlamak için önce Müşteri Ekranı Formunun arka 
planında ‘kullaniciadi’ adlı bir public string değişken oluşturdum ve sonrasında ilgili Label’a bu 
değişkeni atadım ancak bu hâliyle boş değerdi. Bu değeri doldurmak için ise Müşteri Giriş 
Ekranının arka plan kısmında Textbox’lara doğru bilgiler girildiği takdirde Müşteri Ekranı 
Formu açılışından önce bu formdan türettiğimiz nesne ile az önce oluşturduğumuz 
‘kullaniciadi’ adlı değişkene ulaştım ve TxtKullaniciAdi adlı Textbox’daki değeri ulaştığım 
bu değişkene atadım böylece boş değeri doldurmuş oldum. Sonrasındaysa artık kullanıcı adını 
diğer forma taşıdığım için basit bir ‘Select’ SQL komutuyla Müşterinin ad, soyad, ID ve 
uygunluk durumlarını çektim ve ‘where’ şartı olarakta müşterinin kullanıcı adı bilgisini esas 
aldım ve bu probleme böyle bir çözüm geliştirmiş oldum.


