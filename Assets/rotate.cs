using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour{
    public float speed=100f;
    private void Update(){
        transform.Rotate(0,0,speed *Time.deltaTime);
    }
}