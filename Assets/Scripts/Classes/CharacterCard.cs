using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterCard : Card
{
    public CharacterSO Character;
    private Image Marco;
    private Image CharacterSprite;
    private Image CharacterMask;
    private Text Mana;
    private Text CharacterName;
    private Text CharacterDescription;
    private Text CharacterHP;
    private Text CharacterDmg;
    public void Start()
    {
        Marco = GetComponent<Image>();
        Mana = transform.Find("Mana").GetComponent<Text>();
        CharacterName = transform.Find("CharacterName").GetComponent<Text>();
        CharacterDescription = transform.Find("CharacterDescription").GetComponent<Text>();
        CharacterMask = transform.Find("CharacterCardMask").GetComponent<Image>();
        CharacterHP = transform.Find("CharacterHP").GetComponent<Text>();
        CharacterDmg = transform.Find("CharacterDmg").GetComponent<Text>();
        CharacterSprite = transform.Find("CharacterCardMask/CardDesign").GetComponent<Image>();

        CharacterSprite.sprite = Character.Design;
        Marco.sprite = Character.DesignBorder;
        CharacterMask.sprite = Character.DesignMask;
        Mana.text = Character.ManaCost.ToString();
        CharacterName.text = Character.Name;
        CharacterDescription.text = Character.Description;
        CharacterHP.text = Character.HP.ToString();
        CharacterDmg.text = Character.Dmg.ToString();
    }



    public void Invoke(Token token)
    {
        Debug.Log("CharacterCard.Invoke() called");
    }

    public override void Play()
    {
        Debug.Log("CharacterCard.Play() called");
    }
}
