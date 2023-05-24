using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeImageManager : MonoBehaviour
{
    public Image FirstTime_Image;
    public Image LastTime_Image;
    public Sprite[] Time_Images;

    void Start()
    {
        
    }

    void Update()
    {
        FirstTime_ImageUpdate();
        LastTime_ImageUpdate();
    }

    void FirstTime_ImageUpdate()
    {
        if (TimeManager.first_time == 0)
        {
            FirstTime_Image.sprite = Time_Images[0];
        }
        else if (TimeManager.first_time == 1)
        {
            FirstTime_Image.sprite = Time_Images[1];
        }
        else if (TimeManager.first_time == 2)
        {
            FirstTime_Image.sprite = Time_Images[2];
        }
        else if (TimeManager.first_time == 3)
        {
            FirstTime_Image.sprite = Time_Images[3];
        }
        else if (TimeManager.first_time == 4)
        {
            FirstTime_Image.sprite = Time_Images[4];
        }
        else if (TimeManager.first_time == 5)
        {
            FirstTime_Image.sprite = Time_Images[5];
        }
        else if (TimeManager.first_time == 6)
        {
            FirstTime_Image.sprite = Time_Images[6];
        }
        else if (TimeManager.first_time == 7)
        {
            FirstTime_Image.sprite = Time_Images[7];
        }
        else if (TimeManager.first_time == 8)
        {
            FirstTime_Image.sprite = Time_Images[8];
        }
        else if (TimeManager.first_time == 9)
        {
            FirstTime_Image.sprite = Time_Images[9];
        }
    }
    void LastTime_ImageUpdate()
    {
        if (TimeManager.last_time == 0)
        {
            LastTime_Image.sprite = Time_Images[0];
        }
        else if (TimeManager.last_time == 1)
        {
            LastTime_Image.sprite = Time_Images[1];
        }
        else if (TimeManager.last_time == 2)
        {
            LastTime_Image.sprite = Time_Images[2];
        }
        else if (TimeManager.last_time == 3)
        {
            LastTime_Image.sprite = Time_Images[3];
        }
        else if (TimeManager.last_time == 4)
        {
            LastTime_Image.sprite = Time_Images[4];
        }
        else if (TimeManager.last_time == 5)
        {
            LastTime_Image.sprite = Time_Images[5];
        }
        else if (TimeManager.last_time == 6)
        {
            LastTime_Image.sprite = Time_Images[6];
        }
        else if (TimeManager.last_time == 7)
        {
            LastTime_Image.sprite = Time_Images[7];
        }
        else if (TimeManager.last_time == 8)
        {
            LastTime_Image.sprite = Time_Images[8];
        }
        else if (TimeManager.last_time == 9)
        {
            LastTime_Image.sprite = Time_Images[9];
        }
    }
}
