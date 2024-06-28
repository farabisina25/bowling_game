using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    public Rigidbody rb;
    public Ball ball;
    public bool isShoot;

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

    public async void Shoot(Vector3 Force)
    {
        if (isShoot)
        {
            return;
        }
        rb.AddForce(new Vector3(Force.x, 0f, Force.y) * forceMultiplier);
        isShoot = true;
        await UniTask.Delay(TimeSpan.FromSeconds(2f), DelayType.DeltaTime, PlayerLoopTiming.Update);
        ball.IsStart = false;
    }
}
