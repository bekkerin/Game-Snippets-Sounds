using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baaing: MonoBehaviour
{
    public static int baas =1;
    public Text Baas;
    public AudioClip BaaSound;
    public AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>(); 
    }
    public void DecreaseBaas()
    {
        baas -= 1;
        Baas.text = baas.ToString();
        Debug.Log(baas);
        for(int x = 1; x <= baas; x++)
        {
            audiosource.PlayOneShot(BaaSound);
            
        }
    }
    public void IncreaseBaas()
    {
        baas += 1;
        Baas.text = baas.ToString();
        Debug.Log(baas);
        for (int x = 1; x <= baas; x++)
        {
            //audiosource.PlayOneShot(BaaSound);
            //GetComponent<AudioSource>().Play();
            audiosource.Play();

        }

    }

    public void StartBaas()
    {
        audiosource.Play();
    }

    public void PauseBaas()
    {
        audiosource.Pause();
    }

    public void ResumeBaas()
    {
        audiosource.UnPause();
    }
}
