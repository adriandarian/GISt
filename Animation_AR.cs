using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_AR : MonoBehaviour {
    
    float sphere_speed = .5f;
    Vector2 old_pos;

    public string sphere_clicked = "";

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
            this.transform.Rotate(new Vector3(0, sphere_speed + .5f, 0));
            this.transform.position = new Vector3(0, Mathf.Sin(Time.time * 2f) / 4f, 0);
        

        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (sphere_clicked == "")
                {
                    // the object identified by hit.transform was clicked
                    // do whatever you want
                    sphere_clicked = hit.collider.gameObject.name;
                    GameObject.Find("Canvas").GetComponent<UI_Base>().screen = sphere_clicked;
                    GameObject.Find("Canvas").GetComponent<UI_Base>().berry = hit.collider.gameObject.transform.parent.parent.name ;

                }
            }
            else sphere_clicked = "";
        }
    }
}  
