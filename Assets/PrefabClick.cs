using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PrefabClick : MonoBehaviour
{
    public GameObject prefabObj;
    public CinemachineImpulseSource cam;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            prefabObj.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefabObj);
            cam.GenerateImpulse();
        }
    }
}
