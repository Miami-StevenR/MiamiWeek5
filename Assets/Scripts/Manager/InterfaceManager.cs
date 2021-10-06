using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    //TODO: Add PlayerTwoButton reference
    [SerializeField] private Button joinPlayerTwo;

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        //TODO Listen for player two click event
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
        //TODO flip text to say "Leave Player One"
        joinPlayerOne.GetComponentInChildren<Text>().text = "Leave Player One";
        //TODO on click after player has joined, remove player
        joinPlayerOne.onClick.AddListener(() => LeavePlayerOne());
    }
    private void LeavePlayerOne()
    {
        playerInputManager.LeavePlayer(0);
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    private void JoinPlayerTwo()
    {
        playerInputManager.JoinPlayer(1, "PlayerTwo");
        //TODO flip text after player has joined to say "Leave Player Two"
        joinPlayerTwo.GetComponentInChildren<Text>().text = "Leave Player Two";
        //TODO on click after player has joined, remove player
        joinPlayerTwo.onClick.AddListener(() => LeavePlayerTwo());

    } // End of JoinPlayerTwo()
    private void LeavePlayerTwo()
    {
        Debug.Log("got to leave player two");

        playerInputManager.LeavePlayer(1);
    }

}
