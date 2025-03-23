using UnityEngine;

public class MainPanel : MonoBehaviour
{
    [Header("Ayuda")]
    public GameObject mainPanel;
    public GameObject ayudaPanel;
    public GameObject creditosPanel;

    public void OpenPanel (GameObject panel)
    {
        mainPanel.SetActive(false);
        ayudaPanel.SetActive(false);
        creditosPanel.SetActive(false);

        panel.SetActive(true);
    }
}
