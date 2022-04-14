using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger: MonoBehaviour
{
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    string currentPanelStr = "MainRoom";

    
    public void OnRightArrow()  //This function is to move the screen to the right by moving the panel
    {
        

        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";

            
        }
        else if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";

           
        }
        else if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            
        }
    }

    public void OnLeftArrow()   //This function is to move the screen to the left by moving the panel
    {

        
        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";
            
           
        }
        
        else if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";
            
           
        }
        else if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            
        }
    }
    public void OnBackArrow()   //This function is to go back by moving the panel
    {
        

        if (currentPanelStr == "MainRoom")
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "MainRoom";

            
        }
        if (currentPanelStr == "Bathroom")
        {
            this.transform.localPosition = new Vector2(0, 1366);
            currentPanelStr = "Bathroom";

            
        }
        if (currentPanelStr == "SecondRoom")
        {
            this.transform.localPosition = new Vector2(-2360, 0);
            currentPanelStr = "SecondRoom";

           
        }
    }
    public void OnPaint()   // Move to PaintClose
    {
        
        this.transform.localPosition = new Vector2(-2123, 1525);
        currentPanelStr = "MainRoom";

    }

    public void OnToilet()  // Move to toiletClose
    {
        
        this.transform.localPosition = new Vector2(2, 2924);
        currentPanelStr = "Bathroom";

    }

    public void OnSaftyBox()    // Move to boxClose
    {
        
        this.transform.localPosition = new Vector2(-2129, 2917);
        currentPanelStr = "SecondRoom";

    }
}
