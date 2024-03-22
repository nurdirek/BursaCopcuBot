using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodlar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("EnYuksekSkor", 500);
        float enYuksek = PlayerPrefs.GetFloat("EnYuksekSkor");
        PlayerPrefs.SetFloat("EnYuksek", 500);
        float enYuksekSkor = PlayerPrefs.GetFloat("EnYuksek", 500);
        PlayerPrefs.SetInt("PuanSayaci", 0);
        //print(PlayerPrefs.GetInt("PuanSayaci",0));
        PlayerPrefs.SetString("OyuncuAdi", "Oyuncu 1");
        //print(PlayerPrefs.GetString("OyuncuAdi", "oyuncu 1"));
        PlayerPrefs.DeleteKey("OyuncuAdi");
        print(PlayerPrefs.GetString("OyuncuAdi", "Oyuncu 1"));
        PlayerPrefs.DeleteAll();
        print(PlayerPrefs.GetFloat("EnYuksek", 500));

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash")) // Eðer çöp nesnesine temas ederse
        {
            PlayerPrefs.SetInt("PuanSayaci", PlayerPrefs.GetInt("PuanSayaci") + 1); // Puaný artýr
            Debug.Log("Puan: " + PlayerPrefs.GetInt("PuanSayaci")); // Puaný konsola yazdýr (opsiyonel)

            // Temas edilen çöp nesnesini yok et
            Destroy(other.gameObject);
        }
    }

}
