using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    // Move inputs
    protected float xInput;
    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        player.Anim.SetBool(animBoolName, true);
    }

    public virtual void Update() 
    {
        xInput = Input.GetAxisRaw("Horizontal");
    }

    public virtual void Exit() 
    {
        player.Anim.SetBool(animBoolName, false);
    }

}
