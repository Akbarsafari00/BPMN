/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StartEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntermediateCatchEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundaryEvent))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("catchEvent", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class CatchEvent : Event {
    
    private DataOutput[] dataOutputField;
    
    private DataOutputAssociation[] dataOutputAssociationField;
    
    private OutputSet outputSetField;
    
    private EventDefinition[] itemsField;
    
    private System.Xml.XmlQualifiedName[] eventDefinitionRefField;
    
    private bool parallelMultipleField;
    
    public CatchEvent() {
        this.parallelMultipleField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataOutput")]
    public DataOutput[] dataOutput {
        get {
            return this.dataOutputField;
        }
        set {
            this.dataOutputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataOutputAssociation")]
    public DataOutputAssociation[] dataOutputAssociation {
        get {
            return this.dataOutputAssociationField;
        }
        set {
            this.dataOutputAssociationField = value;
        }
    }
    
    /// <remarks/>
    public OutputSet outputSet {
        get {
            return this.outputSetField;
        }
        set {
            this.outputSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cancelEventDefinition", typeof(CancelEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("compensateEventDefinition", typeof(CompensateEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("conditionalEventDefinition", typeof(ConditionalEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("errorEventDefinition", typeof(ErrorEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("escalationEventDefinition", typeof(EscalationEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("eventDefinition", typeof(EventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("linkEventDefinition", typeof(LinkEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("messageEventDefinition", typeof(MessageEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("signalEventDefinition", typeof(SignalEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("terminateEventDefinition", typeof(TerminateEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("timerEventDefinition", typeof(TimerEventDefinition))]
    public EventDefinition[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("eventDefinitionRef")]
    public System.Xml.XmlQualifiedName[] eventDefinitionRef {
        get {
            return this.eventDefinitionRefField;
        }
        set {
            this.eventDefinitionRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool parallelMultiple {
        get {
            return this.parallelMultipleField;
        }
        set {
            this.parallelMultipleField = value;
        }
    }
}