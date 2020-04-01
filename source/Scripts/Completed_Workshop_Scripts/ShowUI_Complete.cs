using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicLeapTools;

public class ShowUI_Complete : MonoBehaviour
{ 
    private PointerReceiver _pointer;

    //Function to switch UI betwen enabled and disabled states
    //while user is dragging parent object
    public void EnableUI()
    {
        //Check if there is a reference to pointer receiver
        if(_pointer == null)
        {
            //Get pointer receiver component from parent
            _pointer = GetComponentInParent<PointerReceiver>();
        }

        //Check if the state of the pointer is in a dragging state
        if (_pointer != null && _pointer.Dragging)
        {
            //Set game object active status to opposite of current status
            gameObject.SetActive(!gameObject.activeSelf);
        }       
    }

    //Disables UI regardless of what current state UI is in
    public void DisableUI()
    {
        gameObject.SetActive(false);
    }


}
