using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_AR : MonoBehaviour {
    bool sphere_clicked = false;

    float sphere_speed = .5f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (!sphere_clicked)
        {
            this.transform.Rotate(new Vector3(0, sphere_speed, 0));
            this.transform.position = new Vector3(0, Mathf.Sin(Time.time * 2f) / 8f, 0);
        }

        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                sphere_clicked = true;
                // the object identified by hit.transform was clicked
                // do whatever you want
                hit.collider.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);

            }
            else sphere_clicked = false;
        }
        if (Input.GetMouseButton(0))
        {
            float delta_speed = 10f;

        }
        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < 3; i++)
            {
                this.transform.GetChild(i).localScale = new Vector3(1, 1, 1);
            }
            sphere_clicked = false;
        }
    }
}  
