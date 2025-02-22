using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    bool state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
            transform.Rotate(0, 1, 0);
    }

    private void OnMouseDown()
    {
        state = true;
    }

    private void OnMouseUp()
    {
        state = false;
    }
}
