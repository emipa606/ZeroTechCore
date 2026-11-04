namespace LingGame;

public static class LingintSUniny
{
    extension(int i)
    {
        public bool Inbounds(int min, int max)
        {
            return i >= min && i <= max;
        }
    }
}