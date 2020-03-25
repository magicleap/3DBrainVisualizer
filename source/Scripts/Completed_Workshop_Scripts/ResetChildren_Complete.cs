using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetChildren_Complete : MonoBehaviour
{
    private Vector3[] _originalPositions;
    private Quaternion[] _originalRotations;
    private Vector3[] _originalScales;
    private bool _initialized = false;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.childCount > 0) 
        {
            _originalPositions = new Vector3[transform.childCount];
            _originalRotations = new Quaternion[transform.childCount];
            _originalScales = new Vector3[transform.childCount];
            
            for(int i = 0; i < transform.childCount; i++)
            {
                _originalPositions[i] = gameObject.transform.GetChild(i).localPosition;
                _originalRotations[i] = gameObject.transform.GetChild(i).localRotation;
                _originalScales[i] = gameObject.transform.GetChild(i).localScale;
            }
        }

        _initialized = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetChildTransforms()
    {
        if(_initialized)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = gameObject.transform.GetChild(i);
                child.localPosition = _originalPositions[i];
                child.localRotation = _originalRotations[i];
                child.localScale = _originalScales[i];

                ShowUI_Complete showUI = child.GetComponentInChildren<ShowUI_Complete>();
                if (showUI != null)
                {
                    showUI.HideUI();
                }
                
            }
        }
    }
}
