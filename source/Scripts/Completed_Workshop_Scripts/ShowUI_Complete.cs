using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicLeapTools;

public class ShowUI_Complete : MonoBehaviour
{
    private bool _enabled =  false; 
    public PointerReceiver pointer;

    // Start is called before the first frame update
    void Start()
    {
        pointer = GetComponentInParent<PointerReceiver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableUI()
    {
        if(pointer != null)
        {
            if (pointer.Dragging)
            {
                _enabled = !_enabled;
                gameObject.SetActive(_enabled);
            }
        }
        else
        {
            Debug.Log("Null Pointer in Parent");
        }
    }

    public void HideUI()
    {
        _enabled = false;
        gameObject.SetActive(_enabled);
    }


}
