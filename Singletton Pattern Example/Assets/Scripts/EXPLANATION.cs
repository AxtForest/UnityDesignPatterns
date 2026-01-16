using UnityEngine;

public class EXPLANATION : MonoBehaviour
{


    // TR:
    // Singleton Pattern
    // Unity’de yalnızca tek bir instance’a sahip olan ve
    // proje genelinde tüm scriptler tarafından erişilebilen bir tasarım desenidir.
    // Özellikle global yöneticilerde kullanılır.(score music menu ...)
    // Birbirleriyle doğrudan bağlantısı olmayan obje ve scriptlerin
    // merkezi bir yapı üzerinden haberleşmesini sağlar
    // ve bu sayede kod karmaşıklığını ve iş yükünü azaltır.
   
    // Ne zaman kullanılmalı?
    // - Oyunda gerçekten tek olması gereken sistemlerde (AudioManager, GameManager)
    // - Sahne boyunca değil, proje genelinde yönetilen yapılarda
    // - Küçük ve orta ölçekli projelerde

    // Ne zaman kullanılmamalı?
    // - Birden fazla instance gerekebilecek sistemlerde
    // - Sık değişen ve test edilmesi gereken yapılarda
    // - Büyük ve modüler projelerde (bağımlılıkların net olması gerekiyorsa)





    // EN:
    // Singleton Pattern
    // A design pattern that ensures only a single instance exists in Unity
    // and allows access to it from anywhere in the project.
    // Commonly used for global managers.(score music menu ...)
    // It enables communication between unrelated objects and scripts
    // through a central structure, reducing code complexity and workload.

    
    // When to use?
    // - For systems that must have only one instance (AudioManager, GameManager)
    // - For project-wide managers, not per-scene objects
    // - In small to medium-sized projects

    // When not to use?
    // - When multiple instances may be needed
    // - For systems that require frequent testing and flexibility
    // - In large, modular projects where clear dependencies are important


}
