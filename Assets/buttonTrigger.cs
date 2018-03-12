using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonTrigger : MonoBehaviour
{
    Material buttonColor;

    private void Start ()
    {
        buttonColor = this.gameObject.GetComponent<Renderer>().material;
    }

    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collision Detected!");
        
        if (col.gameObject.name == "Cube - defaultState")
        {
            Debug.Log("Change");

            buttonColor.color = Color.black;
            RightHand controller = col.gameObject.GetComponent<RightHand>();
            col.gameObject.GetComponent<RightHand>().SetState(new recordingState(controller));         
        }
        else if (col.gameObject.name == "Cube - recordingState")
        {
            Debug.Log("Change");

            buttonColor.color = Color.gray;
            RightHand controller = col.gameObject.GetComponent<RightHand>();
            col.gameObject.GetComponent<RightHand>().SetState(new defaultState(controller));
        }
    }
}
