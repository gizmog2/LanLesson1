using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameHelper : MonoBehaviour
{
    public TMP_InputField Input;
    public TMP_Text textBlock;

    private PlayerHelper _currentPlayerHelper;

    
    public PlayerHelper CurrentPlayer
    {
        get { return _currentPlayerHelper; }
        set { _currentPlayerHelper = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Send()
    {
        CurrentPlayer.Send(Input.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
