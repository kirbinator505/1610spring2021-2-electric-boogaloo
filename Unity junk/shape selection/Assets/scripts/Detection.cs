using UnityEngine;

public class Detection : MonoBehaviour
{
    public StringData word;

    private int number;
    private GameObject shape;
    
    private void Update()
    {
        switch (number)
        {
            case 1:
                word.shape = "the capsule";
                break;
            case 2:
                word.shape = "the hexagon";
                break;
            case 3:
                word.shape = "the square";
                break;
            case 0:
                word.shape = "nothing";
                break;
            default:
                word.shape = "nothing";
                break;
        }

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        shape = other.gameObject;
        number = shape.GetComponent<IntegerAssignment>().value;
    }

    private void OnTriggerExit2D()
    {
        number = 0;
    }
}
