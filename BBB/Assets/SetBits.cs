using System;
using UnityEngine;

public class SetBits : MonoBehaviour
{
    int bSequesce = 8 + 1 + 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Convert.ToString(bSequesce, 2));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
