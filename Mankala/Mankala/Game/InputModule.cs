using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;



static class InputModule
{
    static MouseState currentMouseState, previousMouseState;
    static KeyboardState currentKeyboardState, previousKeyboardState;


    public static void Update()
    {
        previousMouseState = currentMouseState;
        previousKeyboardState = currentKeyboardState;
        currentMouseState = Mouse.GetState();
        currentKeyboardState = Keyboard.GetState();
    }

    public static bool KeyPressed(Keys k)
    {
        return currentKeyboardState.IsKeyDown(k) && previousKeyboardState.IsKeyUp(k);
    }

    public static bool MouseLeftButtonPressed()
    {
        return currentMouseState.LeftButton == ButtonState.Pressed
        && previousMouseState.LeftButton == ButtonState.Released;
    }

    public static Vector2 MousePosition
    {
        get { return new Vector2(currentMouseState.X, currentMouseState.Y); }
    }
}

