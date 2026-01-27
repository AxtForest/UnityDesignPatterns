using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WeaponController : MonoBehaviour
{
    

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] Transform firePointTransform;
    [SerializeField] private float bulletSpeed = 5f;
    Vector3 shootDirection;



    // QUEUE OLUŞTURDUK VE BÜYÜKLÜK BELİRLEDİK FIFO MANTIĞI İLE ÇALIŞIYOR (first in first out)
    // We created a Queue with a fixed size, it works with FIFO logic (First In First Out)
    private Queue<GameObject> bulletPool;
    private const int POOL_SIZE = 10;
    private void Start()
    {

        // POOL OLUŞTURMA 10 tane mermi ile doldurduk enqueue ile poola ekleme yapılır
        // Creating the pool and filling it with 10 bullets using Enqueue
        bulletPool = new Queue<GameObject>();

        for(int i = 0;  i <POOL_SIZE; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }
    void Update()
    {
        HandleAiming();
        HandleShooting();
    }



    // POOLDAN OBJEYİ ÇEKME eğer poolda 0dan fazla bişi varsa o kurşunu azaltıyoruz setActive true yapıyoruz
    // yoksa null diyoruz
    // Getting an object from the pool; if there is any bullet available, activate and return it
    // If the pool is empty, return null
    private GameObject GetBulletFromPool()
    {
        if(bulletPool.Count>0)
        {
            GameObject bullet = bulletPool.Dequeue();
            bullet.SetActive(true);
            return bullet;
        }

        return null;
    }


    // İŞ BİTİNCE POOLA GERİ GÖNDERME burada ise tam tersi false yapıp poola ekliyoruz
    // tabi bunun için bir süre belirlemek gerekiyor
    // Returning the bullet back to the pool by disabling it and enqueueing again
    // Usually this happens after a certain delay
    private void ReturnBulletToPool(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);
    }


   

    private void HandleAiming()
    {
        Vector2 dir = (Vector2)Input.mousePosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        shootDirection = dir;

    }


    // burada çalıştırıyoruz mouseye bastığımızda bullet pooldan çıkıyor istenen yere gidiyor
    // ve sonra coroutine çalışıyor, 2 saniye sonra disable edip poola geri ekliyoruz
    // When mouse button is pressed, we take a bullet from the pool, shoot it,
    // then start a coroutine to disable it after 2 seconds and return it to the pool
    private void HandleShooting()
    {
        if(Input.GetMouseButtonDown(0))
        {


            // OBJECT POOLING SAYESİNDE BU KODLARDAN TAMAMEN KURTULUYORUZ
            // Sürekli Instantiate ve Destroy yapmadığımız için daha performanslı oluyor
            // Thanks to object pooling, we avoid Instantiate & Destroy calls
            // This makes the game much more optimized

            //GameObject bullet = Instantiate(bulletPrefab, firePointTransform.position, Quaternion.identity);
            //Destroy(bullet, 2f);


            GameObject bullet = GetBulletFromPool();

            if(bullet !=null)
            {
                bullet.transform.position = firePointTransform.position;

                bullet.SetActive(true);

                Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
                bulletRigidbody.linearVelocity = shootDirection * bulletSpeed;

                StartCoroutine(DisableBulletAfterDelay(bullet, 2f));

            }



        }

    }



    // burada delayi ve objeyi tanıtıyoruz, kurşunu 2 saniye sonra işleme sok gibi
    
    // Here we define the delay and the bullet reference,
    // basically saying: process this bullet after 2 seconds
    
    private IEnumerator DisableBulletAfterDelay(GameObject bullet , float delay)
    {
        yield return new WaitForSeconds(delay);

        ReturnBulletToPool(bullet);

    }
}
