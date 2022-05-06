using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : AudioManager
{
    public AudioSource confirmSelection, collectSound, hurtSound, dieSound, checkPointSound, switchPressedSound;

    public static FXManager instance;

    private void Start()
    {
        instance = this;
    }

    // Start is called before the first frame update
    public override void PlaySound(AudioSource sound)
    {
        sound.Stop();
        sound.Play();
    }
}
