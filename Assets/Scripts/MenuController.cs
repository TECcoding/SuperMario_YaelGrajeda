using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    UIDocument menu;
    Button botonJugar, botonAyuda, botonCreditos, botonRegresar;
    VisualElement contenedorBotones;
    VisualElement panelAyuda;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Botones
        botonJugar = root.Q<Button>("jugar-button");
        botonAyuda = root.Q<Button>("ayuda-button");
        botonCreditos = root.Q<Button>("creditos-button");
        botonRegresar = root.Q<Button>("regresa-menu-button");

        // Paneles
        contenedorBotones = botonJugar.parent; // contenedor de los tres botones
        panelAyuda = root.Q<VisualElement>("panel-ayuda");

        // Eventos
        botonJugar.clicked += IniciarJugar;
        botonAyuda.clicked += MostrarAyuda;
        botonRegresar.clicked += RegresarMenu;
    }

    private void IniciarJugar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SuperMario");
    }

    private void MostrarAyuda()
    {
        contenedorBotones.style.display = DisplayStyle.None;
        panelAyuda.style.display = DisplayStyle.Flex;
    }

    private void RegresarMenu()
    {
        panelAyuda.style.display = DisplayStyle.None;
        contenedorBotones.style.display = DisplayStyle.Flex;
    }
}
