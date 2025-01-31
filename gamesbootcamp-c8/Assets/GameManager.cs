
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rigidbody ball;
    public TextMeshProUGUI textPrompt;
    public Canvas canvas;

    public void GameOver() 
    {
        ball.gameObject.SetActive(false);
        canvas.enabled = true;
        textPrompt.text = "GAME OVER";
    }

    public void StartGame() 
    {
        ball.gameObject.SetActive(true);
        ball.transform.position = new Vector3(0, 10, 0);
        ball.velocity = Vector3.zero;
        
        canvas.enabled = false;
    }

}
