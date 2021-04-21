using UnityEngine;
using System.Collections;

public class BallDuplicator : MonoBehaviour
{
    public GameObject ball;
    private int _boi = 0;

    IEnumerator Start()
    {
        while (_boi < 25)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(ball);
            _boi++;
        }
    }
}

