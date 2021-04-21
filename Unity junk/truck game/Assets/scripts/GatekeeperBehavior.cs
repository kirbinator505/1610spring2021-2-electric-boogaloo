using UnityEngine;

public class GatekeeperBehavior : MonoBehaviour
{
    public BoolData KeyObj;

    private void OnTriggerEnter2D(Collider2D other)
    {
        KeyObj.value = true;
        gameObject.SetActive(false);
    }
}
