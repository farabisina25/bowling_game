using UnityEngine;

public class Cylinders : MonoBehaviour
{
    public static Cylinder[] cylinders;
    public int CylinderCount;
    public int DeleteCount = 0;
    public int TotalDelete = 0;

    private void Start()
    {
        cylinders = new Cylinder[transform.childCount];
        CylinderCount = transform.childCount;
        for (int i = 0; i < CylinderCount; i++)
        {
            cylinders[i] = transform.GetChild(i).GetComponent<Cylinder>();
        }
    }

    public void deleteCylinders()
    {
        DeleteCount = 0;
        for (int i = 0; i < CylinderCount; i++)
        {
            if (cylinders[i] != null && cylinders[i].IsMoved())
            {
                Destroy(cylinders[i].gameObject);
                DeleteCount++;
                TotalDelete++;
            }
        }
    }

    public bool IsFinish()
    {
        Debug.Log(TotalDelete + " , " + CylinderCount);
        if (TotalDelete < CylinderCount)
        {
            return false;
        }

        return true;
    }
}
