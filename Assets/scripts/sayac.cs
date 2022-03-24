using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sayac : MonoBehaviour
{
    public int sayacim,renksayacim;
    public Text sayactext;
    public Toggle checkbox;

    public Animator anim;
    public bool durdur=true;
    private bool skgoster;
    public Kaydetme kydetme;
    void Start()
    {
        renksayacim = 0;
        checkbox.isOn = false;
        anim.SetBool("animsON_OF", false);
    }

    void Update()
    {
        kydetme = GetComponent<Kaydetme>();
        sayactext.text = sayacim.ToString();
       

        if (checkbox.isOn==true)
        {
            anim.SetBool("animsON_OF", true);
        }
        else
        {
            anim.SetBool("animsON_OF", false);

        }

    }

    public void sayac_sifirla()
    {
        sayacim = 0;
        PlayerPrefs.DeleteKey("skor1");
    }

    public void saydir()
    {      
            if (durdur)
            {
                sayacim += 1;
            }     
    }

    public void skorgoster()
    {
        if (kydetme.ac_kapa == true)
        {
            kydetme.canvas1.SetActive(false);
            kydetme.canvas2.SetActive(true);
            kydetme.ac_kapa = false;
        }
    }

    public void gerigel()
    {

        if (kydetme.ac_kapa==false)
        {
            kydetme.deger.durdur = true;
            kydetme.ac_kapa = true;
            kydetme.canvas1.SetActive(true);
            kydetme.canvas2.SetActive(false);
        }


    }
    
    
}
