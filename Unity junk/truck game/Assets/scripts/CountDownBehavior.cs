
using System.Collections;
using UnityEngine;
using TMPro;

public class CountDownBehavior : MonoBehaviour
{
    [SerializeField] private int num = 3;
    [SerializeField] private float hold = 1f;
    [SerializeField] private TextMeshProUGUI countDown;

    private WaitForSeconds time;
    private IEnumerator Start()
    {
        time = new WaitForSeconds(hold);

        while (num > 0)
        {
            countDown.text = num.ToString();
            num--;
            yield return time;

        }

        countDown.text = "GO";

        yield return time;

        countDown.text = null;
    }
}
