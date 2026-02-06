using UnityEngine;
using UnityEngine.UIElements;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;

    public int numBricks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lay()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                float xPos = -columns + (i * bs_h);
                float yPos = rows - (j * bs_v);

                GameObject newBrick = Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform
           );

                BrickScript bs = newBrick.GetComponent<BrickScript>();

                if (i % 2 == 0)
                {
                    bs.setBrick(1, Color.blue);
                }
                else
                {
                    bs.setBrick(2, Color.red);
                }

            }
        }
    }
}
