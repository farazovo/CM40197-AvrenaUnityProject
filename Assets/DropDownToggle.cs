using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DropDownToggle : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public bool shouldShowDropdown;
    void Update()
    {
        if (shouldShowDropdown)
        {
            dropdown.Show();
        }
        else if (!shouldShowDropdown)
        {
            dropdown.Hide();
        }
    }
}
