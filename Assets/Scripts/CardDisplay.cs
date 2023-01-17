using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText;
    public TMP_Text hpText;
    public TMP_Text attackText;
    public TMP_Text costText;

    public Image factionImage;
    public Image rarityImage;
    public Image attributeImage;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(card.name);

        nameText.text = card.name;
        hpText.text = card.hp.ToString();
        attackText.text = card.attack.ToString();
        costText.text = card.cost.ToString();

        factionImage.sprite = card.faction;
        rarityImage.sprite = card.rarity;
        attributeImage.sprite = card.attribute;
    }
}
