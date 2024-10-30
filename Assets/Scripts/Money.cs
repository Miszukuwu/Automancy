using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public int playerMoney = 1000;
    private Label playerMoneyLabel;
    private VisualElement root;

    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        playerMoneyLabel = root.Q<Label>("MoneyLabel");
        
        if (playerMoneyLabel != null)
        {
            playerMoneyLabel.text = playerMoney.ToString();
        }
        else
        {
            Debug.LogError("Label with name 'Label' not found.");
        }
    }

    void Update()
    {
        playerMoneyLabel.text = playerMoney.ToString();
    }
}