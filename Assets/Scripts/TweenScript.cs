using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScript : MonoBehaviour
{
    [SerializeField] GameObject colorWheel,magicPickRibbon;
    [SerializeField] GameObject gameBerryLogo,gameBerryText,clickonAnyCard;
    [SerializeField] GameObject CARD1gameobj, CARD2gameobj, CARD3gameobj;  //Whole gameobject include front & back card
    [SerializeField] GameObject quefrontcard1Button1, quefrontcard2Button2, quefrontcard3Button3 ; //Front card sprite
    [SerializeField] GameObject coinsbackcard1Button1, coinsbackcard2Button2, coinsbackcard3Button3;//back card sprite

    void Start()
    {
        LeanTween.rotateAround(colorWheel, Vector3.forward, -360, 10f).setLoopClamp(); //Rotate BG colour wheel

        // LeanTween.rotateLocal(card1Button1, new Vector3(0, 180, 0), 0.5f).setLoopPingPong(1);  //Rotate on Y axis for Card1 buttons
        // LeanTween.rotateLocal(card1Button2, new Vector3(0, 180, 0), 1f).setLoopPingPong(1);  //Rotate on Y axis for Card2 buttons
        // LeanTween.rotateLocal(card1Button3, new Vector3(0, 180, 0), 1.5f).setLoopPingPong(1);  //Rotate on Y axis for Card3 buttons

       

        LeanTween.move(magicPickRibbon.GetComponent<RectTransform>(), new Vector3(0f, 756, 0f), 0.51f).setDelay(2.1f);  //MagicPic Animation

        LeanTween.move(gameBerryLogo.GetComponent<RectTransform>(), new Vector3(-405, -830f, 0), 1f).setDelay(4);
        LeanTween.move(gameBerryText.GetComponent<RectTransform>(), new Vector3(11, 208, 0), 01f).setDelay(6);

        LeanTween.scale(clickonAnyCard, new Vector3(1f, 1f, 1f), 3.5f).setDelay(7.6f).setEase(LeanTweenType.easeOutElastic);

        //CARD ANIM START placement on the screen
        LeanTween.move(CARD1gameobj.GetComponent<RectTransform>(), new Vector3(-398f, 0, 0f), 0.9f).setDelay(1f);
        LeanTween.move(CARD2gameobj.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), 0.9f).setDelay(1.2f);
        LeanTween.move(CARD3gameobj.GetComponent<RectTransform>(), new Vector3(392f, 0f, 0f), 0.9f).setDelay(1.4f);


        //CARD ROTATE ANIM for disabling 
        LeanTween.rotateAround(CARD1gameobj, Vector3.up,360,0.5f).setDelay(5f).setLoopCount(2); 
        LeanTween.rotateAround(CARD2gameobj, Vector3.up, 360, 0.5f).setDelay(5.2f).setLoopCount(2);
        LeanTween.rotateAround(CARD3gameobj, Vector3.up, 360, 0.5f).setDelay(5.4f).setLoopCount(2);

        //CARD HIDE COINS ANIM return to front side
        LeanTween.scale(coinsbackcard1Button1, new Vector3(0, 0, 0), 0.09f).setDelay(5.4f);
        LeanTween.scale(coinsbackcard2Button2, new Vector3(0, 0, 0), 0.09f).setDelay(5.6f);
        LeanTween.scale(coinsbackcard3Button3, new Vector3(0, 0, 0), 0.09f).setDelay(5.8f);



        //CARD SHUFFLE ANIM
        /* LeanTween.move(CARD1gameobj.GetComponent<RectTransform>(), new Vector3(Random.Range(0, 788), 0, 0), 0.13f).setDelay(8f).setLoopCount(1);
          LeanTween.move(CARD2gameobj.GetComponent<RectTransform>(), new Vector3(Random.Range(-365, 394), 0, 0), 0.13f).setDelay(8.2f).setLoopCount(2);
          LeanTween.move(CARD3gameobj.GetComponent<RectTransform>(), new Vector3(Random.Range(0, -785), 0, 0), 0.13f).setDelay(8.4f).setLoopCount(3);*/

        LeanTween.move(CARD1gameobj.GetComponent<RectTransform>(), new Vector3(383, 0, 0), 0.5f).setDelay(7f).setEaseInBack();
        LeanTween.move(CARD2gameobj.GetComponent<RectTransform>(), new Vector3(-364, 0, 0), 0.5f).setDelay(7.2f).setLoopCount(1);
        LeanTween.move(CARD3gameobj.GetComponent<RectTransform>(), new Vector3(11, 0, 0), 0.5f).setDelay(7.3f).setLoopCount(1);

        LeanTween.move(CARD1gameobj.GetComponent<RectTransform>(), new Vector3(0, 0, 0),0.5f).setDelay(7.9f).setLoopCount(1);
        LeanTween.move(CARD2gameobj.GetComponent<RectTransform>(), new Vector3(386, 0, 0), 0.5f).setDelay(8.2f).setLoopCount(1);
        LeanTween.move(CARD3gameobj.GetComponent<RectTransform>(), new Vector3(-388, 0, 0), 0.5f).setDelay(8.5f).setLoopCount(1);
    }

    private void Update()
    {
       //StartCoroutine(backcarddisable());
  

       // if(Time.time>=15f)
       // {
       //     Debug.Log("Stop couroutune");
       //     StopCoroutine(backcarddisable());
       // }
       
    }


    IEnumerator backcarddisable()
    {
        yield return new WaitForSeconds(6f);
        //backcard1Button1.SetActive(false);
        //backcard2Button2.SetActive(false);
        //backcard3Button3.SetActive(false);
       /* quefrontcard1Button1.SetActive(true);
        quefrontcard2Button2.SetActive(true);
        quefrontcard3Button3.SetActive(true);*/
    }

    IEnumerator rotatebackcard()
    {
        yield return new WaitForSeconds(10f);
        Debug.Log("2nd coroutine started");
        LeanTween.rotateAround(CARD1gameobj, Vector3.forward, -360, 5f).setLoopCount(2);
        //LeanTween.rotate(CARD1gameobj, new Vector3(0, 180, 0), 0.5f).setLoopPingPong(1);  //Rotate on Y axis for Card1 buttons
        // LeanTween.rotate(CARD2gameobj, new Vector3(0, 180, 0), 1f).setLoopPingPong(1);  //Rotate on Y axis for Card2 buttons
        //  LeanTween.rotate(CARD3gameobj, new Vector3(0, 180, 0), 1.5f).setLoopPingPong(1);  //Rotate on Y axis for Card3 buttons
    }

  

  
}
