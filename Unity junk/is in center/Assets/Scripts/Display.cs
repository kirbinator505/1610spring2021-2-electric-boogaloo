using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public BoolData detect;
    public Text display;
    void Update()
    {
        if (detect.value)
        {
            display.text = "you are in the square";
        }
        
        if (detect.value == false)
        {
            display.text = "you are out of the square";
        }
    }
}
