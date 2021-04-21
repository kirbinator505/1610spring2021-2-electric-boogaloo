using UnityEngine;

public class BoostBehavior : MonoBehaviour
{
    public bool havekey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (havekey)
        {
            print(true);
        }
    }
}
