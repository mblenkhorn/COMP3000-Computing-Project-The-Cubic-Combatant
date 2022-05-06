using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : AudioManager
{
    public AudioSource music, victoryMusic, gameOverMusic;

    public static MusicManager instance;
    
    // Start is called before the first frame update
    void Start()
    {
        PlaySound(music);
        instance = this;
      
    }

    public override void PlaySound(AudioSource sound)
    {
        sound.Stop();
        sound.Play();
        sound.playOnAwake = true;
        sound.loop = true;
    }

    
}
