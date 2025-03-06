using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;



    //A reference to our input manager
    [SerializeField] private InputManager inputManager;

    void Start()
    {
        scoreText.text = "Score: " + score;

    }

    void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }



   



}
