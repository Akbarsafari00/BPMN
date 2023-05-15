namespace Bpmn.Extensions;

public static class FlowElementExtensions
{
    public static TType? FirstElementsByType <TType>(this IEnumerable<FlowElement> rootElements)
        => rootElements.FindElementsByType<TType>().FirstOrDefault();
    
    public static IEnumerable<TType> FindElementsByType<TType>(this IEnumerable<FlowElement> rootElements)
        => rootElements.Where(x => x.GetType() == typeof(TType)).Cast<TType>();
    
    public static StartEvent? FirstStartEvent(this IEnumerable<FlowElement> rootElements)
        => rootElements.FirstElementsByType<StartEvent>();
    
    
    
}