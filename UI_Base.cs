using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Base : MonoBehaviour {

  

    public GameObject FarmViewScreenRasp;
    public GameObject FarmViewScreenBlack;
    public GameObject FarmViewScreenStraw;

    public GameObject RecipeScreenRasp;
    public GameObject RecipeScreenBlack;
    public GameObject RecipeScreenStraw;

    public GameObject Recipe;
    public GameObject InfoScreen;

    public string screen;
    public string berry;

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
        switch (berry)
        {
            case "ImageTargetBlack":
                switch (screen)
                {
                    case "Farm Viewer":
                        FarmViewScreenBlack.SetActive(true);
                        FarmViewScreenBlack.GetComponent<RectTransform>().localPosition = new Vector3(0, FarmViewScreenBlack.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        FarmViewScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenBlack.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (FarmViewScreenBlack.GetComponent<Image>().color.a > 1)
                        {
                            FarmViewScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, 1);
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
                        RecipeScreenBlack.GetComponent<RectTransform>().localPosition = new Vector3(0, RecipeScreenBlack.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        RecipeScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenBlack.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (RecipeScreenBlack.GetComponent<Image>().color.a > 1)
                        {
                            RecipeScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                        }
                        break;
                    case "":
                        FarmViewScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenBlack.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (FarmViewScreenBlack.GetComponent<Image>().color.a < 0)
                        {
                            FarmViewScreenBlack.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            FarmViewScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                            FarmViewScreenBlack.SetActive(false);
                        }
                        RecipeScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenBlack.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (RecipeScreenBlack.GetComponent<Image>().color.a < 0)
                        {
                            RecipeScreenBlack.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            RecipeScreenBlack.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, InfoScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (InfoScreen.GetComponent<Image>().color.a < 0)
                        {
                            InfoScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        break;


                }
                break;
            case "ImageTargetRasp":
                switch (screen)
                {
                    case "Farm Viewer":
                        FarmViewScreenRasp.SetActive(true);
                        FarmViewScreenRasp.GetComponent<RectTransform>().localPosition = new Vector3(0, FarmViewScreenRasp.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        FarmViewScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenRasp.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (FarmViewScreenRasp.GetComponent<Image>().color.a > 1)
                        {
                            FarmViewScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, 1);
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
                        RecipeScreenRasp.GetComponent<RectTransform>().localPosition = new Vector3(0, RecipeScreenRasp.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        RecipeScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenRasp.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (RecipeScreenRasp.GetComponent<Image>().color.a > 1)
                        {
                            RecipeScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                        }
                        break;
                    case "":
                        FarmViewScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenRasp.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (FarmViewScreenRasp.GetComponent<Image>().color.a < 0)
                        {
                            FarmViewScreenRasp.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            FarmViewScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                            FarmViewScreenRasp.SetActive(false);
                        }
                        RecipeScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenRasp.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (RecipeScreenRasp.GetComponent<Image>().color.a < 0)
                        {
                            RecipeScreenRasp.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            RecipeScreenRasp.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, InfoScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (InfoScreen.GetComponent<Image>().color.a < 0)
                        {
                            InfoScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        break;


                }
                break;

            case "ImageTargetStraw":
                switch (screen)
                {
                    case "Farm Viewer":
                        FarmViewScreenStraw.SetActive(true);
                        FarmViewScreenStraw.GetComponent<RectTransform>().localPosition = new Vector3(0, FarmViewScreenStraw.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        FarmViewScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenStraw.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (FarmViewScreenStraw.GetComponent<Image>().color.a > 1)
                        {
                            FarmViewScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, 1);
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
                        RecipeScreenStraw.GetComponent<RectTransform>().localPosition = new Vector3(0, RecipeScreenStraw.GetComponent<RectTransform>().localPosition.y * .7f, 0);
                        RecipeScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenStraw.GetComponent<Image>().color.a + Time.deltaTime * 2.5f);
                        if (RecipeScreenStraw.GetComponent<Image>().color.a > 1)
                        {
                            RecipeScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                        }
                        break;
                    case "":
                        FarmViewScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, FarmViewScreenStraw.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (FarmViewScreenStraw.GetComponent<Image>().color.a < 0)
                        {
                            FarmViewScreenStraw.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            FarmViewScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                            FarmViewScreenStraw.SetActive(false);
                        }
                        RecipeScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, RecipeScreenStraw.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (RecipeScreenStraw.GetComponent<Image>().color.a < 0)
                        {
                            RecipeScreenStraw.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            RecipeScreenStraw.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, InfoScreen.GetComponent<Image>().color.a - Time.deltaTime * 2.5f);
                        if (InfoScreen.GetComponent<Image>().color.a < 0)
                        {
                            InfoScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, -1920, 0);

                            InfoScreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        }
                        break;


                }
                break;





        }
        

     

        
    }

}
