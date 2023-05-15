/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalChoreographyTask))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("choreography", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Choreography : Collaboration {
    
    private FlowElement[] items2Field;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adHocSubProcess", typeof(AdHocSubProcess))]
    [System.Xml.Serialization.XmlElementAttribute("boundaryEvent", typeof(BoundaryEvent))]
    [System.Xml.Serialization.XmlElementAttribute("businessRuleTask", typeof(BusinessRuleTask))]
    [System.Xml.Serialization.XmlElementAttribute("callActivity", typeof(CallActivity))]
    [System.Xml.Serialization.XmlElementAttribute("callChoreography", typeof(CallChoreography))]
    [System.Xml.Serialization.XmlElementAttribute("choreographyTask", typeof(ChoreographyTask))]
    [System.Xml.Serialization.XmlElementAttribute("complexGateway", typeof(ComplexGateway))]
    [System.Xml.Serialization.XmlElementAttribute("dataObject", typeof(DataObject))]
    [System.Xml.Serialization.XmlElementAttribute("dataObjectReference", typeof(DataObjectReference))]
    [System.Xml.Serialization.XmlElementAttribute("dataStoreReference", typeof(DataStoreReference))]
    [System.Xml.Serialization.XmlElementAttribute("endEvent", typeof(EndEvent))]
    [System.Xml.Serialization.XmlElementAttribute("event", typeof(Event))]
    [System.Xml.Serialization.XmlElementAttribute("eventBasedGateway", typeof(EventBasedGateway))]
    [System.Xml.Serialization.XmlElementAttribute("exclusiveGateway", typeof(ExclusiveGateway))]
    [System.Xml.Serialization.XmlElementAttribute("flowElement", typeof(FlowElement))]
    [System.Xml.Serialization.XmlElementAttribute("implicitThrowEvent", typeof(ImplicitThrowEvent))]
    [System.Xml.Serialization.XmlElementAttribute("inclusiveGateway", typeof(InclusiveGateway))]
    [System.Xml.Serialization.XmlElementAttribute("intermediateCatchEvent", typeof(IntermediateCatchEvent))]
    [System.Xml.Serialization.XmlElementAttribute("intermediateThrowEvent", typeof(IntermediateThrowEvent))]
    [System.Xml.Serialization.XmlElementAttribute("manualTask", typeof(ManualTask))]
    [System.Xml.Serialization.XmlElementAttribute("parallelGateway", typeof(ParallelGateway))]
    [System.Xml.Serialization.XmlElementAttribute("receiveTask", typeof(ReceiveTask))]
    [System.Xml.Serialization.XmlElementAttribute("scriptTask", typeof(ScriptTask))]
    [System.Xml.Serialization.XmlElementAttribute("sendTask", typeof(SendTask))]
    [System.Xml.Serialization.XmlElementAttribute("sequenceFlow", typeof(SequenceFlow))]
    [System.Xml.Serialization.XmlElementAttribute("serviceTask", typeof(ServiceTask))]
    [System.Xml.Serialization.XmlElementAttribute("startEvent", typeof(StartEvent))]
    [System.Xml.Serialization.XmlElementAttribute("subChoreography", typeof(SubChoreography))]
    [System.Xml.Serialization.XmlElementAttribute("subProcess", typeof(SubProcess))]
    [System.Xml.Serialization.XmlElementAttribute("task", typeof(Task))]
    [System.Xml.Serialization.XmlElementAttribute("transaction", typeof(Transaction))]
    [System.Xml.Serialization.XmlElementAttribute("userTask", typeof(UserTask))]
    public FlowElement[] Items2 {
        get {
            return this.items2Field;
        }
        set {
            this.items2Field = value;
        }
    }
}