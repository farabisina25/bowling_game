using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LevelManager LevelManager;
    public Ball ball;
    public float timer = 0f;
    public int ShootCount = 1;
    public int Level = 1;
    public int Score = 0;
    private void FixedUpdate()
    {
        if (ball.IsStart == false)
        {
            timer += Time.deltaTime;
            if (ball.ballrb.velocity.magnitude <= 0.1f || timer >= 6)
            {
                Cylinders cylinders = LevelManager.Level1Prefab.GetComponentInChildren<Cylinders>();
                timer = 0f;
                ball.ResetBall();
                cylinders.deleteCylinders();
                Score += cylinders.DeleteCount * 10; 
                if (cylinders.IsFinish())
                {
                    ShootCount = 1;
                    Level++;
                    cylinders.TotalDelete = 0;
                    LevelManager.RestartLevel().Forget();
                }
                else
                {
                    if (ShootCount < 3)
                    {
                        ShootCount++;
                    }
                    else
                    {
                        ShootCount = 1;
                        Level = 1;
                        Score = 0;
                        cylinders.TotalDelete = 0;
                        LevelManager.RestartLevel().Forget();
                    }
                }
            }
        }
    }
}
