using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGreenState : IPlayerColorState
{
    public Color ColorValue { get; } = Color.green;
    public string ColorName { get; } = "Green";
    public void ChangeColor(Player player)
    {
        var newPlayerState = new PlayerWhiteState();
        player.ChangeSpriteRendererColor(newPlayerState.ColorValue);
        player.ColorState = newPlayerState;
    }
}
