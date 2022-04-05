using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger: MonoBehaviour
{
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    string currentPanelStr = "MainRoom";

    private void Start()
    {
        //hideArrows();
        //rightArrow.SetActive(false);

        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        //rightArrow.SetActive(true);
        //leftArrow.SetActive(true);
    }
    
    //void hideArrows()
    //{
        
    //    rightArrow.SetActive(false);
    //    leftArrow.SetActive(false);
    //    backArrow.SetActive(false);
    //}

    //void ShowPanel()
    //{

    //}

    public void OnRightArrow()
    {
        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        else if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";

            

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        else if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
    }

    public void OnLeftArrow()
    {

        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);
        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";
            
            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        
        else if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";
            
            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        else if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
    }
    public void OnBackArrow()
    {
        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
        if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";

            //rightArrow.SetActive(true);
            //leftArrow.SetActive(true);
        }
    }
    public void OnPaint()
    {
        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        this.transform.localPosition = new Vector2(-2123, 1525);
        currentPanelStr = "MainRoom";

        

        //backArrow.SetActive(true);
    }

    public void OnToilet()
    {
        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        this.transform.localPosition = new Vector2(2, 2924);
        currentPanelStr = "Bathroom";



        //backArrow.SetActive(true);
    }

    public void OnSaftyBox()
    {
        //rightArrow.SetActive(false);
        //leftArrow.SetActive(false);
        //backArrow.SetActive(false);

        this.transform.localPosition = new Vector2(-2129, 2917);
        currentPanelStr = "SecondRoom";



        //backArrow.SetActive(true);
    }
}
