using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeImageManager : MonoBehaviour
{
    public Image FirstTime;
    public Image LastTime;
    public Sprite[] images;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FirstTime_ImageChange();
        LastTime_ImageChange();
    }

    void FirstTime_ImageChange()
    {
        if(TimeManager.first_time == 0 )
        {
            FirstTime.sprite = images[0];
        }
        else if(TimeManager.first_time == 1)
        {
            FirstTime.sprite = images[1];
        }
       else if(TimeManager.first_time == 2)
        {
            FirstTime.sprite = images[2];
        }
        else if(TimeManager.first_time == 3)
        {
            FirstTime.sprite = images[3];
        }
        else if(TimeManager.first_time == 4)
        {
            FirstTime.sprite = images[4];
        }
        else if(TimeManager.first_time == 5)
        {
            FirstTime.sprite = images[5];
        }
        else if(TimeManager.first_time == 6)
        {
            FirstTime.sprite = images[6];
        }
        else if(TimeManager.first_time == 7)
        {
            FirstTime.sprite = images[7];
        }
        else if(TimeManager.first_time == 8)
        {
            FirstTime.sprite = images[8];
        }
        else if(TimeManager.first_time == 9)
        {
            FirstTime.sprite = images[9];
        }
    }
    
    void LastTime_ImageChange()
    {
        if(TimeManager.last_time == 0 )
        {
            LastTime.sprite = images[0];
        }
        else if(TimeManager.last_time == 1)
        {
            LastTime.sprite = images[1];
        }
       else if(TimeManager.last_time == 2)
        {
            LastTime.sprite = images[2];
        }
        else if(TimeManager.last_time == 3)
        {
            LastTime.sprite = images[3];
        }
        else if(TimeManager.last_time == 4)
        {
            LastTime.sprite = images[4];
        }
        else if(TimeManager.last_time == 5)
        {
            LastTime.sprite = images[5];
        }
        else if(TimeManager.last_time == 6)
        {
            LastTime.sprite = images[6];
        }
        else if(TimeManager.last_time == 7)
        {
            LastTime.sprite = images[7];
        }
        else if(TimeManager.last_time == 8)
        {
            LastTime.sprite = images[8];
        }
        else if(TimeManager.last_time == 9)
        {
            LastTime.sprite = images[9];
        }
    }
}
