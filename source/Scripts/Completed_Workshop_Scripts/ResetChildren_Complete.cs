using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetChildren_Complete : MonoBehaviour
{
    //Private member variables to store original positions/rotations/scales
    private Vector3[] _originalPositions;
    private Quaternion[] _originalRotations;
    private Vector3[] _originalScales;
    private bool _initialized = false;

    // Start is called before the first frame update
    // When Content is initialized we store orginal values
    void Start()
    {
        //Check if we have any children gameobject
        if (transform.childCount > 0) 
        {
            //Initialize arrays of original values
            _originalPositions = new Vector3[transform.childCount];
            _originalRotations = new Quaternion[transform.childCount];
            _originalScales = new Vector3[transform.childCount];
            
            //Fill arrays with original positions/rotations/scales of gameobjects
            for(int i = 0; i < transform.childCount; i++)
            {
                _originalPositions[i] = gameObject.transform.GetChild(i).localPosition;
                _originalRotations[i] = gameObject.transform.GetChild(i).localRotation;
                _originalScales[i] = gameObject.transform.GetChild(i).localScale;
            }
        }
        _initialized = true;
    }

    //Resets all children transforms to their original positions and rotations
    public void ResetChildTransforms()
    {
        //Has Start happened? 
        if(_initialized)
        {
            //Iterate through children
            for (int i = 0; i < transform.childCount; i++)
            {
                //Reset all positions rotations and scales
                Transform child = gameObject.transform.GetChild(i);
                child.localPosition = _originalPositions[i];
                child.localRotation = _originalRotations[i];
                child.localScale = _originalScales[i];

                //Disable any active UI elements for each compoent
                ShowUI_Complete showUI = child.GetComponentInChildren<ShowUI_Complete>();
                if (showUI != null)
                {
                    showUI.DisableUI();
                }
                
            }
        }
    }
}
