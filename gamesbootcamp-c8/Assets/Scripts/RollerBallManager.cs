using TMPro;
using UnityEngine;

public class RollerBallManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject bombPrefab;
    public TextMeshProUGUI gameEndText;
    public TextMeshProUGUI scoreText;
    public Transform startTransform;

    private int score = 0;
    private float timer = 0;


    public void CoinCollected() 
    {
        score++;
        scoreText.text = $"Score: {score}";
    }


    public void GameEnd(bool playerWon) 
    {
        // set some text
        if(playerWon) 
            gameEndText.text = "You've Won!";
        else
            gameEndText.text = "You've Lost!";

        gameEndText.GetComponentInParent<Canvas>().enabled = true;
    }

    public void ResetGame() 
    {
        playerHealth.transform.position = startTransform.position;
        score = 0;
        timer = 0;
        playerHealth.ResetHealth();

        for (int i = 0; i < 10; i++) 
        {
            float x = Random.Range(-10f,10f);
            float z = Random.Range(-10f,10f);

            GameObject go = Instantiate(bombPrefab);
            go.transform.position = new Vector3(x, 0, z);
        }
    }
    public void StartGame() 
    {
        ResetGame();
    }
}
