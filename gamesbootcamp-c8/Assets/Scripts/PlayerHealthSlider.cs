using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSlider : MonoBehaviour
{
    public float lerpSpeed = 1;

    private Slider slider;
    private float targetValue = 1;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        float currentValue = slider.value;
        slider.value = Mathf.MoveTowards(currentValue, targetValue, 
            lerpSpeed * Time.deltaTime);

    }

    public void SetTarget(float value)
    {
        targetValue = value;
    }
}
