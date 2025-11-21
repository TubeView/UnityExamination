using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource coinSound;
    public AudioSource coinCollect;
    public UICounter uiCounter;
    public GameObject nextCoin;
    public GameObject coin;
    void Start()
    {
        coinSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectCoin()
    {
        coinSound.Stop();
        coinCollect.Play();
        uiCounter.add = 1;
        NextCoin();
        GameObject.Destroy(coin);
    }
    public void NextCoin()
    {
        nextCoin.SetActive(true);
    }
}
