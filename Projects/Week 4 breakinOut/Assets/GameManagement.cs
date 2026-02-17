using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public static GameManagement S;

    public int HighScore;

    //dynamic difficulties control
    public float windowSeconds = 15f;
    public int targetDestroy = 10;
    private float windowStartTime;
    private int destroyedInWindows;
    public bool hardModeActive = false;

    //brick movement
    public float moveAmplitude = 1.5f;
    public float moveSpeed = 2f;

    private BrickLayer brickLayer;




    //public SceneManager sceneManager;

    void Awake()
    {
        S = this;

        DontDestroyOnLoad(this);
    }

    void Start()
    {
        ResetChallengeState();
        FindBrickLayer();
    }

    void FindBrickLayer()
    {
        brickLayer = FindFirstObjectByType<BrickLayer>();
    }

    public void ResetChallengeState()
    {
        windowStartTime = Time.time;
        destroyedInWindows = 0;
        hardModeActive = false;
    }

    public void OnBrickDestroyed()
    {
        if (hardModeActive) return;

        if (Time.time - windowStartTime > windowSeconds)
        {
            windowStartTime = Time.time;
            destroyedInWindows = 0;
        }

        destroyedInWindows++;

        if (destroyedInWindows >= targetDestroy)
        {
            ActiveHardMode();
        }

    }

    void ActiveHardMode()
    {
        hardModeActive = true;

        ChangeBreakableBricks();

        if (brickLayer == null) FindBrickLayer();

        if (brickLayer != null)
        {
            brickLayer.StartMovingBricks(moveAmplitude, moveSpeed);
        }
    }

    public void LoseLife()
    {
        lives -= 1;
        Debug.Log(lives);

        if (lives <= 0)
        {
            if (points > HighScore)
            {
                HighScore = points;
            }
            GameOver();

        }
    }

    void ChangeBreakableBricks()
    {
        BrickScript[] allBricks = FindObjectsByType<BrickScript>(FindObjectsSortMode.None);

        foreach (BrickScript bs in allBricks)
        {
            if (bs.breakable)
            {
                bs.setBrick(3, Color.yellow);
            }
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void AddPoint(int pointValue)
    {
        points += pointValue;
    }

    public void getHighScore()
    {

    }

    void Update()
    {

    }


}
