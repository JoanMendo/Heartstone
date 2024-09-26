using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterSO : EntitySO
{
    [SerializeField] public int Dmg;
    [SerializeField] public int HP;
    
}
