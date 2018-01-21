using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Base : MonoBehaviour {

  

    public GameObject FarmViewScreen;
    public GameObject RecipeScreen;
    public GameObject Recipe;
    public GameObject InfoScreen;

    public string screen;

    float timer = 0;
    // Use this for initialization
    void Start()
    {

    }

    public void Back()
    {
        GameObject.Find("ARProjection").GetComponent<Animation_AR>().sphere_clicked = "";
        screen = "";
    }

    public void ToggleRecipe()
    {
        Recipe.SetActive(!Recipe.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        print(screen);
        switch (screen)
        {
            case "Farm Viewer":
                FarmViewScreen.SetActive(true);
                FarmViewScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, FarmViewScreen.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreen.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                if (FarmViewScreen.GetComponent<Image>().color.a > 1)
                {
                    FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                break;
            case "Info":
                InfoScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, InfoScreen.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, InfoScreen.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                if (InfoScreen.GetComponent<Image>().color.a > 1)
                {
                    InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                print(InfoScreen.GetComponent<Image>().color.a);
                break;
            case "Recipes":
                RecipeScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, RecipeScreen.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                RecipeScreen.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreen.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                if (RecipeScreen.GetComponent<Image>().color.a > 1)
                {
                    RecipeScreen.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                break;
            case "":
               FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                if (FarmViewScreen.GetComponent<Image>().color.a < 0)
                {
                    FarmViewScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                    FarmViewScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                    FarmViewScreen.SetActive(false);
                }
                RecipeScreen.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                if (RecipeScreen.GetComponent<Image>().color.a < 0)
                {
                    RecipeScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                    RecipeScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                }
                InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, InfoScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                if (InfoScreen.GetComponent<Image>().color.a < 0)
                {
                    InfoScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                    InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                }
                break;


        }

     

        
    }

}
