using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSpriteChange : MonoBehaviour
{
    public GameObject quefrontcard1, quefrontcard2, quefrontcard3;
    public GameObject coinsbackcard1, coinsbackcard2, coinsbackcard3;
    public GameObject shuffleButton,collectButton;
    public GameObject card1Border, card2Border, card3Border;


    [SerializeField] GameObject CARD1, CARD2, CARD3;

    [SerializeField] AudioClip AudiocardClick, AudioShuffleclik;

    
    void ShuffleButtonAnim()
    {
        LeanTween.scale(shuffleButton, new Vector3(2.15f, 2.15f, 2.15f), 7.5f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
    }

    void CollectButtonAnim()
    {
        //LeanTween.move(collectButton.GetComponent<RectTransform>(), new Vector3(0f, -320f, 0f), 4.8f).setDelay(0.4f);
        LeanTween.scale(collectButton, new Vector3(2.84f, 2.84f, 2.84f), 4.8f).setDelay(0.6f).setEase(LeanTweenType.easeOutElastic);
        // LeanTween.scale(shuffleButton, new Vector3(2.84f, 2.84f, 2.84f), 2.5f).setDelay(0.6f).setEase(LeanTweenType.easeOutElastic);
    }

   

    public void Button1Disable()
    {
        SoundManager.Instance.PlaySound(AudiocardClick);
        quefrontcard1.SetActive(false);
        LeanTween.scale(coinsbackcard1, new Vector3(2.27f, 17.87f, 4f), 0.19f);
        card1Border.SetActive(true);
        //coinsbackcard1.gameObject.SetActive(true);
        CollectButtonAnim();
        ShuffleButtonAnim();
    }


    public void Button2Disable()
    {
        SoundManager.Instance.PlaySound(AudiocardClick);
        quefrontcard2.SetActive(false);
        LeanTween.scale(coinsbackcard2, new Vector3(2.27f, 17.87f, 4f), 0.19f);
        card2Border.SetActive(true);
        // coinsbackcard2.gameObject.SetActive(true);
        CollectButtonAnim();
        ShuffleButtonAnim();
    }

    public void Button3Disable()
    {
        SoundManager.Instance.PlaySound(AudiocardClick);
        quefrontcard3.SetActive(false);
        LeanTween.scale(coinsbackcard3, new Vector3(2.27f, 17.87f, 4f), 0.19f);
        card3Border.SetActive(true);
        // coinsbackcard3.gameObject.SetActive(true);
        CollectButtonAnim();
        ShuffleButtonAnim();
    }


    public void ShuffleCards()
    {
        SoundManager.Instance.PlaySound(AudioShuffleclik);
 
        LeanTween.move(CARD1.GetComponent<RectTransform>(), new Vector3(Random.Range(0, 788), 0, 0), 0.13f);
        LeanTween.move(CARD2.GetComponent<RectTransform>(), new Vector3(Random.Range(-365, 394), 0, 0), 0.13f);
        LeanTween.move(CARD3.GetComponent<RectTransform>(), new Vector3(Random.Range(0, -785), 0, 0), 0.13f);

        quefrontcard1.SetActive(true);
        coinsbackcard1.gameObject.SetActive(false);

        quefrontcard2.SetActive(true);
        coinsbackcard2.gameObject.SetActive(false);

        quefrontcard3.SetActive(true);
        coinsbackcard3.gameObject.SetActive(false);

        collectButton.SetActive(false);

        card1Border.SetActive(false);
        card2Border.SetActive(false) ;
        card3Border.SetActive(false);
    }
}
