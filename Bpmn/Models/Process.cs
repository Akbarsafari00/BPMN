/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("process", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Process : CallableElement {
    
    private Auditing auditingField;
    
    private Monitoring monitoringField;
    
    private Property[] propertyField;
    
    private LaneSet[] laneSetField;
    
    private FlowElement[] itemsField;
    
    private Artifact[] items1Field;
    
    private ResourceRole[] items2Field;
    
    private CorrelationSubscription[] correlationSubscriptionField;
    
    private System.Xml.XmlQualifiedName[] supportsField;
    
    private ProcessType processTypeField;
    
    private bool isClosedField;
    
    private bool isExecutableField;
    
    private bool isExecutableFieldSpecified;
    
    private System.Xml.XmlQualifiedName definitionalCollaborationRefField;
    
    public Process() {
        this.processTypeField = ProcessType.None;
        this.isClosedField = false;
    }
    
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
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public Property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("laneSet")]
    public LaneSet[] laneSet {
        get {
            return this.laneSetField;
        }
        set {
            this.laneSetField = value;
        }
    }
    
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
    public FlowElement[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("artifact", typeof(Artifact))]
    [System.Xml.Serialization.XmlElementAttribute("association", typeof(Association))]
    [System.Xml.Serialization.XmlElementAttribute("group", typeof(Group))]
    [System.Xml.Serialization.XmlElementAttribute("textAnnotation", typeof(TextAnnotation))]
    public Artifact[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("performer", typeof(Performer))]
    [System.Xml.Serialization.XmlElementAttribute("resourceRole", typeof(ResourceRole))]
    public ResourceRole[] Items2 {
        get {
            return this.items2Field;
        }
        set {
            this.items2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("correlationSubscription")]
    public CorrelationSubscription[] correlationSubscription {
        get {
            return this.correlationSubscriptionField;
        }
        set {
            this.correlationSubscriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supports")]
    public System.Xml.XmlQualifiedName[] supports {
        get {
            return this.supportsField;
        }
        set {
            this.supportsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(ProcessType.None)]
    public ProcessType processType {
        get {
            return this.processTypeField;
        }
        set {
            this.processTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isClosed {
        get {
            return this.isClosedField;
        }
        set {
            this.isClosedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isExecutable {
        get {
            return this.isExecutableField;
        }
        set {
            this.isExecutableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isExecutableSpecified {
        get {
            return this.isExecutableFieldSpecified;
        }
        set {
            this.isExecutableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName definitionalCollaborationRef {
        get {
            return this.definitionalCollaborationRefField;
        }
        set {
            this.definitionalCollaborationRefField = value;
        }
    }
}