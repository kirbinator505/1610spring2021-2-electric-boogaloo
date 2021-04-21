
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBehavior : MonoBehaviour
{
    public int num = 3;
    public float hold = 1f;
    public Text countdown;

    private WaitForSeconds time;
    private IEnumerator Start()
    {
        time = new WaitForSeconds(hold);

        while (num > 0)
        {
            countdown.text = num.ToString();
            num--;
            yield return time;

        }

        countdown.text = "GO";

        yield return time;

        countdown.text = null;
    }
}
