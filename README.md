

<p>⚠️ Note:
Detailed explanations are provided inside the "EXPLANATION" script file as English comments.
This README contains only the Turkish explanation for simplicity.
  </p>
  
  <h3><a href="https://github.com/AxtForest/UnityDesignPatterns/tree/main/Singletton%20Pattern%20Example">Singletton Pattern</a></h3>
  



  <p> 

Singleton Pattern, Unity’de yalnızca tek bir instance’a sahip olan ve
proje genelinde tüm scriptler tarafından erişilebilen bir tasarım desenidir.

Genellikle skor, müzik, menü veya oyun durumu gibi
global yöneticilerde (GameManager, AudioManager vb.) kullanılır.

Bu desen, birbirleriyle doğrudan bağlantısı olmayan
obje ve scriptlerin merkezi bir yapı üzerinden haberleşmesini sağlar.
Böylece kod karmaşıklığı azalır ve geliştirme süreci daha yönetilebilir hale gelir.

### Ne Zaman Kullanılmalı?
- Oyunda gerçekten tek olması gereken sistemlerde
- Sahne bazlı değil, proje genelinde yönetilen yapılarda
- Küçük ve orta ölçekli projelerde

### Ne Zaman Kullanılmamalı?
- Birden fazla instance gerekebilecek sistemlerde
- Sık değişen ve test edilmesi gereken yapılarda
- Büyük ve modüler projelerde (bağımlılıkların açık olması gerektiğinde)</p>
