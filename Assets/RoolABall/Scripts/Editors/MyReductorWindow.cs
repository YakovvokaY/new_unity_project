
using UnityEngine;
using UnityEditor;


public class MyReductorWindow : EditorWindow
{
    public static GameObject ObjectInstantiate;
    public string _nameObject = "Hello World";
    public bool _groupEnabled;
    public int _countObject = 1;
    public float _radius = 10;
    private void OnGUI()
    {
        GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
        ObjectInstantiate =EditorGUILayout.ObjectField("Объект который хотим вставить",ObjectInstantiate, typeof(GameObject), true) as GameObject;
        _nameObject = EditorGUILayout.TextField("Имя объекта", _nameObject);

        _groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки",_groupEnabled);
        _countObject = EditorGUILayout.IntSlider("Количество объектов",_countObject, 1, 100);
        _radius = EditorGUILayout.Slider("Радиус окружности", _radius, 10, 50);
        EditorGUILayout.EndToggleGroup();

        bool button = GUILayout.Button("Создать объекты");

        if (button)
        {
            if (ObjectInstantiate!=null)
            {
                GameObject root = new GameObject("Root");

                for (int i = 0; i < _countObject; i++)
                {
                    float angle = i * Mathf.PI * 2 / _countObject;

                    Vector3 pos = new Vector3(Mathf.Cos(angle), 0,Mathf.Sin(angle)) * _radius;
                    GameObject temp = Instantiate(ObjectInstantiate, pos,Quaternion.identity);
                    temp.name = $"{_nameObject} ({i})";
                    temp.transform.SetParent(root.transform);
                }
            }
        }
    }
}
public class MenuItems
{
    [MenuItem("MyReductorWindow/Пример (создание объектов на окружности) ")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(MyReductorWindow), false, "Geekbrains");
    }
}