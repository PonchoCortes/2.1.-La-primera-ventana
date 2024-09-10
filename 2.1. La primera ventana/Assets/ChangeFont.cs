using UnityEngine;
using UnityEngine.UI;

public class ChangeFont : MonoBehaviour
{
    public Font newFont;  // Arrastra aquí la fuente desde el editor
    private Text uiText;

    private void Start()
    {
        Start(newFont);
    }

    void Start(Font newFont)
    {
        // Obtener el componente Text del objeto
        uiText = GetComponent<Text>();

        // Cambiar la fuente
        if (newFont != null)
        {
            uiText.font = newFont;
        }
    }
}
