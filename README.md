


  <h3><a href="https://github.com/AxtForest/UnityDesignPatterns/tree/main/Singletton%20Pattern%20Example">Singletton Pattern</a></h3>
  <p>  //TR:
     Singleton Pattern
     Unity’de yalnızca tek bir instance’a sahip olan ve
     proje genelinde tüm scriptler tarafından erişilebilen bir tasarım desenidir.
     Özellikle global yöneticilerde kullanılır.(score music menu ...)
     Birbirleriyle doğrudan bağlantısı olmayan obje ve scriptlerin
     merkezi bir yapı üzerinden haberleşmesini sağlar
     ve bu sayede kod karmaşıklığını ve iş yükünü azaltır.
   
   Ne zaman kullanılmalı?
     - Oyunda gerçekten tek olması gereken sistemlerde (AudioManager, GameManager)
     - Sahne boyunca değil, proje genelinde yönetilen yapılarda
     - Küçük ve orta ölçekli projelerde

   Ne zaman kullanılmamalı?
     - Birden fazla instance gerekebilecek sistemlerde
     - Sık değişen ve test edilmesi gereken yapılarda
     - Büyük ve modüler projelerde (bağımlılıkların net olması gerekiyorsa)
    
  </p>
  
