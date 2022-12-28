using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerColorState 
{
    public Color ColorValue { get;}
    public string ColorName { get; }
    void ChangeColor(Player player); 
}
