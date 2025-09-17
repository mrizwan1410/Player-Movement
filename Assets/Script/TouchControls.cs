using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    public static int playerTurnAxisTouch = 0;
    public static int playerMoveAxisTouch = 0;

    void Start()
    {
        playerTurnAxisTouch = 0;
        playerMoveAxisTouch = 0;
    }

    // *******left button pointers**********
    public void playerLeftUIPointerDown()
    {
        playerTurnAxisTouch = -1;
    }
    public void playerLeftUIPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    //********right button pointers*************
    public void playerRightUIPointerDown()
    {
        playerTurnAxisTouch = 1;
    }
    public void playerRightUIPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    //********Move button pointers*************
    public void playerMoveUIPointerDown()
    {
        playerMoveAxisTouch = 1;
    }
    public void playerMoveUIPointerUp()
    {
        playerMoveAxisTouch = 0;
    }

    void Update()
    {
        
    }
}
