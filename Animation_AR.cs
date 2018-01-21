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
        sphere_speed *= .95f;

        if (sphere_clicked != "")
        {

            //GameObject.Find(sphere_clicked).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
           // GameObject.Find(sphere_clicked).gameObject.transform.localScale = new Vector3(GameObject.Find(sphere_clicked).gameObject.transform.localScale.x + .25f, GameObject.Find(sphere_clicked).gameObject.transform.localScale.y + .25f, GameObject.Find(sphere_clicked).gameObject.transform.localScale.y + .25f);

        }

        if (sphere_clicked == "")
        {
            this.transform.Rotate(new Vector3(0, sphere_speed + .5f, 0));
            for (int i = 0; i < 3; i++)
            {
                //this.transform.GetChild(i).rotation = Quaternion.Euler( new Vector3(0, 0, 0));//Rotate(new Vector3(Random.value, Random.value, Random.value));
                
            }

            this.transform.position = new Vector3(0, Mathf.Sin(Time.time * 2f) / 4f, 0);
        }

        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                // the object identified by hit.transform was clicked
                // do whatever you want
                sphere_clicked = hit.collider.gameObject.name;
                GameObject.Find("Canvas").GetComponent<UI_Base>().screen = sphere_clicked;
            }
            else sphere_clicked = "";
        }
        if (Input.GetMouseButton(0))
        {
            
            Vector2 current = Input.mousePosition;

            sphere_speed = (current - old_pos).magnitude / 10f;

            old_pos = current;


        }
        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.transform.GetChild(i).gameObject.name != sphere_clicked)
                {
                   // this.transform.GetChild(i).localScale = new Vector3(1, 1, 1);
                }
            }
        }
    }
}  
