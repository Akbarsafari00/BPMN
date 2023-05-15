namespace Bpmn.Extensions;

public static class SequenceFlowExtensions
{
    public static SequenceFlow? FindBySourceRef(this IEnumerable<SequenceFlow> sequenceFlows , string sourceRef) 
        => sequenceFlows.FirstOrDefault(x=>x.sourceRef == sourceRef);
    
    public static SequenceFlow? FindByTargetRef(this IEnumerable<SequenceFlow> sequenceFlows , string targetRef) 
        => sequenceFlows.FirstOrDefault(x=>x.targetRef == targetRef);
  
}