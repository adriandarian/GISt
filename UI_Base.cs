using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Base : MonoBehaviour {

    public GameObject SplashScreen;
    

    public GameObject FarmViewScreen;
    public GameObject NutritionScreen;
    public GameObject InfoScreen;

    public string screen;
    
    float timer = 0;
	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        print(screen);
        switch (screen)
        {
            case "Farm Viewer":
                FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreen.GetComponent<Image>().color.a + Time.deltaTime);
                if (FarmViewScreen.GetComponent<Image>().color.a > 1)
                {
                    FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                break;
            case "Info":

                break;
            case "":
                FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreen.GetComponent<Image>().color.a - Time.deltaTime);

                break;


        }

        timer += Time.deltaTime;


        if (timer > .25f)
        {
            SplashScreen.GetComponent<Image>().color = new Color(1, 1, 1, SplashScreen.GetComponent<Image>().color.a - Time.deltaTime);
        }



        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
            print(deltaMagnitudeDiff);

            if (deltaMagnitudeDiff > 100f)
            {
                GameObject.Find("ARProjection").GetComponent<Animation_AR>().sphere_clicked = "";
                screen = "";
            }

        }

    }

}
