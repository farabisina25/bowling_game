using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public Cylinders cylinders;

    private void Start()
    {
        cylinders = GetComponentInChildren<Cylinders>();
    }
}
