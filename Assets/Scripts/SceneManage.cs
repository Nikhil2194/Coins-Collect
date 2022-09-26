using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour

{
    [SerializeField] GameObject star1, star2;
    [SerializeField] AudioClip homereplayAudio;

    private void Start()
    {
        LeanTween.rotateAround(star1, Vector3.forward, -360, 5f).setLoopClamp();
        LeanTween.rotateAround(star2, Vector3.forward, -360, 5f).setLoopClamp();
    }
    public void Replay()
    {
       
        Debug.Log("Replay pressed");
        SceneManager.LoadScene("GamePlay");
        SoundManager.Instance.PlaySound(homereplayAudio);

    }

    public void Home()
    {
        Debug.Log("Home pressed");
        SceneManager.LoadScene("Start");
        SoundManager.Instance.PlaySound(homereplayAudio);
    }
}
