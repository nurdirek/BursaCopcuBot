using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // M�zik dosyan�z� buraya s�r�kleyip b�rak�n
    private AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource bile�enini olu�turup ayarlayal�m
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.loop = true; // M�zi�i s�rekli olarak d�ng�ye alal�m
        musicSource.playOnAwake = true; // Oyun ba�lad���nda m�zi�i �almaya ba�las�n
        musicSource.volume = 0.5f; // M�zik ses seviyesi (0 ile 1 aras�nda)

        // M�zi�i �almak i�in
        musicSource.Play();
    }
}

