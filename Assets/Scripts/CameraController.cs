using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject target;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("UnityChan");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            transform.position = target.transform.position + new Vector3(0, 2, -3);
        }
    }

    public void SetGameOver()
    {
        gameOver = true;
    }
}
