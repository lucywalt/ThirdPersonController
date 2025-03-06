using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Coin coin1;
    [SerializeField] private Coin coin2;
    [SerializeField] private Coin coin3;
    [SerializeField] private Coin coin4;
    [SerializeField] private Coin coin5;


    //A reference to our input manager
    [SerializeField] private InputManager inputManager;

    void Start()
    {
        Coin[] coins = { coin1, coin2, coin3, coin4, coin5 };
        scoreText.text = "Score: " + score;
        foreach (Coin c in coins)
        {
            c.OnCoin.AddListener(IncrementScore);
        }
        
    }

    void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }



   



}
