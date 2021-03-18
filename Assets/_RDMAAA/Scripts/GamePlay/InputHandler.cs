using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Keyboard")]
public class InputHandler : IInputManager
{
    [SerializeField]
    KeyCode backWordCode;
    [SerializeField]
    KeyCode forwordWordCode;
    [SerializeField]
    KeyCode rightCode;
    [SerializeField]
    KeyCode leftCode;
    [SerializeField]
    KeyCode jumpCode;
    [SerializeField]
    KeyCode jetCode;
    [SerializeField]
    KeyCode timeCode;
    [SerializeField]
    KeyCode switchCode;
    public override bool GetBackword()
    {
       // Debug.Log("backword");
        return Input.GetKey(backWordCode);
    }

    public override bool GetForword()
    {
        return Input.GetKey(forwordWordCode);
    }

    public override bool GetLeft()
    {
        return Input.GetKey(leftCode);
    }

    public override bool GetRight()
    {
        return Input.GetKey(rightCode);
    }

    public override bool Jump()
    {
        return Input.GetKeyDown(jumpCode);
    }

    public override bool SwitchPlayer()
    {
        return Input.GetKeyDown(switchCode);
    }

    public override bool UseJetPack()
    {
        return Input.GetKey(jetCode);
    }

    public override bool useTime()
    {
        return Input.GetKey(timeCode);
    }
}
