using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCard : Card
{
    public EntitySO Spell;
    private Image SpellDesignBorder;
    private Image SpellMask;
    private Sprite SpellImage;
    private Text Mana;
    private Text SpellName;
    private Text SpellDescription;
    public void Start()
    {
        Mana = transform.Find("Mana").GetComponent<Text>();
        SpellName = transform.Find("SpellName").GetComponent<Text>();
        SpellDescription = transform.Find("SpellDescription").GetComponent<Text>();
        SpellDesignBorder = GetComponent<Image>();
        SpellMask = transform.Find("SpellCardMask").GetComponent<Image>();

        SpellImage = Spell.Design;
        SpellDesignBorder.sprite = Spell.DesignBorder;

        Mana.text = Spell.ManaCost.ToString();
        SpellName.text = Spell.Name;
        SpellDescription.text = Spell.Description;
        SpellMask.sprite = Spell.DesignMask;


    }

    public override void Play()
    {
        
    }
}
