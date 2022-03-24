using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kaydetme : MonoBehaviour
{

    public sayac deger;
    public Text skor1,skor2,skor3,skor4,skor5;
    public int toplam_skor,yuksek_skor;
    public GameObject canvas1, canvas2;
    public bool ac_kapa;

    private void Awake()
    {
        skor1.text = "" + PlayerPrefs.GetInt("skor1");

    }
    void Start()
    {
        skor1.text = "" + PlayerPrefs.GetInt("skor1");
    }

    void Update()
    {

        toplam_skor = deger.sayacim;
        yuksek_skor = toplam_skor;
        //skor1.text = "" + toplam_skor;
        Debug.Log("Hafýzadaki Skor" + PlayerPrefs.GetInt("skor1"));
        skor1.text = "" + PlayerPrefs.GetInt("skor1");

    }
    public void kaydet()
    {       
        PlayerPrefs.SetInt("skor1", yuksek_skor);

        if (ac_kapa)
        {
            deger.durdur = false;
            ac_kapa = false;
            canvas1.SetActive(false);
            canvas2.SetActive(true);
        }
       
    }
}
