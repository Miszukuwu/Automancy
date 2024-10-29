using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public int playerMoney = 1000; // Przyk�adowa warto�� pieni�dzy gracza

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        IntegerField playerMoneyField = root.Q<IntegerField>("playerMoneyField");
        playerMoneyField.value = playerMoney;

        // Mo�esz doda� listener, aby zaktualizowa� warto�� playerMoney po ka�dej zmianie w UI
        playerMoneyField.RegisterValueChangedCallback(evt => playerMoney = evt.newValue);
    }
}