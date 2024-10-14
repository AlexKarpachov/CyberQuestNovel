using Naninovel;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private ICustomVariableManager customVariableManager;
    // string playerName;

    void Start()
    {
        /*playerName = PlayerPrefs.GetString("PlayerName", "Гравець");
        Debug.Log(playerName);*/

        // Отримуємо доступ до сервісу кастомних змінних Naninovel
        customVariableManager = Engine.GetService<ICustomVariableManager>();

        // Отримуємо значення змінної PlayerName
        var playerName = customVariableManager.GetVariableValue("PlayerName");

        // Виводимо в консоль значення
        Debug.Log("Ім'я гравця в Naninovel: " + playerName);
    }
}
