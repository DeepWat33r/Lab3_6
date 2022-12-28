using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlueState : IPlayerColorState
{
    public Color ColorValue { get; } = Color.blue;
    public string ColorName { get; } = "Blue";
    public void ChangeColor(Player player)
    {
        var newPlayerState = new PlayerGreenState();
        player.ChangeSpriteRendererColor(newPlayerState.ColorValue);
        player.ColorState = newPlayerState;
    }
}
