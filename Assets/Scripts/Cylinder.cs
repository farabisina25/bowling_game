using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private Vector3 start;

    public void Start()
    {
        start = transform.position;
    }

    public bool IsMoved()
    {
        if (transform.position != start)
        {
            return true;
        }

        return false;
    }
}
