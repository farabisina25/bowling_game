using DG.Tweening;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private Vector3 start;

    public void Start()
    {
        start = transform.position;
    }
    
    public void ResetCylinder()
    {
        transform.DOMove(start, 1f);
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
