
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






<h3><a href="https://github.com/AxtForest/UnityDesignPatterns/tree/main/Object%20Pooling%20Pattern/Assets">Object Pooling Pattern</a></h3>



  <p> 

Object Pooling Pattern, oyun sırasında sıkça oluşturulup yok edilen nesnelerin (mermi, düşman, efekt vb.) önceden oluşturulup tekrar tekrar kullanılmasını sağlayan bir tasarım desenidir.

Bu desen, Instantiate ve Destroy işlemlerinin maliyetini azaltarak performansı artırır ve özellikle yoğun sahnelerde daha stabil bir oyun deneyimi sunar.

Object Pooling sayesinde nesneler yok edilmek yerine pasif hale getirilir ve ihtiyaç duyulduğunda tekrar aktif edilerek kullanılır.

### Ne Zaman Kullanılmalı?
- Sık sık oluşturulup yok edilen objelerde (mermi, particle, enemy, UI popup vb.)
- Performansın kritik olduğu sahnelerde
- Mobil ve düşük donanımlı platformlarda

### Ne Zaman Kullanılmamalı?
- Nadir kullanılan veya tek seferlik objelerde
- Sayısı çok az ve performans etkisi olmayan yapılarda
- Karmaşıklığın fazla olduğu küçük sistemlerde
  </p>

<p align="center">
  <b>Before Pooling</b> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  <b>After Pooling</b>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/01e402d1-eb1c-4cda-a852-c08bac3b09a0" width="45%" />
  <img src="https://github.com/user-attachments/assets/825d53d2-9f53-4433-9e11-5b04394fa0b6" width="45%" />
</p>



  
