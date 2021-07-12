using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRegisterLogin : MonoBehaviour
{
    public GameObject Register;
    public GameObject LogIn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClicktochangeStatus()
    {
        if(Register.activeSelf)
        {
            Register.SetActive(false);
            LogIn.SetActive(true);
        }
    }
}
