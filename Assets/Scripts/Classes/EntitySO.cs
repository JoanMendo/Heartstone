using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Entity", menuName = "Entity")]
public class EntitySO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public int ManaCost;
    [SerializeField] public string Rarity;
    [SerializeField] public Sprite Design;
    [SerializeField] public Sprite DesignBorder;
    [SerializeField] public Sprite DesignMask;
    [SerializeField] public string Description;
}
