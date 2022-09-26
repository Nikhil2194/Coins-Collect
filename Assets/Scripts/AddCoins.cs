using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class AddCoins : MonoBehaviour
{
    public int coins= 0000;
    [SerializeField] ParticleSystem coinsAddEffect;

    public TextMeshProUGUI coinsText;
    [SerializeField] ParticleSystem clickEffect1;
    [SerializeField] ParticleSystem clickEffect2;
    [SerializeField] ParticleSystem clickEffect3;

    [SerializeField] AudioClip AudiocoinAdd;

    public GameObject upperPanel;

    [SerializeField] GameObject animcoinPrefabs1, animcoinPrefabs2, animcoinPrefabs3;
    [SerializeField] Transform target;

    //[Space]
    //[Header("Available coins :(coins to pool)")]
    //[SerializeField] int maxCoins;
    //Queue<GameObject> coinsQueue = new Queue<GameObject>();

    //[Space]
    //[Header("Animation Settings")]
    //[SerializeField] [Range(0.5f, 0.9f)] float minAnimDuration;
    //[SerializeField] [Range(0.9f, 2f)] float maxAnimDuration;
    //[SerializeField] Ease easeType;

    Vector3 targetPosition;

    //[SerializeField] int amount;
    //[SerializeField] Vector3 collectedCoinPosition;




    private void Awake()
    {
        coinsText = GetComponent<TextMeshProUGUI>();
        targetPosition = target.position;
        //PrepareCoins();
    }

    void Update()
    {
        coinsText.text = coins.ToString();
    }

    //void PrepareCoins()
    //{
    //    GameObject coin;
    //    for (int i =0; i< maxCoins; i++)
    //    {
    //        coin = Instantiate(animcoinPrefabs);
    //        coin.transform.parent = transform;
    //        coin.SetActive(false);
    //        coinsQueue.Enqueue(coin);
    //    }
    //}

    //void AnimateCoins(Vector3 collectedCoinPosition, int amount)
    //{
    //    Debug.Log("ANimate Coins");
    //    for(int i=0; i<amount; i++)
    //    {
    //        if(coinsQueue.Count >0)
    //        {
    //            GameObject coin = coinsQueue.Dequeue();
    //            coin.SetActive(true);

    //            coin.transform.position = collectedCoinPosition;

    //            float duration = Random.Range(minAnimDuration, maxAnimDuration);
    //            coin.transform.DOMove(targetPosition, duration).SetEase(easeType).OnComplete(()=> {
    //                coin.SetActive(false);
    //                coinsQueue.Enqueue(coin);
    //                coins++;
    //            });
    //        }
    //    }
    //}

   public void Card1(/*Vector3 collectedCoinPosition, int amount*/)
    {
        Debug.Log("Card1 pressed");
        animcoinPrefabs1.SetActive(true);
        LeanTween.moveLocal(animcoinPrefabs1, targetPosition, 0.6f);
        clickEffect1.Play();
        coins = coins + 6000;
        coinsAddEffect.Play();
        SoundManager.Instance.PlaySound(AudiocoinAdd);
        LeanTween.moveLocalY(upperPanel, 0, 0.5f);
    }

    public void Card2()
    {
        animcoinPrefabs2.SetActive(true);
        LeanTween.moveLocal(animcoinPrefabs2, targetPosition, 0.6f);
        clickEffect2.Play();
        coins = coins + 4000;
        coinsAddEffect.Play();
        SoundManager.Instance.PlaySound(AudiocoinAdd);
        LeanTween.moveLocalY(upperPanel, 0, 0.5f);
    }
    public void Card3()
    {
        animcoinPrefabs3.SetActive(true);
        LeanTween.moveLocal(animcoinPrefabs3, targetPosition, 0.6f);
        clickEffect3.Play();
        coins = coins + 3000;
        coinsAddEffect.Play();
        SoundManager.Instance.PlaySound(AudiocoinAdd);
        LeanTween.moveLocalY(upperPanel, 0, 0.5f);
    }
}
