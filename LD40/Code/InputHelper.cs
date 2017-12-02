using System.Diagnostics;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Input.InputListeners;

namespace LD40
{
    public static class InputHelper
    {
        public static KeyboardListener KeyboardListener;

        public static void Initialize()
        {
            var keyboardSettings = new KeyboardListenerSettings();
            keyboardSettings.RepeatDelayMilliseconds = 150;
            keyboardSettings.InitialDelayMilliseconds = keyboardSettings.RepeatDelayMilliseconds;

            KeyboardListener = new KeyboardListener(keyboardSettings);
            //KeyboardListener.KeyPressed += (sender, args) => { Debug.WriteLine(args.Key);};
        }

        public static void Update(GameTime gameTime)
        {
            KeyboardListener.Update(gameTime);
        }
    }
}