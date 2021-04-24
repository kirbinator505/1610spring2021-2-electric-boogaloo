using UnityEngine;
using TMPro;

public class PointCount : MonoBehaviour
{
    [SerializeField] private int creditValue = 3;
    public IntData numberCount;
    [SerializeField] private TextMeshProUGUI scoreText;


    void Awake()
    {
        numberCount.value = 0;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        numberCount.value += creditValue;
        scoreText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }

    public void Start()
    {
        scoreText.text = numberCount.value.ToString();
    }
}
