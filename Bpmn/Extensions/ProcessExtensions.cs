namespace Bpmn.Extensions;

public static class ProcessExtensions
{
    public static IEnumerable<TType> FindElementsByType<TType>(this Process process)
        => process.Items.FindElementsByType<TType>();
    
    public static StartEvent? FirstStartEvent(this Process process)
        => process.Items.FirstStartEvent();
    
    public static SequenceFlow? FindSequenceFlowBySourceRef(this Process process , string sourceRef) 
        => process.FindElementsByType<SequenceFlow>().FirstOrDefault(x=>x.sourceRef == sourceRef);
    
    public static SequenceFlow? FindSequenceFlowByTargetRef(this Process process, string targetRef) 
         => process.FindElementsByType<SequenceFlow>().FirstOrDefault(x=>x.targetRef == targetRef);
    
    public static FlowElement? FirstElementById(this Process process, string id) 
        => process.Items.FirstOrDefault(x=>x.id == id);

    public static IEnumerable<FlowElement>? NextElement(this Process process, FlowNode element)
    {
        var list = new List<FlowElement>();
        foreach (var name in element.outgoing)
        {
            var startSequenceFlow =(SequenceFlow) process.FirstElementById(name.Name);
            var flowElement = process.FirstElementById(startSequenceFlow.targetRef);
            list.Add(flowElement);
        }
        
        return list;
    }

}