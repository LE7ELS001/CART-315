using UnityEngine;
using UnityEngine.UIElements;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;

    public int numBricks;

    public float unbreakableChance = 0.35f;
    public Color unbreakbleColor = Color.gray;

    //rule for unbreakable bricks 
    public int bottomSafeRows = 1;
    public int maxUnbreakables = 6;
    public int maxUnbreakableNeighbors = 2;

    private bool moveBricks = false;
    private float amp, spd;
    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveBricks)
        {
            float offsetX = Mathf.Sin(Time.time * spd) * amp;
            transform.position = startPos + new Vector3(offsetX, 0f, 0f);
        }
    }

    public void StartMovingBricks(float amplitude, float speed)
    {
        amp = amplitude;
        spd = speed;
        moveBricks = true;
    }

    public void Lay()
    {
        numBricks = 0;

        bool[,] unGrid = new bool[columns, rows];

        int unCount = 0;

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                float xPos = -columns + (i * bs_h);
                float yPos = rows - (j * bs_v);

                GameObject newBrick = Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform
           );

                BrickScript bs = newBrick.GetComponent<BrickScript>();

                //unbreakable brick generate 
                bool makeUnbreakable = Random.value < unbreakableChance;


                if (j >= rows - bottomSafeRows)
                {
                    makeUnbreakable = false;
                }

                if (unCount >= maxUnbreakables)
                {
                    makeUnbreakable = false;
                }

                if (makeUnbreakable)
                {
                    int neighbors = 0;

                    if (i > 0 && unGrid[i - 1, j]) neighbors++;
                    if (j > 0 && unGrid[i, j - 1]) neighbors++;
                    if (i < columns - 1 && unGrid[i + 1, j]) neighbors++;
                    if (j < rows - 1 && unGrid[i, j + 1]) neighbors++;

                    if (neighbors >= maxUnbreakableNeighbors)
                        makeUnbreakable = false;
                }

                if (makeUnbreakable)
                {
                    bs.breakable = false;
                    bs.setBrick(0, unbreakbleColor);

                    newBrick.tag = "Unbreakable";

                    unGrid[i, j] = true;
                    unCount++;
                }
                else
                {
                    bs.breakable = true;
                    if (i % 2 == 0)
                    {
                        bs.setBrick(1, Color.blue);
                    }
                    else
                    {
                        bs.setBrick(2, Color.red);
                    }

                    newBrick.tag = "Brick";
                    numBricks++;
                }


            }
        }
    }
}
