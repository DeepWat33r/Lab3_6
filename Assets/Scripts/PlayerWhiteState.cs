using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWhiteState : IPlayerColorState
{
    
    public Color ColorValue { get; } = Color.white;
    public string ColorName { get; } = "White";
    public void ChangeColor(Player player)
    {
        var newPlayerState = new PlayerBlueState();
        player.ChangeSpriteRendererColor(newPlayerState.ColorValue);
        player.ColorState = newPlayerState;
    }
}
