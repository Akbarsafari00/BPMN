namespace Bpmn.Extensions;

public static class RootElementExtensions
{
    public static TType? FirstElementsByType <TType>(this IEnumerable<RootElement> rootElements)
        => rootElements.Where(x => x.GetType() == typeof(TType)).Cast<TType>().FirstOrDefault();
    
    public static IEnumerable<TType> FindElementsByType<TType>(this IEnumerable<RootElement> rootElements)
        => rootElements.Where(x => x.GetType() == typeof(TType)).Cast<TType>();
    
    
}