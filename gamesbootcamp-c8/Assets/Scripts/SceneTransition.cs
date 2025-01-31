using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public float speed = 1.0f;
    public Image background;
    public Color backgroundColour = Color.clear;

    private int sceneToLoad;
    private float targetA;
    private bool loadScene;
    
    
    
    public static SceneTransition Instance;



    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Update()
    {
        if (loadScene) 
        {
            backgroundColour.a = Mathf.MoveTowards(backgroundColour.a,
                targetA, Time.deltaTime * speed);

            background.color = backgroundColour;

            if(backgroundColour.a == targetA) //have finished fading 
            {
                if (targetA == 1) //fading in
                {
                    SceneManager.LoadScene(sceneToLoad);
                    FadeOut();
                }
                else // fading out 
                {
                    loadScene = false;
                    background.gameObject.SetActive(false);
                }
            }
        }


        if (!loadScene && Input.GetKeyDown(KeyCode.P)) 
        {
            LoadScene(0);
        }
    }

    public void LoadScene(int index) 
    {
        sceneToLoad = index;
        loadScene = true;
        FadeIn();
    }

    private void FadeIn() 
    {
        targetA = 1;
        background.gameObject.SetActive(true);
    }

    private void FadeOut() 
    {
        targetA = 0;
    }
}
