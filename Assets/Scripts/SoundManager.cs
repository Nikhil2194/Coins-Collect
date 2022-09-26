using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource music, effect;

    private void Awake()
    {
        if(Instance ==null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }

    }

    public void PlaySound(AudioClip clip)
    {
        effect.PlayOneShot(clip);
    }
}
