using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public int playerMoney = 1000; // Przyk³adowa wartoœæ pieniêdzy gracza

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        IntegerField playerMoneyField = root.Q<IntegerField>("playerMoneyField");
        playerMoneyField.value = playerMoney;

        // Mo¿esz dodaæ listener, aby zaktualizowaæ wartoœæ playerMoney po ka¿dej zmianie w UI
        playerMoneyField.RegisterValueChangedCallback(evt => playerMoney = evt.newValue);
    }
}