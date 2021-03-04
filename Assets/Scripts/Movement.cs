using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Movement : MonoBehaviour
{   
    public GameObject cam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
      cam.transform.position =  new Vector2 (cam.transform.position.x + speed * Time.deltaTime, cam.transform.position.y);     
    }


}
