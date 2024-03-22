using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // Müzik dosyanýzý buraya sürükleyip býrakýn
    private AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource bileþenini oluþturup ayarlayalým
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.loop = true; // Müziði sürekli olarak döngüye alalým
        musicSource.playOnAwake = true; // Oyun baþladýðýnda müziði çalmaya baþlasýn
        musicSource.volume = 0.5f; // Müzik ses seviyesi (0 ile 1 arasýnda)

        // Müziði çalmak için
        musicSource.Play();
    }
}

