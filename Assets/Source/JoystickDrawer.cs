using UnityEngine;
using UnityEngine.UI;

public class JoystickDrawer : IControllerDrawer
{
    Joystick joystick;
    public JoystickDrawer(Joystick joystick)
    {
        this.joystick = joystick;
    }
    public void Draw()
    {
        
    }
}