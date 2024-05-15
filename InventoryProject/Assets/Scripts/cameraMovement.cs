using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public void LeftArrow()
    {
        transform.position = new Vector3(0.18f,0.5f,0);
    }

    // Update is called once per frame
    public void RightArrow()
    {
        transform.position = new Vector3(8.3f,0.5f,0);
    }
}
