using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gitTest : MonoBehaviour
{
    public GameObject A;
    private int num;
    public Transform Mpos;
    void Start()
    {
        num = 3;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GItTest();
        }
    }
    void GItTest()
    {
        for (int i = 0; i < num; i++)
        {
            Instantiate(A, Mpos.position, Quaternion.identity);
        }
    }
}
