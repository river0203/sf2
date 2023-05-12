using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PIC
{
    public class TimeManager : MonoBehaviour
    {
        public float MaxTime = 60;
        int first_time = 0;
        int last_time = 0;
        int CurrentTime = 0;

        private void Start()
        {
            CurrentTime = (int)MaxTime;
        }

        private void Update()
        {
            MaxTime -= Time.deltaTime;
            CurrentTime = (int)MaxTime;
            first_time = CurrentTime / 10;
            last_time = CurrentTime % 10;
            Debug.Log($"{first_time}{last_time}");
        }    
    }
}