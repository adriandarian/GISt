using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    Vector3 old;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            old = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            this.GetComponent<RectTransform>().position += pos - old;
            old = pos;

            if (this.GetComponent<RectTransform>().localPosition.x < -2188f)
            {
                this.GetComponent<RectTransform>().localPosition = new Vector2(-2188f, this.GetComponent<RectTransform>().localPosition.y);
            }
            if (this.GetComponent<RectTransform>().localPosition.x > 2181f)
            {
                this.GetComponent<RectTransform>().localPosition = new Vector2(2188f, this.GetComponent<RectTransform>().localPosition.y);
            }
            if (this.GetComponent<RectTransform>().localPosition.y < -370f)
            {
                this.GetComponent<RectTransform>().localPosition = new Vector2(this.GetComponent<RectTransform>().localPosition.x, -370f);
            }
            if (this.GetComponent<RectTransform>().localPosition.y > 361f)
            {
                this.GetComponent<RectTransform>().localPosition = new Vector2(this.GetComponent<RectTransform>().localPosition.x, 361f);
            }
        }
    }
}
