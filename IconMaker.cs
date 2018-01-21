using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMaker : MonoBehaviour//5.6.4
{
    public int seed = 1900018000;//latitude/longitude seeds random number generator
    int currentPoint = 0;   //saves index of vertex of icon
    float time = 0f;
    void Start()
    {
        refresh();  //initializes linerenderer
        icon();     //generate
    }
    void updateText()
    {
        string backwardsLoc=seed.ToString();
        string lat = "Latitude: ", lon = "\nLongitude: ";
        for(int i=5;i!=10;i++)
        {   
            lon += backwardsLoc[i];
            if (i == 7)
                lon += "°";
        }
        lon += "\"";
        for (int i = 1; i != 5; i++)
        {
            lat += backwardsLoc[i];
            if (i == 2)
                lat += "°";
        }
        lat += "\"";
        gameObject.GetComponent<GUIText>().text = lat + lon;
    }
    void Update()
    {  
        time += Time.deltaTime;
        if (time > 2f)
        {
            seed = Random.Range(10000, 19000);
            seed = seed*100000 + Random.Range(0, 36000);
            Random.InitState(seed);
            time = 0;
            icon();
            updateText();
        }  
    }
    void refresh()
    {
        currentPoint = 0;
        for (int i = 0; i != 100; i++)
            gameObject.GetComponent<LineRenderer>().SetPosition(i, Vector3.zero);
    }
    void icon()
    {
        Vector3[] exterior =
        {
                new Vector2(0f, 1.57f),
                new Vector2(.79f, 1.91f),
                new Vector2(1.68f, 1.96f),
                new Vector2(2.27f, 1.3f),
                new Vector2(2.15f, 0f),
                new Vector2(1.31f, -1.42f),
                new Vector2(.41f, -2.2f),
                new Vector2(0f, -2.13f),
                new Vector2(-.41f, -2.2f),
                new Vector2(-1.31f, -1.42f),
                new Vector2(-2.15f, 0f),
                new Vector2(-2.27f, 1.3f),
                new Vector2(-1.68f, 1.96f),
                new Vector2(-.79f, 1.91f),
        };
        currentPoint = 14;
        gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, new Vector2(0f, 1.57f));
        Random.InitState(seed);
        Vector3[] interior = new Vector3[7];
        float y = 0f, x = 0f;
        int j = 0;
        for (int i = 0; i != 7; i++)
        {
            y = Random.Range(-2.13f, 1.4f);
            x = Random.Range(-1f, 1f) * (y + 2.13f) / 1.85f;
            interior[i] = new Vector3(x, y);
        }
        gameObject.GetComponent<LineRenderer>().SetPositions(exterior);
        currentPoint = 15;
        int lastExteriorPoint = 0;
        for (int i = 0; i != interior.Length; i++)
        {
            goToPoint(lastExteriorPoint, Random.Range(8, 13), exterior);
            gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, interior[i]);
            currentPoint++;
            lastExteriorPoint = Random.Range(1, 7);
            gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, exterior[lastExteriorPoint]);
            currentPoint++;
        }
        bool flip = true;
        Vector3 temp1 = gameObject.GetComponent<LineRenderer>().GetPosition(currentPoint - 2);
        Vector3 temp2 = gameObject.GetComponent<LineRenderer>().GetPosition(currentPoint - 3);
        for (int i = currentPoint; i != 100; i++)
        {
            if (flip)
            {
                gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, temp1);
                currentPoint++;
            }
            else
            {
                gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, temp2);
                currentPoint++;
            }
            flip = !flip;
        }
    }
    void goToPoint(int start, int stop, Vector3[] exterior)
    {
        if (start < stop)
            for (int i = start + 1; i != stop; i++)
            {
                gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, exterior[i]);
                currentPoint++;
            }
        else if (start > stop)
            for (int i = start - 1; i != stop; i--)
            {
                gameObject.GetComponent<LineRenderer>().SetPosition(currentPoint, exterior[i]);
                currentPoint++;
            }
    }
}