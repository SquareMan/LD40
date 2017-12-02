namespace LD40
{
    static class StateManager
    {
        public enum State
        {
            Initialization,
            MainMenu,
            InGame,
            InBattle,
            Paused
        }

        public static State CurrentState;
    }
}
