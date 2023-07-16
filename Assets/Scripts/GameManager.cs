using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //buttons
    public Button dealBtn;
    public Button hitBtn;
    public Button standBtn;
    public Button betBtn;

    // Start is called before the first frame update
    void Start()
    {
        //Adding click listeners
        dealBtn.onClick.AddListener(() => Dealclicked());
        hitBtn.onClick.AddListener(() => Hitclicked());
        standBtn.onClick.AddListener(() => Standclicked());
    }

    private void Dealclicked()
    {
        throw new NotImplementedException();
    }

    private void Hitclicked()
    {
        throw new NotImplementedException();
    }

    private void Standclicked()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
