# Player Controller - Unity 2D Platformer

Bu proje, bir **Unity 2D platformer** oyununda bir oyuncu karakterini kontrol eden temel bir **C#** scriptini içerir. Karakterin yatay hareketi, zıplaması, yön değiştirmesi ve yere değme durumu gibi işlemler bu script ile yönetilmektedir.

## İçerik

1. [Tanımlanan Değişkenler](#tanımlanan-değişkenler)
2. [Fonksiyonlar](#fonksiyonlar)
3. [Kullanım](#kullanım)
4. [Geliştirme](#geliştirme)
5. [Kurulum](#kurulum)

---

## Tanımlanan Değişkenler

- **Rigidbody2D playerRB**: Karakterin fiziksel hareketlerini kontrol eder.
- **Animator playerAnimator**: Karakterin animasyonlarını yönetir.
- **float moveSpeed**: Karakterin yatay hareket hızı.
- **float jumpSpeed**: Zıplama kuvveti.
- **float jumpFrequensy**: Zıplamalar arasındaki minimum bekleme süresi.
- **float nextJumpTime**: Bir sonraki zıplamanın yapılabileceği zamanı belirtir.
- **bool facingRight**: Karakterin hangi yöne baktığını belirler (sağ veya sol).
- **bool isGrounded**: Karakterin yere değip değmediğini kontrol eder.
- **Transform groundCheckPosition**: Zemini kontrol etmek için referans pozisyon.
- **float groundCheckRadius**: Zeminin kontrol edildiği alanın yarıçapı.
- **LayerMask groundCheckLayer**: Zeminin hangi katmanda olduğunu tanımlar.

## Fonksiyonlar

- **Awake()**: Scriptin başında çalıştırılır. Şu an boş bırakılmıştır.
  
- **Start()**: Oyun başladığında çalıştırılır. `playerRB` ve `playerAnimator` bileşenlerini atar.

- **Update()**: Her karede çalışır. Aşağıdaki işlemleri yapar:
  - **HorizontalMove()**: Karakterin yatay hareketini sağlar.
  - **OnGroundCheck()**: Karakterin yere değip değmediğini kontrol eder.
  - **FlipFace()**: Karakterin hareket yönüne göre yüzünü çevirir.
  - **Jump()**: Karakter zıplar.

- **FixedUpdate()**: Her fiziksel güncellemede çalışır. Bu fonksiyon şu an için boş bırakılmıştır.

- **HorizontalMove()**: 
  - Karakterin yatay eksendeki hareketini sağlar. Oyuncunun girdiğine göre (`Input.GetAxis("Horizontal")`) hareket eder.
  - `playerSpeed` animasyon parametresi, karakterin hızına göre güncellenir.

- **FlipFace()**: Karakterin hareket yönüne göre yüzünü sola veya sağa çevirir.

- **Jump()**: Karakterin yukarıya doğru bir kuvvetle zıplamasını sağlar.

- **OnGroundCheck()**: Karakterin yere değip değmediğini kontrol eder ve bu bilgiye göre animasyonları ayarlar.

## Kullanım

Bu script, Unity'de bir **Rigidbody2D** ve **Animator** bileşenlerine sahip 2D karakterler için kullanılabilir. Karakterin hareketi, zıplaması ve yön değiştirmesi bu script ile kontrol edilir.

### Kullanım Adımları:
1. **Rigidbody2D** ve **Animator** bileşenleri olan bir oyun nesnesine script'i atayın.
2. **groundCheckPosition** ve **groundCheckLayer** ayarlarını yaparak karakterin yere değip değmediğini kontrol edin.
3. Karakterin hareket hızını ve zıplama gücünü ayarlamak için `moveSpeed` ve `jumpSpeed` değerlerini kullanın.

## Geliştirme

İleride şu özellikler eklenebilir:
- Karakterin çift zıplama veya uzun zıplama gibi yetenekleri eklenebilir.
- Zıplama ve hareket sırasında farklı animasyonlar entegre edilebilir.
- Farklı yüzey türlerine göre zıplama kuvveti ayarlanabilir.

## Kurulum

1. **Unity** ile yeni bir proje oluşturun.
2. Yukarıdaki **C#** scriptini bir dosyaya kopyalayın ve Unity projenize ekleyin.
3. Script'i, bir **Rigidbody2D** ve **Animator** bileşenine sahip olan bir oyun nesnesine atayın.
4. Gerekli ayarları yapın ve projeyi çalıştırın.

5.  #BTKAkademi https://www.btkakademi.gov.tr/portal/course/unity-ile-dijital-oyun-gelistirmeye-giris-10680
