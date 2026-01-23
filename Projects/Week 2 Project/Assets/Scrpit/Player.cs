using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public float m_MoveSpeed = 0.1f;
    public float m_platformX, m_plafFormY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputProcess();
    }

    private void InputProcess()
    {
        if (Input.GetKeyDown(left))
        {
            //move platform to left 
            m_platformX -= m_MoveSpeed;
        }
        else if (Input.GetKeyDown(right))
        {
            //move platform to right
            m_platformX += m_MoveSpeed;
        }
        float py = transform.position.y;
        transform.position = new UnityEngine.Vector3(m_platformX, py, 0);
    }
}
