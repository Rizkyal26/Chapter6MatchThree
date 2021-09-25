using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton

    private static SoundManager _instance = null;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SoundManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public AudioClip scoreNormal;
    public AudioClip scoreNormal2;
    public AudioClip scoreCombo;
    public AudioClip scoreCombo2;


    public AudioClip wrongMove;

    public AudioClip tap;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void PlayScore(bool isCombo)
    {
        if (isCombo)
        {
            player.PlayOneShot(scoreCombo);
            player.PlayOneShot(scoreCombo2);
        }
        else
        {
            player.PlayOneShot(scoreNormal);
            player.PlayOneShot(scoreNormal2);
        }
    }

    public void PlayWrong()
    {
        player.PlayOneShot(wrongMove);
    }

    public void PlayTap()
    {
        player.PlayOneShot(tap);
    }
}