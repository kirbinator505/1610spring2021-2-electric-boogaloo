using UnityEngine;
using UnityEngine.Events;

public class ClickBehavior : MonoBehaviour
{
    [SerializeField] private UnityEvent activate;

    private void OnMouseDown()
    {
        activate.Invoke();
    }

}
