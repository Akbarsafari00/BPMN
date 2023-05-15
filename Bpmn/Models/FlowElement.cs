/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SequenceFlow))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FlowNode))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Gateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InclusiveGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ExclusiveGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EventBasedGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplexGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChoreographyActivity))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubChoreography))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChoreographyTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CallChoreography))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Event))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ThrowEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntermediateThrowEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplicitThrowEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EndEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CatchEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StartEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntermediateCatchEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundaryEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Activity))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Task))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UserTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SendTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReceiveTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRuleTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubProcess))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Transaction))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AdHocSubProcess))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CallActivity))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataStoreReference))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObjectReference))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("flowElement", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class FlowElement : BaseElement {
    
    private Auditing auditingField;
    
    private Monitoring monitoringField;
    
    private System.Xml.XmlQualifiedName[] categoryValueRefField;
    
    private string nameField;
    
    /// <remarks/>
    public Auditing auditing {
        get {
            return this.auditingField;
        }
        set {
            this.auditingField = value;
        }
    }
    
    /// <remarks/>
    public Monitoring monitoring {
        get {
            return this.monitoringField;
        }
        set {
            this.monitoringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("categoryValueRef")]
    public System.Xml.XmlQualifiedName[] categoryValueRef {
        get {
            return this.categoryValueRefField;
        }
        set {
            this.categoryValueRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}