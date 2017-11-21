namespace TheRamanEffect.UnityEngineExtensions
{
    public interface IObject
    {
        string name { get; set; }
        int GetInstanceID();
    }
}