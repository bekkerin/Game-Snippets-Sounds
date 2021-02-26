using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mooing : MonoBehaviour
{
    public static int moos = 1;
    public Text Moos;
    public AudioClip MooSound;
    public AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void DecreaseMoos()
    {
        moos -= 1;
        Moos.text = moos.ToString();
        Debug.Log(moos);

        audiosource.PlayOneShot(MooSound);
    }
    public void IncreaseMoos()
    {
        moos += 1;
        Moos.text = moos.ToString();
        Debug.Log(moos);

        audiosource.PlayOneShot(MooSound);
    }

    public void StartMoos()
    {
        audiosource.Play();
    }
    public void PauseMoos()
    {
        audiosource.Pause();
    }
    public void ResumeMoos()
    {
        audiosource.UnPause();
    }
}
