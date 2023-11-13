using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyUp("space"))
            Destroy(gameObject);
        }
}
