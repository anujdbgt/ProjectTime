namespace TheRamanEffect.UnityEngineExtensions
{
    public interface IBehaviour : IComponent
    {
        bool enabled { get; set; }
        bool isActiveAndEnabled { get; }
    }
}