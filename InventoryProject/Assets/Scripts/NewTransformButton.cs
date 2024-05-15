using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonMovement : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;
    public GameObject Item9;
    public Vector3 squaremove;
    public Vector3 squaremove2;
    public Vector3 squaremove3;
    public Vector3 squaremove4;
    public Vector3 squaremove5;
    public Vector3 squaremove6;
    public Vector3 squaremove7;
    public Vector3 squaremove8;
    public Vector3 squaremove9;
    private Vector3 sized = new Vector3(0.07f, 0.07f, 0);

    private void Start()
    {
        // Add listener to the button
       
        
    }

    public void MoveButton()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item1, squaremove, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }

    public void MoveButton2()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item2, squaremove2, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton3()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item3, squaremove3, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton4()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item4, squaremove4, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton5()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item5, squaremove5, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton6()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item6, squaremove6, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton7()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item7, squaremove7, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton8()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item8, squaremove8, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
    public void MoveButton9()
    {

        // Move the button to the target position
        GameObject Cloned = Instantiate(Item9, squaremove9, Quaternion.identity);
        Cloned.transform.localScale = sized;
    }
}
