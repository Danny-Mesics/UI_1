using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionUI : MonoBehaviour
{
    public Action action;
    Player player;

    [Header("Child Components")]
    public Image icon;
    public TextMeshProUGUI nameTag;
    public TextMeshProUGUI descriptionTag;


    public void SetAction(Action a)
    {
        action = a;
        if (nameTag)
            nameTag.text = action.actionName;
        if (descriptionTag)
            descriptionTag.text = action.description;
        if (icon)
        {
            icon.sprite = action.Icon;
            icon.color = action.color;
        }
    }

    public void Init(Player p)
    {
        player = p;
        Button button = GetComponentInChildren<Button>();
        if (button)
            button.onClick.AddListener(() => { player.DoAction(action); });
    }


    // Start is called before the first frame update
    void Start()
    {
        if (action != null)
        {
            SetAction(action);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
