using UnityEngine.UI;
using UnityEngine;

public class GameText : MonoBehaviour
{
    public GameManager gm;

    public Text shoottext;

    public Text leveltext;

    public Text scoretext;
    // Update is called once per frame
    void Update()
    {
        shoottext.text = "Shoot " + gm.ShootCount + "/3";
        leveltext.text = "Level " + gm.Level;
        scoretext.text = "Score: " + gm.Score;
    }
}
