using DG.Tweening;
using UnityEngine;

public class Ball : MonoBehaviour
{
   public Collider collider;
   public Rigidbody ballrb;
   public bool IsStart = true;
   public ClickManager click;
   public Vector3 start = new Vector3(0f, 2.5f, -50f);
   
   public void ResetBall()
   {
      collider.enabled = false;
      ballrb.isKinematic = true;
      transform.DOJump(start, 10f, 1, 2f).OnComplete((() =>
      {
         ballrb.isKinematic = false;
         collider.enabled = true;
      }));
      IsStart = true;
      click.isShoot = false;
   }
}
