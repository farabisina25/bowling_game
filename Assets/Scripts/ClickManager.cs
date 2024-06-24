using System;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    public Rigidbody rb;

    private bool isShoot;

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot(mousePressDownPos - mouseReleasePos);
    }

    private float forceMultiplier = 100f;

    void Shoot(Vector3 Force)
    {
        if (isShoot)
        {
            return;
        }
        rb.AddForce(new Vector3(Force.x, 0f, Force.y) * forceMultiplier);
        isShoot = true;
    }
}
