using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public static BGMusic instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
    }

 

    // ------------ USİNG EXAMPLE -----------

    //Make Instance

    //[SerializeField] private AudioSource Audio;
    //[SerializeField] private AudioClip deathSound;

    //Awake()

    //public void PlayDeathSound()
    //{
    //    AudioClip.PlayOneShot(deathSound);
    //}


    //CALL THE İNSTANCE

    //private bool isCharDead;

    //private void Start()
    //{
    //    if(isCharDead)
    //    {
    //        Singleton.Instance.PlayDeathSound();
    //    }
    //}






}
